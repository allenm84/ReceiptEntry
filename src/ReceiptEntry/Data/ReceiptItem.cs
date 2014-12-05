using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "ReceiptItem", Namespace = Database.Namespace)]
  public class ReceiptItem : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    [PropertyIDAttribute("Name", "Name")]
    public string Name { get; set; }

    [DataMember(Order = 1)]
    [PropertyIDAttribute("Price", "Price")]
    public decimal Price { get; set; }

    [DataMember(Order = 2)]
    [PropertyIDAttribute("AliasID", "Friendly Name")]
    public string AliasID { get; set; }

    [DataMember(Order = 3)]
    [PropertyIDAttribute("Code", "Code")]
    public string Code { get; set; }

    [DataMember(Order = 4)]
    [PropertyIDAttribute("Quantity", "Quantity")]
    public Quantity Quantity { get; set; }
  }
}
