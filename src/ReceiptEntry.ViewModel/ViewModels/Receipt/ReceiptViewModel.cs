using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptViewModel : BaseViewModel
  {
    private readonly SaveFileViewModel mParent;

    private ReceiptItemViewModel[] mCommittedItems;
    private ReceiptTaxViewModel[] mCommittedTaxes;

    public string ID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    public string MerchantID
    {
      get { return GetField<string>(); }
      set 
      {
        string id = value;
        SetField(id);

        if (id != null)
        {
          Columns = mParent.Merchants.Fetch(m => m.ID == id).CurrentColumns;
        }
        else
        {
          Columns = new BindingList<ReceiptColumnReferenceViewModel>();
        }
      }
    }

    public SaveFileViewModel Parent
    {
      get { return mParent; }
    }

    public DateTime Date
    {
      get { return GetField<DateTime>(); }
      set { SetField(value); }
    }

    private readonly BindingList<ReceiptItemViewModel> mItems;
    public BindingList<ReceiptItemViewModel> Items
    {
      get { return mItems; }
    }

    private readonly BindingList<ReceiptTaxViewModel> mTaxes;
    public BindingList<ReceiptTaxViewModel> Taxes
    {
      get { return mTaxes; }
    }

    private BindingList<ReceiptColumnReferenceViewModel> mColumns;
    public BindingList<ReceiptColumnReferenceViewModel> Columns
    {
      get { return mColumns; }
      private set
      {
        mColumns = value;
        FirePropertyChanged();
      }
    }

    public decimal Total
    {
      get { return GetField<decimal>(); }
      set { SetField(value); }
    }

    private readonly ValidateReceiptTotalViewModel mValidate;
    public ValidateReceiptTotalViewModel Validate
    {
      get { return mValidate; }
    }

    internal ReceiptViewModel(SaveFileViewModel parent, Receipt receipt)
      : this(parent, receipt.ID, receipt.MerchantID, receipt.Date, receipt.Items, receipt.Taxes, receipt.Total)
    {
    }

    internal ReceiptViewModel(SaveFileViewModel parent, string id, string merchantID)
      : this(parent, id, merchantID, DateTime.Today, null, null, 0)
    {
    }

    private ReceiptViewModel(SaveFileViewModel parent, string id, string merchantID, DateTime date, ReceiptItem[] items, ReceiptTax[] taxes, decimal total)
    {
      mParent = parent;
      ID = id;
      MerchantID = merchantID;
      Date = date;

      mItems = new BindingList<ReceiptItemViewModel>();
      if (items != null)
      {
        foreach (var item in items)
        {
          mItems.Add(new ReceiptItemViewModel(item));
        }
      }

      mTaxes = new BindingList<ReceiptTaxViewModel>();
      if (taxes != null)
      {
        foreach (var tax in taxes)
        {
          mTaxes.Add(new ReceiptTaxViewModel(tax));
        }
      }

      Total = total;

      mValidate = new ValidateReceiptTotalViewModel(this);
      Accept();
    }

    protected override bool InternalCanDoAccept(object parameter)
    {
      return !string.IsNullOrWhiteSpace(MerchantID);
    }

    protected override void Commit()
    {
      mCommittedItems = mItems.ToArray();
      Array.ForEach(mCommittedItems, i => i.Accept());

      mCommittedTaxes = mTaxes.ToArray();
      Array.ForEach(mCommittedTaxes, i => i.Accept());

      base.Commit();
    }

    protected override void Rollback()
    {
      if (mCommittedItems != null)
      {
        Array.ForEach(mCommittedItems, i => i.Reject());

        mItems.Clear();
        foreach (var item in mCommittedItems)
        {
          mItems.Add(item);
        }
      }

      if (mCommittedTaxes != null)
      {
        Array.ForEach(mCommittedTaxes, i => i.Reject());

        mTaxes.Clear();
        foreach (var tax in mCommittedTaxes)
        {
          mTaxes.Add(tax);
        }
      }
      base.Rollback();
    }

    public bool Contains(string text)
    {
      if (string.IsNullOrWhiteSpace(text))
      {
        return true;
      }

      var names = mColumns
        .Select(c => mParent.Columns.Fetch(r => r.ID == c.ColumnID))
        .Where(c => c.Type == ReceiptColumnType.Text)
        .Select(c => c.Name)
        .ToArray();

      return mItems.Any(i =>
      {
        var values = names.Select(n => (i[n] as string) ?? string.Empty);
        return values.Any(v => v.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1);
      });
    }

    internal Receipt ToReceipt()
    {
      return new Receipt
      {
        Date = Date,
        ID = ID,
        Items = mItems.Select(i => i.ToReceiptItem()).ToArray(),
        MerchantID = MerchantID,
        Taxes = mTaxes.Select(t => t.ToTax()).ToArray(),
        Total = Total,
      };
    }
  }
}
