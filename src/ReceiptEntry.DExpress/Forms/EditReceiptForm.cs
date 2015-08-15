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

namespace ReceiptEntry.DExpress
{
  public partial class EditReceiptForm : BaseForm
  {
    static readonly string sColumnsName;
    static EditReceiptForm()
    {
      sColumnsName = name.of((ReceiptViewModel v) => v.Columns);
    }

    static int sPreviousHelpfulNameIndex = 1;

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
      colHelpfulNameID.Visible = false;
      AddViewModelColumns();

      var colName = cboViewNames.Columns.AddVisible((HelpfulNameViewModel v) => v.Name);
      colName.SortOrder = ColumnSortOrder.Ascending;
      bsNames.DataSource = receipt.Parent.Names.Items;

      cboMerchant.BindValue(receipt, (ReceiptViewModel v) => v.MerchantID);
      bsMerchants.DataSource = receipt.Parent.Merchants.Items;
      dtDate.BindDate(receipt, (ReceiptViewModel v) => v.Date);
      chkShowHelpfulName.BindChecked(receipt, (ReceiptViewModel v) => v.ShowHelpfulName);
      chkShowHelpfulName.CheckedChanged += chkShowHelpfulName_CheckedChanged;
      bsItems.DataSource = receipt.Items;
      bsTaxes.DataSource = receipt.Taxes;
      numTotal.BindValue(receipt, (ReceiptViewModel v) => v.Total);
      CommandBinder.Bind(okCancelButtons1, receipt);
      receipt.PropertyChanged += receipt_PropertyChanged;

      var format = colPercent.DisplayFormat;
      format.FormatType = DevExpress.Utils.FormatType.Custom;
      format.Format = new AddPercentageFormatter();

      Yielder.Call(SyncColumns, UpdateHelpfulNameVisibility);
    }

    private void AddViewModelColumns()
    {
      foreach (var c in mAllColumns)
      {
        var column = new GridColumn();
        column.FieldName = c.Name;
        column.Visible = false;
        SetUnboundType(column, c.Type);
        mGridColumns[c.ID] = column;
        gridViewItems.Columns.Add(column);
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
      UpdateHelpfulNameVisibility();
    }

    private void UpdateHelpfulNameVisibility()
    {
      if (chkShowHelpfulName.Checked)
      {
        colHelpfulNameID.Visible = false;
        colHelpfulNameID.VisibleIndex = sPreviousHelpfulNameIndex;
      }
      else
      {
        if (colHelpfulNameID.Visible)
        {
          sPreviousHelpfulNameIndex = colHelpfulNameID.VisibleIndex;
        }
        colHelpfulNameID.Visible = false;
      }
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
      var merchant = mReceipt.Parent.Merchants.CreateItem();
      merchant.Name = cboMerchant.GetFilterText();

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

    private void chkShowHelpfulName_CheckedChanged(object sender, EventArgs e)
    {
      UpdateHelpfulNameVisibility();
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
      var name = mReceipt.Parent.Names.CreateItem();
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
  }
}