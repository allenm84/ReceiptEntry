using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry.DExpress
{
  public partial class BaseForm : XtraForm
  {
    protected bool mCancelClose = false;

    public BaseForm()
    {
      InitializeComponent();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (mCancelClose)
      {
        e.Cancel = true;
        mCancelClose = false;
      }
      base.OnFormClosing(e);
    }
  }
}