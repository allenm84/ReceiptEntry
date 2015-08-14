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
  public partial class HelpfulNameListForm : BaseForm, IGridListEditor
  {
    private readonly HelpfulNameListViewModel mNames;

    public HelpfulNameListForm(HelpfulNameListViewModel names)
    {
      mNames = names;
      InitializeComponent();
      SetupNames();
      CommandBinder.Bind(okCancelButtons1, names);
    }

    private void SetupNames()
    {
      lstNames.AutoGenerateColumns = false;
      lstNames.Mode = GridListControlViewMode.List;
      lstNames.AddColumn((HelpfulNameViewModel v) => v.Name);
      lstNames.Editor = this;
      lstNames.DataSource = mNames.Items;
    }

    public bool AllowEdit
    {
      get { return true; }
    }

    public bool AddValue(IWin32Window owner, out object newValue)
    {
      newValue = null;

      var name = mNames.CreateItem();
      using (var dlg = new TextInputForm())
      {
        dlg.Text = "Add Helpful Name";
        dlg.Prompt = "Name:";
        dlg.Input = name.Name;

        if (dlg.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
        {
          name.Name = dlg.Input;
          newValue = name;
          return true;
        }
      }

      return false;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      editedValue = null;

      var name = original as HelpfulNameViewModel;
      if (name == null)
      {
        return false;
      }

      using (var dlg = new TextInputForm())
      {
        dlg.Text = "Edit Helpful Name";
        dlg.Prompt = "Name:";
        dlg.Input = name.Name;

        if (dlg.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
        {
          name.Name = dlg.Input;
          editedValue = name;
          return true;
        }
      }

      return false;
    }

    public int GetVisibleCount()
    {
      return mNames.Items.Count;
    }
  }
}