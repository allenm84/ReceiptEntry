using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [AttributeUsage(AttributeTargets.Property)]
  public class PropertyIDAttribute : Attribute
  {
    public string ID { get; private set; }
    public string Display { get; private set; }

    public PropertyIDAttribute(string id, string display)
    {
      ID = id;
      Display = display;
    }
  }
}
