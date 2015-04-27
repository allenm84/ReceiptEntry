using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class EditTextDialog : BaseForm
  {
    public string Prompt
    {
      get { return layoutControlItem1.Text; }
      set { layoutControlItem1.Text = value; }
    }

    public string Value
    {
      get { return textEdit1.Text; }
      set { textEdit1.Text = value; }
    }

    public EditTextDialog()
    {
      InitializeComponent();
    }
  }
}
