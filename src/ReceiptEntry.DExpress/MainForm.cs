using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ReceiptEntry.Model;
using ReceiptEntry.Services;
using ReceiptEntry.ViewModel;
using System.Threading.Tasks;

namespace ReceiptEntry.DExpress
{
  public partial class MainForm : BaseForm
  {
    static ulong sId = 0;

    private SaveFileViewModel viewModel;
    private ISaveFileService service;
    private readonly GridViewFeatures gridViewFeatures;

    public MainForm()
    {
      InitializeComponent();
      gridViewReceipts.SetPropertiesToList(false, false);

      service = new DataContractSaveFileService(Path.Combine(Application.StartupPath, "saved.xml"));
      //service = new TestFileService();

      viewModel = new SaveFileViewModel(service);
      bsMerchants.DataSource = viewModel.Merchants.Items;
      bsReceipts.DataSource = viewModel.Receipts.Items;

      gridViewFeatures = new GridViewFeatures(gridViewReceipts);
      gridViewFeatures.AddAlignGroupSummariesToColumns();
    }

    private void DoEditColumnList()
    {
      using (var dlg = new ReceiptColumnListForm(viewModel.Columns))
      {
        dlg.ShowDialog(this);
      }
    }

    private void DoEditHelpfulNameList()
    {
      using (var dlg = new HelpfulNameListForm(viewModel.Names))
      {
        dlg.ShowDialog(this);
      }
    }

    private void DoEditMerchantList()
    {
      using (var dlg = new MerchantListForm(viewModel.Merchants))
      {
        dlg.ShowDialog(this);
      }
    }

    private void DoAddReceipt()
    {
      var receipt = viewModel.Receipts.CreateItem();
      using (var dlg = new EditReceiptForm(receipt))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          bsReceipts.Add(receipt);
        }
      }
    }

    private void DoEditReceipt(ReceiptViewModel receipt)
    {
      using (var dlg = new EditReceiptForm(receipt))
      {
        dlg.ShowDialog(this);
      }
    }

    private async void ExpandAllGroupsAsync(ulong id)
    {
      await Task.Yield();
      if (id == sId)
      {
        gridViewReceipts.ExpandAllGroups();
      }
    }

    private void gridViewReceipts_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      var receipt = e.Row as ReceiptViewModel;
      if (e.Column == colDateMonth)
      {
        e.Value = string.Format("{0:MM} - {0:MMMM}", receipt.Date);
      }
      else if (e.Column == colDateYear)
      {
        e.Value = string.Format("{0:yyyy}", receipt.Date);
      }
    }

    private void gridReceipts_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button == System.Windows.Forms.MouseButtons.Left)
      {
        var info = gridViewReceipts.CalcHitInfo(e.Location);
        if (info.InRow && !info.InGroupRow)
        {
          var receipt = gridViewReceipts.GetRow(info.RowHandle) as ReceiptViewModel;
          if (receipt != null)
          {
            DoEditReceipt(receipt);
          }
        }
      }
    }

    private void tbbSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      viewModel.SaveCommand.Execute(sender);
    }

    private void tbbColumns_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      Yielder.Call(DoEditColumnList);
    }

    private void tbbNames_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      Yielder.Call(DoEditHelpfulNameList);
    }

    private void tbbMerchants_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      Yielder.Call(DoEditMerchantList);
    }

    private void tbbAddReceipt_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      Yielder.Call(DoAddReceipt);
    }

    private void tbbViewStats_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {

    }

    private void txtSearchText_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        gridViewReceipts.RefreshData();
      }
    }

    private void cboMerchantFilter_EditValueChanged(object sender, EventArgs e)
    {
      gridViewReceipts.RefreshData();
    }

    private void tbbClearMerchants_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      if (tbbMerchantFilter.EditValue != null 
        && MessageHelper.Confirm(this, "Are you sure you want to clear the merchant filter?"))
      {
        tbbMerchantFilter.EditValue = null;
      }
    }

    private void gridViewReceipts_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
    {
      var receipt = bsReceipts[e.ListSourceRow] as ReceiptViewModel;
      var merchantID = tbbMerchantFilter.EditValue as string;

      e.Handled = true;
      e.Visible = (string.IsNullOrWhiteSpace(merchantID) || receipt.MerchantID == merchantID) && 
        receipt.Contains(tbbSearchText.EditValue as string);

      ExpandAllGroupsAsync(sId++);
    }
  }
}
