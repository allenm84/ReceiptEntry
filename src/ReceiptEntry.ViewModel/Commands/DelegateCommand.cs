using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReceiptEntry.ViewModel
{
  internal class DelegateCommand : ICommand
  {
    private readonly Action<object> execute;
    private readonly Func<object, bool> canExecute;

    public DelegateCommand(Action<object> execute)
      : this(execute, null)
    {

    }

    public DelegateCommand(Action<object> execute, Func<object, bool> canExecute)
    {
      this.execute = execute;
      this.canExecute = canExecute;
    }

    public void FireCanExecuteChanged(object sender = null)
    {
      var changed = CanExecuteChanged;
      if (changed != null)
      {
        changed(sender ?? this, EventArgs.Empty);
      }
    }

    public bool CanExecute(object parameter)
    {
      if (canExecute == null)
      {
        return true;
      }

      return canExecute(parameter);
    }

    public event EventHandler CanExecuteChanged;

    public void Execute(object parameter)
    {
      if (CanExecute(parameter))
      {
        execute(parameter);
      }
    }
  }
}
