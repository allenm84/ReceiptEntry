using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptTax", Namespace = SaveFile.Namespace)]
  public class ReceiptTax : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public decimal Percent { get; set; }

    [DataMember(Order = 1)]
    public decimal Amount { get; set; }
  }
}
