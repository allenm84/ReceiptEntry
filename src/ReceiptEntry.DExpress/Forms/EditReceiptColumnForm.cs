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
    private readonly int mTypeCount;

    public EditReceiptColumnForm(ReceiptColumnViewModel column)
    {
      mColumn = column;
      InitializeComponent();

      txtName.BindText(column, ((ReceiptColumnViewModel v) => v.Name));

      cboType.FillWithEnum<ReceiptColumnType>();
      cboType.BindValue(column, (ReceiptColumnViewModel v) => v.Type);
      cboType.EditValueChanged += cboType_EditValueChanged;
      cboType.PreviewKeyDown += cboType_PreviewKeyDown;
      mTypeCount = ((System.Collections.IList)cboType.Properties.DataSource).Count;

      Yielder.Call(UpdateExampleText);
    }

    private async void ExpectedIndex(int index, int wrapped)
    {
      await Task.Yield();
      if (index != cboType.ItemIndex)
      {
        cboType.EditValue = cboType.Properties.GetDataSourceValue("Value", wrapped);
      }
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
        case ReceiptColumnType.HelpfulName:
          {
            lblExample.Text = "Example: <b>Helpful Name</b> for an item";
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

    private void cboType_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
    {
      if (e.KeyCode == Keys.Down)
      {
        ExpectedIndex(cboType.ItemIndex + 1, 0);
      }
      else if (e.KeyCode == Keys.Up)
      {
        ExpectedIndex(cboType.ItemIndex - 1, mTypeCount - 1);
      }
    }

    protected override bool ProcessDialogKey(Keys keyData)
    {
      if (keyData == Keys.Enter)
      {
        AcceptButton.PerformClick();
      }
      return base.ProcessDialogKey(keyData);
    }
  }
}