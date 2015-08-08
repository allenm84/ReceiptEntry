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
    public bool IsSelected
    {
      get { return GetField<bool>(); }
      set { SetField(value); }
    }

    public int Order
    {
      get { return GetField<int>(); }
      set { SetField(value); }
    }

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

    internal ReceiptColumnReference ToColumnReference()
    {
      return new ReceiptColumnReference { ColumnID = ColumnID };
    }
  }
}
