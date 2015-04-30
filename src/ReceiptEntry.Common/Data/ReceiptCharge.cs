using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptCharge", Namespace = SaveFile.Namespace)]
  public class ReceiptCharge : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string Description { get; set; }
    [DataMember(Order = 1)]
    public decimal Amount { get; set; }
  }
}
