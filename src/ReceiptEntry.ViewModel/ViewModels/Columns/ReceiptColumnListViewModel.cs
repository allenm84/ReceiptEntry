using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;
using ReceiptEntry.Tools;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptColumnListViewModel : BaseListViewModel<ReceiptColumnViewModel>
  {
    internal ReceiptColumnViewModel this[string id]
    {
      get { return Fetch(c => c.ID == id); }
    }

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

    internal Dictionary<string, ReceiptColumnViewModel> CreateLookUp()
    {
      return Items.ToDictionary(k => k.ID);
    }
  }
}
