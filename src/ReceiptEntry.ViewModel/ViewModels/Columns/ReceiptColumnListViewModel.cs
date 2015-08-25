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
        mItems.Add(new ReceiptColumnViewModel(this, column));
      }

      Accept();
    }

    public override ReceiptColumnViewModel CreateItem()
    {
      return new ReceiptColumnViewModel(this, ID.Next, "<New Column>", ReceiptColumnType.Text);
    }

    internal ReceiptColumnViewModel EnsureHelpfulName()
    {
      var helpfulNameColumn = Items.FirstOrDefault(c => c.Type == ReceiptColumnType.HelpfulName);
      if (helpfulNameColumn == null)
      {
        helpfulNameColumn = CreateItem();
        helpfulNameColumn.Type = ReceiptColumnType.HelpfulName;
        helpfulNameColumn.Name = "HN";
        Items.Add(helpfulNameColumn);
      }
      return helpfulNameColumn;
    }
  }
}
