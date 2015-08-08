using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.ViewModel
{
  public abstract class BaseListViewModel<T> : BaseViewModel where T : BaseViewModel
  {
    protected readonly BindingList<T> mItems = new BindingList<T>();
    public BindingList<T> Items
    {
      get { return mItems; }
    }

    protected T[] mCommittedItems;

    protected override void Commit()
    {
      mCommittedItems = mItems.ToArray();
      base.Commit();
    }

    protected override void Rollback()
    {
      if (mCommittedItems != null)
      {
        mItems.Clear();
        foreach (var item in mCommittedItems)
        {
          mItems.Add(item);
        }
      }
      base.Rollback();
    }

    public abstract T CreateItem();
  }
}
