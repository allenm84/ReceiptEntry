using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Base;

namespace ReceiptEntry
{
  public partial class MainForm : BaseForm, IWorker
  {
    private DataContractFile<SaveFile> dcf;
    private SaveFile saveFile;
    private GridViewFeatures features;

    public MainForm()
    {
      InitializeComponent();
      InitializeDCF();
      MinimumSize = Size;
      features = new GridViewFeatures(gridViewReceipts);
      features.AddAlignGroupSummariesToColumns();
    }

    public void SetIsWorking(bool working)
    {
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      foreach (BarItem item in barManager1.Items)
      {
        item.Enabled = !working;
      }
    }

    private void InitializeDCF()
    {
      string filepath = Path.Combine(Application.StartupPath, "receipts.xml");
      dcf = new DataContractFile<SaveFile>(filepath);
    }

    private SaveFile CreateNewSaveFile()
    {
      return new SaveFile
      {
        Merchants = new List<Merchant>(),
        Receipts = new List<Receipt>(),
      };
    }

    private async void LoadSaveFile()
    {
      using (this.BeginWork())
      {
        saveFile = await Task.Run(() =>
        {
          SaveFile data;
          dcf.TryRead(out data);
          return data ?? CreateNewSaveFile();
        });
      }

      gridViewReceipts.BeginDataUpdate();

      foreach (var m in saveFile.Merchants)
      {
        merchantSource.Add(m);
      }
      foreach (var r in saveFile.Receipts)
      {
        receiptSource.Add(r);
      }

      gridViewReceipts.EndDataUpdate();
    }

    private void Flush()
    {
      saveFile.Merchants = merchantSource.OfType<Merchant>().ToList();
      saveFile.Receipts = receiptSource.OfType<Receipt>().ToList();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      LoadSaveFile();
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

    private void tbbSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      Flush();
      dcf.Write(saveFile);
    }

    private void tbbMerchants_ItemClick(object sender, ItemClickEventArgs e)
    {
      var merchants = saveFile.Merchants.Select(m => m.Duplicate());
      using (var dlg = new MerchantListDialog(merchants))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          gridViewReceipts.BeginDataUpdate();
          cboMerchants.BeginUpdate();

          merchantSource.Clear();
          foreach (var m in dlg.Merchants)
          {
            merchantSource.Add(m);
          }

          cboMerchants.EndUpdate();
          gridViewReceipts.EndDataUpdate();
        }
      }
    }

    private void tbbShoppingListItems_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbNewReceipt_ItemClick(object sender, ItemClickEventArgs e)
    {

    }
  }
}
