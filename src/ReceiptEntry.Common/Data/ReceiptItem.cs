using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem
  {
    [DataMember(Order = 0)]
    public string NameID { get; set; }
    [DataMember(Order = 1)]
    public string Code { get; set; }
    [DataMember(Order = 2)]
    public decimal Price { get; set; }
    [DataMember(Order = 3)]
    public decimal Count { get; set; }
  }
}
