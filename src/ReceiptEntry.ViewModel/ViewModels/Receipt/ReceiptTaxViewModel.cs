using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptTaxViewModel : BaseViewModel
  {
    public decimal Percent
    {
      get { return GetField<decimal>(); }
      set { SetField(value); }
    }

    public decimal Amount
    {
      get { return GetField<decimal>(); }
      set { SetField(value); }
    }

    public ReceiptTaxViewModel()
      : this(0, 0)
    {

    }

    internal ReceiptTaxViewModel(ReceiptTax tax)
      : this(tax.Percent, tax.Amount)
    {

    }

    internal ReceiptTaxViewModel(decimal percent, decimal amount)
    {
      Percent = percent;
      Amount = amount;
      Accept();
    }

    internal ReceiptTax ToTax()
    {
      return new ReceiptTax
      {
        Amount = Amount,
        Percent = Percent,
      };
    }
  }
}
