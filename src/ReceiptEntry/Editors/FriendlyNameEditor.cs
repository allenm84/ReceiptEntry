using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public partial class FriendlyNameEditor : XtraUserControl
  {
    public bool AliasEnabled
    {
      get { return chkEnableAlias.Checked; }
      set { chkEnableAlias.Checked = value; }
    }

    public object AliasValue
    {
      get { return cboAlias.EditValue; }
      set { cboAlias.EditValue = value; }
    }

    public FriendlyNameEditor()
    {
      InitializeComponent();
      itemAliasSource.DataSource = Database.ItemAlias;
      cboAlias.DataBindings.Add("Enabled", chkEnableAlias, "Checked");
    }

    protected override void SetBoundsCore(int x, int y, int width, int height, BoundsSpecified specified)
    {
      base.SetBoundsCore(x, y, width, 47, specified);
    }

    private void cboAlias_AddNewValue(object sender, DevExpress.XtraEditors.Controls.AddNewValueEventArgs e)
    {
      using (var dlg = new EditTextDialog())
      {
        dlg.Text = "Add Friendly Name";
        dlg.Caption = "Name:";
        dlg.Value = searchLookUpEdit1View.FindFilterText;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          var alias = new ItemAlias { ID = Database.NewID(), Name = dlg.Value };
          itemAliasSource.Add(alias);
          e.NewValue = alias.ID;
        }
        else
        {
          e.Cancel = true;
        }
      }
    }

    public bool IsValid()
    {
      return 
        !chkEnableAlias.Checked || 
        (chkEnableAlias.Checked && !string.IsNullOrWhiteSpace(cboAlias.EditValue as string));
    }
  }
}
