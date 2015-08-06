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
  public partial class TextInputForm : BaseForm
  {
    public string Prompt
    {
      get { return layoutControlItem1.Text; }
      set { layoutControlItem1.Text = value; }
    }

    public string Input
    {
      get { return textEdit1.Text; }
      set { textEdit1.Text = value; }
    }

    public TextInputForm()
    {
      InitializeComponent();
    }
  }
}