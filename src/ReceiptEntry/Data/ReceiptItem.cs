using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ReceiptEntry
{
  [DataContract(Name = "ReceiptItem", Namespace = SaveFile.Namespace)]
  public class ReceiptItem : IExtensibleDataObject
  {
    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public string ItemID { get; set; }

    [DataMember(Order = 1)]
    public decimal Quantity { get; set; }

    [DataMember(Order = 2)]
    public decimal Price { get; set; }

    [IgnoreDataMember]
    private NamedItem mLinkedItem;
    public NamedItem LinkedItem
    {
      get { return LinkRef.Get(ItemID, SaveFile.Instance.NamedItems, m => m.ID, ref mLinkedItem) ?? NamedItem.Empty; }
    }

    public string Name
    {
      get
      {
        return LinkedItem.Name;
      }
    }

    public string Display
    {
      get
      {
        return string.Format("({0:0.00}) {1} for {2:c2}",
          Quantity, Name, Price);
      }
    }
  }
}
