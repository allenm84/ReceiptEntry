using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class TypeProperties
  {
    static PropertyInfo[] receiptItemProperties;
    static TypeProperties()
    {
      receiptItemProperties = new PropertyInfo[]
      {
        Extensions.GetPropertyInfo((ReceiptItem x) => x.Name),
        Extensions.GetPropertyInfo((ReceiptItem x) => x.Price),
        Extensions.GetPropertyInfo((ReceiptItem x) => x.AliasID),
        Extensions.GetPropertyInfo((ReceiptItem x) => x.Code),
        Extensions.GetPropertyInfo((ReceiptItem x) => x.Quantity),
      };
    }

    public static IEnumerable<PropertyInfo> ReceiptItemProperties
    {
      get
      {
        return receiptItemProperties.Select(p => p);
      }
    }
  }
}
