using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public class UseAlias : ReceiptItemName
  {
    public override string RetrieveName(ReceiptItem item)
    {
      string name = null;
      if (!string.IsNullOrWhiteSpace(item.AliasID))
      {
        var alias = Database.ItemAlias.SingleOrDefault(a => a.ID == item.AliasID);
        if (alias != null)
        {
          name = alias.Name;
        }
      }
      return name;
    }
  }
}
