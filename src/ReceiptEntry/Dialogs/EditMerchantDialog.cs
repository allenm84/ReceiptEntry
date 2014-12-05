using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class EditMerchantDialog : BaseForm
  {
    public EditMerchantDialog()
    {
      InitializeComponent();
      merchantTypeBindingSource.DataSource = Database.MerchantTypes;
    }

    public void SetMerchantName(string name)
    {
      txtName.Text = name;
    }

    public void Read(Merchant merchant)
    {
      SetMerchantName(merchant.Name);
      cboMerchantType.EditValue = merchant.MerchantTypeID;
    }

    public Merchant Flush()
    {
      return new Merchant
      {
        ID = Database.NewID(),
        MerchantTypeID = (string)cboMerchantType.EditValue,
        Name = txtName.Text,
      };
    }

    private void searchLookUpEdit1_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      using (var dlg = new EditTextDialog())
      {
        dlg.Text = "Add Merchant Type";
        dlg.Caption = "Name:";
        dlg.Value = searchLookUpEdit1View.FindFilterText;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var type = new MerchantType { ID = Database.NewID(), Name = dlg.Value };
          merchantTypeBindingSource.Add(type);
          e.NewValue = type.ID;
        }
        else
        {
          e.Cancel = true;
        }
      }
    }
  }
}
