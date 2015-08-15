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
    private SaveFileViewModel viewModel;
    private ISaveFileService service;
    private readonly GridViewFeatures gridViewFeatures;

    public MainForm()
    {
      InitializeComponent();
      gridViewReceipts.SetPropertiesToList(false, false);

      //service = new DataContractSaveFileService(Path.Combine(Application.StartupPath, "saved.xml"));
      service = new TestFileService();
      viewModel = new SaveFileViewModel(service);
      bsMerchants.DataSource = viewModel.Merchants.Items;

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
        if (info.InRow)
        {
          var receipt = gridViewReceipts.GetRow(info.RowHandle) as ReceiptViewModel;
          if (receipt != null)
          {
            DoEditReceipt(receipt);
          }
        }
      }
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

    private void tbbSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      gridViewReceipts.RefreshData();
    }

    private void gridViewReceipts_CustomRowFilter(object sender, DevExpress.XtraGrid.Views.Base.RowFilterEventArgs e)
    {
      var receipt = bsReceipts[e.ListSourceRow] as ReceiptViewModel;
      e.Handled = true;
      e.Visible = receipt.Contains(tbbSearchText.EditValue as string);
    }
  }
}
