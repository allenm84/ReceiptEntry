using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa.com/apps/ReceiptEntry/v4";

    [DataMember(Order = 0)]
    public List<Merchant> Merchants { get; set; }
    [DataMember(Order = 1)]
    public List<Receipt> Receipts { get; set; }
  }
}
