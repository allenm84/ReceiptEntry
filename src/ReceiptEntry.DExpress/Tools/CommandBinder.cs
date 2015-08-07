using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ReceiptEntry.DExpress
{
  public class CommandBinder
  {
    public static void Bind(Control control, ICommand command)
    {
      new CommandBinder(control, command);
    }

    private Control control;
    private ICommand command;

    public CommandBinder(Control control, ICommand command)
    {
      this.control = control;
      this.command = command;

      ReadCommandAsync();

      command.CanExecuteChanged += command_CanExecuteChanged;
      control.Click += control_Click;
      control.Disposed += control_Disposed;
    }

    ~CommandBinder()
    {
      Dispose(false);
      Debug.Fail("CommandBinder was not disposed!");
    }

    private void control_Disposed(object sender, EventArgs e)
    {
      Dispose(true);
    }

    private void Dispose(bool disposing)
    {
      if (disposing)
      {
        if (command != null)
        {
          command.CanExecuteChanged -= command_CanExecuteChanged;
          command = null;
        }

        if (control != null)
        {
          control.Click -= control_Click;
          control.Disposed -= control_Disposed;
          control = null;
        }

        GC.SuppressFinalize(this);
      }
    }

    private async void ReadCommandAsync()
    {
      await Task.Yield();
      ReadCommand();
    }

    private void ReadCommand()
    {
      control.Enabled = command.CanExecute(this);
    }

    private void command_CanExecuteChanged(object sender, EventArgs e)
    {
      ReadCommand();
    }

    private void control_Click(object sender, EventArgs e)
    {
      command.Execute(this);
    }
  }
}
