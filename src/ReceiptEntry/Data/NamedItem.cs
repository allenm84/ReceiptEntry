using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ReceiptEntry
{
  [DataContract(Name = "NamedItem", Namespace = SaveFile.Namespace)]
  public class NamedItem : IExtensibleDataObject, INameIDItem
  {
    public static NamedItem Empty { get { return new NamedItem { ID = "NamedItemEmpty", Name = "[Empty]" }; } }

    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public string ID { get; set; }

    [DataMember(Order = 1)]
    public string Name { get; set; }
  }
}
