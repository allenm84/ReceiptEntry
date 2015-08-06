using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptColumn", Namespace = SaveFile.Namespace)]
  public class ReceiptColumn : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }

    [DataMember(Order = 1)]
    public string Name { get; set; }

    [DataMember(Order = 2)]
    public ReceiptColumnType Type { get; set; }
  }
}
