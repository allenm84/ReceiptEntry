using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public class UseUnknown : ReceiptItemName
  {
    public override string RetrieveName(ReceiptItem item)
    {
      return "[Unknown Item]";
    }
  }
}
