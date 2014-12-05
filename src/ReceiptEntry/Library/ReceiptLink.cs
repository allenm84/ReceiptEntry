using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry
{
  public class ReceiptLink
  {
    private Receipt receipt;
    private ReceiptItem item;

    public string MerchantID { get { return receipt.MerchantID; } }
    public string Merchant { get { return receipt.Name; } }

    public DateTime Date { get { return receipt.Date; } }

    public string ItemID { get { return item.ItemID; } }
    public string Item { get { return item.Name; } }

    public decimal Quantity { get { return item.Quantity; } }
    public decimal Price { get { return item.Price; } }

    public ReceiptLink(ReceiptItem item, Receipt receipt)
    {
      this.item = item;
      this.receipt = receipt;
    }
  }
}
