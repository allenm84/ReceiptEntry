using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public static class BindingExtensions
  {
    public static void Set<T>(this BindingSource source, IEnumerable<T> values)
    {
      source.Clear();
      foreach (T v in values)
        source.Add(v);
    }

    public static void Insert<T>(this BindingList<T> list, T item, Func<T, T, int> compare)
    {
      int comparison, i;
      for (i = 0; i < list.Count; ++i)
      {
        T other = list[i];
        comparison = compare(item, other);
        if (comparison < 0)
        {
          list.Insert(i, item);
          return;
        }
      }

      // if we get here, just add the item
      list.Add(item);
    }

    public static void ResetItem<T>(this BindingList<T> list, T item)
    {
      list.ResetItem(list.IndexOf(item));
    }
  }
}
