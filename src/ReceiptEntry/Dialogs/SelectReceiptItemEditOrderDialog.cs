using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public partial class SelectReceiptItemEditOrderDialog : BaseForm
  {
    private List<string> selectedIDs = new List<string>();

    public SelectReceiptItemEditOrderDialog()
    {
      InitializeComponent();
      foreach (var prop in TypeProperties.ReceiptItemProperties)
      {
        itemSource.Add(new OrderedPropertyItem(prop, selectedIDs, itemSource));
      }
    }

    public string[] GetSelection()
    {
      return selectedIDs.ToArray();
    }

    private void chkSelected_CheckedChanged(object sender, EventArgs e)
    {
      gridViewItems.PostEditor();
    }

    private void okCancelButtons1_CancelClick(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "If you cancel, then the default order will be used. Is that OK?", "Cancel",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      cancelClose = (result == System.Windows.Forms.DialogResult.No);
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure this is the order you want?", "Confirm",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      cancelClose = (result == System.Windows.Forms.DialogResult.No);
    }

    private void gridItems_MouseClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewItems.CalcHitInfo(e.Location);
        if ((info.InRow || info.InRowCell) && (info.Column != colSelected))
        {
          var item = gridViewItems.GetRow(info.RowHandle) as OrderedPropertyItem;
          item.Selected = !item.Selected;
          item.Notify();
        }
      }
    }
  }
}
