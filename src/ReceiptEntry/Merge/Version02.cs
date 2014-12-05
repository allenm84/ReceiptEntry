using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Merge.V2
{
  [DataContract(Name = "Brand", Namespace = SaveFile.Namespace)]
  public class Brand : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
  }

  [DataContract(Name = "ExtensibleDataObject", Namespace = SaveFile.Namespace)]
  public abstract class ExtensibleDataObject : IExtensibleDataObject
  {
    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }
  }

  [DataContract(Name = "Measurement", Namespace = SaveFile.Namespace)]
  public enum Measurement
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

  [DataContract(Name = "Merchant", Namespace = SaveFile.Namespace)]
  public class Merchant : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public bool IsGrocery { get; set; }
  }

  [DataContract(Name = "NamedItem", Namespace = SaveFile.Namespace)]
  public class NamedItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string BrandID { get; set; }
    [DataMember(Order = 1)]
    public string CategoryID { get; set; }
    [DataMember(Order = 2)]
    public string ID { get; set; }
    [DataMember(Order = 3)]
    public string Name { get; set; }
    [DataMember(Order = 4)]
    public decimal Size { get; set; }
    [DataMember(Order = 5)]
    public Measurement Measurement { get; set; }
  }

  [DataContract(Name = "Receipt", Namespace = SaveFile.Namespace)]
  public class Receipt : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string MerchantID { get; set; }
    [DataMember]
    public DateTime Date { get; set; }
    [DataMember]
    public List<ReceiptItem> Items { get; set; }
    [DataMember]
    public decimal Tax { get; set; }
  }

  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember]
    public string ItemID { get; set; }
    [DataMember]
    public decimal Quantity { get; set; }
    [DataMember]
    public decimal PricePerItem { get; set; }
  }

  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa.com/apps/all/ReceiptEntry";

    [DataMember]
    public List<Brand> brands;
    [DataMember]
    public List<NamedItem> items;
    [DataMember]
    public List<Merchant> merchants;
    [DataMember]
    public List<Receipt> receipts;
  }
}
