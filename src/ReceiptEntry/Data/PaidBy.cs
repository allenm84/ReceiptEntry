using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ReceiptEntry
{
  [DataContract(Name = "PaidBy", Namespace = SaveFile.Namespace)]
  public class PaidBy : IExtensibleDataObject, INameIDItem
  {
    public static PaidBy Empty { get { return new PaidBy { ID = "PaidByEmpty", Name = "[Empty]" }; } }

    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public string ID { get; set; }

    [DataMember(Order = 1)]
    public string Name { get; set; }
  }
}
