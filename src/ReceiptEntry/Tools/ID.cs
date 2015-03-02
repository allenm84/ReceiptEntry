using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class ID
  {
    public static string Gen() { return Guid.NewGuid().ToString(); }
  }
}
