using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class IWorkerExtensions
  {
    private class DisposableWorker : IDisposable
    {
      private IWorker worker;

      public DisposableWorker(IWorker worker)
      {
        this.worker = worker;
        worker.SetIsWorking(true);
      }

      public void Dispose()
      {
        worker.SetIsWorking(false);
        worker = null;
      }
    }

    public static IDisposable BeginWork(this IWorker worker)
    {
      return new DisposableWorker(worker);
    }
  }
}
