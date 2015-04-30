using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public abstract class NotifyPropertyChanged : INotifyPropertyChanged
  {
    private bool mAllowPropertyChangedEvents = true;

    public event PropertyChangedEventHandler PropertyChanged;

    protected void SuspendNotifications()
    {
      mAllowPropertyChangedEvents = false;
    }

    protected void ResumeNotifications()
    {
      mAllowPropertyChangedEvents = true;
    }

    protected virtual void FirePropertyChanged([CallerMemberName] string propertyName = "")
    {
      if (!mAllowPropertyChangedEvents)
      {
        return;
      }

      var changed = PropertyChanged;
      if (changed != null)
      {
        changed(this, new PropertyChangedEventArgs(propertyName));
      }
    }
  }
}
