using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class MerchantViewModel : BaseViewModel
  {
    internal string ID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    public string Name
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    private readonly BindingList<ReceiptColumnReferenceViewModel> mColumns;
    public BindingList<ReceiptColumnReferenceViewModel> Columns
    {
      get { return mColumns; }
    }

    internal MerchantViewModel(Merchant merchant)
      : this(merchant.ID, merchant.Name, merchant.Columns)
    {

    }

    internal MerchantViewModel(string id, string name, ReceiptColumnReference[] columns = null)
    {
      ID = id;
      Name = name;

      mColumns = new BindingList<ReceiptColumnReferenceViewModel>();
      if (columns != null)
      {
        foreach (var c in columns)
        {
          mColumns.Add(new ReceiptColumnReferenceViewModel(c));
        }
      }

      Snapshot();
    }
  }
}
