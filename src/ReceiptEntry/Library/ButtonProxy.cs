using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public class ButtonProxy : IButtonControl
  {
    private SimpleButton button;

    public ButtonProxy(SimpleButton button)
    {
      this.button = button;
    }

    DialogResult IButtonControl.DialogResult
    {
      get { return button.DialogResult; }
      set { button.DialogResult = value; }
    }

    void IButtonControl.NotifyDefault(bool value)
    {
      button.NotifyDefault(value);
    }

    void IButtonControl.PerformClick()
    {
      button.PerformClick();
    }

    public static implicit operator SimpleButton(ButtonProxy proxy)
    {
      return proxy.button;
    }
  }
}
