using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public abstract class ReceiptItemName
  {
    public abstract string RetrieveName(ReceiptItem item);
  }
}
