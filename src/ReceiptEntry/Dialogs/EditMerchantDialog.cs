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
    private Merchant merchant;

    public EditMerchantDialog(Merchant merchant)
    {
      this.merchant = merchant;

      InitializeComponent();
      txtName.Text = merchant.Name;
      chkIsGroceryStore.Checked = merchant.IsGrocery;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      merchant.Name = txtName.Text;
      merchant.IsGrocery = chkIsGroceryStore.Checked;
    }
  }
}
