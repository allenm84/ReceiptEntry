using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ReceiptEntry
{
  [DataContract(Name = "Merchant", Namespace = SaveFile.Namespace)]
  public class Merchant : IExtensibleDataObject, INameIDItem
  {
    public static Merchant Empty { get { return new Merchant { ID = "MerchantEmpty", Name = "[Empty]" }; } }

    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public string ID { get; set; }

    [DataMember(Order = 1)]
    public string Name { get; set; }
  }
}
