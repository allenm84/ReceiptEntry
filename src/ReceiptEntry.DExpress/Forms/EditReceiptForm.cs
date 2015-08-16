﻿using System;
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
    static readonly string sColumnsName;
    static EditReceiptForm()
    {
      sColumnsName = name.of((ReceiptViewModel v) => v.Columns);
    }

    private readonly ReceiptViewModel mReceipt;
    private readonly BindingList<ReceiptColumnViewModel> mAllColumns;
    private readonly Dictionary<string, GridColumn> mGridColumns;

    private BindingList<ReceiptColumnReferenceViewModel> mCurrentColumns;

    public EditReceiptForm(ReceiptViewModel receipt)
    {
      mReceipt = receipt;
      mAllColumns = receipt.Parent.Columns.Items;
      mGridColumns = new Dictionary<string, GridColumn>();

      InitializeComponent();
      AddViewModelColumns();

      var colName = cboViewNames.Columns.AddVisible((HelpfulNameViewModel v) => v.Name);
      colName.SortOrder = ColumnSortOrder.Ascending;
      bsNames.DataSource = receipt.Parent.Names.Items;

      cboMerchant.BindValue(receipt, (ReceiptViewModel v) => v.MerchantID);
      bsMerchants.DataSource = receipt.Parent.Merchants.Items;
      dtDate.BindDate(receipt, (ReceiptViewModel v) => v.Date);
      bsItems.DataSource = receipt.Items;
      bsTaxes.DataSource = receipt.Taxes;
      numTotal.BindValue(receipt, (ReceiptViewModel v) => v.Total);
      CommandBinder.Bind(okCancelButtons1, receipt);
      receipt.PropertyChanged += receipt_PropertyChanged;

      var format = colPercent.DisplayFormat;
      format.FormatType = DevExpress.Utils.FormatType.Custom;
      format.Format = new AddPercentageFormatter();

      Yielder.Call(SyncColumns, UpdateEditButton);
    }

    private void AddViewModelColumns()
    {
      foreach (var c in mAllColumns)
      {
        if (!mGridColumns.ContainsKey(c.ID))
        {
          var column = new GridColumn();
          column.FieldName = c.Name;
          column.Visible = false;
          SetUnboundType(column, c.Type);
          mGridColumns[c.ID] = column;
          gridViewItems.Columns.Add(column);
        }
      }
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

    private void SyncColumns()
    {
      AddViewModelColumns();

      gridViewItems.BeginUpdate();

      if (mCurrentColumns != null)
      {
        foreach (var c in mCurrentColumns)
        {
          c.Order = mGridColumns[c.ColumnID].VisibleIndex + 1;
        }
      }

      mCurrentColumns = mReceipt.Columns;

      if (mCurrentColumns != null)
      {
        foreach (var kvp in mGridColumns)
        {
          kvp.Value.VisibleIndex = -1;
        }

        var columns = mCurrentColumns.OrderBy(i => i.Order).Select((c, o)=> new { Column = c, Order = o});
        foreach (var c in columns)
        {
          mGridColumns[c.Column.ColumnID].VisibleIndex = c.Order + 1;
        }
      }

      gridViewItems.EndUpdate();
    }

    private void UpdateEditButton()
    {
      var index = cboMerchant.Properties.GetIndexByKeyValue(cboMerchant.EditValue);
      btnEdit.Enabled = (-1 < index && index < bsMerchants.Count);
    }

    private void receipt_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      if (e.PropertyName == sColumnsName)
      {
        SyncColumns();
      }
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
      var index = cboMerchant.Properties.GetIndexByKeyValue(cboMerchant.EditValue);
      if (index < 0 || index >= bsMerchants.Count)
      {
        return;
      }

      var merchant = bsMerchants[index] as MerchantViewModel;
      if (merchant == null)
      {
        return;
      }

      using (var dlg = new EditMerchantForm(merchant))
      {
        dlg.Text = "Edit Merchant";
        dlg.ShowDialog(this);
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
  }
}