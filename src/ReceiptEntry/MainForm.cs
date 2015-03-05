using System;
using System.Collections;
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

    public MainForm()
    {
      InitializeComponent();
      InitializeDCF();
      MinimumSize = Size;
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
          return Sanitize(data ?? CreateNewSaveFile());
        });
      }

      gridReceipts.SetData(saveFile.Merchants, saveFile.Receipts);
    }

    private SaveFile Sanitize(SaveFile file)
    {
      foreach (var r in file.Receipts)
      {
        foreach (var i in r.Items)
        {
          if (i.SearchIDs != null)
          {
            i.SearchIDs.Clear();
            i.SearchIDs = null;
          }
          i.SearchIDs = new List<string>();
        }
      }
      return file;
    }

    private void Flush()
    {
      saveFile.Merchants = gridReceipts.Merchants.ToList();
      saveFile.Receipts = gridReceipts.Receipts.ToList();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      LoadSaveFile();
    }

    private void tbbSave_ItemClick(object sender, ItemClickEventArgs e)
    {
      Flush();
      dcf.Write(saveFile);
    }

    private void tbbMerchants_ItemClick(object sender, ItemClickEventArgs e)
    {
      var merchants = gridReceipts.Merchants.Select(m => m.Duplicate());
      var receipts = gridReceipts.Receipts.ToArray();

      using (var dlg = new MerchantListDialog(merchants, receipts))
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          gridReceipts.Set(dlg.Merchants);
        }
      }
    }

    private void tbbShoppingListItems_ItemClick(object sender, ItemClickEventArgs e)
    {

    }

    private void tbbNewReceipt_ItemClick(object sender, ItemClickEventArgs e)
    {
      gridReceipts.AddNewReceipt();
    }

    private void tbbSearch_ItemClick(object sender, ItemClickEventArgs e)
    {
      var receipts = new BindingList<Receipt>();
      receipts.ListChanged += receipts_ListChanged;

      var merchants = gridReceipts.MerchantSource;
      using (var dlg = new SearchOptionsDialog())
      {
        dlg.Text = "Search...";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          SearchResultsDialog.Run(this, 
            dlg.CreateOptions(),
            gridReceipts.Receipts,
            merchants,
            receipts);
        }
      }
    }

    private void receipts_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemDeleted)
      {
        var list = sender as IList;
        var item = list[e.NewIndex];
        gridReceipts.ReceiptSource.Remove(item);
      }
    }
  }
}
