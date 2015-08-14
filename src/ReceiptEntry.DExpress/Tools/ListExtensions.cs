using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.DExpress
{
  public static class ListExtensions
  {
    public static T PopOrDefault<T>(this IList<T> list, Func<T, bool> predicate)
    {
      var matches = new List<T>();

      for (int i = 0; i < list.Count; ++i)
      {
        T item = list[i];
        if (predicate(item))
        {
          matches.Add(item);
          list.RemoveAt(i--);
        }
      }

      return matches.SingleOrDefault();
    }
  }
}
