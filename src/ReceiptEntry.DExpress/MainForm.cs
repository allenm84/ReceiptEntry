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

namespace ReceiptEntry.DExpress
{
  public partial class MainForm : BaseForm
  {
    private SaveFileViewModel viewModel;
    private ISaveFileService service;

    public MainForm()
    {
      InitializeComponent();
      service = new DataContractSaveFileService(Path.Combine(Application.StartupPath, "saved.xml"));
      viewModel = new SaveFileViewModel(service);
    }

    private void tbbMerchants_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
    {
      using (var dlg = new MerchantListForm(viewModel.Merchants))
      {
        dlg.ShowDialog(this);
      }
    }
  }
}
