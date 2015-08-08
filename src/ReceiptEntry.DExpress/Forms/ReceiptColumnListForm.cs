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

namespace ReceiptEntry.DExpress
{
  public partial class ReceiptColumnListForm : BaseForm, IGridListEditor
  {
    private readonly ReceiptColumnListViewModel mColumns;

    public ReceiptColumnListForm(ReceiptColumnListViewModel columns)
    {
      mColumns = columns;
      InitializeComponent(); 
      SetupColumns();
      CommandBinder.Bind(okCancelButtons1, columns);
    }

    private void SetupColumns()
    {
      lstColumns.AutoGenerateColumns = false;
      lstColumns.Mode = GridListControlViewMode.List;
      lstColumns.AddColumn((ReceiptColumnViewModel v) => v.Name);

      var colType = lstColumns.AddColumn((ReceiptColumnViewModel v) => v.Type);
      colType.Width = 80;
      colType.MinWidth = 80;
      colType.MaxWidth = 80;
      colType.OptionsColumn.AllowSize = false;

      lstColumns.Editor = this;
      lstColumns.DataSource = mColumns.Items;
    }

    public bool AllowEdit
    {
      get { return true; }
    }

    public bool AddValue(IWin32Window owner, out object newValue)
    {
      newValue = null;

      var column = mColumns.CreateItem();
      using (var dlg = new EditReceiptColumnForm(column))
      {
        dlg.Text = "Add Column";
        if (dlg.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
        {
          newValue = column;
          return true;
        }
      }

      return false;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      editedValue = null;

      var column = original as ReceiptColumnViewModel;
      if (column == null)
      {
        return false;
      }

      using (var dlg = new EditReceiptColumnForm(column))
      {
        dlg.Text = "Edit Column";
        if (dlg.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
        {
          editedValue = column;
          return true;
        }
      }

      return false;
    }

    public int GetVisibleCount()
    {
      return mColumns.Items.Count;
    }
  }
}