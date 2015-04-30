using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public sealed class ReceiptEntryApplication : NotifyPropertyChanged
  {
    static Lazy<ReceiptEntryApplication> lzInstance = new Lazy<ReceiptEntryApplication>(true);
    public static ReceiptEntryApplication Instance
    {
      get { return lzInstance.Value; }
    }

    internal static ReceiptItemNameListViewModel Names
    {
      get;
      private set;
    }

    internal static ReceiptItemNameViewModel SelectReceiptItemName(ReceiptItemNameViewModel[] names, string name, string alias)
    {
      
    }
  }
}
