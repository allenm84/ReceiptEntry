using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ReceiptEntry.ViewModel
{
  public abstract class BaseViewModel : BaseNotifyPropertyChanged, IDataErrorInfo
  {
    protected static object DeepCopy(object obj)
    {
      if (obj == null)
      {
        return null;
      }

      using (var stream = new MemoryStream())
      {
        var formatter = new BinaryFormatter();
        formatter.Serialize(stream, obj);
        stream.Position = 0;
        return formatter.Deserialize(stream);
      }
    }

    private readonly Dictionary<string, object> mFields = new Dictionary<string, object>();
    private readonly Dictionary<string, string> mErrors = new Dictionary<string, string>();
    private Dictionary<string, object> mAccepted;

    private readonly DelegateCommand mAcceptCommand;
    public ICommand AcceptCommand
    {
      get { return mAcceptCommand; }
    }

    private readonly DelegateCommand mRejectCommand;
    public ICommand RejectCommand
    {
      get { return mRejectCommand; }
    }

    protected bool IsErrorFree
    {
      get { return mErrors.Count == 0; }
    }

    public BaseViewModel()
    {
      mAcceptCommand = new DelegateCommand(DoAccept, CanDoAccept);
      mRejectCommand = new DelegateCommand(DoReject, CanDoReject);
    }

    protected void RefreshCommands()
    {
      RefreshAccept();
      RefreshReject();
    }

    protected void RefreshAccept()
    {
      mAcceptCommand.FireCanExecuteChanged(this);
    }

    protected void RefreshReject()
    {
      mRejectCommand.FireCanExecuteChanged(this);
    }

    protected override void AfterPropertyChanged(string propertyName)
    {
      base.AfterPropertyChanged(propertyName);
      RefreshCommands();
    }

    private bool CanDoAccept(object parameter)
    {
      return IsErrorFree && InternalCanDoAccept(parameter);
    }

    protected virtual bool InternalCanDoAccept(object parameter)
    {
      return true;
    }

    private void DoAccept(object parameter)
    {
      Accept();
    }

    internal void Accept()
    {
      mAccepted = mFields.ToDictionary(k => k.Key, v => DeepCopy(v.Value));
      Commit();
    }

    protected virtual void Commit()
    {
      
    }

    private bool CanDoReject(object parameter)
    {
      return InternalCanDoReject(parameter);
    }

    protected virtual bool InternalCanDoReject(object parameter)
    {
      return true;
    }

    private void DoReject(object parameter)
    {
      Reject();
    }

    internal void Reject()
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

    protected void Push(Dictionary<string, object> values)
    {
      foreach (var kvp in values)
      {
        PushValue(kvp.Key, kvp.Value);
      }
    }

    protected Dictionary<string, object> Pull()
    {
      return mFields.ToDictionary(k => k.Key, v => v.Value);
    }

    protected void ClearErrors()
    {
      var keys = mErrors.Keys.ToArray();
      foreach (var key in keys)
      {
        SetError(string.Empty, key, false);
      }
      RefreshCommands();
    }

    protected void SetError(string error, [CallerMemberName] string key = "", bool refresh = true)
    {
      if (string.IsNullOrWhiteSpace(error))
      {
        mErrors.Remove(key);
      }
      else
      {
        mErrors[key] = error;
      }

      FirePropertyChanged(key);

      if (refresh)
      {
        RefreshCommands();
      }
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

    string IDataErrorInfo.Error
    {
      get { return mErrors.FirstOrDefault().Value ?? string.Empty; }
    }

    string IDataErrorInfo.this[string columnName]
    {
      get
      {
        string error;
        if (!mErrors.TryGetValue(columnName, out error))
        {
          error = string.Empty;
        }
        return error;
      }
    }
  }
}
