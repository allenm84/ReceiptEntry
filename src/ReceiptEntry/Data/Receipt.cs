using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace ReceiptEntry
{
  [DataContract(Name = "Receipt", Namespace = SaveFile.Namespace)]
  public class Receipt : IExtensibleDataObject
  {
    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public string ID { get; set; }

    [DataMember(Order = 1)]
    public string MerchantID { get; set; }

    [DataMember(Order = 2)]
    public DateTime Date { get; set; }

    [DataMember(Order = 3)]
    public List<ReceiptItem> Items { get; set; }

    [DataMember(Order = 4)]
    public decimal Tax { get; set; }

    [DataMember(Order = 5)]
    public string PaidByID { get; set; }

    public decimal Total
    {
      get { return Items.Sum(i => i.Price) + Tax; }
    }

    [IgnoreDataMember]
    private Merchant mLinkedMerchant;
    public Merchant LinkedMerchant
    {
      get { return LinkRef.Get(MerchantID, SaveFile.Instance.Merchants, m => m.ID, ref mLinkedMerchant) ?? Merchant.Empty; }
    }

    [IgnoreDataMember]
    private PaidBy mLinkedPaidBy;
    public PaidBy LinkedPaidBy
    {
      get { return LinkRef.Get(PaidByID, SaveFile.Instance.PaidBys, p => p.ID, ref mLinkedPaidBy) ?? PaidBy.Empty; }
    }

    public string Name
    {
      get { return LinkedMerchant.Name; }
    }

    public string PaidByName
    {
      get { return LinkedPaidBy.Name; }
    }
  }
}
