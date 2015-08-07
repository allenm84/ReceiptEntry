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
using ReceiptEntry.Model;

namespace ReceiptEntry.DExpress
{
  public partial class EditReceiptColumnForm : BaseForm
  {
    private readonly ReceiptColumnViewModel mColumn;
    public EditReceiptColumnForm(ReceiptColumnViewModel column)
    {
      mColumn = column;
      InitializeComponent();

      txtName.BindText(column, ((ReceiptColumnViewModel v) => v.Name));

      cboType.FillWithEnum<ReceiptColumnType>();
      cboType.BindValue(column, (ReceiptColumnViewModel v) => v.Type);
      cboType.EditValueChanged += cboType_EditValueChanged;

      Yielder.Call(UpdateExampleText);
    }

    private void UpdateExampleText()
    {
      var type = (ReceiptColumnType)cboType.EditValue;
      switch (type)
      {
        case ReceiptColumnType.Dollars: 
          {
            lblExample.Text = "Example: <b>$12.34</b>"; 
            break;
          }
        case ReceiptColumnType.Number:
          {
            lblExample.Text = "Example: <b>123</b> or <b>123.45</b>";
            break;
          }
        case ReceiptColumnType.Text:
          {
            lblExample.Text = "Example: <b>Cat</b> or <b>123ABC</b>";
            break;
          }
      }
    }

    private void cboType_EditValueChanged(object sender, EventArgs e)
    {
      UpdateExampleText();
    }
  }
}