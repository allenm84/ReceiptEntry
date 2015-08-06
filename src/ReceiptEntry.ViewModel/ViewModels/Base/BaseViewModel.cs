using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public abstract class BaseViewModel : BaseNotifyPropertyChanged
  {
    private readonly Dictionary<string, object> mFields = new Dictionary<string, object>();

    private Dictionary<string, object> mCurrentSnapshot;
    protected void Snapshot()
    {
      mCurrentSnapshot = mFields.ToDictionary(k => k.Key, v => v.Value);
    }

    protected void Commit()
    {
      mCurrentSnapshot = null;
    }

    protected void Cancel()
    {
      if (mCurrentSnapshot != null)
      {
        foreach (var kvp in mCurrentSnapshot)
        {
          PushValue(kvp.Key, kvp.Value);
        }
      }

      mCurrentSnapshot = null;
    }

    protected virtual bool ValueChanged<T>(string key, T value)
    {
      return !(GetField<T>(key).Equals(value));
    }

    protected T GetField<T>([CallerMemberName] string key = "")
    {
      object value;
      if (!mFields.TryGetValue(key, out value))
      {
        value = default(T);
        mFields[key] = value;
      }
      return (T)value;
    }

    protected void SetField<T>(T value, [CallerMemberName] string key = "", bool force = true)
    {
      if (force || ValueChanged(key, value))
      {
        PushValue(key, value);
      }
    }

    private void PushValue(string key, object value)
    {
      mFields[key] = value;
      FirePropertyChanged(key);
    }
  }
}
