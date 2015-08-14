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

    public MainForm()
    {
      InitializeComponent();
      //service = new DataContractSaveFileService(Path.Combine(Application.StartupPath, "saved.xml"));
      service = new TestFileService();
      viewModel = new SaveFileViewModel(service);
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

    }
  }
}
