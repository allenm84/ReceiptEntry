using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public delegate void BeforeRemoveEventHandler(object sender, BeforeRemoveEventArgs e);
  public class BeforeRemoveEventArgs : CancelEventArgs
  {
    public int Index { get; private set; }
    public BeforeRemoveEventArgs(bool cancel, int index)
      : base(cancel)
    {
      Index = index;
    }
  }

  public class BindingListEx<T> : BindingList<T>
  {
    public event BeforeRemoveEventHandler Removing;

    protected override void RemoveItem(int index)
    {
      var removing = Removing;
      if (removing != null)
      {
        var args = new BeforeRemoveEventArgs(false, index);
        removing(this, args);
        if (args.Cancel)
        {
          return;
        }
      }

      base.RemoveItem(index);
    }
  }
}
