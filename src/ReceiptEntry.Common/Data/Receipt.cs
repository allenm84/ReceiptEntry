using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
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
    public ReceiptItem[] Items { get; set; }

    [DataMember(Order = 4)]
    public ReceiptTax[] Taxes { get; set; }

    [DataMember(Order = 5)]
    public decimal Total { get; set; }
  }
}
