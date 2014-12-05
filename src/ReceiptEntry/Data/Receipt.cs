using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Receipt", Namespace = SaveFile.Namespace)]
  public class Receipt : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string MerchantID { get; set; }
    [DataMember]
    public DateTime Date { get; set; }
    [DataMember]
    public List<ReceiptItem> Items { get; set; }
    [DataMember]
    public decimal Tax { get; set; }

    public decimal Total
    {
      get
      {
        decimal total = Tax;
        if (Items != null)
        {
          total += Items.Sum(i => i.Total);
        }
        return total;
      }
    }
  }
}
