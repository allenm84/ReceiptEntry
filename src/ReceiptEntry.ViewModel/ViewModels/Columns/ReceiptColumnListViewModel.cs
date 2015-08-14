using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptColumnListViewModel : BaseListViewModel<ReceiptColumnViewModel>
  {
    internal ReceiptColumnListViewModel(SaveFileViewModel parent, IEnumerable<ReceiptColumn> columns)
      : base(parent)
    {
      foreach (var column in columns)
      {
        mItems.Add(new ReceiptColumnViewModel(column));
      }

      Accept();
    }

    public override ReceiptColumnViewModel CreateItem()
    {
      return new ReceiptColumnViewModel(ID.Next, "<New Column>", ReceiptColumnType.Text);
    }
  }
}
