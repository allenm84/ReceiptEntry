using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReceiptEntry.ViewModel;
using DevExpress.XtraGrid.Columns;
using ReceiptEntry.Model;
using DevExpress.Data;
using DevExpress.XtraGrid.Views.Base;

namespace ReceiptEntry.DExpress
{
  public partial class EditReceiptForm : BaseForm
  {
    private readonly ReceiptViewModel mReceipt;
    private readonly BindingList<ReceiptColumnViewModel> mAllColumns;
    private readonly Dictionary<string, GridColumn> mGridColumns;

    private List<ReceiptColumnReferenceViewModel> mSelectedMerchantColumns;

    public EditReceiptForm(ReceiptViewModel receipt)
    {
      mSelectedMerchantColumns = new List<ReceiptColumnReferenceViewModel>();

      mReceipt = receipt;
      mAllColumns = receipt.Parent.Columns.Items;
      mGridColumns = new Dictionary<string, GridColumn>();

      InitializeComponent();
      AddMissingGridColumns();

      var colName = cboViewNames.Columns.AddVisible((HelpfulNameViewModel v) => v.Name);
      colName.SortOrder = ColumnSortOrder.Ascending;
      bsNames.DataSource = receipt.Parent.Names.Items;

      cboMerchant.BindValue(receipt, (ReceiptViewModel v) => v.MerchantID);
      bsMerchants.DataSource = receipt.Parent.Merchants.Items;
      dtDate.BindDate(receipt, (ReceiptViewModel v) => v.Date);
      chkShowHelpfulName.BindEnabled(receipt, (ReceiptViewModel v) => v.IsValidMerchant);
      chkShowHelpfulName.BindChecked(receipt, (ReceiptViewModel v) => v.ShowHelpfulName);
      bsItems.DataSource = receipt.Items;
      bsTaxes.DataSource = receipt.Taxes;
      numTotal.BindValue(receipt, (ReceiptViewModel v) => v.Total);
      CommandBinder.Bind(okCancelButtons1, receipt);

      var format = colPercent.DisplayFormat;
      format.FormatType = DevExpress.Utils.FormatType.Custom;
      format.Format = new AddPercentageFormatter();

      receipt.ColumnsChanged += receipt_ColumnsChanged;
      Yielder.Call(SyncColumns, UpdateEditButton);
    }

    private void receipt_ColumnsChanged(object sender, EventArgs e)
    {
      SyncColumns();
    }

    private void AddMissingGridColumns()
    {
      foreach (var c in mAllColumns)
      {
        if (!mGridColumns.ContainsKey(c.ID))
        {
          AddGridColumn(c);
        }
      }
    }

    private GridColumn AddGridColumn(ReceiptColumnViewModel c)
    {
      var column = new GridColumn();
      column.FieldName = c.Name;
      column.Visible = false;
      SetUnboundType(column, c.Type);
      mGridColumns[c.ID] = column;
      gridViewItems.Columns.Add(column);
      return column;
    }

    private void SetUnboundType(GridColumn column, ReceiptColumnType type)
    {
      switch (type)
      {
        case ReceiptColumnType.Dollars:
          {
            column.UnboundType = UnboundColumnType.Decimal;
            column.DisplayFormat.FormatString = "c2";
            column.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            break;
          }
        case ReceiptColumnType.HelpfulName:
          {
            column.UnboundType = UnboundColumnType.String;
            column.ColumnEdit = cboNames;
            column.ShowButtonMode = ShowButtonModeEnum.ShowAlways;
            break;
          }
        case ReceiptColumnType.Number:
          {
            column.UnboundType = UnboundColumnType.Decimal;
            break;
          }
        case ReceiptColumnType.Text:
          {
            column.UnboundType = UnboundColumnType.String;
            break;
          }
      }
    }

    private void WriteColumnOrder()
    {
      foreach (var c in mSelectedMerchantColumns)
      {
        c.Order = mGridColumns[c.ColumnID].VisibleIndex + 1;
      }
    }

    private void ReadColumnOrder()
    {
      foreach (var kvp in mGridColumns)
      {
        kvp.Value.VisibleIndex = -1;
      }

      var columns = mSelectedMerchantColumns.OrderBy(i => i.Order).Select((c, o) => new { Column = c, Order = o });
      foreach (var c in columns)
      {
        mGridColumns[c.Column.ColumnID].VisibleIndex = c.Order + 1;
      }
    }

    private void SyncColumns()
    {
      AddMissingGridColumns();

      gridViewItems.BeginUpdate();
      WriteColumnOrder();

      mSelectedMerchantColumns = mReceipt.Columns.ToList();

      ReadColumnOrder();
      gridViewItems.EndUpdate();
    }

    private void UpdateEditButton()
    {
      var index = cboMerchant.Properties.GetIndexByKeyValue(cboMerchant.EditValue);
      btnEdit.Enabled = (-1 < index && index < bsMerchants.Count);
    }

    private void receipt_ColumnOrderChanged(object sender, EventArgs e)
    {
      gridViewItems.BeginUpdate();
      ReadColumnOrder();
      gridViewItems.EndUpdate();
    }

    private void cboMerchant_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      var lookup = sender as SearchLookUpEdit;

      var merchant = mReceipt.Parent.Merchants.CreateItem();
      merchant.Name = lookup.GetFilterText();

      using (var dlg = new EditMerchantForm(merchant))
      {
        dlg.Text = "Create Merchant";
        e.Cancel = true;

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          bsMerchants.Add(merchant);
          e.NewValue = merchant.ID;
          e.Cancel = false;
        }
      }
    }

    private void btnEdit_Click(object sender, EventArgs e)
    {
      var merchant = mReceipt.Parent.Merchants.Fetch(cboMerchant.EditValue as string);
      using (var dlg = new EditMerchantForm(merchant))
      {
        dlg.Text = "Edit Merchant";
        dlg.ShowDialog(this);

        AddMissingGridColumns();
        ReadColumnOrder();
        SyncColumns();
      }
    }

    private void gridViewItems_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
    {
      var key = e.Column.FieldName;
      var item = e.Row as ReceiptItemViewModel;
      if (item != null)
      {
        if (e.IsGetData)
        {
          e.Value = item[key];
        }
        else if (e.IsSetData)
        {
          item[key] = e.Value;
        }
      }
    }

    private void cboNames_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      var lookup = sender as SearchLookUpEdit;

      var name = mReceipt.Parent.Names.CreateItem();
      name.Name = lookup.GetFilterText();

      using (var dlg = new TextInputForm())
      {
        dlg.Text = "Add Name";
        dlg.Prompt = "Name:";
        dlg.Input = name.Name;

        e.Cancel = true;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          name.Name = dlg.Input;
          e.NewValue = name.ID;
          e.Cancel = false;
          bsNames.Add(name);
        }
      }
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
      using (var dlg = new ValidateReceiptTotalForm(mReceipt.Validate))
      {
        dlg.ShowDialog(this);
      }
    }

    private void cboMerchant_EditValueChanged(object sender, EventArgs e)
    {
      UpdateEditButton();
    }

    private void gridViewItems_DragObjectDrop(object sender, DragObjectDropEventArgs e)
    {
      Yielder.Call(WriteColumnOrder);
    }
  }
}