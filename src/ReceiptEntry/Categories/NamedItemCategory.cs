using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;

namespace ReceiptEntry
{
  public class NamedItemCategory : StatisticCategory
  {
    private Lazy<object> calculateDataSource;
    public NamedItemCategory()
    {
      calculateDataSource = new Lazy<object>(() =>
      {
        var query = from value in
                      (from receipt in SaveFile.Instance.Receipts
                       from item in receipt.Items
                       select item)
                    group value by value.ItemID into itemGroup
                    select new
                    {
                      Name = Common.GetNamedItem(itemGroup.Key).Name,
                      Cnt = itemGroup.Count(),
                      Min = itemGroup.Min(v => decimal.Divide(v.Price, v.Quantity)),
                      Ave = itemGroup.Average(v => decimal.Divide(v.Price, v.Quantity)),
                      Max = itemGroup.Max(v => decimal.Divide(v.Price, v.Quantity)),
                      Ttl = itemGroup.Sum(v => v.Price),
                    };
        return query.ToList();
      }, true);
    }

    protected override string GetName()
    {
      return "Items";
    }

    public override void InitializeProperties(GridEX grid)
    {
      grid.SetPropertiesToList(false, false);
      grid.ColumnHeaders = InheritableBoolean.True;
    }

    public override object GetDataSource()
    {
      return calculateDataSource.Value;
    }

    public override void SetupTables(GridEX grid)
    {
      grid.RootTable.Columns.LockColumnWidth("Cnt", 70);
      grid.RootTable.Columns["Cnt"].TextAlignment = TextAlignment.Center;

      grid.RootTable.Columns.LockColumnWidth("Ttl", 70);
      grid.RootTable.Columns["Ttl"].TextAlignment = TextAlignment.Center;

      grid.RootTable.Columns.LockColumnWidth("Ave", 70);
      grid.RootTable.Columns["Ave"].TextAlignment = TextAlignment.Center;

      grid.RootTable.Columns.LockColumnWidth("Max", 70);
      grid.RootTable.Columns["Max"].TextAlignment = TextAlignment.Center;

      grid.RootTable.Columns.LockColumnWidth("Min", 70);
      grid.RootTable.Columns["Min"].TextAlignment = TextAlignment.Center;
    }
  }
}
