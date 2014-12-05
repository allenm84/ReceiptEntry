using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "NamedItem", Namespace = SaveFile.Namespace)]
  public class NamedItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string BrandID { get; set; }
    [DataMember(Order = 1)]
    public string CategoryID { get; set; }
    [DataMember(Order = 2)]
    public string ID { get; set; }
    [DataMember(Order = 3)]
    public string Name { get; set; }
    [DataMember(Order = 4)]
    public decimal Size { get; set; }
    [DataMember(Order = 5)]
    public Measurement Measurement { get; set; }
  }
}
