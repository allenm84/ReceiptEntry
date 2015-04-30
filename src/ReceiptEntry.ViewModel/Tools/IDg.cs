using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public static class IDg
  {
    public static string Next
    {
      get { return Guid.NewGuid().ToString(); }
    }
  }
}
