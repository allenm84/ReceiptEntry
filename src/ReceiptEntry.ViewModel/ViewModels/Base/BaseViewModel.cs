using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public abstract class BaseViewModel : BaseNotifyPropertyChanged
  {
    protected static object DeepCopy(object obj)
    {
      using (var stream = new MemoryStream())
      {
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, obj);
        stream.Position = 0;
        return formatter.Deserialize(stream);
      }
    }

    private readonly Dictionary<string, object> mFields = new Dictionary<string, object>();
    private Dictionary<string, object> mAccepted;

    protected void Accept()
    {
      mAccepted = mFields.ToDictionary(k => k.Key, v => DeepCopy(v.Value));
      Commit();
    }

    protected virtual void Commit()
    {
      
    }

    protected void Reject()
    {
      foreach (var kvp in mAccepted)
      {
        PushValue(kvp.Key, kvp.Value);
      }

      Rollback();
    }

    protected virtual void Rollback()
    {
      
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

    private bool ValueChanged<T>(string key, T value)
    {
      return !(GetField<T>(key).Equals(value));
    }

    private void PushValue(string key, object value)
    {
      mFields[key] = value;
      FirePropertyChanged(key);
    }
  }
}
