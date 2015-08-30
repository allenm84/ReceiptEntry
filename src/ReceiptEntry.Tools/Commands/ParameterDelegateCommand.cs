using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReceiptEntry.ViewModel
{
  public class ParameterDelegateCommand<T> : ICommand where T : CommandParameter
  {
    private readonly Action<T> execute;
    private readonly Func<T, bool> canExecute;

    public ParameterDelegateCommand(Action<T> execute)
      : this(execute, null)
    {

    }

    public ParameterDelegateCommand(Action<T> execute, Func<T, bool> canExecute)
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
      if (!(parameter is T))
      {
        return false;
      }

      if (canExecute == null)
      {
        return true;
      }

      return canExecute((T)parameter);
    }

    public event EventHandler CanExecuteChanged;

    public void Execute(object parameter)
    {
      if (CanExecute(parameter))
      {
        execute((T)parameter);
      }
    }
  }
}
