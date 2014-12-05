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
  public partial class FromTotalDialog : BaseForm
  {
    public decimal Quantity
    {
      get
      {
        if (optQuantity.Checked)
        {
          return numQuantity.Value;
        }
        else if (numPricePerItem.Value != 0m)
        {
          return numTotal.Value / numPricePerItem.Value;
        }
        else
        {
          return 0m;
        }
      }
    }

    public decimal PricePerItem
    {
      get
      {
        if (optPricePerItem.Checked)
        {
          return numPricePerItem.Value;
        }
        else if (numQuantity.Value != 0m)
        {
          return numTotal.Value / numQuantity.Value;
        }
        else
        {
          return 0m;
        }
      }
    }

    public FromTotalDialog()
    {
      InitializeComponent();
      numQuantity.DataBindings.Add("Enabled", optQuantity, "Checked");
      numPricePerItem.DataBindings.Add("Enabled", optPricePerItem, "Checked");
    }
  }
}
