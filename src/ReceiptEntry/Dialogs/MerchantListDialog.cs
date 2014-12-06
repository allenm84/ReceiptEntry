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
  public partial class MerchantListDialog : BaseForm
  {
    private BindingList<Merchant> list;

    public MerchantListDialog(IEnumerable<Merchant> merchants)
    {
      InitializeComponent();

      list = new BindingList<Merchant>();
      foreach (var m in merchants)
      {
        list.Add(m);
      }
      list.ListChanged += list_ListChanged;

      lstMerchants.DataSource = list;
      lstMerchants.DisplayMember = "Name";
      lstMerchants.ValueMember = "ID";

      UpdateButtons();
    }

    private void UpdateButtons()
    {
      editorButtons.UpdateButtons(lstMerchants.SelectedItems.Count, list.Count);
    }

    private void DoEditItem(Merchant merchant)
    {
      if (merchant == null) return;
      using (var dlg = new EditTextDialog())
      {
        dlg.Text = "Edit Merchant";
        dlg.Prompt = "Name:";
        dlg.Value = merchant.Name;
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          merchant.Name = dlg.Value;
          list.ResetItem(merchant);
        }
      }
    }

    private void list_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void editorButtons_AddClick(object sender, EventArgs e)
    {
      using (var dlg = new EditTextDialog())
      {
        dlg.Text = "Add Merchant";
        dlg.Prompt = "Name:";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          list.Add(new Merchant
          {
            ID = ID.Gen(),
            Name = dlg.Value,
          });
        }
      }
    }

    private void editorButtons_EditClick(object sender, EventArgs e)
    {
      DoEditItem(lstMerchants.SelectedItem as Merchant);
    }

    private void editorButtons_RemoveClick(object sender, EventArgs e)
    {

    }

    private void editorButtons_ClearClick(object sender, EventArgs e)
    {

    }

    private void lstMerchants_MouseDoubleClick(object sender, MouseEventArgs e)
    {
      var index = lstMerchants.IndexFromPoint(e.Location);
      DoEditItem(lstMerchants.GetItem(index) as Merchant);
    }

    private void lstMerchants_SelectedIndexChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }
  }
}
