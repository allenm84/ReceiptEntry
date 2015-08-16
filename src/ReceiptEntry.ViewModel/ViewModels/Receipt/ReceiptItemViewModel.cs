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
    public object this[string name]
    {
      get { return GetField<object>(name); }
      set { SetField(value, name); }
    }

    public ReceiptItemViewModel()
      : this(new Dictionary<string, object>())
    {

    }

    internal ReceiptItemViewModel(ReceiptItem item)
      : this(item.Values)
    {

    }

    internal ReceiptItemViewModel(Dictionary<string, object> values)
    {
      Push(values);
      Accept();
    }

    internal ReceiptItem ToReceiptItem()
    {
      return new ReceiptItem
      {
        Values = Pull(),
      };
    }
  }
}
