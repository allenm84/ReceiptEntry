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
    private readonly ReceiptColumnListViewModel mParent;

    public string ID
    {
      get { return GetField<string>(); }
      private set { SetField(value); }
    }

    public string Name
    {
      get { return GetField<string>(); }
      set
      {
        SetField(value);

        var name = this.Name;
        if (string.IsNullOrWhiteSpace(name))
        {
          SetError("Please enter a valid name for this column.");
        }
        else
        {
          var matches = mParent.Items
            .Where(i => i != this)
            .GroupBy(i => i.Name)
            .Where(g => g.Key == name)
            .Sum(g => g.Count());

          SetError(matches > 0
            ? string.Format("There is already a column with the name of {0}.", name)
            : "");
        }
      }
    }

    public ReceiptColumnType Type
    {
      get { return GetField<ReceiptColumnType>(); }
      set { SetField(value); }
    }

    internal ReceiptColumnViewModel(ReceiptColumnListViewModel parent, ReceiptColumn column)
      : this(parent, column.ID, column.Name, column.Type)
    {

    }

    internal ReceiptColumnViewModel(ReceiptColumnListViewModel parent, string id, string name, ReceiptColumnType type)
    {
      mParent = parent;

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

    protected override bool InternalCanDoAccept(object parameter)
    {
      return !string.IsNullOrWhiteSpace(Name);
    }
  }
}
