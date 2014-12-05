using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa.com/apps/all/ReceiptEntry";
    private SaveFile() { }

    [DataMember]
    private List<Brand> brands;
    [DataMember]
    private List<NamedItem> items;
    [DataMember]
    private List<Merchant> merchants;
    [DataMember]
    private List<Receipt> receipts;

    static string filepath;
    static DataContractSerializer dcs;
    static SaveFile instance;

    static SaveFile()
    {
      filepath = Path.Combine(Application.StartupPath, "receipts.xml");
      dcs = new DataContractSerializer(typeof(SaveFile));
      instance = new SaveFile();
    }

    public static void Load()
    {
      instance.brands = new List<Brand>();
      instance.items = new List<NamedItem>();
      instance.merchants = new List<Merchant>();
      instance.receipts = new List<Receipt>();

      if (File.Exists(filepath))
      {
        using (var stream = File.OpenRead(filepath))
        {
          var data = dcs.ReadObject(stream) as SaveFile;
          if (data != null)
          {
            instance.brands = data.brands ?? instance.brands;
            instance.items = data.items ?? instance.items;
            instance.merchants = data.merchants ?? instance.merchants;
            instance.receipts = data.receipts ?? instance.receipts;
          }
        }
      }
    }

    public static void Save()
    {
      using (var stream = File.Create(filepath))
      {
        dcs.WriteObject(stream, instance);
      }
    }

    public static List<Brand> Brands
    {
      get { return instance.brands; }
      set { instance.brands = value; }
    }

    public static List<NamedItem> Items
    {
      get { return instance.items; }
      set { instance.items = value; }
    }

    public static List<Merchant> Merchants
    {
      get { return instance.merchants; }
      set { instance.merchants = value; }
    }

    public static List<Receipt> Receipts
    {
      get { return instance.receipts; }
      set { instance.receipts = value; }
    }
  }
}
