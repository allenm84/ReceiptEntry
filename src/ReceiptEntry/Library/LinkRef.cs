using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry
{
  public static class LinkRef
  {
    public static T Get<T>(string id, IEnumerable<T> database, Func<T, string> getID, ref T value) where T : class
    {
      bool needsUpdate = (value == null) || (value != null && !getID(value).Matches(id));
      if (needsUpdate)
      {
        value = database.FirstOrDefault(v => getID(v).Matches(id));
      }
      return value;
    }
  }
}
