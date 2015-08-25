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
    private readonly List<ReceiptColumnReferenceViewModel> mHelpfulNameColumns;

    private ReceiptItemViewModel[] mCommittedItems;
    private ReceiptTaxViewModel[] mCommittedTaxes;

    public string ID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    public bool IsValidMerchant
    {
      get { return GetField<bool>(); }
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
          var columns = mParent.Merchants.Fetch(id).CurrentColumns;
          UpdateColumns(columns);
          Columns = columns;
          IsValidMerchant = true;
        }
        else
        {
          Columns = new BindingList<ReceiptColumnReferenceViewModel>();
          IsValidMerchant = false;
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

    public bool ShowHelpfulName
    {
      get { return GetField<bool>(); }
      set 
      { 
        SetField(value);
        if (IsValidMerchant)
        {
          UpdateColumns(Columns);
          FireColumnOrderChanged();
        }
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

    public event EventHandler ColumnOrderChanged;

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
      mHelpfulNameColumns = new List<ReceiptColumnReferenceViewModel>();

      mParent = parent;
      ID = id;
      MerchantID = merchantID;
      Date = date;

      InitializeHelpfulNames();

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

    private void FireColumnOrderChanged()
    {
      var changed = ColumnOrderChanged;
      if (changed != null)
      {
        changed(this, EventArgs.Empty);
      }
    }

    protected override bool InternalCanDoAccept(object parameter)
    {
      return IsValidMerchant;
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

    private void InitializeHelpfulNames()
    {
      // create a lookup table for the columns
      if (IsValidMerchant)
      {
        var lookup = mParent.Columns.Items.ToDictionary(k => k.ID);
        mHelpfulNameColumns.AddRange(mColumns
          .Where(c => lookup[c.ColumnID].Type == ReceiptColumnType.HelpfulName));

        if (mHelpfulNameColumns.Count > 0)
        {
          // there is at least one helpful name column available, so show it!
          ShowHelpfulName = true;
        }
        else
        {
          // there are no helpful name columns that are a part of this receipt.
          // Let's add a helpful name column
          var helpfulName = mParent.Columns.EnsureHelpfulName();
          var item = mColumns.FirstOrDefault(c => lookup[c.ColumnID].Name == "Item");
          mHelpfulNameColumns.Add(new ReceiptColumnReferenceViewModel(helpfulName.ID)
          {
            Order = (item == null) ? 1 : Math.Max(1, item.Order - 1),
          });

          // since there are no helpful names, we need to hide the columns
          ShowHelpfulName = false;
        }
      }
      else
      {
        ShowHelpfulName = false;
      }
    }

    private void UpdateColumns(BindingList<ReceiptColumnReferenceViewModel> columns)
    {
      // create a lookup table for the columns
      var lookup = mParent.Columns.Items.ToDictionary(k => k.ID);

      // get the index of all the helpful columns
      var indices = columns
        .Select((c, i) => new { Index = i, Column = lookup[c.ColumnID] })
        .Where(a => a.Column.Type == ReceiptColumnType.HelpfulName)
        .OrderByDescending(a => a.Index)
        .ToArray();

      if (!ShowHelpfulName)
      {
        // we need to remove a column if it is a helpful name
        mHelpfulNameColumns.ForEach(c => columns.Remove(c));
      }
      else if (indices.Length == 0)
      {
        // there are no helpful name columns, so let's add them back!
        mHelpfulNameColumns.ForEach(c => columns.Add(c));
      }
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
