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

    private MerchantViewModel mCurrentMerchant;

    public string ID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    public bool ContainsHelpfulName
    {
      get { return GetField<bool>(); }
      private set { SetField(value); }
    }

    public string MerchantID
    {
      get { return GetField<string>(); }
      set 
      {
        SetField(value);
        UpdateCurrentMerchant();
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

    public bool ShowHelpfulName
    {
      get { return GetField<bool>(); }
      set 
      { 
        SetField(value);
        FireColumnsChanged();
      }
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

    public IEnumerable<ReceiptColumnReferenceViewModel> Columns
    {
      get
      {
        if (mCurrentMerchant == null)
        {
          yield break;
        }

        bool show = ShowHelpfulName; 
        foreach (var column in mCurrentMerchant.CurrentColumns)
        {
          if (!show && IsHelpfulName(column))
          {
            continue;
          }
          yield return column;
        }
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

    public event EventHandler ColumnsChanged;

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
      return ContainsHelpfulName;
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

      if (mCurrentMerchant == null)
      {
        return false;
      }

      // create a lookup for all the columns
      var columns = mCurrentMerchant.CurrentColumns;
      var lookup = mParent.Columns.Items.ToDictionary(k => k.ID);

      // retrieve all of the text column names
      var names = columns
        .Select(c => lookup[c.ColumnID])
        .Where(c => c.Type == ReceiptColumnType.Text)
        .Select(c => c.Name)
        .ToArray();

      return mItems.Any(i =>
      {
        var values = names.Select(n => (i[n] as string) ?? string.Empty);
        var matched = values.Any(v => v.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1);
        i.IsMatched = matched;
        return matched;
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

    private bool IsHelpfulName(ReceiptColumnReferenceViewModel reference)
    {
      var column = mParent.Columns.Fetch(c => c.ID == reference.ColumnID);
      return (column != null) && (column.Type == ReceiptColumnType.HelpfulName);
    }

    private void UpdateCurrentMerchant()
    { 
      // retrieve the columns from the selected merchant
      mCurrentMerchant = mParent.Merchants.Fetch(MerchantID);
      if (mCurrentMerchant != null)
      {
        var columns = mCurrentMerchant.CurrentColumns;
        var lookup = mParent.Columns.Items.ToDictionary(k => k.ID);
        ContainsHelpfulName = columns.Any(c => lookup[c.ColumnID].Type == ReceiptColumnType.HelpfulName);
      }
      else
      {
        ContainsHelpfulName = false;
      }

      // make sure the view is alerted
      FireColumnsChanged();
    }

    private void FireColumnsChanged()
    {
      var changed = ColumnsChanged;
      if (changed != null)
      {
        changed(this, EventArgs.Empty);
      }
    }
  }
}
