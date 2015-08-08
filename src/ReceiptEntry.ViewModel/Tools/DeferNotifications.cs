using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public interface IDeferNotifcation
  {
    void Begin();
    void End();
  }

  public class DeferNotifications : IDisposable
  {
    private IDeferNotifcation mDefer;

    public DeferNotifications(IDeferNotifcation defer)
    {
      mDefer = defer;
      mDefer.Begin();
    }

    public void Dispose()
    {
      if (mDefer != null)
      {
        mDefer.End();
        mDefer = null;
      }
    }
  }
}
