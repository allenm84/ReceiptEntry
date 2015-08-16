using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptColumnType", Namespace = SaveFile.Namespace)]
  public enum ReceiptColumnType
  {
    [EnumMember]
    Dollars,

    [EnumMember]
    HelpfulName,

    [EnumMember]
    Number,

    [EnumMember]
    Text,
  }
}
