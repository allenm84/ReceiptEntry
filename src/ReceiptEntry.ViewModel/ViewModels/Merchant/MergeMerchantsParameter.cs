using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public class MergeMerchantsParameter : CommandParameter
  {
    public string Name { get; set; }
    public MerchantViewModel[] Merchants { get; set; }
  }
}
