using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using DevExpress.Data;
using DevExpress.Utils;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using Shopping;

namespace ReceiptEntry
{
  public class ReceiptItemGridViewHelper
  {
    private GridView gridViewItems;
    private GridColumn colItemName;
    private GridColumn colCode;
    private GridColumn colPrice;
    private GridColumn colQuantity;

    public bool ShowCodeColumn
    {
      get { return colCode.Visible; }
      set
      {
        if (value)
        {
          colCode.VisibleIndex = 1;
          colCode.Visible = true;
        }
        else
        {
          colCode.Visible = false;
        }
      }
    }

    public ReceiptItemGridViewHelper(GridView gridViewItems)
    {
      this.gridViewItems = gridViewItems;
      InitializeColumns();
      InitializeGridView();
    }

    private void InitializeColumns()
    {
      colItemName = new GridColumn();
      colItemName.Caption = "Name";
      colItemName.FieldName = "ItemName";
      colItemName.Name = "colItemName";
      colItemName.UnboundType = UnboundColumnType.String;
      colItemName.Visible = true;
      colItemName.VisibleIndex = 0;

      colCode = new GridColumn();
      colCode.FieldName = "Code";
      colCode.Name = "colCode";
      colCode.MaxWidth = 80;
      colCode.MinWidth = 80;
      colCode.Width = 80;

      colQuantity = new GridColumn();
      colQuantity.AppearanceCell.Options.UseTextOptions = true;
      colQuantity.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
      colQuantity.Caption = "Qty";
      colQuantity.FieldName = "ItemQuantity";
      colQuantity.MaxWidth = 80;
      colQuantity.MinWidth = 80;
      colQuantity.Name = "colQuantity";
      colQuantity.UnboundType = UnboundColumnType.String;
      colQuantity.Visible = true;
      colQuantity.VisibleIndex = 1;
      colQuantity.Width = 80;

      colPrice = new GridColumn();
      colPrice.AppearanceCell.Options.UseTextOptions = true;
      colPrice.AppearanceCell.TextOptions.HAlignment = HorzAlignment.Center;
      colPrice.DisplayFormat.FormatString = "c2";
      colPrice.DisplayFormat.FormatType = FormatType.Numeric;
      colPrice.FieldName = "Price";
      colPrice.MaxWidth = 80;
      colPrice.MinWidth = 80;
      colPrice.Name = "colPrice";
      colPrice.Visible = true;
      colPrice.VisibleIndex = 2;
      colPrice.Width = 80;
    }

    private void InitializeGridView()
    {
      gridViewItems.Columns.AddRange(new GridColumn[] { colItemName, colCode, colQuantity, colPrice });
      gridViewItems.FocusRectStyle = DrawFocusRectStyle.RowFullFocus;
      gridViewItems.OptionsBehavior.AllowAddRows = DefaultBoolean.False;
      gridViewItems.OptionsBehavior.AllowDeleteRows = DefaultBoolean.False;
      gridViewItems.OptionsBehavior.AllowIncrementalSearch = true;
      gridViewItems.OptionsBehavior.Editable = false;
      gridViewItems.OptionsBehavior.ReadOnly = true;
      gridViewItems.OptionsCustomization.AllowColumnMoving = false;
      gridViewItems.OptionsCustomization.AllowFilter = false;
      gridViewItems.OptionsCustomization.AllowGroup = false;
      gridViewItems.OptionsCustomization.AllowQuickHideColumns = false;
      gridViewItems.OptionsSelection.EnableAppearanceFocusedCell = false;
      gridViewItems.OptionsSelection.MultiSelect = true;
      gridViewItems.OptionsView.ShowGroupPanel = false;
      gridViewItems.CustomUnboundColumnData += gridViewItems_CustomUnboundColumnData;
    }

    private void gridViewItems_CustomUnboundColumnData(object sender, CustomColumnDataEventArgs e)
    {
      var item = e.Row as ReceiptItem;
      if (e.IsGetData)
      {
        if (e.Column.FieldName == "ItemName")
        {
          var shopping = ShoppingListAccessor.CachedItems.SingleOrDefault(i => i.ID == item.ShoppingListItemID);
          if (shopping != null)
          {
            e.Value = shopping.Name;
          }
          else
          {
            e.Value = item.Name;
          }
        }
        else if (e.Column.FieldName == "ItemQuantity")
        {
          if (item.Quantity != null)
          {
            var qty = item.Quantity;
            e.Value = string.Format("{0} {1}", qty.Amount, qty.Unit);
          }
        }
      }
    }
  }
}
