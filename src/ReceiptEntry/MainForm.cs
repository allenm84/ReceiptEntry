using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class MainForm : BaseForm
  {
    private GridViewFeatures features;

    public MainForm()
    {
      InitializeComponent();
      features = new GridViewFeatures(gridViewReceipts);
      features.AddAlignGroupSummariesToColumns();
    }

    private void EditReceiptByRowHandle(int rowHandle)
    {
      EditReceiptByRowHandle(gridViewReceipts.GetRow(rowHandle));
    }

    private void EditReceiptByRowHandle(object row)
    {
      EditReceiptByItem(row as Receipt);
    }

    private void EditReceiptByItem(Receipt receipt)
    {
      if (receipt == null) return;
      var copy = receipt.Duplicate();
      using (var dlg = new EditReceiptDialog(copy))
      {
        dlg.Text = "Edit Receipt";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var index = receiptSource.IndexOf(receipt);
          receiptSource[index] = copy;
        }
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      SaveFile.Load();
      merchantSource.DataSource = SaveFile.Merchants;
      namedItemSource.DataSource = SaveFile.Items;
      receiptSource.DataSource = SaveFile.Receipts;
      base.OnLoad(e);
    }

    private void tbbSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      SaveFile.Save();
    }

    private void tbbBrands_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbItems_ItemClick(object sender, ItemClickEventArgs e)
    {
      using (var dlg = new NamedItemsDialog(SaveFile.Items))
      {
        dlg.ShowDialog(this);
      }
    }

    private void tbbMerchants_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbNewReceipt_ItemClick(object sender, ItemClickEventArgs e)
    {
      var receipt = new Receipt
      {
        Date = DateTime.Today,
        ID = Pool.ID,
        Items = new List<ReceiptItem>(),
        MerchantID = null,
        Tax = 0,
      };

      using (var dlg = new EditReceiptDialog(receipt))
      {
        dlg.Text = "Add Receipt";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          receiptSource.Add(receipt);
          namedItemSource.ResetBindings(false);
          merchantSource.ResetBindings(false);
        }
      }
    }

    private void gridViewReceipts_CustomColumnGroup(object sender, CustomColumnSortEventArgs e)
    {
      if (e.Column == colDateMonth)
      {
        var r1 = e.RowObject1 as Receipt;
        var r2 = e.RowObject2 as Receipt;
        e.Result = r1.Date.Month.CompareTo(r2.Date.Month);
        e.Handled = true;
      }
    }

    private void gridViewReceipts_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
    {
      if (e.Column == colDateMonth)
      {
        var value = e.Row as Receipt;
        e.Value = value.Date;
      }
    }

    private void gridReceipts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewReceipts.CalcHitInfo(e.Location);
        if ((info.InRow || info.InRowCell) && !info.InGroupRow)
        {
          EditReceiptByRowHandle(info.RowHandle);
        }
      }
    }
  }
}
