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
  public partial class ValidateReceiptTotalForm : BaseForm
  {
    private readonly ValidateReceiptTotalViewModel mValidate;

    public ValidateReceiptTotalForm(ValidateReceiptTotalViewModel validate)
    {
      mValidate = validate;
      InitializeComponent();

      layoutControl1.MaximumSize = new System.Drawing.Size(0, 1000);
      layoutControl1.MinimumSize = new System.Drawing.Size(0, 10);

      bsPriceColumns.DataSource = validate.PriceColumns;
      cboPriceColumns.BindValue(validate, (ValidateReceiptTotalViewModel v) => v.SelectedPriceColumn);
      bsQuantityColumns.DataSource = validate.QuantityColumns;
      cboQuantityColumns.BindValue(validate, (ValidateReceiptTotalViewModel v) => v.SelectedQuantityColumn);
      numActual.BindValue(validate, (ValidateReceiptTotalViewModel v) => v.ActualTotal);
    }
  }
}