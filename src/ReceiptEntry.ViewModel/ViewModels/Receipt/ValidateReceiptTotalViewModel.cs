using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ValidateReceiptTotalViewModel : BaseViewModel
  {
    private readonly ReceiptViewModel mParent;

    public ReceiptColumnViewModel[] PriceColumns
    {
      get
      {
        var columns = mParent.Parent.Columns.Items
          .Where(c => c.Type == ReceiptColumnType.Dollars)
          .Where(c => mParent.Columns.Any(r => r.ColumnID == c.ID))
          .ToArray();

        if (columns.Length == 1)
        {
          SelectedPriceColumn = columns[0].ID;
        }

        return columns;
      }
    }

    public ReceiptColumnViewModel[] QuantityColumns
    {
      get
      {
        var columns = mParent.Parent.Columns.Items
          .Where(c => c.Type == ReceiptColumnType.Number)
          .Where(c => mParent.Columns.Any(r => r.ColumnID == c.ID))
          .ToArray();

        if (columns.Length == 1)
        {
          SelectedQuantityColumn = columns[0].ID;
        }

        return columns;
      }
    }

    public string SelectedPriceColumn
    {
      get { return GetField<string>(); }
      set 
      { 
        SetField(value);
        UpdateActualTotal();
      }
    }

    public string SelectedQuantityColumn
    {
      get { return GetField<string>(); }
      set
      {
        SetField(value);
        UpdateActualTotal();
      }
    }

    public decimal ActualTotal
    {
      get { return GetField<decimal>(); }
      private set { SetField(value); }
    }

    internal ValidateReceiptTotalViewModel(ReceiptViewModel parent)
    {
      mParent = parent;
    }

    private decimal GetTotal(ReceiptItemViewModel item, string price, string quantity)
    {
      return 
        item.Fetch(price, 0m) * 
        item.Fetch(quantity, 1m);
    }

    private void UpdateActualTotal()
    {
      if (!string.IsNullOrWhiteSpace(SelectedPriceColumn)
        && !string.IsNullOrWhiteSpace(SelectedQuantityColumn))
      {
        var price = mParent.Parent.Columns.Fetch(c => c.ID == SelectedPriceColumn);
        var quantity = mParent.Parent.Columns.Fetch(c => c.ID == SelectedQuantityColumn);

        ActualTotal =
          mParent.Items.Sum(i => GetTotal(i, price.Name, quantity.Name)) +
          mParent.Taxes.Sum(t => t.Amount);
      }
    }
  }
}
