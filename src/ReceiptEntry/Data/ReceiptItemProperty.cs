using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "ReceiptItemProperty", Namespace = SaveFile.Namespace)]
  public enum ReceiptItemProperty
  {
    [EnumMember]
    Name,
    [EnumMember]
    Price,
    [EnumMember]
    ShoppingListItemID,
    [EnumMember]
    Code,
    [EnumMember]
    Quantity,
  }
}
