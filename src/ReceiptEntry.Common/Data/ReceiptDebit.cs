using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "ReceiptDebit", Namespace = SaveFile.Namespace)]
  public class ReceiptDebit : ReceiptCharge
  {
    
  }
}
