using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public abstract class BaseNotifyPropertyChanged : INotifyPropertyChanged
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

    protected virtual bool BeforePropertyChanged(string propertyName)
    {
      return true;
    }

    protected virtual void AfterPropertyChanged(string propertyName)
    {

    }

    protected void FirePropertyChanged([CallerMemberName] string propertyName = "")
    {
      if (!mAllowPropertyChangedEvents)
      {
        return;
      }

      if (!BeforePropertyChanged(propertyName))
      {
        return;
      }

      var changed = PropertyChanged;
      if (changed != null)
      {
        changed(this, new PropertyChangedEventArgs(propertyName));
      }

      AfterPropertyChanged(propertyName);
    }
  }
}
