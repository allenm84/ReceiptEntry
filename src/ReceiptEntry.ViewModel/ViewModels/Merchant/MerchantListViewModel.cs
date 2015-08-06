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
    protected readonly BindingList<MerchantViewModel> mMerchants;
    public BindingList<MerchantViewModel> Merchants
    {
      get { return mMerchants; }
    }

    internal MerchantListViewModel(SaveFileViewModel parent, IEnumerable<Merchant> merchants)
    {
      mMerchants = new BindingList<MerchantViewModel>();
      foreach (var merchant in merchants)
      {
        mMerchants.Add(new MerchantViewModel(merchant));
      }
    }
  }
}
