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
  public class MerchantViewModel : BaseViewModel, IDeferNotifcation
  {
    private readonly HashSet<string> mColumnIDHashset;
    private ReceiptColumnReference[] mOriginalColumns;
    private bool mSuspendColumnChange = false;

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
        RefreshAccept();
      }
    }

    private readonly ReceiptColumnListViewModel mAllColumns;
    public BindingList<ReceiptColumnViewModel> Columns
    {
      get { return mAllColumns.Items; }
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

    private readonly DelegateCommand mMoveSelectedToCurrentCommand;
    public ICommand MoveSelectedToCurrentCommand
    {
      get { return mMoveSelectedToCurrentCommand; }
    }

    private readonly DelegateCommand mMoveSelectedToAvailableCommand;
    public ICommand MoveSelectedToAvailableCommand
    {
      get { return mMoveSelectedToAvailableCommand; }
    }

    private readonly DelegateCommand mUpdateCommand;
    public ICommand UpdateCommand
    {
      get { return mUpdateCommand; }
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

      var original = new List<ReceiptColumnReference>(columns ?? new ReceiptColumnReference[0]);
      if (!allColumns.Items.Any(c => c.Type == ReceiptColumnType.HelpfulName))
      {
        var helpfulNameColumn = allColumns.CreateItem();
        helpfulNameColumn.Type = ReceiptColumnType.HelpfulName;
        helpfulNameColumn.Name = "HN";
        allColumns.Items.Add(helpfulNameColumn);
      }

      if (!original.Any(o => allColumns.Fetch(f => f.ID == o.ColumnID).Type == ReceiptColumnType.HelpfulName))
      {
        var helpfulNameColumn = allColumns.Items.First(c => c.Type == ReceiptColumnType.HelpfulName);
        original.Add(new ReceiptColumnReference { ColumnID = helpfulNameColumn.ID });
      }

      mOriginalColumns = original.ToArray();

      mAllColumns = allColumns;
      mAllColumns.Items.ListChanged += allColumns_ListChanged;

      mAddAllColumnsCommand = new DelegateCommand(DoAddAllCommands, CanAddAllCommands);
      mRemoveAllColumnsCommand = new DelegateCommand(DoRemoveAllCommands, CanRemoveAllCommands);

      mMoveSelectedToCurrentCommand = new DelegateCommand(DoMoveSelectedToCurrent, CanMoveSelectedToCurrent);
      mMoveSelectedToAvailableCommand = new DelegateCommand(DoMoveSelectedToAvailable, CanMoveSelectedToAvailable);
      mUpdateCommand = new DelegateCommand(DoUpdate, CanUpdate);

      mColumnIDHashset = new HashSet<string>();
      mCurrentColumns = new BindingList<ReceiptColumnReferenceViewModel>();
      mAvailableColumns = new BindingList<ReceiptColumnReferenceViewModel>();

      ReadColumns();
      Accept();

      mCurrentColumns.ListChanged += mColumns_ListChanged;
      mAvailableColumns.ListChanged += mColumns_ListChanged;
    }

    private void AddColumn(ReceiptColumnViewModel column)
    {
      mColumnIDHashset.Add(column.ID);
      mAvailableColumns.Add(new ReceiptColumnReferenceViewModel(column.ID));
    }

    private void AddToCurrent(ReceiptColumnReferenceViewModel column)
    {
      column.Order = mCurrentColumns.Count + 1;
      mCurrentColumns.Add(column);
    }

    protected override bool CanDoAccept(object parameter)
    {
      return !string.IsNullOrWhiteSpace(Name) && mCurrentColumns.Count > 0;
    }

    private bool CanAddAllCommands(object parameter)
    {
      return mAvailableColumns.Count > 0;
    }

    private void DoAddAllCommands(object parameter)
    {
      using (new DeferNotifications(this))
      {
        for (int i = mAvailableColumns.Count - 1; i > -1; --i)
        {
          var column = mAvailableColumns[i];
          mAvailableColumns.RemoveAt(i);
          AddToCurrent(column);
        }
      }
    }

    private bool CanRemoveAllCommands(object parameter)
    {
      return mCurrentColumns.Count > 0;
    }

    private void DoRemoveAllCommands(object parameter)
    {
      using (new DeferNotifications(this))
      {
        for (int i = mCurrentColumns.Count - 1; i > -1; --i)
        {
          var column = mCurrentColumns[i];
          mCurrentColumns.RemoveAt(i);
          mAvailableColumns.Add(column);
        }
      }
    }

    private bool CanMoveSelectedToCurrent(object parameter)
    {
      return mAvailableColumns.Any(c => c.IsSelected);
    }

    private void DoMoveSelectedToCurrent(object parameter)
    {
      using (new DeferNotifications(this))
      {
        var selected = mAvailableColumns.Where(c => c.IsSelected).ToArray();
        foreach (var s in selected)
        {
          mAvailableColumns.Remove(s);
          s.IsSelected = false;
        }
        Array.ForEach(selected, AddToCurrent);
      }
    }

    private bool CanMoveSelectedToAvailable(object parameter)
    {
      return mCurrentColumns.Any(c => c.IsSelected);
    }

    private void DoMoveSelectedToAvailable(object parameter)
    {
      using (new DeferNotifications(this))
      {
        var selected = mCurrentColumns.Where(c => c.IsSelected).ToArray();
        foreach (var s in selected)
        {
          mCurrentColumns.Remove(s);
          s.IsSelected = false;
        }

        foreach (var s in selected)
        {
          mAvailableColumns.Add(s);
        }
      }
    }

    private bool CanUpdate(object parameter)
    {
      return mCurrentColumns.Count > 0;
    }

    private void DoUpdate(object parameter)
    {
      using (new DeferNotifications(this))
      {
        var columns = mCurrentColumns
          .OrderBy(a => a.Order)
          .ToArray();

        mCurrentColumns.Clear();
        for (int i = 0; i < columns.Length; ++i)
        {
          var column = columns[i];
          column.Order = i + 1;
          mCurrentColumns.Add(column);
        }
      }
    }

    private void FireColumnsChanged()
    {
      var changed = ColumnsChanged;
      if (changed != null)
      {
        changed(this, EventArgs.Empty);
      }

      RefreshAccept();
    }

    private void Refresh()
    {
      mAddAllColumnsCommand.FireCanExecuteChanged(this);
      mRemoveAllColumnsCommand.FireCanExecuteChanged(this);
      mMoveSelectedToCurrentCommand.FireCanExecuteChanged(this);
      mMoveSelectedToAvailableCommand.FireCanExecuteChanged(this);
      mUpdateCommand.FireCanExecuteChanged(this);
      FireColumnsChanged();
    }

    private void ReadColumns()
    {
      mColumnIDHashset.Clear();
      mCurrentColumns.Clear();
      mAvailableColumns.Clear();

      if (mOriginalColumns != null)
      {
        int order = 1;
        foreach (var c in mOriginalColumns)
        {
          if (mColumnIDHashset.Add(c.ColumnID))
          {
            var column = new ReceiptColumnReferenceViewModel(c);
            column.Order = (order++);
            mCurrentColumns.Add(column);
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
      return mAllColumns.CreateItem();
    }

    private void mColumns_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (mSuspendColumnChange)
      {
        return;
      }

      Refresh();
    }

    private void allColumns_ListChanged(object sender, ListChangedEventArgs e)
    {
      if (e.ListChangedType == ListChangedType.ItemAdded)
      {
        AddColumn(mAllColumns.Items[e.NewIndex]);
      }
    }

    void IDeferNotifcation.Begin()
    {
      mSuspendColumnChange = true;
    }

    void IDeferNotifcation.End()
    {
      mSuspendColumnChange = false;
      Refresh();
    }

    internal Merchant ToMerchant()
    {
      return new Merchant
      {
        Columns = mCurrentColumns.OrderBy(c => c.Order).Select(c => c.ToColumnReference()).ToArray(),
        ID = ID,
        Name = Name,
      };
    }
  }
}
