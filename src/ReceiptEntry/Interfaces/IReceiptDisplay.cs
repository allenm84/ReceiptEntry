using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public interface IReceiptDisplay
  {
    IEnumerable<Receipt> Receipts { get; }
    void SelectReceipt(Receipt item);
  }
}
