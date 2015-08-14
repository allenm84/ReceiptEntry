using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptListViewModel : BaseListViewModel<ReceiptViewModel>
  {
    internal ReceiptListViewModel(SaveFileViewModel parent, IEnumerable<Receipt> receipts)
      : base(parent)
    {
      foreach (var receipt in receipts)
      {
        mItems.Add(new ReceiptViewModel(parent, receipt));
      }

      Accept();
    }

    public override ReceiptViewModel CreateItem()
    {
      return new ReceiptViewModel(mParent, ID.Next, null);
    }
  }
}
