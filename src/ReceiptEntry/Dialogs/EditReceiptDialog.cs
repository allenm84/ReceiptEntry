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
  public partial class EditReceiptDialog : BaseForm
  {
    private bool cancelClose = false;
    private Receipt receipt;

    public EditReceiptDialog(Receipt receipt)
    {
      this.receipt = receipt;
      InitializeComponent();

      merchantSource.DataSource = SaveFile.Merchants;
      namedItemSource.DataSource = SaveFile.Items;

      cboMerchants.EditValue = receipt.MerchantID;
      dteDate.DateTime = receipt.Date;
      receiptItemSource.DataSource = receipt.Items;
      numTax.Value = receipt.Tax;

      receiptItemSource.ListChanged += receiptItemSource_ListChanged;
    }

    private void UpdateButtons()
    {
      int selectionCount = gridViewItems.SelectedRowsCount;
      btnEdit.Enabled = selectionCount == 1;
      btnRemove.Enabled = selectionCount > 0;
      btnClear.Enabled = receiptItemSource.Count > 0;
      UpdateTotal();
    }

    private void EditItemByRowHandle(int rowHandle)
    {
      EditItemByRowValue(gridViewItems.GetRow(rowHandle));
    }

    private void EditItemByRowValue(object value)
    {
      EditItemByItem(value as ReceiptItem);
    }

    private void EditItemByItem(ReceiptItem item)
    {
      if (item == null) return;
      var copy = item.Duplicate();
      using (var dlg = new EditReceiptItemDialog(copy))
      {
        dlg.Text = "Edit Item";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var index = receiptItemSource.IndexOf(item);
          receiptItemSource[index] = copy;
        }
      }
    }

    private void UpdateTotal()
    {
      numTotal.Value = numTax.Value + (receiptItemSource
        .Cast<ReceiptItem>()
        .Sum(i => (i.Quantity * i.PricePerItem)));
    }

    private void receiptItemSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void cboMerchants_AddNewValue(object sender, AddNewValueEventArgs e)
    {
      var merchant = new Merchant
      {
        ID = Pool.ID,
        IsGrocery = false,
        Name = cboMerchants.GetSearchText(),
      };

      using (var dlg = new EditMerchantDialog(merchant))
      {
        dlg.Text = "Add Merchant";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          merchantSource.Add(merchant);
          e.NewValue = merchant.ID;
          e.Cancel = false;
        }
        else
        {
          e.Cancel = true;
        }
      }
    }

    private void gridViewItems_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void gridItems_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewItems.CalcHitInfo(e.Location);
        if ((info.InRow || info.InRowCell) && !info.InGroupRow)
        {
          EditItemByRowHandle(info.RowHandle);
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      var item = new ReceiptItem
      {
        ItemID = null,
        PricePerItem = 0,
        Quantity = 0,
      };

      using (var dlg = new EditReceiptItemDialog(item))
      {
        dlg.Text = "Add Item";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          receiptItemSource.Add(item);
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      EditItemByRowValue(gridViewItems.GetFocusedRow());
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this,
        "Are you sure you want to remove the selected items",
        "Remove", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      gridViewItems.DeleteSelectedRows();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this,
        "Are you sure you want to clear all the items",
        "Clear", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      receiptItemSource.Clear();
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
      receipt.Date = dteDate.DateTime.Date;
      receipt.MerchantID = cboMerchants.EditValue as string;
      receipt.Tax = numTax.Value;

      if (string.IsNullOrWhiteSpace(receipt.MerchantID))
      {
        cancelClose = true;
        XtraMessageBox.Show(this,
          "Please select a merchant", "Invalid",
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void numTax_ValueChanged(object sender, EventArgs e)
    {
      UpdateTotal();
    }
  }
}
