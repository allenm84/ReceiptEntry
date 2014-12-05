using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;

namespace ReceiptEntry
{
  public partial class MainForm : BaseForm
  {
    private ReceiptItemGridViewHelper gridViewHelper;
    private GridViewFeatures features;

    public MainForm()
    {
      InitializeComponent();

      gridViewHelper = new ReceiptItemGridViewHelper(gridViewReceiptItems);
      gridViewReceiptItems.OptionsView.ShowColumnHeaders = false;
      gridViewReceiptItems.OptionsView.ShowIndicator = false;
      gridViewReceiptItems.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
      gridViewReceiptItems.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;

      features = new GridViewFeatures(gridViewReceipts);
      features.AddAlignGroupSummariesToColumns();
    }

    private async void LoadDatabase()
    {
      Enabled = false;
      
      await Task.Run(() => Database.Load());
      merchantSource.DataSource = Database.Merchants;
      receiptSource.DataSource = Database.Receipts;

      Enabled = true;
    }

    private async void DoSave()
    {
      tbbSave.Enabled = false;
      await Task.Run(() => Database.Save());
      tbbSave.Enabled = true;
    }

    private void EditReceiptByRowHandle(int rowHandle)
    {
      EditReceiptByItem(gridViewReceipts.GetRow(rowHandle) as Receipt);
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
      base.OnLoad(e);
      LoadDatabase();
    }

    private void tbbSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      DoSave();
    }

    private void tbbMerchantTypes_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbMerchants_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbFriendlyNames_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbNewReceipt_ItemClick(object sender, ItemClickEventArgs e)
    {
      var receipt = new Receipt
      {
        Date = DateTime.Today,
        Items = new BindingList<ReceiptItem>(),
        MerchantID = null,
        Tax = 0,
      };

      using (var dlg = new EditReceiptDialog(receipt))
      {
        dlg.ShowEditOrder = true;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          receiptSource.Add(receipt);
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
        e.Value = value.Date.Date;
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
