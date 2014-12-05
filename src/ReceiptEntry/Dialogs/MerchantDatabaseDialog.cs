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
  public partial class MerchantDatabaseDialog : Form
  {
    private BindingList<Merchant> merchants;

    public MerchantDatabaseDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridMerchants.SelectedItems.Count == 1;
    }

    private void MerchantDatabaseDialog_Load(object sender, EventArgs e)
    {
      merchants = new BindingList<Merchant>(SaveFile.Instance.Merchants);

      gridMerchants.SetPropertiesToList(true, true);
      gridMerchants.SetPropertiesToShowFilterRow();
      gridMerchants.DataSource = merchants;
      gridMerchants.RetrieveStructure();
      gridMerchants.RootTable.Columns.HideAllExcept("Name");
      gridMerchants.RootTable.SortKeys.Add("Name");
      gridMerchants.SetRow(0);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var merchant = new Merchant
      {
        Name = gridMerchants.RootTable.GetFilterText(),
        ID = Duid.Next,
      };

      using (NameEntryDialog dlg = new NameEntryDialog())
      {
        dlg.Text = "Add Merchant";
        dlg.BindTo(merchant);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          merchants.Add(merchant);
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      var row = gridMerchants.SelectedItems[0].GetRow();
      var selected = row.DataRow as Merchant;

      var copy = selected.Duplicate();
      using (NameEntryDialog dlg = new NameEntryDialog())
      {
        dlg.Text = string.Format("Edit {0}", selected.Name);
        dlg.BindTo(copy);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          merchants[row.RowIndex] = copy;
        }
      }
    }

    private void gridMerchants_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }
  }
}
