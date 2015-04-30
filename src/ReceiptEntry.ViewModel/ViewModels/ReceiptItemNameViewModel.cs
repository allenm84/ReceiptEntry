using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptItemNameViewModel : NotifyPropertyChanged
  {
    private readonly ReceiptItemName name;

    internal ReceiptItemNameViewModel()
      : this(new ReceiptItemName { ID = IDg.Next })
    {

    }

    internal ReceiptItemNameViewModel(ReceiptItemName name)
    {
      this.name = name;
      Read(false);
    }

    private void Read(bool notify)
    {
      if (!notify)
      {
        SuspendNotifications();
      }

      ID = name.ID;
      Name = name.Name;
      Alias = name.Alias;

      if (!notify)
      {
        ResumeNotifications();
      }
    }

    private string mID;
    internal string ID
    {
      get { return mID; }
      set
      {
        mID = value;
        FirePropertyChanged();
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
      }
    }
  }
}
