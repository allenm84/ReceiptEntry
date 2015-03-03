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
using DevExpress.XtraGrid.Views.Base;

namespace ReceiptEntry
{
  public partial class ReceiptGridControl : XtraUserControl
  {
    private GridViewFeatures features;

    public IEnumerable<Merchant> Merchants { get { return merchantSource.OfType<Merchant>(); } }
    public IEnumerable<Receipt> Receipts { get { return receiptSource.OfType<Receipt>(); } }

    public BindingSource MerchantSource { get { return merchantSource; } }
    public BindingSource ReceiptSource { get { return receiptSource; } }

    public ReceiptGridControl()
    {
      InitializeComponent();

      features = new GridViewFeatures(gridViewReceipts);
      features.AddAlignGroupSummariesToColumns();
    }

    public void Bind(object merchants, object receipts)
    {
      gridViewReceipts.BeginDataUpdate();
      merchantSource.DataSource = merchants;
      receiptSource.DataSource = receipts;
      gridViewReceipts.EndDataUpdate();
    }

    public void BindMerchants(object source)
    {
      gridViewReceipts.BeginDataUpdate();
      merchantSource.DataSource = source;
      gridViewReceipts.EndDataUpdate();
    }

    public void BindReceipts(object source)
    {
      gridViewReceipts.BeginDataUpdate();
      receiptSource.DataSource = source;
      gridViewReceipts.EndDataUpdate();
    }

    public void SetData(IEnumerable<Merchant> merchants, IEnumerable<Receipt> receipts)
    {
      gridViewReceipts.BeginDataUpdate();
      merchantSource.Set(merchants);
      receiptSource.Set(receipts);
      gridViewReceipts.EndDataUpdate();
    }

    public void Set(IEnumerable<Merchant> merchants)
    {
      gridViewReceipts.BeginDataUpdate();
      merchantSource.Set(merchants);
      gridViewReceipts.EndDataUpdate();
    }

    public void Set(IEnumerable<Receipt> receipts)
    {
      gridViewReceipts.BeginDataUpdate();
      receiptSource.Set(receipts);
      gridViewReceipts.EndDataUpdate();
    }

    public void EditByRowHandle(int handle)
    {
      EditByItem(gridViewReceipts.GetRow(handle) as Receipt);
    }

    public void EditByItem(Receipt receipt)
    {
      if (receipt == null) return;

      var copy = receipt.Duplicate();
      using (var dlg = new EditReceiptDialog(copy, merchantSource))
      {
        dlg.Text = "Edit Receipt";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var index = receiptSource.IndexOf(receipt);
          receiptSource[index] = copy;
        }
      }
    }

    public void AddNewReceipt()
    {
      var receipt = new Receipt();
      receipt.Date = DateTime.Today;
      receipt.Items = new ReceiptItem[0];

      using (var dlg = new EditReceiptDialog(receipt, merchantSource))
      {
        dlg.Text = "Add Receipt";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          receiptSource.Add(receipt);
        }
      }
    }

    public void BeginDataUpdate()
    {
      gridViewReceipts.BeginDataUpdate();
    }

    public void EndDataUpdate()
    {
      gridViewReceipts.EndDataUpdate();
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
        e.Value = value.Date.Date;
      }
    }

    private void gridReceipts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewReceipts.CalcHitInfo(e.Location);
        if (!info.InGroupRow && (info.InRowCell || info.InRow))
        {
          EditByRowHandle(info.RowHandle);
        }
      }
    }

    private void gridReceipts_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        if (MessageHelper.Confirm(this, string.Format("Are you sure you want to delete the selected receipts?{0}NOTE: If you selected a year, or a month, all of the receipts underneath will be deleted.", Environment.NewLine)))
        {
          gridViewReceipts.DeleteSelectedRows();
        }
      }
    }
  }
}
