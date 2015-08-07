using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptColumnReferenceViewModel : BaseViewModel
  {
    public string ColumnID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    internal ReceiptColumnReferenceViewModel(ReceiptColumnReference column)
      : this(column.ColumnID)
    {

    }

    internal ReceiptColumnReferenceViewModel(string columnID)
    {
      ColumnID = columnID;
      Accept();
    }

    public ReceiptColumnReference ToColumnReference()
    {
      return new ReceiptColumnReference { ColumnID = ColumnID };
    }
  }
}
