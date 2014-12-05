using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Merchant", Namespace = Database.Namespace)]
  public class Merchant : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string ID { get; set; }
    [DataMember(Order = 1)]
    public string MerchantTypeID { get; set; }
    [DataMember(Order = 2)]
    public string Name { get; set; }
  }
}
