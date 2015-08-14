using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptItemViewModel : BaseViewModel
  {
    public string HelpfulNameID
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    public object this[string name]
    {
      get { return GetField<object>(name); }
      set { SetField(value, name); }
    }

    public ReceiptItemViewModel()
      : this(new Dictionary<string, object>(), null)
    {

    }

    internal ReceiptItemViewModel(ReceiptItem item)
      : this(item.Values, item.HelpfulNameID)
    {

    }

    internal ReceiptItemViewModel(Dictionary<string, object> values, string helpfulNameID)
    {
      Push(values);
      HelpfulNameID = helpfulNameID;
    }
  }
}
