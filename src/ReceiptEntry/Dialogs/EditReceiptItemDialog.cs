using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class EditReceiptItemDialog : Form
  {
    private decimal PriceTotal { get { return (decimal)numTotal.Value; } }
    private decimal PricePer { get { return (decimal)numPer.Value; } }
    private decimal Quantity { get { return (decimal)numQuantity.Value; } }

    private ReceiptItem dataSource;
    private bool cancelClose = false;

    public EditReceiptItemDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
    }

    public void BindTo(ReceiptItem item)
    {
      dataSource = item;

      numQuantity.DataBindings.Add("Value", dataSource, "Quantity");
      numTotal.DataBindings.Add("Value", dataSource, "Price");
    }

    private void CalculateQuantity(bool showError = true)
    {
      if (PriceTotal == 0 || PricePer == 0)
      {
        if (showError)
        {
          MessageBox.Show(this,
            "Can't calculate quantity unless the per item price and total price have a value.",
            "Need Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        numQuantity.Value = PriceTotal / PricePer;
      }
    }

    private void CalculatePer(bool showError = true)
    {
      if (PriceTotal == 0 || Quantity == 0)
      {
        if (showError)
        {
          MessageBox.Show(this,
            "Can't calculate per item price unless the quantity and total price have a value.",
            "Need Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        numPer.Value = PriceTotal / Quantity;
      }
    }

    private void CalculateTotal(bool showError = true)
    {
      if (Quantity == 0 || PricePer == 0)
      {
        if (showError)
        {
          MessageBox.Show(this,
            "Can't calculate total price unless the quantity and per item price have a value.",
            "Need Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
      }
      else
      {
        numTotal.Value = (PricePer * Quantity);
      }
    }

    private void EditReceiptItemDialog_Load(object sender, EventArgs e)
    {
      gridMapping.SetPropertiesToList(false, false);
      gridMapping.SetPropertiesToHideSelection();
      gridMapping.DataSource = new List<ReceiptItem> { dataSource };
      gridMapping.RetrieveStructure();
      gridMapping.RootTable.Columns.HideAllExcept("Name");

      CalculatePer(false);
    }

    private void btnCalculateQuantity_Click(object sender, EventArgs e)
    {
      CalculateQuantity();
    }

    private void btnCalculatePer_Click(object sender, EventArgs e)
    {
      CalculatePer();
    }

    private void btnCalculateTotal_Click(object sender, EventArgs e)
    {
      CalculateTotal();
    }

    private void btnEditMapping_Click(object sender, EventArgs e)
    {
      using (var dlg = new DataSelectionDialog<NamedItem>())
      {
        // setup the dialog
        dlg.Text = "Select Item";
        dlg.Icon = this.Icon;

        // set the matches function
        dlg.GetMatchesTo = (t =>
          SaveFile.Instance.NamedItems.Where(n => Textex.IndexOf(n.Name, t)));

        // set the add function
        dlg.AddNewItem = SaveFile.Instance.NamedItems.Add;

        // set the creation function
        dlg.CreateNewItem = (x => new NamedItem
        {
          ID = Duid.Next,
          Name = x,
        });

        // show the dialog
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          dataSource.ItemID = dlg.SelectedItem.ID;
          gridMapping.Refresh();
        }
      }
    }

    private void btnQuantityCalculator_Click(object sender, EventArgs e)
    {
      using (var dlg = new QuantityCalculatorDialog())
      {
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          numQuantity.Value = dlg.Result;
        }
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      if (dataSource.LinkedItem == null)
      {
        cancelClose = true;
        MessageBox.Show(this,
          "Please select (or create) an item.", "OK",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (Quantity <= 0m)
      {
        cancelClose = true;
        MessageBox.Show(this,
          "Please enter in a valid quantity.", "OK",
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (PriceTotal == 0)
      {
        cancelClose = true;
        MessageBox.Show(this,
          "Please enter in a valid total, or click the 'U' button to update the total.", "OK",
           MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      cancelClose = false;
    }

    private void EditReceiptItemDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        e.Cancel = true;
        cancelClose = false;
      }
    }
  }
}
