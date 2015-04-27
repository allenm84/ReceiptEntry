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
  public partial class EditMerchantDialog : BaseForm
  {
    static ReceiptItemProperty[] properties;
    static EditMerchantDialog()
    {
      properties = (ReceiptItemProperty[])Enum.GetValues(typeof(ReceiptItemProperty));
    }

    private List<ReceiptItemProperty> selectedIDs = new List<ReceiptItemProperty>();
    public IEnumerable<ReceiptItemProperty> Selection
    {
      get { return selectedIDs; }
      set
      {
        ClearSelection();
        if (value != null)
        {
          foreach (var prop in value)
          {
            var item = GetOrderedProperty(prop);
            item.Selected = true;
            item.Notify();
          }
        }
      }
    }

    public string MerchantName
    {
      get { return txtName.Text; }
      set { txtName.Text = value; }
    }

    private IEnumerable<OrderedPropertyItem> Items
    {
      get { return itemSource.OfType<OrderedPropertyItem>(); }
    }

    public EditMerchantDialog()
    {
      InitializeComponent();
      foreach (var prop in properties)
      {
        itemSource.Add(new OrderedPropertyItem(prop, selectedIDs, itemSource));
      }
    }

    private OrderedPropertyItem GetOrderedProperty(ReceiptItemProperty property)
    {
      return Items.Single(o => o.Property == property);
    }

    private void ClearSelection()
    {
      foreach (var item in Items)
      {
        item.Selected = false;
        item.Notify();
      }
    }

    private void chkSelected_CheckedChanged(object sender, EventArgs e)
    {
      gridViewItems.PostEditor();
    }

    private void gridItems_MouseClick(object sender, MouseEventArgs e)
    {
      if ((e.Button & System.Windows.Forms.MouseButtons.Left) != 0)
      {
        var info = gridViewItems.CalcHitInfo(e.Location);
        if ((info.InRow || info.InRowCell) && (info.Column != colSelected))
        {
          var item = gridViewItems.GetRow(info.RowHandle) as OrderedPropertyItem;
          item.Selected = !item.Selected;
          item.Notify();
        }
      }
    }
  }
}
