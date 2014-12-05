using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public string Name { get; set; }
    [DataMember(Order = 1)]
    public decimal Price { get; set; }
    [DataMember(Order = 2)]
    public string ShoppingListItemID { get; set; }
    [DataMember(Order = 3)]
    public string Code { get; set; }
    [DataMember(Order = 4)]
    public Quantity Quantity { get; set; }
  }
}
