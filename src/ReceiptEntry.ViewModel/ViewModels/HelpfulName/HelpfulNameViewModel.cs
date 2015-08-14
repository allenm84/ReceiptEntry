using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class HelpfulNameViewModel : BaseViewModel
  {
    public string ID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    public string Name
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    internal HelpfulNameViewModel(HelpfulName name)
      : this(name.ID, name.Name)
    {

    }

    internal HelpfulNameViewModel(string id, string name)
    {
      ID = id;
      Name = name;
      Accept();
    }
  }
}
