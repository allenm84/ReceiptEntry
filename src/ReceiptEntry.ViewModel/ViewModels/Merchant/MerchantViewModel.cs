using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class MerchantViewModel : BaseViewModel
  {
    private readonly HashSet<string> mColumnIDHashset;
    private ReceiptColumnReference[] mOriginalColumns;

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

    private readonly ReceiptColumnListViewModel mAllColumns;
    public BindingList<ReceiptColumnViewModel> Columns
    {
      get { return mAllColumns.Columns; }
    }

    private readonly BindingList<ReceiptColumnReferenceViewModel> mAvailableColumns;
    public BindingList<ReceiptColumnReferenceViewModel> AvailableColumns
    {
      get { return mAvailableColumns; }
    }

    private readonly BindingList<ReceiptColumnReferenceViewModel> mCurrentColumns;
    public BindingList<ReceiptColumnReferenceViewModel> CurrentColumns
    {
      get { return mCurrentColumns; }
    }

    private readonly DelegateCommand mAddAllColumnsCommand;
    public ICommand AddAllColumnsCommand
    {
      get { return mAddAllColumnsCommand; }
    }

    private readonly DelegateCommand mRemoveAllColumnsCommand;
    public ICommand RemoveAllColumnsCommand
    {
      get { return mRemoveAllColumnsCommand; }
    }

    public event EventHandler ColumnsChanged;

    internal MerchantViewModel(Merchant merchant, ReceiptColumnListViewModel allColumns)
      : this(merchant.ID, merchant.Name, merchant.Columns, allColumns)
    {

    }

    internal MerchantViewModel(string id, string name, ReceiptColumnReference[] columns, ReceiptColumnListViewModel allColumns)
    {
      ID = id;
      Name = name;

      mOriginalColumns = columns;
      mAllColumns = allColumns;

      mAddAllColumnsCommand = new DelegateCommand(DoAddAllCommands, CanAddAllCommands);
      mRemoveAllColumnsCommand = new DelegateCommand(DoRemoveAllCommands, CanRemoveAllCommands);

      mColumnIDHashset = new HashSet<string>();
      mCurrentColumns = new BindingList<ReceiptColumnReferenceViewModel>();
      mAvailableColumns = new BindingList<ReceiptColumnReferenceViewModel>();

      ReadColumns();
      Accept();
    }

    private bool CanAddAllCommands(object parameter)
    {
      return mAvailableColumns.Count > 0;
    }

    private void DoAddAllCommands(object parameter)
    {
      for (int i = mAvailableColumns.Count - 1; i > -1; --i)
      {
        var column = mAvailableColumns[i];
        mAvailableColumns.RemoveAt(i);
        mCurrentColumns.Add(column);
      }
      Refresh();
    }

    private bool CanRemoveAllCommands(object parameter)
    {
      return mCurrentColumns.Count > 0;
    }

    private void DoRemoveAllCommands(object parameter)
    {
      for (int i = mCurrentColumns.Count - 1; i > -1; --i)
      {
        var column = mCurrentColumns[i];
        mCurrentColumns.RemoveAt(i);
        mAvailableColumns.Add(column);
      }
      Refresh();
    }

    private void FireColumnsChanged()
    {
      var changed = ColumnsChanged;
      if (changed != null)
      {
        changed(this, EventArgs.Empty);
      }
    }

    private void Refresh()
    {
      mAddAllColumnsCommand.FireCanExecuteChanged(this);
      mRemoveAllColumnsCommand.FireCanExecuteChanged(this);
      FireColumnsChanged();
    }

    private void ReadColumns()
    {
      mColumnIDHashset.Clear();
      mCurrentColumns.Clear();
      mAvailableColumns.Clear();

      if (mOriginalColumns != null)
      {
        foreach (var c in mOriginalColumns)
        {
          if (mColumnIDHashset.Add(c.ColumnID))
          {
            mCurrentColumns.Add(new ReceiptColumnReferenceViewModel(c));
          }
        }
      }

      foreach (var column in Columns)
      {
        if (mColumnIDHashset.Add(column.ID))
        {
          mAvailableColumns.Add(new ReceiptColumnReferenceViewModel(column.ID));
        }
      }
    }

    protected override void Commit()
    {
      mOriginalColumns = mCurrentColumns
        .Select(c => c.ToColumnReference())
        .ToArray();
      base.Commit();
    }

    protected override void Rollback()
    {
      ReadColumns();
      base.Rollback();
    }

    public ReceiptColumnViewModel CreateColumn()
    {
      return mAllColumns.CreateColumn();
    }

    public void AddColumn(ReceiptColumnViewModel column)
    {
      mAllColumns.Columns.Add(column);
      mColumnIDHashset.Add(column.ID);
      mAvailableColumns.Add(new ReceiptColumnReferenceViewModel(column.ID));
      Refresh();
    }
  }
}
