using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public partial class CodeEditor : XtraUserControl
  {
    public bool CodeEnabled
    {
      get { return chkEnableCode.Checked; }
      set { chkEnableCode.Checked = value; }
    }

    public string CodeValue
    {
      get { return txtCode.Text; }
      set { txtCode.Text = value; }
    }

    public CodeEditor()
    {
      InitializeComponent();
      txtCode.DataBindings.Add("Enabled", chkEnableCode, "Checked");
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      base.SetBoundsCore(x, y, width, 47, specified);
    }

    public bool IsValid()
    {
      return 
        !chkEnableCode.Checked ||
        chkEnableCode.Checked && !string.IsNullOrWhiteSpace(txtCode.Text);
    }
  }
}
