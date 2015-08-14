using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class MerchantListViewModel : BaseListViewModel<MerchantViewModel>
  {
    internal MerchantListViewModel(SaveFileViewModel parent, IEnumerable<Merchant> merchants)
      : base(parent)
    {
      foreach (var merchant in merchants)
      {
        mItems.Add(new MerchantViewModel(merchant, parent.Columns));
      }

      Accept();
    }

    public override MerchantViewModel CreateItem()
    {
      return new MerchantViewModel(ID.Next, "<New Merchant>", null, mParent.Columns);
    }
  }
}
