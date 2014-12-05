using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Merge.V3
{
  [DataContract(Name = "ExtensibleDataObject", Namespace = Database.Namespace)]
  public abstract class ExtensibleDataObject : IExtensibleDataObject
  {
    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }
  }

  [DataContract(Name = "Database", Namespace = Database.Namespace)]
  public partial class Database : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa.com/apps/ReceiptEntry/v3";

    [DataMember(Order = 0)]
    public BindingList<MerchantType> merchantTypes;
    [DataMember(Order = 1)]
    public BindingList<ItemAlias> itemAlias;
    [DataMember(Order = 2)]
    public BindingList<Merchant> merchants;
    [DataMember(Order = 3)]
    public BindingList<Receipt> receipts;
  }

  [DataContract(Name = "MerchantType", Namespace = Database.Namespace)]
  public class MerchantType : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string Name { get; set; }
  }

  [DataContract(Name = "Merchant", Namespace = Database.Namespace)]
  public class Merchant : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string MerchantTypeID { get; set; }
    [DataMember(Order = 2)]
    public string Name { get; set; }
  }

  [DataContract(Name = "ItemAlias", Namespace = Database.Namespace)]
  public class ItemAlias : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string Name { get; set; }
  }

  [DataContract(Name = "Quantity", Namespace = Database.Namespace)]
  public class Quantity : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public decimal Amount { get; set; }
    [DataMember(Order = 1)]
    public Unit Unit { get; set; }
  }

  [DataContract(Name = "Receipt", Namespace = Database.Namespace)]
  public class Receipt : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public DateTime Date { get; set; }
    [DataMember(Order = 1)]
    public string MerchantID { get; set; }
    [DataMember(Order = 2)]
    public BindingList<ReceiptItem> Items { get; set; }
    [DataMember(Order = 3)]
    public decimal Tax { get; set; }
    [DataMember(Order = 4)]
    public string[] EditOrder { get; set; }
    [DataMember(Order = 5)]
    public bool ShowCodeColumn { get; set; }
  }

  [DataContract(Name = "ReceiptItem", Namespace = Database.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string Name { get; set; }
    [DataMember(Order = 1)]
    public decimal Price { get; set; }
    [DataMember(Order = 2)]
    public string AliasID { get; set; }
    [DataMember(Order = 3)]
    public string Code { get; set; }
    [DataMember(Order = 4)]
    public Quantity Quantity { get; set; }
  }

  [DataContract(Name = "Unit", Namespace = Database.Namespace)]
  public enum Unit
  {
    [EnumMember]
    Slice,
    [EnumMember]
    Unit,
    [EnumMember]
    Teaspoon,
    [EnumMember]
    Tablespoon,
    [EnumMember]
    FluidOunce,
    [EnumMember]
    Gill,
    [EnumMember]
    Cup,
    [EnumMember]
    Pint,
    [EnumMember]
    Quart,
    [EnumMember]
    Gallon,
    [EnumMember]
    Milliliter,
    [EnumMember]
    Liter,
    [EnumMember]
    Deciliter,
    [EnumMember]
    Pound,
    [EnumMember]
    Ounce,
    [EnumMember]
    Microgram,
    [EnumMember]
    Milligram,
    [EnumMember]
    Gram,
    [EnumMember]
    Kilogram,
  }
}
