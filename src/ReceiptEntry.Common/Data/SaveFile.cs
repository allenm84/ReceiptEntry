using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class SaveFile : ExtensibleDataObject
  {
    public const string Namespace = "http://www.mapa.com/apps/receiptEntry/v5";

    [DataMember(Order = 0)]
    public HelpfulName[] Names { get; set; }

    [DataMember(Order = 1)]
    public Merchant[] Merchants { get; set; }

    [DataMember(Order = 2)]
    public ReceiptColumn[] Columns { get; set; }

    [DataMember(Order = 3)]
    public Receipt[] Receipts { get; set; }
  }
}
