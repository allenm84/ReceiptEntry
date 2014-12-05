using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace ReceiptEntry
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : IExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa-apps.com/receiptentry";

    static object syncRoot = new object();
    static SaveFile instance = new SaveFile();
    public static SaveFile Instance { get { lock (syncRoot) { return instance; } } }

    static DataContractSerializer serializer;
    static string filepath;

    static SaveFile()
    {
      serializer = new DataContractSerializer(typeof(SaveFile));
      filepath = Path.Combine(Application.StartupPath, "saved.xml");
    }

    public static void Reset()
    {
      instance = new SaveFile();
      instance.Initialize();
    }

    public static void Load()
    {
      SaveFile other = null;
      if (File.Exists(filepath))
      {
        using (Stream stream = File.OpenRead(filepath))
        {
          other = serializer.ReadObject(stream) as SaveFile;
        }
      }
      instance.Initialize(other);
    }

    public static void Save()
    {
      lock (syncRoot)
      {
        using (Stream stream = File.Create(filepath))
        {
          serializer.WriteObject(stream, instance);
        }
      }
    }

    private SaveFile() { }

    private void Initialize()
    {
      Initialize(null);
    }

    private void Initialize(SaveFile other)
    {
      var type = instance.GetType();
      var properties = type.GetProperties();
      foreach (var property in properties)
      {
        if (property.HasAttribute(typeof(DataMemberAttribute)))
        {
          object value = null;
          if (other != null)
          {
            var otherValue = property.GetValue(other, null);
            value = otherValue;
          }

          if (value == null)
          {
            value = Creator.CreateInstance(property.PropertyType);
          }

          property.SetValue(instance, value, null);
        }
      }
    }

    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public List<Merchant> Merchants { get; set; }

    [DataMember(Order = 1)]
    public List<Receipt> Receipts { get; set; }

    [DataMember(Order = 2)]
    public List<NamedItem> NamedItems { get; set; }

    [DataMember(Order = 3)]
    public Options Options { get; set; }

    [DataMember(Order = 4)]
    public List<PaidBy> PaidBys { get; set; }
  }
}
