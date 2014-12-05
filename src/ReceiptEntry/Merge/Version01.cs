using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Merge.V1
{
  [DataContract(Name = "ExtensibleDataObject", Namespace = SaveFile.Namespace)]
  public abstract class ExtensibleDataObject : IExtensibleDataObject
  {
    ExtensionDataObject IExtensibleDataObject.ExtensionData { get; set; }
  }

  [DataContract(Name = "Merchant", Namespace = SaveFile.Namespace)]
  public class Merchant : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string Name { get; set; }
  }

  [DataContract(Name = "Receipt", Namespace = SaveFile.Namespace)]
  public class Receipt : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string MerchantID { get; set; }
    [DataMember(Order = 2)]
    public DateTime Date { get; set; }
    [DataMember(Order = 3)]
    public List<ReceiptItem> Items { get; set; }
    [DataMember(Order = 4)]
    public decimal Tax { get; set; }
    [DataMember(Order = 5)]
    public string PaidByID { get; set; }
  }

  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ItemID { get; set; }
    [DataMember(Order = 1)]
    public decimal Quantity { get; set; }
    [DataMember(Order = 2)]
    public decimal Price { get; set; }
  }

  [DataContract(Name = "NamedItem", Namespace = SaveFile.Namespace)]
  public class NamedItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string Name { get; set; }
  }

  [DataContract(Name = "Options", Namespace = SaveFile.Namespace)]
  public class Options : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public Size MainWindowSize { get; set; }
  }

  [DataContract(Name = "PaidBy", Namespace = SaveFile.Namespace)]
  public class PaidBy : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string Name { get; set; }
  }

  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa-apps.com/receiptentry";

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
