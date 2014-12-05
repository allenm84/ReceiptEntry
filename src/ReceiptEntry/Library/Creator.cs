using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry
{
  public static class Creator
  {
    public static object CreateInstance(Type type)
    {
      if (type == typeof(string)) return string.Empty;
      return Activator.CreateInstance(type);
    }

    public static string String(object obj)
    {
      if (obj == null) return "";
      if (obj is string) return (obj as string) ?? "";
      return obj.ToString();
    }
  }
}
