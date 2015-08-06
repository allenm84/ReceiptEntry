using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "Merchant", Namespace = SaveFile.Namespace)]
  public class Merchant : BaseIDName
  {
    [DataMember(Order = 0)]
    public ReceiptColumnReference[] Columns { get; set; }
  }
}
