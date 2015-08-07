using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class MerchantListViewModel
  {
    private readonly SaveFileViewModel mParent;

    private readonly BindingList<MerchantViewModel> mMerchants;
    public BindingList<MerchantViewModel> Merchants
    {
      get { return mMerchants; }
    }

    internal MerchantListViewModel(SaveFileViewModel parent, IEnumerable<Merchant> merchants)
    {
      mParent = parent;

      mMerchants = new BindingList<MerchantViewModel>();
      foreach (var merchant in merchants)
      {
        mMerchants.Add(new MerchantViewModel(merchant, parent.Columns));
      }
    }

    public MerchantViewModel CreateMerchant()
    {
      return new MerchantViewModel(IDg.Next, "<New Merchant>", null, mParent.Columns);
    }
  }
}
