using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public partial class MerchantListDialog : BaseForm
  {
    private BindingList<Merchant> list;
    public IEnumerable<Merchant> Merchants
    {
      get { return list; }
    }

    public MerchantListDialog(IEnumerable<Merchant> merchants)
    {
      InitializeComponent();

      list = new BindingList<Merchant>();
      foreach (var m in merchants)
      {
        list.Insert(m, CompareMerchants);
      }
      list.ListChanged += list_ListChanged;

      lstMerchants.DataSource = list;
      lstMerchants.DisplayMember = "Name";
      lstMerchants.ValueMember = "ID";

      UpdateButtons();
    }

    private int CompareMerchants(Merchant a, Merchant b)
    {
      return string.Compare(a.Name, b.Name);
    }

    private void UpdateButtons()
    {
      editorButtons.UpdateButtons(lstMerchants.SelectedItems.Count, list.Count);
    }

    private void DoEditItem(Merchant merchant)
    {
      if (merchant == null) return;
      using (var dlg = new EditMerchantDialog())
      {
        dlg.Text = "Edit Merchant";
        dlg.MerchantName = merchant.Name;
        dlg.Selection = merchant.Values;

        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          string name = dlg.MerchantName;
          if (name != merchant.Name)
          {
            list.Remove(merchant);
            merchant.Name = name;
            list.Insert(merchant, CompareMerchants);
            lstMerchants.SelectedItem = merchant;
          }
          merchant.Values = dlg.Selection.ToArray();
        }
      }
    }

    private void list_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void editorButtons_AddClick(object sender, EventArgs e)
    {
      using (var dlg = new EditMerchantDialog())
      {
        dlg.Text = "Add Merchant";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          list.Insert(new Merchant
          {
            ID = ID.Gen(),
            Name = dlg.MerchantName,
            Values = dlg.Selection.ToArray(),
          }, CompareMerchants);
        }
      }
    }

    private void editorButtons_EditClick(object sender, EventArgs e)
    {
      DoEditItem(lstMerchants.SelectedItem as Merchant);
    }

    private void editorButtons_RemoveClick(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to remove the selected merchants?", "Remove",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;

      var items = lstMerchants.SelectedItems.OfType<Merchant>().ToArray();
      lstMerchants.BeginUpdate();
      foreach (var item in items)
        list.Remove(item);
      lstMerchants.EndUpdate();
    }

    private void editorButtons_ClearClick(object sender, EventArgs e)
    {
      var result = XtraMessageBox.Show(this, "Are you sure you want to clear all merchants?", "Clear",
        MessageBoxButtons.YesNo, MessageBoxIcon.Question);
      if (result == System.Windows.Forms.DialogResult.No) return;
      list.Clear();
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
