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
    private MerchantViewModel mMerchant;

    public EditMerchantForm(MerchantViewModel merchant)
    {
      mMerchant = merchant;
      InitializeComponent();
    }
  }
}