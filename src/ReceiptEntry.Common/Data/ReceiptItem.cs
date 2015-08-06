using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [KnownType(typeof(decimal)), KnownType(typeof(string))]
  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public Dictionary<string, object> Values { get; set; }

    [DataMember(Order = 1)]
    public string HelpfulNameID { get; set; }
  }
}
