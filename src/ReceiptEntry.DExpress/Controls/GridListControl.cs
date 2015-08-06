using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System.Linq.Expressions;
using System.Reflection;

namespace ReceiptEntry.DExpress
{
  public partial class GridListControl : XtraUserControl
  {
    private GridListControlViewMode mMode = GridListControlViewMode.Default;
    private IGridListEditor mEditor = null;

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AutoGenerateColumns
    {
      get { return gridViewItems.OptionsBehavior.AutoPopulateColumns; }
      set { gridViewItems.OptionsBehavior.AutoPopulateColumns = value; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool ShowEditorButtons
    {
      get { return ctrlButtons.Visible; }
      set { ctrlButtons.Visible = value; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public bool AllowRemove
    {
      get { return ctrlButtons.AllowRemove; }
      set 
      { 
        ctrlButtons.AllowRemove = value;
        UpdateButtonsAsync();
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public object DataSource
    {
      get { return itemSource.DataSource; }
      set { itemSource.DataSource = value; }
    }

    public GridColumnCollection Columns
    {
      get { return gridViewItems.Columns; }
    }

    public GridView View
    {
      get { return gridViewItems; }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public GridListControlViewMode Mode
    {
      get { return mMode; }
      set
      {
        if (value != mMode)
        {
          mMode = value;
          UpdateViewOptions();
        }
      }
    }

    [Browsable(false)]
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
    public IGridListEditor Editor
    {
      get { return mEditor; }
      set
      {
        mEditor = value;
        if (mEditor != null)
        {
          ctrlButtons.EditVisible = mEditor.AllowEdit;
        }
      }
    }

    public event GridListControlRemoveEventHandler Remove;
    public event GridListControlRemoveEventHandler Clear;

    public GridListControl()
    {
      InitializeComponent();
      UpdateViewOptions();
      UpdateButtonsAsync();
    }

    private void UpdateViewOptions()
    {
      bool autoGenerateColumns = AutoGenerateColumns;
      switch (mMode)
      {
        case GridListControlViewMode.Default:
          {
            gridViewItems.OptionsBehavior.Reset();
            gridViewItems.OptionsCustomization.Reset();
            gridViewItems.OptionsDetail.Reset();
            gridViewItems.OptionsEditForm.Reset();
            gridViewItems.OptionsFilter.Reset();
            gridViewItems.OptionsFind.Reset();
            gridViewItems.OptionsHint.Reset();
            gridViewItems.OptionsLayout.Reset();
            gridViewItems.OptionsMenu.Reset();
            gridViewItems.OptionsNavigation.Reset();
            gridViewItems.OptionsPrint.Reset();
            gridViewItems.OptionsSelection.Reset();
            gridViewItems.OptionsView.Reset();
            break;
          }
        case GridListControlViewMode.List:
          {
            gridViewItems.FocusRectStyle = DrawFocusRectStyle.RowFocus;

            gridViewItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            gridViewItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            gridViewItems.OptionsBehavior.AllowIncrementalSearch = true;
            gridViewItems.OptionsBehavior.Editable = false;
            gridViewItems.OptionsBehavior.ReadOnly = true;

            gridViewItems.OptionsCustomization.AllowColumnMoving = false;
            gridViewItems.OptionsCustomization.AllowColumnResizing = false;
            gridViewItems.OptionsCustomization.AllowRowSizing = false;

            gridViewItems.OptionsDetail.EnableMasterViewMode = false;

            gridViewItems.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewItems.OptionsSelection.EnableAppearanceFocusedRow = true;
            gridViewItems.OptionsSelection.EnableAppearanceHideSelection = true;
            gridViewItems.OptionsSelection.MultiSelect = true;
            gridViewItems.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
            gridViewItems.OptionsSelection.UseIndicatorForSelection = false;

            gridViewItems.OptionsView.ShowColumnHeaders = false;
            gridViewItems.OptionsView.ShowGroupPanel = false;
            gridViewItems.OptionsView.ShowIndicator = false;
            break;
          }
      }
    }

    public async void UpdateButtonsAsync()
    {
      await Task.Yield();
      UpdateButtons();
    }

    public void UpdateButtons()
    {
      int count = itemSource.Count;
      if (mEditor != null)
      {
        count = mEditor.GetVisibleCount();
      }

      ctrlButtons.UpdateButtons(gridViewItems.SelectedRowsCount,
        gridViewItems.IsDataRow(gridViewItems.FocusedRowHandle),
        count);
    }

    private void EditByRow(object row)
    {
      object editedValue;

      if (mEditor != null && mEditor.AllowEdit && mEditor.EditValue(this, row, out editedValue))
      {
        int index = itemSource.IndexOf(row);
        itemSource[index] = editedValue;
      }
    }

    private void ctrlButtons_AddClick(object sender, EventArgs e)
    {
      object newValue;

      if (mEditor != null && mEditor.AddValue(this, out newValue))
      {
        itemSource.Add(newValue);
      }
    }

    private void ctrlButtons_EditClick(object sender, EventArgs e)
    {
      EditByRow(gridViewItems.GetFocusedRow());
    }

    private void ctrlButtons_RemoveClick(object sender, EventArgs e)
    {
      var remove = Remove;
      if (remove != null)
      {
        var args = new GridListControlRemoveEventArgs(gridViewItems, false);
        remove(this, args);
        if (args.Handled)
        {
          return;
        }
      }

      if (MessageHelper.Confirm(this, "Are you sure you want to remove the selected items?"))
      {
        gridViewItems.DeleteSelectedRows();
      }
    }

    private void ctrlButtons_ClearClick(object sender, EventArgs e)
    {
      var clear = Clear;
      if (clear != null)
      {
        var args = new GridListControlRemoveEventArgs(gridViewItems, false);
        clear(this, args);
        if (args.Handled)
        {
          return;
        }
      }

      if (MessageHelper.Confirm(this, "Are you sure you want to remove all of the items?"))
      {
        itemSource.Clear();
      }
    }

    private void gridItems_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      if (e.Button.HasFlag(MouseButtons.Left))
      {
        var info = gridViewItems.CalcHitInfo(e.Location);
        if ((info.InRow || info.InRowCell) && !info.InGroupRow)
        {
          EditByRow(gridViewItems.GetRow(info.RowHandle));
        }
      }
    }

    private void gridViewItems_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        ctrlButtons.Remove();
      }
    }

    private void gridViewItems_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      UpdateButtons();
    }

    public GridColumn AddColumn<TSource, TType>(Expression<Func<TSource, TType>> propertyLambda)
    {
      if (propertyLambda == null)
        throw new ArgumentNullException("propertyLambda");

      var body = propertyLambda.Body;

      // make sure that we're actually accessing a property
      var member = body as MemberExpression;
      if (member == null)
        throw new ArgumentException(string.Format("Expression '{0}' refers to a method, not a property.",
          propertyLambda.ToString()));

      // and that its actually a property
      var propInfo = member.Member as PropertyInfo;
      if (propInfo == null)
        throw new ArgumentException(string.Format("Expression '{0}' refers to a field, not a property.",
          propertyLambda.ToString()));

      // add the column
      var propertyName = propInfo.Name;
      var column = gridViewItems.Columns.AddField(propertyName);
      column.Visible = true;
      return column;
    }

    public IEnumerable<T> GetValues<T>() where T: class
    {
      for(int i = 0; i < gridViewItems.DataRowCount; ++i)
      {
        var r = gridViewItems.GetRowHandle(i);
        yield return gridViewItems.GetRow(r) as T;
      }
    }
  }

  public enum GridListControlViewMode
  {
    Default,
    List,
  }

  public interface IGridListEditor
  {
    bool AllowEdit { get;}
    bool AddValue(IWin32Window owner, out object newValue);
    bool EditValue(IWin32Window owner, object original, out object editedValue);
    int GetVisibleCount();
  }

  public delegate void GridListControlRemoveEventHandler(object sender, GridListControlRemoveEventArgs e);

  public class GridListControlRemoveEventArgs : EventArgs
  {
    public GridView GridView { get; private set; }
    public bool Handled { get; set; }

    public GridListControlRemoveEventArgs(GridView gridView, bool handled)
    {
      GridView = gridView;
      Handled = handled;
    }
  }
}
