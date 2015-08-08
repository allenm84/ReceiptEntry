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
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Grid;

namespace ReceiptEntry.DExpress
{
  public partial class EditMerchantForm : BaseForm
  {
    private readonly MerchantViewModel mMerchant;
    private GridViewDragAndDrop mFromAvailable;
    private GridViewDragAndDrop mFromCurrent;

    public EditMerchantForm(MerchantViewModel merchant)
    {
      mMerchant = merchant;
      InitializeComponent();
      SetupDragDrop();

      gridViewAvailableColumns.SetPropertiesToList();

      gridViewCurrentColumns.SetPropertiesToList();
      gridViewCurrentColumns.OptionsBehavior.Editable = true;
      gridViewCurrentColumns.OptionsBehavior.ReadOnly = false;
      colCurrentColumnID.OptionsColumn.AllowEdit = false;
      colCurrentColumnID.OptionsColumn.ReadOnly = true;

      gridViewAvailableColumns.SelectionChanged += gridViewColumns_SelectionChanged;
      gridViewCurrentColumns.SelectionChanged += gridViewColumns_SelectionChanged;

      bsAvailable.DataSource = merchant.AvailableColumns;
      bsCurrent.DataSource = merchant.CurrentColumns;
      bsColumns.DataSource = merchant.Columns;

      txtName.BindText(merchant, (MerchantViewModel v) => v.Name);
      merchant.ColumnsChanged += merchant_ColumnsChanged;

      CommandBinder.Bind(btnAll, merchant.AddAllColumnsCommand);
      CommandBinder.Bind(btnNone, merchant.RemoveAllColumnsCommand);
      CommandBinder.Bind(btnUpdateOrder, merchant.UpdateCommand);
      CommandBinder.Bind(okCancelButtons1, merchant);

      Yielder.Call(UpdateCounts);
    }

    private void SetupDragDrop()
    {
      mFromAvailable = new GridViewDragAndDrop(gridViewAvailableColumns);
      mFromCurrent = new GridViewDragAndDrop(gridViewCurrentColumns);

      gridAvailableColumns.DragOver += gridColumns_DragOver;
      gridAvailableColumns.DragDrop += gridAvailableColumns_DragDrop;
      
      gridCurrentColumns.DragOver += gridColumns_DragOver;
      gridCurrentColumns.DragDrop += gridCurrentColumns_DragDrop;
    }

    private void UpdateCounts()
    {
      lciAvailable.Text = string.Format("Available({0})", bsAvailable.Count);
      lciCurrent.Text = string.Format("Current({0})", bsCurrent.Count);
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      if (mFromAvailable != null)
      {
        mFromAvailable.Dispose();
        mFromAvailable = null;
      }

      if (mFromCurrent != null)
      {
        mFromCurrent.Dispose();
        mFromCurrent = null;
      }
      base.OnFormClosed(e);
    }

    private void merchant_ColumnsChanged(object sender, EventArgs e)
    {
      UpdateCounts();
    }

    private void gridViewColumns_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
    {
      var view = sender as GridView;
      for (int r = 0; r < view.DataRowCount; ++r)
      {
        var row = view.GetRow(r) as ReceiptColumnReferenceViewModel;
        row.IsSelected = view.IsRowSelected(r);
      }
    }

    private void gridColumns_DragOver(object sender, DragEventArgs e)
    {
      var info = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
      e.Effect = (info == null)
        ? DragDropEffects.None
        : DragDropEffects.Move;
    }

    private void gridAvailableColumns_DragDrop(object sender, DragEventArgs e)
    {
      var info = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
      if (info != null)
      {
        mMerchant.MoveSelectedToAvailableCommand.Execute(this);
      }
    }

    private void gridCurrentColumns_DragDrop(object sender, DragEventArgs e)
    {
      var info = e.Data.GetData(typeof(GridHitInfo)) as GridHitInfo;
      if (info != null)
      {
        mMerchant.MoveSelectedToCurrentCommand.Execute(this);
      }
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      var column = mMerchant.CreateColumn();
      using (var dlg = new EditReceiptColumnForm(column))
      {
        dlg.Text = "Add Column";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          bsColumns.Add(column);
        }
      }
    }
  }
}