﻿using System;
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

    public bool ShowHelpfulName
    {
      get { return GetField<bool>(); }
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
      set
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
    }

    protected override bool CanDoAccept(object parameter)
    {
      return !string.IsNullOrWhiteSpace(MerchantID);
    }
  }
}