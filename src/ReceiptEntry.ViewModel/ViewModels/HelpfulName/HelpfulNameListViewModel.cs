using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class HelpfulNameListViewModel : BaseListViewModel<HelpfulNameViewModel>
  {
    internal HelpfulNameListViewModel(SaveFileViewModel parent, IEnumerable<HelpfulName> names)
      : base(parent)
    {
      foreach (var name in names)
      {
        mItems.Add(new HelpfulNameViewModel(name));
      }

      Accept();
    }

    public override HelpfulNameViewModel CreateItem()
    {
      return new HelpfulNameViewModel(ID.Next, "<New Helpful Name>");
    }
  }
}
