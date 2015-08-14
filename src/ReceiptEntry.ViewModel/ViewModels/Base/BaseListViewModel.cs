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
    protected readonly SaveFileViewModel mParent;
    internal SaveFileViewModel Parent
    {
      get { return mParent; }
    }

    protected readonly BindingList<T> mItems = new BindingList<T>();
    public BindingList<T> Items
    {
      get { return mItems; }
    }

    protected T[] mCommittedItems;

    public BaseListViewModel(SaveFileViewModel parent)
    {
      mParent = parent;
    }

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

    internal T Fetch(Func<T, bool> predicate)
    {
      return mItems.SingleOrDefault(predicate);
    }

    public abstract T CreateItem();
  }
}
