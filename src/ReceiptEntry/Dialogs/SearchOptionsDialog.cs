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

namespace ReceiptEntry
{
  public partial class SearchOptionsDialog : BaseForm
  {
    static bool sIncludeExact = false;
    static bool sIncludeSimilar = true;
    static bool sSearchItemCode = false;
    static string sText = "";

    public SearchOptionsDialog()
    {
      InitializeComponent();
      ReadStaticOptions();
    }

    private void ReadStaticOptions()
    {
      chkIncludeExact.Checked = sIncludeExact;
      chkIncludeSimilar.Checked = sIncludeSimilar;
      chkSearchItemCode.Checked = sSearchItemCode;
      txtSearchText.Text = sText;
    }

    private void WriteStaticOptions()
    {
      sIncludeExact = chkIncludeExact.Checked;
      sIncludeSimilar = chkIncludeSimilar.Checked;
      sSearchItemCode = chkSearchItemCode.Checked;
      sText = txtSearchText.Text;
    }

    public SearchOptions CreateOptions()
    {
      return new SearchOptions
      {
        IncludeExact = chkIncludeExact.Checked,
        IncludeSimilar = chkIncludeSimilar.Checked,
        SearchItemCode = chkSearchItemCode.Checked,
        Text = txtSearchText.Text,
      };
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      WriteStaticOptions();
      base.OnFormClosed(e);
    }

    private void chkIncludeExact_CheckedChanged(object sender, EventArgs e)
    {
      if (chkIncludeExact.Checked && chkIncludeSimilar.Checked)
      {
        MessageHelper.Inform(this, "You selected to include exact matches, so similar matches won't be returned");
        chkIncludeSimilar.Checked = false;
      }
    }

    private void chkIncludeSimilar_CheckedChanged(object sender, EventArgs e)
    {
      if (chkIncludeExact.Checked && chkIncludeSimilar.Checked)
      {
        MessageHelper.Inform(this, "You selected to include similar matches, so exact matches won't be returned");
        chkIncludeExact.Checked = false;
      }
    }

    private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        e.Handled = true;
        okCancelButtons1.OK.PerformClick();
      }
    }
  }
}