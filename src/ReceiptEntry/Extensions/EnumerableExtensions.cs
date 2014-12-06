using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class EnumerableExtensions
  {
    public static IEnumerable<T> Exclude<T>(this IEnumerable<T> values, T value)
    {
      var equals = EqualityComparer<T>.Default;
      foreach (T t in values)
      {
        if (equals.Equals(t, value)) continue;
        yield return t;
      }
    }
  }
}
