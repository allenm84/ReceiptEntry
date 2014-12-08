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

    private Receipt[] receipts;

    public MerchantListDialog(IEnumerable<Merchant> merchants, Receipt[] receipts)
    {
      this.receipts = receipts;
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

    private void SanitizeReceipts()
    {
      Merchant unassigned = null;

      foreach (var r in receipts)
      {
        if (list.Count == 0 || !list.Any(m => m.ID == r.MerchantID))
        {
          if (unassigned == null)
          {
            unassigned = new Merchant();
            unassigned.Name = "[Empty]";
            unassigned.ID = ID.Gen();
            list.Add(unassigned);
          }
          r.MerchantID = unassigned.ID;
        }
      }
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
      if (!MessageHelper.Confirm(this, "Are you sure you want to remove the selected merchants?"))
        return;

      var message = "{0} is being used by {1} receipts. In order to remove {0}, you must select a replacement merchant. If you do not select a replacement, then {0} will not be removed";
      var items = lstMerchants.SelectedItems.OfType<Merchant>().ToArray();
      lstMerchants.BeginUpdate();
      foreach (var merchant in items)
      {
        var matches = receipts.Where(r => r.MerchantID == merchant.ID).ToArray();
        if (matches.Length > 0)
        {
          var text = string.Format(message, merchant.Name, matches.Length);
          using (var dlg = new SelectMerchantDialog(Merchants.Exclude(merchant), text))
          {
            dlg.Text = "Select Replacement Merchant";
            if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
              string id = dlg.SelectedMerchantID;
              foreach (var match in matches)
              {
                match.MerchantID = id;
              }
            }
            else
            {
              MessageHelper.Inform(this, string.Format("{0} will not be removed", merchant.Name));
              continue;
            }
          }
        }

        list.Remove(merchant);
      }

      SanitizeReceipts();
      lstMerchants.EndUpdate();
    }

    private void editorButtons_ClearClick(object sender, EventArgs e)
    {
      if (MessageHelper.Confirm(this, "Are you sure you want to clear all merchants?"))
      {
        list.Clear();
        SanitizeReceipts();
      }
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

    private void lstMerchants_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Delete)
      {
        editorButtons.Remove();
      }
    }
  }
}
