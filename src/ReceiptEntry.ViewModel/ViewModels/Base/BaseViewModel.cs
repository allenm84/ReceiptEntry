using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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

    protected virtual bool CanDoAccept(object parameter)
    {
      return true;
    }

    private void DoAccept(object parameter)
    {
      Accept();
    }

    protected void Accept()
    {
      mAccepted = mFields.ToDictionary(k => k.Key, v => DeepCopy(v.Value));
      Commit();
    }

    protected virtual void Commit()
    {
      
    }

    protected virtual bool CanDoReject(object parameter)
    {
      return true;
    }

    private void DoReject(object parameter)
    {
      Reject();
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

    protected void Push(Dictionary<string, object> values)
    {
      foreach (var kvp in values)
      {
        PushValue(kvp.Key, kvp.Value);
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
  }
}
