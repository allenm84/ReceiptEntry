using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptColumnListViewModel
  {
    protected readonly BindingList<ReceiptColumnViewModel> mColumns;
    public BindingList<ReceiptColumnViewModel> Columns
    {
      get { return mColumns; }
    }

    internal ReceiptColumnListViewModel(SaveFileViewModel parent, IEnumerable<ReceiptColumn> columns)
    {
      mColumns = new BindingList<ReceiptColumnViewModel>();
      foreach (var column in columns)
      {
        mColumns.Add(new ReceiptColumnViewModel(column));
      }
    }

    public ReceiptColumnViewModel CreateColumn()
    {
      return new ReceiptColumnViewModel(IDg.Next, "<New Column>", ReceiptColumnType.Text);
    }
  }
}
