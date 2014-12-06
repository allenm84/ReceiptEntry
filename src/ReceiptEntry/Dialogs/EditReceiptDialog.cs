using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public partial class EditReceiptDialog : BaseForm
  {
    private Receipt receipt;
    private ReceiptItemGridViewHelper gridViewHelper;
    private ReceiptItemProperty[] currentEditOrder;

    public EditReceiptDialog(Receipt receipt, IList merchants)
    {
      this.receipt = receipt;
      InitializeComponent();

      numTax.SetMinMax();
      gridViewHelper = new ReceiptItemGridViewHelper(gridViewItems);

      merchantSource.DataSource = merchants;
      receiptItemSource.Set(receipt.Items);

      dtDate.DataBindings.Add("EditValue", receipt, "Date");
      cboMerchant.DataBindings.Add("EditValue", receipt, "MerchantID");
      numTax.DataBindings.Add("EditValue", receipt, "Tax");

      receiptItemSource.ListChanged += receiptItemSource_ListChanged;
      cboMerchant.EditValueChanged += cboMerchant_EditValueChanged;
    }

    private void cboMerchant_EditValueChanged(object sender, EventArgs e)
    {
      currentEditOrder = null;

      var merchant = cboMerchantView.GetFocusedRow() as Merchant;
      if (merchant != null)
      {
        currentEditOrder = merchant.Values;
      }

      gridViewHelper.ShowCodeColumn = (currentEditOrder == null)
        || (currentEditOrder.Length == 0)
        || (currentEditOrder.Contains(ReceiptItemProperty.Code));
    }

    private void EditByRowHandle(int rowHandle)
    {
      var row = gridViewItems.GetRow(rowHandle);
      EditByItem(row as ReceiptItem);
    }

    private void EditByItem(ReceiptItem item)
    {
      if (item == null) return;

      using (var dlg = new EditReceiptItemDialog(currentEditOrder))
      {
        dlg.Text = "Edit Item";
        dlg.Read(item);
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var index = receiptItemSource.IndexOf(item);
          receiptItemSource[index] = dlg.Flush();
        }
      }
    }

    private void UpdateTotal()
    {
      numTotal.Value = numTax.Value + receiptItemSource
        .Cast<ReceiptItem>()
        .Sum(i => i.Price);
    }

    private void UpdateButtons()
    {
      btnEdit.Enabled = gridViewItems.SelectedRowsCount == 1;
      btnRemove.Enabled = gridViewItems.SelectedRowsCount > 0;
      btnClear.Enabled = receiptItemSource.Count > 0;
      btnDuplicate.Enabled = gridViewItems.SelectedRowsCount == 1;
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      UpdateTotal();
      UpdateButtons();
    }

    private void cboMerchant_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      using (var dlg = new EditMerchantDialog())
      {
        dlg.Text = "Add Merchant";
        dlg.MerchantName = cboMerchantView.FindFilterText;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var merchant = new Merchant
          {
            ID = ID.Gen(),
            Name = dlg.MerchantName,
            Values = dlg.Selection.ToArray(),
          };

          merchantSource.Add(merchant);
          e.NewValue = merchant.ID;
        }
        else
        {
          e.Cancel = true;
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      using (var dlg = new EditReceiptItemDialog(currentEditOrder))
      {
        dlg.Text = "Add Receipt Item";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var index = receiptItemSource.Add(dlg.Flush());
          var handle = gridViewItems.GetRowHandle(index);
          gridViewItems.MakeRowVisible(handle);
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      EditByItem(gridViewItems.GetFocusedRow() as ReceiptItem);
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to remove the selected items?", "Confirm", 
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      gridViewItems.DeleteSelectedRows();
    }

    private void btnClear_Click(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to clear all the items?", "Confirm",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      receiptItemSource.Clear();
    }

    private void gridItems_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewItems.CalcHitInfo(e.Location);
        if (info.InRowCell || info.InRow)
        {
          EditByRowHandle(info.RowHandle);
        }
      }
    }

    private void receiptItemSource_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateTotal();
      UpdateButtons();
    }

    private void numTax_ValueChanged(object sender, EventArgs e)
    {
      UpdateTotal();
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(cboMerchant.EditValue as string))
      {
        cancelClose = true;
        XtraMessageBox.Show(this, "Please select a merchant", "Error", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      // flush the items
      receipt.Items = receiptItemSource.OfType<ReceiptItem>().ToArray();
    }

    private void gridViewItems_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void btnDuplicate_Click(object sender, EventArgs e)
    {
      var item = gridViewItems.GetFocusedRow() as ReceiptItem;
      if (item == null) return;

      using (var dlg = new DuplicateAmountDialog())
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          gridViewItems.BeginDataUpdate();

          int amt = dlg.Amount;
          int index = -1;

          for (int i = 0; i < amt; ++i)
          {
            index = receiptItemSource.Add(item.Duplicate());
          }

          gridViewItems.EndDataUpdate();

          var handle = gridViewItems.GetRowHandle(index);
          gridViewItems.MakeRowVisible(handle);
        }
      }
    }    
  }
}
