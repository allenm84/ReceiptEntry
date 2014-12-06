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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using Shopping;

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
      ShoppingListAccessor.Init();
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
      merchantSource.Set(saveFile.Merchants);
      receiptSource.Set(saveFile.Receipts);
      gridViewReceipts.EndDataUpdate();
    }

    private IEnumerable<Merchant> Merchants { get { return merchantSource.OfType<Merchant>(); } }
    private IEnumerable<Receipt> Receipts { get { return receiptSource.OfType<Receipt>(); } }

    private void Flush()
    {
      saveFile.Merchants = Merchants.ToList();
      saveFile.Receipts = Receipts.ToList();
    }

    private void EditByRowHandle(int handle)
    {
      EditByItem(gridViewReceipts.GetRow(handle) as Receipt);
    }

    private void EditByItem(Receipt receipt)
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
      var merchants = Merchants.Select(m => m.Duplicate());
      using (var dlg = new MerchantListDialog(merchants, Receipts.ToArray()))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          gridViewReceipts.BeginDataUpdate();
          merchantSource.Set(dlg.Merchants);
          gridViewReceipts.EndDataUpdate();
        }
      }
    }

    private void tbbShoppingListItems_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbNewReceipt_ItemClick(object sender, ItemClickEventArgs e)
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
        var result = XtraMessageBox.Show(this, 
          string.Format("Are you sure you want to delete the selected receipts?{0}NOTE: If you selected a year, or a month, all of the receipts underneath will be deleted.", Environment.NewLine),
          "Remove", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        if (result == System.Windows.Forms.DialogResult.No) return;
        gridViewReceipts.DeleteSelectedRows();
      }
    }
  }
}
