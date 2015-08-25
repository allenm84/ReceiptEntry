using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  internal static class ListExtensions
  {
    public static int FirstIndexOf<T>(this IList<T> list, Func<T, bool> predicate)
    {
      for (int i = 0; i < list.Count; ++i)
      {
        if (predicate(list[i]))
        {
          return i;
        }
      }
      return -1;
    }
  }
}
