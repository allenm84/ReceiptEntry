using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptItemViewModel : BaseViewModel
  {
    static ulong sCurrentID = 0;
    static readonly HashSet<ulong> sMatches = new HashSet<ulong>();

    private readonly ulong mId = (sCurrentID++);

    public bool IsMatched
    {
      get { return sMatches.Contains(mId); }
      internal set
      {
        if (value)
        {
          sMatches.Add(mId);
        }
        else
        {
          sMatches.Remove(mId);
        }
        FirePropertyChanged();
      }
    }

    public object this[string name]
    {
      get { return GetField<object>(name); }
      set { SetField(value, name); }
    }

    public ReceiptItemViewModel()
      : this(new Dictionary<string, object>())
    {

    }

    internal ReceiptItemViewModel(ReceiptItem item)
      : this(item.Values)
    {

    }

    internal ReceiptItemViewModel(Dictionary<string, object> values)
    {
      Push(values);
      Accept();
    }

    internal ReceiptItem ToReceiptItem()
    {
      return new ReceiptItem
      {
        Values = Pull(),
      };
    }

    internal T Fetch<T>(string key, T defaultValue = default(T))
    {
      object value;
      if (TryGetValue(key, out value) && (value is T))
      {
        return (T)value;
      }
      else
      {
        return defaultValue;
      }
    }
  }
}
