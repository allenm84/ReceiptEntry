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
    private FriendlyNameEditor aliasEditor;
    private CodeEditor codeEditor;
    private QuantityEditor quantityEditor;

    public EditReceiptItemDialog(string[] order)
    {
      InitializeComponent();
      InitializeLayout(order);
    }

    private void InitializeLayout(string[] order)
    {
      IEnumerable<PropertyInfo> props;
      if (order == null)
      {
        props = TypeProperties.ReceiptItemProperties.Select(p => p);
      }
      else
      {
        props = TypeProperties.ReceiptItemProperties
          .Select(p => new { Property = p, ID = p.GetCustomAttribute<PropertyIDAttribute>().ID })
          .Select(a => new { Property = a.Property, ID = a.ID, Index = Array.IndexOf(order, a.ID) })
          .Where(a => a.Index > -1)
          .OrderBy(a => a.Index)
          .Select(a => a.Property);
      }

      int layoutItemSize = 0;
      foreach (var prop in props)
      {
        var attr = prop.GetCustomAttribute<PropertyIDAttribute>();
        var control = CreateControl(prop, attr);

        var li = layoutControlGroup2.AddItem();
        li.Name = "Layout" + prop.Name;
        li.Text = attr.Display + ":";
        li.Control = control;

        var height = control.Height + layoutControlGroup2.Padding.Bottom;
        li.SizeConstraintsType = SizeConstraintsType.Custom;
        li.MinSize = new System.Drawing.Size(0, height);
        li.MaxSize = new System.Drawing.Size(0, height);
        layoutItemSize += height;
      }

      Height = 132 + layoutItemSize;
    }

    private Control CreateControl(PropertyInfo prop, PropertyIDAttribute attr)
    {
      switch (attr.ID)
      {
        case "Name":
          {
            txtName = new TextEdit();
            txtName.Name = "txtName";
            return txtName;
          }
        case "Price":
          {
            numPrice = new SpinEdit();
            numPrice.Name = "numPrice";
            return numPrice;
          }
        case "AliasID":
          {
            aliasEditor = new FriendlyNameEditor();
            aliasEditor.Name = "aliasEditor";
            return aliasEditor;
          }
        case "Code":
          {
            codeEditor = new CodeEditor();
            codeEditor.Name = "codeEditor";
            return codeEditor;
          }
        case "Quantity":
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
      if (aliasEditor != null && !string.IsNullOrWhiteSpace(item.AliasID))
      {
        aliasEditor.AliasEnabled = true;
        aliasEditor.AliasValue = item.AliasID;
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
        item.AliasID = (string)aliasEditor.AliasValue;
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

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);
      //layoutControl1.BestFit();
    }

    private void okCancelButtons1_OKClick(object sender, EventArgs e)
    {
      if (string.IsNullOrWhiteSpace(txtName.Text))
      {
        cancelClose = true;
        XtraMessageBox.Show(this, "Please enter a name for the item.", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (aliasEditor != null && !aliasEditor.IsValid())
      {
        cancelClose = true;
        XtraMessageBox.Show(this, "Please select a friendly name. You can also un-check the checkbox.", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (codeEditor != null && !codeEditor.IsValid())
      {
        cancelClose = true;
        XtraMessageBox.Show(this, "Please enter the code. You can also un-check the checkbox.", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      if (quantityEditor != null)
      {
        if (!quantityEditor.IsValid())
        {
          cancelClose = true;
          XtraMessageBox.Show(this, "Please select a unit for the quantity. You can also un-check the checkbox.", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }

        if (quantityEditor.QuantityEnabled && quantityEditor.Amount == 0m)
        {
          var result = XtraMessageBox.Show(this, "Are you sure you meant 0 for the quantity?", "Quantity",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question);
          if (result == System.Windows.Forms.DialogResult.Yes) return;
          cancelClose = true;
          return;
        }
      }
    }
  }
}
