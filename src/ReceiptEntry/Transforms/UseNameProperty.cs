using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public class UseNameProperty : ReceiptItemName
  {
    public override string RetrieveName(ReceiptItem item)
    {
      return item.Name;
    }
  }
}
