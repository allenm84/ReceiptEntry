using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;

namespace ReceiptEntry
{
  public partial class SelectMerchantDialog : BaseForm
  {
    public string SelectedMerchantID
    {
      get { return cboMerchant.EditValue as string; }
      set { cboMerchant.EditValue = value; }
    }

    public SelectMerchantDialog(IEnumerable<Merchant> merchants, string message)
    {
      InitializeComponent();
      merchantSource.Set(merchants);
      labelControl1.Text = message;
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(SelectedMerchantID))
      {
        cancelClose = true;
        XtraMessageBox.Show(this, "Please select a merchant", "Error", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
    }
  }
}
