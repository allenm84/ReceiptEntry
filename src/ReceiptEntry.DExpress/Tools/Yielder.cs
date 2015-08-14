using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.DExpress
{
  public static class Yielder
  {
    public static async void Call(params Action[] actions)
    {
      await Task.Yield();
      Array.ForEach(actions, a => a());
    }
  }
}
