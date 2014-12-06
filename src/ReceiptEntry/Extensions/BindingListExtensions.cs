using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class BindingListExtensions
  {
    public static void ResetItem<T>(this BindingList<T> list, T item)
    {
      list.ResetItem(list.IndexOf(item));
    }
  }
}
