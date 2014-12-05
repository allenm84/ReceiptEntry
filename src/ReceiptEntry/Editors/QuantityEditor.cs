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
  public partial class QuantityEditor : XtraUserControl
  {
    public bool QuantityEnabled
    {
      get { return chkEnableQuantity.Checked; }
      set { chkEnableQuantity.Checked = value; }
    }

    public decimal Amount
    {
      get { return numAmount.Value; }
      set { numAmount.Value = value; }
    }

    public object UnitValue
    {
      get { return cboUnit.EditValue; }
      set { cboUnit.EditValue = value; }
    }

    public QuantityEditor()
    {
      InitializeComponent();
      cboUnit.FillWithEnum<Unit>();

      numAmount.DataBindings.Add("Enabled", chkEnableQuantity, "Checked");
      cboUnit.DataBindings.Add("Enabled", chkEnableQuantity, "Checked");
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      base.SetBoundsCore(x, y, width, 47, specified);
    }

    public bool IsValid()
    {
      return
        !chkEnableQuantity.Checked ||
        (chkEnableQuantity.Checked && (cboUnit.EditValue as Unit?).HasValue);
    }
  }
}
