using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class Pool
  {
    public static string ID { get { return Guid.NewGuid().ToString(); } }
  }
}
