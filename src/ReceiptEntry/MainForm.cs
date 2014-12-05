using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;
using System.Threading;
using System.Linq.Expressions;
using System.Reflection;

namespace ReceiptEntry
{
  public partial class MainForm : Form, IDoWorkView, ISingleInstanceApplicationView
  {
    private BindingList<Receipt> receiptBindingList;
    private bool mDirty = false;
    private DoWorkController workController;

    public MainForm()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);

      workController = new DoWorkController(this);
      MinimumSize = Size;

      SetDirty(false);
      UpdateCommands();
    }

    #region ISingleInstanceApplicationView Members

    public Form MainWindow { get { return this; } }

    public void StartupNextInstance(IList<string> commandLine)
    {
      this.BringToForeground();
    }

    public void Startup(IList<string> commandLine)
    {
      // do nothing really...
    }

    #endregion

    #region IDoWorkView Members

    public void ShowError(string text)
    {
      MessageBox.Show(this, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void SetIsWorking(bool working)
    {
      tableLayoutPanel1.Enabled = !working;
      uiCommandBar.Enabled = !working;
      uiCommandBar.Focus();
      progStatus.Visible = working;
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
    }

    #endregion

    private void SetDirty(bool dirty)
    {
      if (mDirty != dirty)
      {
        Text = string.Format("Receipt Entry{0}", dirty ? "*" : "");
        mDirty = dirty;
      }
    }

    private void InitializeReceiptGrid()
    {
      // set the properties of the grid
      gridReceipts.SetPropertiesToList(true, false);
      gridReceipts.GridLines = GridLines.None;
      gridReceipts.GroupMode = GroupMode.Collapsed;
      gridReceipts.HideColumnsWhenGrouped = InheritableBoolean.False;
      gridReceipts.HideSelection = HideSelection.Highlight;

      // set the data source of the grid
      gridReceipts.DataSource = receiptBindingList;
      gridReceipts.RetrieveStructure(true);

      // only show the appropriate columns
      gridReceipts.RootTable.Columns.HideAllExcept("Name", "Date", "Total");
      gridReceipts.Tables["Items"].Columns.HideAllExcept("Display");

      // order the columns
      gridReceipts.RootTable.Columns["Name"].Position = 0;

      // set alignment
      gridReceipts.RootTable.Columns.LockColumnWidth("Total", 80);
      gridReceipts.RootTable.Columns["Total"].TextAlignment = TextAlignment.Center;
      gridReceipts.RootTable.Columns.LockColumnWidth("Date", 80);
      gridReceipts.RootTable.Columns["Date"].TextAlignment = TextAlignment.Center;

      // sort the receipts by date, then name, then total
      gridReceipts.RootTable.SortKeys.Add("Date");
      gridReceipts.RootTable.SortKeys.Add("Name");
      gridReceipts.RootTable.SortKeys.Add("Total");

      // sort the items by quantity, then name, then price
      gridReceipts.Tables["Items"].SortKeys.Add("Quantity");
      gridReceipts.Tables["Items"].SortKeys.Add("Name");
      gridReceipts.Tables["Items"].SortKeys.Add("Price");

      // group the date multiple times
      var grpYear = gridReceipts.RootTable.Groups.Add("Date");
      grpYear.GroupInterval = GroupInterval.Year;
      grpYear.GroupFormatString = "yyyy";
      grpYear.GroupPrefix = string.Empty;

      var grpMonth = gridReceipts.RootTable.Groups.Add("Date");
      grpMonth.GroupInterval = GroupInterval.Month;
      grpMonth.GroupFormatString = "MMM";
      grpMonth.GroupPrefix = string.Empty;

      // update the grid
      gridReceipts.SetRow(0);
      gridReceipts.CollapseGroups();

      // add header totals
      var groupTotal = new GridEXGroupHeaderTotal();
      groupTotal.AggregateFunction = AggregateFunction.Sum;
      groupTotal.Column = gridReceipts.RootTable.Columns["Total"];
      groupTotal.TotalPrefix = "";
      groupTotal.TotalSuffix = "";
      groupTotal.TotalFormatString = "c2";
      groupTotal.ColumnAlign = gridReceipts.RootTable.Columns["Total"];
      gridReceipts.RootTable.GroupHeaderTotals.Add(groupTotal);
    }

    private void UpdateCommands()
    {
      SaveCommand.IsEnabled = true;
      AddReceiptCommand.IsEnabled = true;

      try
      {
        EditReceiptCommand.IsEnabled =
          gridReceipts.SelectedItems.Count == 1 &&
          gridReceipts.SelectedItems[0].GetRow().RowType == RowType.Record;
      }
      catch
      {
        EditReceiptCommand.IsEnabled = false;
      }

      try
      {
        RemoveReceiptCommand.IsEnabled = gridReceipts.SelectedItems
          .Cast<GridEXSelectedItem>()
          .Select(s => s.GetRow())
          .All(r => r.RowType == RowType.Record);
      }
      catch
      {
        RemoveReceiptCommand.IsEnabled = false;
      }
    }

    private void WriteSaveFile()
    {
      SaveFile.Instance.Receipts = receiptBindingList.ToList();
      SaveFile.Instance.Options.MainWindowSize = this.Size;
    }

    private void DoLoad()
    {
      workController.StartWorker(DoLoadWork, DoLoadRunWorkerCompleted);
    }

    private void DoLoadWork(DoWorkInput input)
    {
      SaveFile.Load();

      // if there are no paidbys, then add one
      if (SaveFile.Instance.PaidBys.Count == 0)
      {
        SaveFile.Instance.PaidBys.Add(new PaidBy
        {
          ID = "{475C8C11-A823-4AEB-9F7A-D09CEB1F8BEF}",
          Name = "Mike",
        });
      }
    }

    private void DoLoadRunWorkerCompleted(DoWorkOutput output)
    {
      // set the data source
      receiptBindingList = new BindingList<Receipt>(SaveFile.Instance.Receipts);

      // initialize the grid
      InitializeReceiptGrid();

      // subscribe to the list changed event
      receiptBindingList.ListChanged += new ListChangedEventHandler(receiptBindingList_ListChanged);

      // set the size
      Size = SaveFile.Instance.Options.MainWindowSize;

      // we're no longer dirty
      SetDirty(false);
    }

    private void DoSave()
    {
      WriteSaveFile();
      workController.StartWorker((x) => SaveFile.Save(), (x) => SetDirty(false));
    }

    private void DoAdd()
    {
      using (EditReceiptDialog dlg = new EditReceiptDialog())
      {
        // create a receipt and initialize the dialog from it
        Receipt receipt = new Receipt()
        {
          Date = DateTime.Today,
          Items = new List<ReceiptItem>(),
          ID = Duid.Next,
        };
        dlg.BindTo(receipt);

        // show the dialog to the user
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          receiptBindingList.Add(receipt);
        }
      }
    }

    private void DoEdit()
    {
      var row = gridReceipts.SelectedItems[0].GetRow();
      if (row.RowType == RowType.Record)
      {
        if (row.DataRow is Receipt)
        {
          DoEditReceipt(row.DataRow as Receipt);
        }
        else if (row.DataRow is ReceiptItem)
        {
          DoEditReceiptItem(row.DataRow as ReceiptItem, row.Parent.DataRow as Receipt);
        }
        else
        {
          MessageBox.Show(this, "Can't edit this item", "Can't Edit",
            MessageBoxButtons.OK, MessageBoxIcon.None);
        }
      }
    }

    private void DoEditReceipt(Receipt receipt)
    {
      using (EditReceiptDialog dlg = new EditReceiptDialog())
      {
        try
        {
          var copy = receipt.Duplicate();
          dlg.BindTo(copy);

          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            int index = receiptBindingList.IndexOf(receipt);
            receiptBindingList[index] = copy;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(this, string.Concat("Couldn't edit because: ", ex.Message),
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void DoEditReceiptItem(ReceiptItem item, Receipt receipt)
    {
      using (EditReceiptItemDialog dlg = new EditReceiptItemDialog())
      {
        try
        {
          var copy = item.Duplicate();
          dlg.BindTo(copy);

          if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            int index = receipt.Items.IndexOf(item);
            receipt.Items[index] = copy;

            index = receiptBindingList.IndexOf(receipt);
            receiptBindingList.ResetItem(index);
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(this, string.Concat("Couldn't edit because: ", ex.Message),
            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }

    private void DoRemove()
    {
      if (SystemManager.Confirmed(this))
      {
        var pendingDeletes = new HashSet<GridEXRow>();
        try
        {
          var rows = gridReceipts.SelectedItems
            .Cast<GridEXSelectedItem>()
            .Select(s => s.GetRow())
            .ToList();

          for (int i = 0; i < rows.Count; ++i)
          {
            var row = rows[i];
            if (row.DataRow is ReceiptItem)
            {
              // retrieve the item
              var item = row.DataRow as ReceiptItem;

              // first, get the parent receipt
              if (row.Parent != null && row.Parent.DataRow is Receipt)
              {
                // is this receipt contained within the rows already
                var receipt = row.Parent.DataRow as Receipt;
                if (rows.Count(r => object.ReferenceEquals(r.DataRow, receipt)) == 0)
                {
                  // retrieve the row of the item to delete
                  pendingDeletes.Add(gridReceipts.GetRow(item));
                }
              }
            }
            else if (row.DataRow is Receipt)
            {
              // retrieve the receipt
              var receipt = row.DataRow as Receipt;

              // remove all the items from the rows if they exist in this receipt
              rows.RemoveAll(r =>
                (r.DataRow is ReceiptItem) &&
                (receipt.Items.Contains((ReceiptItem)r.DataRow)));

              // remove the receipt from the grid
              receiptBindingList.Remove(receipt);
            }

            // ignore this receipt item and continue
            rows.RemoveAt(i);
            --i;
          }
        }
        catch (Exception ex)
        {
          MessageBox.Show(this, string.Concat("Couldn't remove because: ", ex.Message), "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        foreach (var row in pendingDeletes)
        {
          row.Delete();
        }
        receiptBindingList.ResetBindings();
      }
    }

    private void ShowDatabase<T>(Func<Form> dialog, Expression<Func<SaveFile, T>> expression) where T : class
    {
      var memb = (MemberExpression)expression.Body;
      var prop = (PropertyInfo)memb.Member;

      using (var dlg = dialog())
      {
        var backup = ExtensionMethods.Duplicate((dynamic)prop.GetValue(SaveFile.Instance, null));
        if (dlg.ShowDialog(this) != System.Windows.Forms.DialogResult.OK)
        {
          prop.SetValue(SaveFile.Instance, backup, null);
        }
        else
        {
          SetDirty(true);
        }
      }
    }

    private void DoShowMerchants()
    {
      ShowDatabase(() => new MerchantDatabaseDialog(), x => x.Merchants);
    }

    private void DoShowItems()
    {
      ShowDatabase(() => new NamedItemDatabaseDialog(), x => x.NamedItems);
    }

    private void DoShowStatistics()
    {
      using (var dlg = new StatisticsDialog())
      {
        dlg.ShowDialog(this);
      }
    }

    private void DoSearchItems()
    {
      using (var dlg = new SearchDialog())
      {
        dlg.ShowDialog(this);
      }
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      DoLoad();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (mDirty)
      {
        var result = MessageBox.Show(this, "Do you want to save your changes?", "Closing",
          MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        e.Cancel = (result == System.Windows.Forms.DialogResult.Cancel);
        if (result == System.Windows.Forms.DialogResult.Yes)
        {
          DoSave();
        }
      }
    }

    private void receiptBindingList_ListChanged(object sender, ListChangedEventArgs e)
    {
      SetDirty(true);
      UpdateCommands();
    }

    private void gridReceipts_SelectionChanged(object sender, EventArgs e)
    {
      UpdateCommands();
    }

    private void SaveCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoSave();
    }

    private void AddReceiptCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoAdd();
    }

    private void EditReceiptCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoEdit();
    }

    private void RemoveReceiptCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoRemove();
    }

    private void MerchantDatabaseCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoShowMerchants();
    }  

    private void ItemsDatabaseCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoShowItems();
    }

    private void StatisticsCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoShowStatistics();
    }

    private void SearchCommand_Click(object sender, Janus.Windows.UI.CommandBars.CommandEventArgs e)
    {
      DoSearchItems();
    }
  }
}
