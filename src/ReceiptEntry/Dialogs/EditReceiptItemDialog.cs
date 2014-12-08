using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace ReceiptEntry
{
  public partial class EditReceiptItemDialog : BaseForm
  {
    private TextEdit txtName;
    private SpinEdit numPrice;
    private ShoppingListItemEditor aliasEditor;
    private CodeEditor codeEditor;
    private QuantityEditor quantityEditor;

    public EditReceiptItemDialog(ReceiptItemProperty[] order)
    {
      InitializeComponent();
      InitializeLayout(order);
    }

    private void InitializeLayout(ReceiptItemProperty[] order)
    {
      var props = Enum.GetValues(typeof(ReceiptItemProperty)).OfType<ReceiptItemProperty>();
      if(order != null && order.Length > 0)
      {
        props = props
          .Select(p => new { Property = p, Index = Array.IndexOf(order, p) })
          .Where(a => a.Index > -1)
          .OrderBy(a => a.Index)
          .Select(a => a.Property);
      }

      int layoutItemSize = 0;
      foreach (var prop in props)
      {
        var control = CreateControl(prop);

        var li = layoutControlGroup2.AddItem();
        li.Name = "Layout" + prop;
        li.Text = prop.GetDisplay() + ":";
        li.Control = control;

        var height = control.Height + layoutControlGroup2.Padding.Bottom;
        li.SizeConstraintsType = SizeConstraintsType.Custom;
        li.MinSize = new System.Drawing.Size(0, height);
        li.MaxSize = new System.Drawing.Size(0, height);
        layoutItemSize += height;
      }

      Height = 132 + layoutItemSize;
    }

    private Control CreateControl(ReceiptItemProperty prop)
    {
      switch (prop)
      {
        case ReceiptItemProperty.Name:
          {
            txtName = new TextEdit();
            txtName.Name = "txtName";
            return txtName;
          }
        case ReceiptItemProperty.Price:
          {
            numPrice = new SpinEdit();
            numPrice.Name = "numPrice";
            numPrice.SetMinMax();
            return numPrice;
          }
        case ReceiptItemProperty.ShoppingListItemID:
          {
            aliasEditor = new ShoppingListItemEditor();
            aliasEditor.Name = "aliasEditor";
            return aliasEditor;
          }
        case ReceiptItemProperty.Code:
          {
            codeEditor = new CodeEditor();
            codeEditor.Name = "codeEditor";
            return codeEditor;
          }
        case ReceiptItemProperty.Quantity:
          {
            quantityEditor = new QuantityEditor();
            quantityEditor.Name = "quantityEditor";
            return quantityEditor;
          }
      }
      throw new InvalidOperationException("Unknown property!");
    }

    public void Read(ReceiptItem item)
    {
      txtName.Text = item.Name;
      numPrice.Value = item.Price;
      if (aliasEditor != null && !string.IsNullOrWhiteSpace(item.ShoppingListItemID))
      {
        aliasEditor.AliasEnabled = true;
        aliasEditor.AliasValue = item.ShoppingListItemID;
      }
      if (codeEditor != null && !string.IsNullOrWhiteSpace(item.Code))
      {
        codeEditor.CodeEnabled = true;
        codeEditor.CodeValue = item.Code;
      }
      if (quantityEditor != null && item.Quantity != null)
      {
        quantityEditor.QuantityEnabled = true;
        quantityEditor.Amount = item.Quantity.Amount;
        quantityEditor.UnitValue = item.Quantity.Unit;
      }
    }

    public ReceiptItem Flush()
    {
      ReceiptItem item = new ReceiptItem();
      item.Name = txtName.Text;
      item.Price = numPrice.Value;
      if (aliasEditor != null && aliasEditor.AliasEnabled)
      {
        item.ShoppingListItemID = (string)aliasEditor.AliasValue;
      }
      if (codeEditor != null && codeEditor.CodeEnabled)
      {
        item.Code = codeEditor.CodeValue;
      }
      if (quantityEditor != null && quantityEditor.QuantityEnabled)
      {
        item.Quantity = new Quantity
        {
          Amount = quantityEditor.Amount,
          Unit = (Unit)quantityEditor.UnitValue,
        };
      }
      return item;
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtName.Text))
      {
        cancelClose = true;
        MessageHelper.Error(this, "Please enter a name for the item.");
        return;
      }

      if (aliasEditor != null && !aliasEditor.IsValid())
      {
        cancelClose = true;
        MessageHelper.Error(this, "Please select a friendly name. You can also un-check the checkbox.");
        return;
      }

      if (codeEditor != null && !codeEditor.IsValid())
      {
        cancelClose = true;
        MessageHelper.Error(this, "Please enter the code. You can also un-check the checkbox.", "Error");
        return;
      }

      if (quantityEditor != null)
      {
        if (!quantityEditor.IsValid())
        {
          cancelClose = true;
          MessageHelper.Error(this, "Please select a unit for the quantity. You can also un-check the checkbox.");
          return;
        }

        if (quantityEditor.QuantityEnabled && quantityEditor.Amount == 0m)
        {
          if (!MessageHelper.Confirm(this, "Are you sure you meant 0 for the quantity?"))
          {
            cancelClose = true;
          }
          return;
        }
      }
    }
  }
}
