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
  public partial class QuantityCalculatorDialog : Form
  {
    private bool cancelClose = false;

    public decimal Result { get; private set; }

    public QuantityCalculatorDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
      UpdateInputs();
    }

    private void UpdateInputs()
    {
      numActualPrice.Enabled = optPrice.Checked;
      numActualUnits.Enabled = optUnits.Checked;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      decimal result;
      if (!CalculateResult(out result))
      {
        cancelClose = true;
      }
      Result = result;
    }

    private bool CalculateResult(out decimal result)
    {
      result = 0;

      decimal ratioPrice = (decimal)numRatioPrice.Value;
      decimal ratioUnit = (decimal)numRatioUnits.Value;

      if (ratioPrice == 0)
      {
        MessageBox.Show(this, "Please enter in the ratio price before hitting 'OK'", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.None);
        return false;
      }

      if (ratioUnit == 0)
      {
        MessageBox.Show(this, "Please enter in the ratio units before hitting 'OK'", "Error",
          MessageBoxButtons.OK, MessageBoxIcon.None);
        return false;
      }

      if (optUnits.Checked)
      {
        decimal unit = ((decimal)numActualUnits.Value);
        if (unit == 0)
        {
          MessageBox.Show(this, "Please enter in the actual units before hitting 'OK'", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.None);
          return false;
        }

        decimal price = (ratioPrice / ratioUnit) * unit;
        result = ratioPrice / price;
      }
      else
      {
        decimal price = ((decimal)numActualPrice.Value);
        if (price == 0)
        {
          MessageBox.Show(this, "Please enter in the actual price before hitting 'OK'", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.None);
          return false;
        }

        decimal unit = (ratioUnit / ratioPrice) * price;
        result = ratioUnit / unit;
      }

      return true;
    }

    private void QuantityCalculatorDialog_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        e.Cancel = true;
        cancelClose = false;
      }
    }

    private void option_CheckedChanged(object sender, EventArgs e)
    {
      UpdateInputs();
    }
  }
}
