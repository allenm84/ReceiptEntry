using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public static class Common
  {
    public static Merchant GetMerchant(string id)
    {
      return SaveFile.Instance.Merchants.FirstOrDefault(m => m.ID.Matches(id)) ?? Merchant.Empty;
    }

    public static NamedItem GetNamedItem(string id)
    {
      return SaveFile.Instance.NamedItems.FirstOrDefault(i => i.ID.Matches(id)) ?? NamedItem.Empty;
    }

    public static Tuplex<bool, ReceiptItem> AddReceiptItem(IWin32Window owner, string initialName)
    {
      bool accepted = false;
      ReceiptItem item = new ReceiptItem
      {
        ItemID = "",
      };

      using (var dlg = new EditReceiptItemDialog())
      {
        dlg.Text = "Add Item";
        dlg.BindTo(item);
        accepted = dlg.ShowDialog(owner) == DialogResult.OK;
      }

      return new Tuplex<bool, ReceiptItem>(accepted, item);
    }

    public static Tuplex<bool, ReceiptItem> EditReceiptItem(IWin32Window owner, ReceiptItem item)
    {
      bool accepted = false;
      ReceiptItem copy = item.Duplicate();

      using (var dlg = new EditReceiptItemDialog())
      {
        dlg.Text = string.Format("Edit {0}", copy.Name);
        dlg.BindTo(copy);
        accepted = dlg.ShowDialog(owner) == DialogResult.OK;
      }

      return new Tuplex<bool, ReceiptItem>(accepted, copy);
    }
  }
}
