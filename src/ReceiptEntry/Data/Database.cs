using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  [DataContract(Name = "Database", Namespace = Database.Namespace)]
  public partial class Database : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa.com/apps/ReceiptEntry/v3";
    public static string NewID() { return Guid.NewGuid().ToString(); }

    static DataContractFile<Database> dcf;
    static Database instance;
    static Database()
    {
      dcf = new DataContractFile<Database>(Path.Combine(Application.StartupPath, "database.xml"));
    }

    public static void Load()
    {
      if (instance != null)
      {
        throw new InvalidOperationException("The database has already been loaded!");
      }

      dcf.TryRead(out instance);
      if (instance == null)
      {
        instance = new Database();
      }
      instance.Initialize();

      foreach (var r in instance.receipts)
      {
        r.Date = r.Date.Date;
      }
    }

    public static void Save()
    {
      dcf.TryWrite(instance);
    }

    [DataMember(Order = 0)]
    private BindingList<MerchantType> merchantTypes;
    [DataMember(Order = 1)]
    private BindingList<ItemAlias> itemAlias;
    [DataMember(Order = 2)]
    private BindingList<Merchant> merchants;
    [DataMember(Order = 3)]
    private BindingList<Receipt> receipts;

    public static BindingList<MerchantType> MerchantTypes
    {
      get { return instance.merchantTypes; }
    }

    public static BindingList<ItemAlias> ItemAlias
    {
      get { return instance.itemAlias; }
    }

    public static BindingList<Merchant> Merchants
    {
      get { return instance.merchants; }
    }

    public static BindingList<Receipt> Receipts
    {
      get { return instance.receipts; }
    }
  }
}
