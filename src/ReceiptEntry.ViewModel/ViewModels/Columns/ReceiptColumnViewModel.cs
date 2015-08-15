using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class ReceiptColumnViewModel : BaseViewModel
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

    public ReceiptColumnType Type
    {
      get { return GetField<ReceiptColumnType>(); }
      set { SetField(value); }
    }

    internal ReceiptColumnViewModel(ReceiptColumn column)
      : this(column.ID, column.Name, column.Type)
    {

    }

    internal ReceiptColumnViewModel(string id, string name, ReceiptColumnType type)
    {
      ID = id;
      Name = name;
      Type = type;
      Accept();
    }

    internal ReceiptColumn ToColumn()
    {
      return new ReceiptColumn
      {
        ID = ID,
        Name = Name,
        Type = Type,
      };
    }
  }
}
