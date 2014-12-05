using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember]
    public string ItemID { get; set; }
    [DataMember]
    public decimal Quantity { get; set; }
    [DataMember]
    public decimal PricePerItem { get; set; }

    public decimal Total
    {
      get { return Quantity * PricePerItem; }
    }
  }
}
