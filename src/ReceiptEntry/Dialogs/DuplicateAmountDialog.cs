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
  public partial class DuplicateAmountDialog : BaseForm
  {
    public int Amount
    {
      get { return (int)spinEdit1.Value; }
      set { spinEdit1.Value = value; }
    }

    public DuplicateAmountDialog()
    {
      InitializeComponent();
    }
  }
}
