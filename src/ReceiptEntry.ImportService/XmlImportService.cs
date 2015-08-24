using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using ReceiptEntry.ImportService;
using ReceiptEntry.Model;

namespace ReceiptEntry.Services
{
  public class XmlImportService : ISaveFileService
  {
    private static string ID { get { return Guid.NewGuid().ToString(); } }

    private static void CalculateTotal(Receipt receipt)
    {
      var items = receipt.Items ?? new ReceiptItem[0];

      decimal total = receipt.Taxes.Sum(t => t.Amount);
      if (items.Length > 0)
      {
        total += items.Sum(i =>
        {
          object price;
          if (!i.Values.TryGetValue("Price", out price))
          {
            price = 0m;
          }
          return (decimal)price;
        });
      }

      receipt.Total = total;
    }

    private readonly DataContractFile<SaveFile> dcf;

    public XmlImportService(string filepath)
    {
      dcf = new DataContractFile<SaveFile>(filepath);
    }

    public SaveFile PullSaveFile()
    {
      var rdoc = XDocument.Parse(Resources.receipts);
      var ndoc = XDocument.Parse(Resources.shoppingItems);

      var itemColumn = new ReceiptColumn { ID = ID, Name = "Item", Type = ReceiptColumnType.Text };
      var helpfulNameColumn = new ReceiptColumn { ID = ID, Name = "HN", Type = ReceiptColumnType.HelpfulName };
      var priceColumn = new ReceiptColumn { ID = ID, Name = "Price", Type = ReceiptColumnType.Dollars };
      var codeColumn = new ReceiptColumn { ID = ID, Name = "Code", Type = ReceiptColumnType.Text };
      var quantityColumn = new ReceiptColumn { ID = ID, Name = "Quantity", Type = ReceiptColumnType.Number };
      var columns = new[] { itemColumn, helpfulNameColumn, codeColumn, priceColumn, quantityColumn };

      var merchants = new List<Merchant>();
      foreach (var m in rdoc.Descendants("Merchant"))
      {
        merchants.Add(new Merchant
        {
          Columns = columns.Select(c => new ReceiptColumnReference { ColumnID = c.ID }).ToArray(),
          ID = m.Element("ID").Value,
          Name = m.Element("Name").Value,
        });
      }

      var receipts = new List<Receipt>();
      foreach (var r in rdoc.Descendants("Receipt"))
      {
        var receipt = new Receipt();
        receipt.Date = (DateTime)r.Element("Date");
        receipt.ID = ID;
        receipt.MerchantID = r.Element("MerchantID").Value;
        receipt.Taxes = new[] { new ReceiptTax { Amount = (decimal)r.Element("Tax") } };

        var items = new List<ReceiptItem>();
        foreach (var i in r.Element("Items").Elements())
        {
          var values = new Dictionary<string, object>();
          values[itemColumn.Name] = i.Element("Name").Value;
          values[helpfulNameColumn.Name] = i.Element("ShoppingListItemID").Value;
          values[priceColumn.Name] = (decimal)i.Element("Price");
          values[codeColumn.Name] = i.Element("Code").Value;

          var amount = i.Element("Quantity").Element("Amount");
          if (amount != null)
          {
            values[quantityColumn.Name] = (decimal)amount;
          }

          items.Add(new ReceiptItem { Values = values });
        }

        receipt.Items = items.ToArray();

        CalculateTotal(receipt);
        receipts.Add(receipt);
      }

      var names = new List<HelpfulName>();
      foreach (var s in ndoc.Descendants("ShoppingListItem"))
      {
        names.Add(new HelpfulName
        {
          ID = s.Element("ID").Value,
          Name = s.Element("Name").Value,
        });
      }

      var file = new SaveFile();
      file.Columns = columns;
      file.Merchants = merchants.ToArray();
      file.Names = names.ToArray();
      file.Receipts = receipts.ToArray();
      return file;
    }

    public void PushSaveFile(SaveFile file)
    {
      dcf.TryWrite(file);
    }
  }
}
