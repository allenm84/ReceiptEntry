using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptColumnReference", Namespace = SaveFile.Namespace)]
  public class ReceiptColumnReference : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ColumnID { get; set; }
  }
}
