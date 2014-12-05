using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Quantity", Namespace = Database.Namespace)]
  public class Quantity : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public decimal Amount { get; set; }
    [DataMember(Order = 1)]
    public Unit Unit { get; set; }
  }
}
