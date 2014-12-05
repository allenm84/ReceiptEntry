using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;

namespace ReceiptEntry
{
  public class MerchantCategory : StatisticCategory
  {
    private Lazy<object> calculateDataSource;

    public MerchantCategory()
    {
      calculateDataSource = new Lazy<object>(() =>
      {
        var query = from value in
                    (from receipt in SaveFile.Instance.Receipts
                     from item in receipt.Items
                     select new { ID = receipt.MerchantID, Price = item.Price })
                  group value by value.ID into merchantGroup
                  select new
                  {
                    Name = Common.GetMerchant(merchantGroup.Key).Name,
                    Cnt = merchantGroup.Count(),
                    Min = merchantGroup.Min(v => v.Price),
                    Ave = merchantGroup.Average(v => v.Price),
                    Max = merchantGroup.Max(v => v.Price),
                    Ttl = merchantGroup.Sum(v => v.Price),
                  };
      return query.ToList();
      }, true);
    }

    protected override string GetName()
    {
      return "Merchants";
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
