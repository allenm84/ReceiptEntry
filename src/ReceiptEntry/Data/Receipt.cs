using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Receipt", Namespace = SaveFile.Namespace)]
  public class Receipt : ExtensibleDataObject
  {
    [DataMember(Order = 0)]
    public DateTime Date { get; set; }
    [DataMember(Order = 1)]
    public string MerchantID { get; set; }
    [DataMember(Order = 2)]
    public ReceiptItem[] Items { get; set; }
    [DataMember(Order = 3)]
    public decimal Tax { get; set; }

    public decimal Total
    {
      get
      {
        decimal total = Tax;
        if (Items != null)
        {
          total += Items.Sum(i => i.Price);
        }
        return total;
      }
    }
  }
}
