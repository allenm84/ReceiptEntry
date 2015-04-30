using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptItemNameListViewModel : BaseListViewModel<ReceiptItemNameViewModel>
  {
    public ReceiptItemNameViewModel this[string id]
    {
      get { return list.SingleOrDefault(m => m.ID == id); }
    }
  }
}
