using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.GridEX;
using System.Collections;

namespace ReceiptEntry
{
  public class PurchasesCategory : StatisticCategory
  {
    private class Purchase
    {
      public DateTime Date { get; set; }
      public string Merchant { get; set; }
      public string Name { get; set; }
      public decimal Quantity { get; set; }
      public decimal Price { get; set; }
    }

    private Lazy<object> calculateDataSource;
    public PurchasesCategory()
    {
      calculateDataSource = new Lazy<object>(() =>
      {
        var query = from receipt in SaveFile.Instance.Receipts
                    from item in receipt.Items
                    select new Purchase
                    {
                      Date = receipt.Date,
                      Merchant = receipt.Name,
                      Name = item.Name,
                      Quantity = item.Quantity,
                      Price = item.Price,
                    };

        return query.ToList();
      }, true);
    }

    protected override string GetName()
    {
      return "Purchases";
    }

    public override void InitializeProperties(GridEX grid)
    {
      grid.SetPropertiesToList(false, false);
      grid.ColumnHeaders = InheritableBoolean.True;
      grid.RowHeaders = InheritableBoolean.True;
      grid.HideColumnsWhenGrouped = InheritableBoolean.False;
      grid.GroupMode = GroupMode.Collapsed;
      grid.SetPropertiesToShowFilterRow();
      grid.FilterRowButtonStyle = Janus.Windows.GridEX.FilterRowButtonStyle.ConditionOperatorDropDown;
    }

    public override object GetDataSource()
    {
      return calculateDataSource.Value;
    }

    public override void SetupTables(GridEX grid)
    {
      const string Merchant = "Merchant";

      var grpMerchantID = grid.RootTable.Groups.Add(Merchant);
      grpMerchantID.GroupPrefix = "";
      grpMerchantID.SortOrder = SortOrder.Ascending;

      // we don't want the quantity to be $
      grid.RootTable.Columns["Quantity"].FormatString = "";
    }
  }
}
