using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class EditReceiptItemDialog : BaseForm
  {
    private ReceiptItem item;
    private bool cancelClose = false;

    public EditReceiptItemDialog(ReceiptItem item)
    {
      this.item = item;

      InitializeComponent();
      RefreshCategories();

      namedItemSource.DataSource = SaveFile.Items;
      brandSource.DataSource = SaveFile.Brands;

      cboItems.EditValue = item.ItemID;
      numQuantity.Value = item.Quantity;
      numPrice.Value = item.PricePerItem;
    }

    private void RefreshCategories()
    {
      pathSource.DataSource = Categories.Paths.ToList();
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      RefreshCategories();
    }

    private void cboItems_AddNewValue(object sender, AddNewValueEventArgs e)
    {
      var item = new NamedItem
      {
        BrandID = null,
        CategoryID = null,
        ID = Pool.ID,
        Name = cboItems.GetSearchText(),
      };

      using (var dlg = new EditNamedItemDialog(item))
      {
        dlg.Text = "Add Item";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          namedItemSource.Add(item);
          e.NewValue = item.ID;
          e.Cancel = false;
          brandSource.ResetBindings(true);
        }
        else
        {
          e.Cancel = true;
        }
      }
    }

    private void btnFromTotal_Click(object sender, EventArgs e)
    {
      using (var dlg = new FromTotalDialog())
      {
        dlg.Text = "From Total";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          numPrice.Value = dlg.PricePerItem;
          numQuantity.Value = dlg.Quantity;
        }
      }
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      colName.BestFit();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        cancelClose = false;
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      item.ItemID = cboItems.EditValue as string;
      item.PricePerItem = numPrice.Value;
      item.Quantity = numQuantity.Value;

      if (string.IsNullOrWhiteSpace(item.ItemID))
      {
        cancelClose = true;
        XtraMessageBox.Show(this,
          "Please select an item", "Invalid",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
