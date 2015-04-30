using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptItemViewModel : NotifyPropertyChanged
  {
    private readonly ReceiptItem item;
    private bool ignoreFetchRequest;

    internal ReceiptItemViewModel()
      : this(new ReceiptItem())
    {

    }

    internal ReceiptItemViewModel(ReceiptItem item)
    {
      this.item = item;
      Read(false);
    }

    private void Read(bool notify)
    {
      if (!notify)
      {
        SuspendNotifications();
      }

      NameID = item.NameID;
      Code = item.Code;
      Price = item.Price;
      Count = item.Count;

      if (!notify)
      {
        ResumeNotifications();
      }
    }

    private void Write()
    {
      var names = ReceiptEntryApplication.Names.Select(n => new
      {
        NameScore = Levenshtein.DistanceIgnoreCase(mName, n.Name),
        AliasScore = Levenshtein.DistanceIgnoreCase(mAlias, n.Alias),
        ID = n.ID,
        Name = n,
      })
      .OrderBy(a => a.NameScore)
      .ThenBy(a => a.AliasScore)
      .ToArray();

      var matches = names
        .Where(a => a.NameScore == 0 && a.AliasScore == 0)
        .ToArray();

      if (matches.Length == 1)
      {
        item.NameID = matches[0].ID;
      }
      else
      {
        var arr = names.Select(n => n.Name).ToArray();
        var selected = ReceiptEntryApplication.SelectReceiptItemName(arr, Name, Alias);
        item.NameID = selected.ID;

        Name = selected.Name;
        Alias = selected.Alias;
      }

      item.Code = Code;
      item.Price = Price;
      item.Count = Count;
    }

    private void FetchNameID()
    {
      if (ignoreFetchRequest)
      {
        return;
      }

      var names = ReceiptEntryApplication.Names;

      // first are there any exact matches
      var exact = names.Where(n =>
        string.Equals(n.Alias, Alias) &&
        string.Equals(n.Name, Name)).ToArray();
      if (exact.Length > 0)
      {
        // there is at least one exact match. It doesn't matter
        // if there are multiple. Just 
      }
    }

    private void ReadNameData()
    {
      var names = ReceiptEntryApplication.Names;

      ignoreFetchRequest = true;

      var name = names[mNameID];
      if (name != null)
      {
        Name = name.Name;
        Alias = name.Alias;
      }
      else
      {
        Name = "{Unknown}";
        Alias = "";
      }

      ignoreFetchRequest = false;
    }

    private string mNameID;
    internal string NameID
    {
      get { return mNameID; }
      set
      {
        mNameID = value;
        FirePropertyChanged();
        ReadNameData();
      }
    }

    private string mName;
    public string Name
    {
      get { return mName; }
      set
      {
        mName = value;
        FirePropertyChanged();
        FetchNameID();
      }
    }

    private string mCode;
    public string Code
    {
      get { return mCode; }
      set
      {
        mCode = value;
        FirePropertyChanged();
      }
    }

    private decimal mPrice;
    public decimal Price
    {
      get { return mPrice; }
      set
      {
        mPrice = value;
        FirePropertyChanged();
      }
    }

    private decimal mCount;
    public decimal Count
    {
      get { return mCount; }
      set
      {
        mCount = value;
        FirePropertyChanged();
      }
    }

    private string mAlias;
    public string Alias
    {
      get { return mAlias; }
      set
      {
        mAlias = value;
        FirePropertyChanged();
        FetchNameID();
      }
    }
  }
}
