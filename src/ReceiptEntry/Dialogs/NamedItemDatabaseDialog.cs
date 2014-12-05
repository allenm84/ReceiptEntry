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
  public partial class NamedItemDatabaseDialog : Form
  {
    private BindingList<NamedItem> items;

    public NamedItemDatabaseDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridItems.SelectedItems.Count == 1;
    }

    private void NamedItemDatabaseDialog_Load(object sender, EventArgs e)
    {
      items = new BindingList<NamedItem>(SaveFile.Instance.NamedItems);

      gridItems.SetPropertiesToList(true, true);
      gridItems.SetPropertiesToShowFilterRow();
      gridItems.DataSource = items;
      gridItems.RetrieveStructure();
      gridItems.RootTable.Columns.HideAllExcept("Name");
      gridItems.RootTable.SortKeys.Add("Name");
      gridItems.SetRow(0);
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var item = new NamedItem
      {
        Name = gridItems.RootTable.GetFilterText(),
        ID = Duid.Next,
      };

      using (NameEntryDialog dlg = new NameEntryDialog())
      {
        dlg.Text = "Add Item";
        dlg.BindTo(item);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          items.Add(item);
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      var row = gridItems.SelectedItems[0].GetRow();
      var selected = row.DataRow as NamedItem;

      var copy = selected.Duplicate();
      using (NameEntryDialog dlg = new NameEntryDialog())
      {
        dlg.Text = string.Format("Edit {0}", selected.Name);
        dlg.BindTo(copy);

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          items[row.RowIndex] = copy;
        }
      }
    }

    private void gridItems_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }
  }
}
