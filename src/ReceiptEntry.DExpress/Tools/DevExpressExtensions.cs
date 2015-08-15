using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data;
using DevExpress.Utils.Win;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;
using ReceiptEntry.ViewModel;

namespace ReceiptEntry.DExpress
{
  public static class DevExpressExtensions
  {
    public static Binding BindChecked<TSource>(this CheckEdit checkEdit, TSource value, Expression<Func<TSource, bool>> propertyLambda)
    {
      return checkEdit.DataBindings.Add("Checked", value, propertyLambda.of(), false, DataSourceUpdateMode.OnPropertyChanged);
    }

    public static Binding BindDate<TSource>(this DateEdit dateEdit, TSource value, Expression<Func<TSource, DateTime>> propertyLambda)
    {
      return dateEdit.DataBindings.Add("DateTime", value, propertyLambda.of());
    }

    public static Binding BindValue<TSource, TValue>(this SearchLookUpEdit lookUp, TSource value, Expression<Func<TSource, TValue>> propertyLambda)
    {
      return lookUp.DataBindings.Add("EditValue", value, propertyLambda.of(), false, DataSourceUpdateMode.OnPropertyChanged);
    }

    public static Binding BindValue<TSource, TValue>(this LookUpEdit lookUp, TSource value, Expression<Func<TSource, TValue>> propertyLambda)
    {
      return lookUp.DataBindings.Add("EditValue", value, propertyLambda.of(), false, DataSourceUpdateMode.OnPropertyChanged);
    }

    public static Binding BindValue<TSource>(this SpinEdit spin, TSource value, Expression<Func<TSource, decimal>> propertyLambda)
    {
      return spin.DataBindings.Add("Value", value, propertyLambda.of());
    }

    public static Binding BindText<TSource>(this TextEdit text, TSource value, Expression<Func<TSource, string>> propertyLambda)
    {
      return text.DataBindings.Add("Text", value, propertyLambda.of());
    }

    public static GridColumn AddVisible<TSource, TType>(this GridColumnCollection columns, Expression<Func<TSource, TType>> propertyLambda)
    {
      return columns.AddVisible(propertyLambda.of());
    }

    public static void ImmediateUpdate(this GridView view)
    {
      view.BeginUpdate();
      view.EndUpdate();
    }

    public static void RemoveSelectedValue(this LookUpEdit lookUp, IList source)
    {
      var value = lookUp.EditValue;
      var index = source.IndexOf(value);
      source.Remove(value);

      // normalize the index. If the value removed was at the end of the list, then
      // this will push up the index to be the new last value. Otherwise, the index
      // will remain the same.
      index = Math.Min(source.Count - 1, index);

      // if the index is valid, then use it as the currently selected value
      if (index > -1)
      {
        lookUp.EditValue = source[index];
      }
      else
      {
        lookUp.EditValue = null;
      }
    }

    public static CheckState ToCheckState(this bool value)
    {
      return value
        ? CheckState.Checked
        : CheckState.Unchecked;
    }

    public static void SetIsVisible(this BarItem item, bool visible)
    {
      item.Visibility = visible
        ? BarItemVisibility.Always
        : BarItemVisibility.Never;
    }

    public static string GetFilterText(this SearchLookUpEdit search)
    {
      return search.Properties.GetFilterText();
    }

    public static string GetFilterText(this RepositoryItemSearchLookUpEdit search)
    {
      return search.View.FindFilterText;
    }

    public static void ClearRows(this GridView gridView)
    {
      gridView.BeginUpdate();
      gridView.SelectAll();
      gridView.DeleteSelectedRows();
      gridView.EndUpdate();
    }

    public static void SetEnabled(this Bar bar, bool enabled)
    {
      ((IDockableObject)bar).BarControl.Enabled = enabled;
    }

    public static void SetMinMax(this SpinEdit edit)
    {
      edit.Properties.MinValue = decimal.MinValue + 1;
      edit.Properties.MaxValue = decimal.MaxValue - 1;
    }

    public static void FillWithEnum<T>(this LookUpEdit lookUp, Func<T, bool> filter = null, Func<T, string> getText = null)
    {
      lookUp.Properties.FillWithEnum(filter, getText);
    }

    public static void FillWithEnum<T>(this RepositoryItemLookUpEdit lookUp, Func<T, bool> filter = null, Func<T, string> getText = null)
    {
      if (getText == null)
      {
        getText = (x) => x.ToString();
      }

      var values = Enum.GetValues(typeof(T)).Cast<T>();
      if (filter != null)
      {
        values = values.Where(filter);
      }

      lookUp.DataSource = values
        .Select(v => new { Value = v, Display = getText(v) })
        .ToArray();
      lookUp.DisplayMember = "Display";
      lookUp.ValueMember = "Value";
      lookUp.ShowHeader = false;

      lookUp.Columns.Clear();
      lookUp.Columns.Add(new LookUpColumnInfo("Display")
      {
        Visible = true,
        SortOrder = ColumnSortOrder.Ascending
      });
    }
  }
}
