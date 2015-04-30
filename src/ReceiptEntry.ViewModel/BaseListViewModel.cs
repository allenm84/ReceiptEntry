using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public class BaseListViewModel<T> : NotifyPropertyChanged, IEnumerable<T>
  {
    protected readonly BindingList<T> list = new BindingList<T>();

    public IEnumerator<T> GetEnumerator()
    {
      return list.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      return list.GetEnumerator();
    }
  }
}
