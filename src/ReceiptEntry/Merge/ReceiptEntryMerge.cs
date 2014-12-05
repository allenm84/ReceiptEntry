using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class ReceiptEntryMerge
  {
    private class IDMap
    {
      public string OldID { get; set; }
      public string NewID { get; set; }
    }

    public static SaveFile Merge()
    {
      var file = new SaveFile();
      file.Merchants = new List<Merchant>();
      file.Receipts = new List<Receipt>();
      var merchants = file.Merchants;
      var receipts = file.Receipts;

      var dcf = new DataContractFile<Shopping.ShoppingList>(@"C:\Users\mallen\Dropbox\Paige\[data]\shoppingItems.xml");
      Shopping.ShoppingList list;
      dcf.TryRead(out list);
      if (list == null)
      {
        list = new Shopping.ShoppingList();
        list.Items = new List<Shopping.ShoppingListItem>();
      }

      // create the readers
      var v1dcf = new DataContractFile<Merge.V1.SaveFile>(@"C:\Users\mallen\Dropbox\Downloads\Archive\Receipts\v1.xml");
      var v2dcf = new DataContractFile<Merge.V2.SaveFile>(@"C:\Users\mallen\Dropbox\Downloads\Archive\Receipts\v2.xml");
      var v3dcf = new DataContractFile<Merge.V3.Database>(@"C:\Users\mallen\Dropbox\Downloads\Archive\Receipts\v3.xml");

      // read all of the data
      var v1 = v1dcf.Read();
      var v2 = v2dcf.Read();
      var v3 = v3dcf.Read();

      // create a merchant map
      var merchantMap = new List<IDMap>();

      // load in all of the merchants
      foreach (var m in v1.Merchants)
      {
        var merchant = merchants.SingleOrDefault(p => p.Name == m.Name);
        if (merchant == null)
        {
          merchant = new Merchant();
          merchant.ID = ID.Gen();
          merchant.Name = m.Name;
          merchants.Add(merchant);
        }

        merchantMap.Add(new IDMap
        {
          OldID = m.ID,
          NewID = merchant.ID,
        });
      }
      foreach (var m in v2.merchants)
      {
        var merchant = merchants.SingleOrDefault(p => p.Name == m.Name);
        if (merchant == null)
        {
          merchant = new Merchant();
          merchant.ID = ID.Gen();
          merchant.Name = m.Name;
          merchants.Add(merchant);
        }

        merchantMap.Add(new IDMap
        {
          OldID = m.ID,
          NewID = merchant.ID,
        });
      }
      foreach (var m in v3.merchants)
      {
        var merchant = merchants.SingleOrDefault(p => p.Name == m.Name);
        if (merchant == null)
        {
          merchant = new Merchant();
          merchant.ID = ID.Gen();
          merchant.Name = m.Name;
          merchants.Add(merchant);
        }

        merchantMap.Add(new IDMap
        {
          OldID = m.ID,
          NewID = merchant.ID,
        });
      }

      // go through the receipts and add the items
      foreach (var r in v1.Receipts)
      {
        var receipt = new Receipt();
        receipt.Date = r.Date;
        receipt.MerchantID = Unfold(merchantMap, r.MerchantID);
        receipt.Tax = r.Tax;
        receipt.Items = r.Items.Select(i =>
        {
          var value = v1.NamedItems.SingleOrDefault(n => n.ID == i.ItemID);
          var item = new ReceiptItem();
          item.Name = value.Name;
          item.Price = i.Price;
          item.Quantity = new Quantity
          {
            Amount = i.Quantity,
            Unit = Unit.Unit,
          };
          return item;
        }).ToArray();
        receipts.Add(receipt);
      }
      foreach (var r in v2.receipts)
      {
        var receipt = new Receipt();
        receipt.Date = r.Date;
        receipt.MerchantID = Unfold(merchantMap, r.MerchantID);
        receipt.Tax = r.Tax;
        receipt.Items = r.Items.Select(i =>
        {
          var value = v2.items.SingleOrDefault(n => n.ID == i.ItemID);
          var item = new ReceiptItem();
          item.Name = value.Name;
          item.Price = i.PricePerItem;

          var quantity = new Quantity();
          quantity.Amount = i.Quantity;

          Unit unit;
          string text = value.Measurement.ToString();
          if (!Enum.TryParse<Unit>(text, true, out unit))
          {
            unit = Unit.Unit;
          }
          quantity.Unit = unit;

          item.Quantity = quantity;
          return item;

        }).ToArray();
        receipts.Add(receipt);
      }
      foreach (var r in v3.receipts)
      {
        var receipt = new Receipt();
        receipt.Date = r.Date;
        receipt.MerchantID = Unfold(merchantMap, r.MerchantID);
        receipt.Tax = r.Tax;
        receipt.Items = r.Items.Select(i =>
        {
          var item = new ReceiptItem();
          item.Code = i.Code;
          item.Name = i.Name;
          item.Price = i.Price;

          if (i.Quantity == null)
          {
            item.Quantity = new Quantity
            {
              Amount = 1,
              Unit = Unit.Unit,
            };
          }
          else
          {
            item.Quantity = new Quantity
            {
              Amount = i.Quantity.Amount,
              Unit = (Unit)(int)i.Quantity.Unit,
            };
          }

          if (!string.IsNullOrWhiteSpace(i.AliasID))
          {
            var value = v3.itemAlias.Single(a => a.ID == i.AliasID);
            if (value != null)
            {
              var match = list.Items.SingleOrDefault(x => x.Name == value.Name);
              if (match == null)
              {
                match = new Shopping.ShoppingListItem();
                match.ID = ID.Gen();
                match.Name = value.Name;
                list.Items.Add(match);
              }
              item.ShoppingListItemID = match.ID;
            }
          }
          return item;
        }).ToArray();
        receipts.Add(receipt);
      }

      dcf.Write(list);
      return file;
    }

    private static string Unfold(List<IDMap> map, string oldID)
    {
      return map.Single(m => m.OldID == oldID).NewID;
    }
  }
}
