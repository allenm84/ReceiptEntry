using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry
{
  public interface INameIDItem
  {
    string ID { get; set; }
    string Name { get; set; }
  }
}
