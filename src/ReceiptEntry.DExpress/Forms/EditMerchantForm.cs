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
  public partial class EditMerchantForm : BaseForm
  {
    private readonly MerchantViewModel mMerchant;

    public EditMerchantForm(MerchantViewModel merchant)
    {
      mMerchant = merchant;
      InitializeComponent();

      gridViewAvailableColumns.SetPropertiesToList();
      gridViewCurrentColumns.SetPropertiesToList();

      bsAvailable.DataSource = merchant.AvailableColumns;
      bsCurrent.DataSource = merchant.CurrentColumns;
      bsColumns.DataSource = merchant.Columns;

      merchant.ColumnsChanged += merchant_ColumnsChanged;

      CommandBinder.Bind(btnAll, merchant.AddAllColumnsCommand);
      CommandBinder.Bind(btnNone, merchant.RemoveAllColumnsCommand);
      Yielder.Call(UpdateCounts);
    }

    private void UpdateCounts()
    {
      lciAvailable.Text = string.Format("Available({0})", bsAvailable.Count);
      lciCurrent.Text = string.Format("Current({0})", bsCurrent.Count);
    }

    private void merchant_ColumnsChanged(object sender, EventArgs e)
    {
      UpdateCounts();
    }

    private void btnAddNew_Click(object sender, EventArgs e)
    {
      var column = mMerchant.CreateColumn();
      using (var dlg = new EditReceiptColumnForm(column))
      {
        dlg.Text = "Add Column";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          mMerchant.AddColumn(column);
        }
      }
    }
  }
}