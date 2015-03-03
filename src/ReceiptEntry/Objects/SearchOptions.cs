using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public class SearchOptions
  {
    public string Text { get; set; }
    public bool IncludeExact { get; set; }
    public bool IncludeSimilar { get; set; }
    public bool SearchItemCode { get; set; }
  }
}
