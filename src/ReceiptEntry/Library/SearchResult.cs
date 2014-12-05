using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry
{
  public class SearchResult
  {
    public SearchResultType Type { get; set; }
    public string Name { get; set; }
    public ReceiptLink[] Links { get; set; }
    public int Count { get; set; }
    public decimal Min { get; set; }
    public decimal Average { get; set; }
    public decimal Max { get; set; }
    public decimal Total { get; set; }
  }
}
