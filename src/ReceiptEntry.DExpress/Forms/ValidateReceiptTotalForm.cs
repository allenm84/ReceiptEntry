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

      bsColumns.DataSource = validate.Columns;
      cboColumns.BindValue(validate, (ValidateReceiptTotalViewModel v) => v.SelectedColumnID);
      numExpected.BindValue(validate, (ValidateReceiptTotalViewModel v) => v.ExpectedTotal);
      numActual.BindValue(validate, (ValidateReceiptTotalViewModel v) => v.ActualTotal);
      CommandBinder.Bind(btnCalculate, validate.ValidateCommand);
    }
  }
}