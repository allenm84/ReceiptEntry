using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class EditReceiptDialog : Form
  {
    private Receipt dataSource;
    private BindingList<ReceiptItem> items;

    public EditReceiptDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
    }

    public void BindTo(Receipt receipt)
    {
      dataSource = receipt;

      if (string.IsNullOrEmpty(dataSource.PaidByID))
        dataSource.PaidByID = SaveFile.Instance.PaidBys.First().ID;

      items = new BindingList<ReceiptItem>(dataSource.Items);
      items.ListChanged += new ListChangedEventHandler(items_ListChanged);

      cboCalendar.DataBindings.Add("Value", dataSource, "Date");
      numTax.DataBindings.Add("Value", dataSource, "Tax");
    }

    private void UpdateDisplay()
    {
      btnOK.Enabled = (items.Count > 0) && (dataSource.LinkedMerchant != null);
      btnAdd.Enabled = true;
      btnEdit.Enabled = gridItems.SelectedItems.Count == 1;
      numTotal.Value = items.Sum(r => r.Price) + ((decimal)numTax.Value);
    }

    private void items_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateDisplay();
    }

    private void EditReceiptDialog_Load(object sender, EventArgs e)
    {
      gridMapping.SetPropertiesToList(false, false);
      gridMapping.SetPropertiesToHideSelection();
      gridMapping.DataSource = new List<Receipt> { dataSource };
      gridMapping.RetrieveStructure();
      gridMapping.RootTable.Columns.HideAllExcept("Name");

      gridPaidBy.SetPropertiesToList(false, false);
      gridPaidBy.SetPropertiesToHideSelection();
      gridPaidBy.DataSource = new List<Receipt> { dataSource };
      gridPaidBy.RetrieveStructure();
      gridPaidBy.RootTable.Columns.HideAllExcept("PaidByName");

      gridItems.SetPropertiesToList(true, true);
      gridItems.DataSource = items;
      gridItems.RetrieveStructure();
      gridItems.RootTable.Columns.HideAllExcept("Display");

      UpdateDisplay();
    }

    private void btnEditMapping_Click(object sender, EventArgs e)
    {
      using (var dlg = new DataSelectionDialog<Merchant>())
      {
        // setup the dialog
        dlg.Text = "Select Merchant";
        dlg.Icon = this.Icon;

        // set the matches function
        dlg.GetMatchesTo = (t =>
          SaveFile.Instance.Merchants.Where(n => Textex.IndexOf(n.Name, t)));

        // set the add function
        dlg.AddNewItem = SaveFile.Instance.Merchants.Add;

        // set the creation function
        dlg.CreateNewItem = (x => new Merchant
        {
          ID = Duid.Next,
          Name = x,
        });

        // show the dialog
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dataSource.MerchantID = dlg.SelectedItem.ID;
          gridMapping.Refresh();
        }
      }
      UpdateDisplay();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var result = Common.AddReceiptItem(this, "<New>");
      if (result)
      {
        items.Add(result);
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      var row = gridItems.SelectedItems[0].GetRow();
      var item = row.DataRow as ReceiptItem;

      var result = Common.EditReceiptItem(this, item);
      if (result)
      {
        var index = items.IndexOf(item);
        items[index] = result;
      }
    }

    private void gridItems_SelectionChanged(object sender, EventArgs e)
    {
      UpdateDisplay();
    }

    private void numTax_ValueChanged(object sender, EventArgs e)
    {
      UpdateDisplay();
    }

    private void btnEditPaidBy_Click(object sender, EventArgs e)
    {
      using (var dlg = new DataSelectionDialog<PaidBy>())
      {
        // setup the dialog
        dlg.Text = "Who paid for this?";
        dlg.Icon = this.Icon;

        // set the matches function
        dlg.GetMatchesTo = (t =>
          SaveFile.Instance.PaidBys.Where(n => Textex.IndexOf(n.Name, t)));

        // set the add function
        dlg.AddNewItem = SaveFile.Instance.PaidBys.Add;

        // set the creation function
        dlg.CreateNewItem = (x => new PaidBy
        {
          ID = Duid.Next,
          Name = x,
        });

        // show the dialog
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dataSource.PaidByID = dlg.SelectedItem.ID;
          gridPaidBy.Refresh();
        }
      }
      UpdateDisplay();
    }
  }
}
