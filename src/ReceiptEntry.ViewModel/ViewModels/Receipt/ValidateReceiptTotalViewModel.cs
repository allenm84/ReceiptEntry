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
  public class ValidateReceiptTotalViewModel : BaseViewModel
  {
    private readonly ReceiptViewModel mParent;

    public ReceiptColumnViewModel[] Columns
    {
      get
      {
        return mParent.Parent.Columns.Items
          .Where(c => c.Type == ReceiptColumnType.Dollars)
          .Where(c => mParent.Columns.Any(r => r.ColumnID == c.ID))
          .ToArray();
      }
    }

    public string SelectedColumnID
    {
      get { return GetField<string>(); }
      set { SetField(value); }
    }

    public decimal ExpectedTotal
    {
      get { return mParent.Total; }
      private set { FirePropertyChanged(); }
    }

    public decimal ActualTotal
    {
      get { return GetField<decimal>(); }
      private set { SetField(value); }
    }

    private readonly DelegateCommand mValidateCommand;
    public ICommand ValidateCommand
    {
      get { return mValidateCommand; }
    }

    internal ValidateReceiptTotalViewModel(ReceiptViewModel parent)
    {
      mParent = parent;
      parent.PropertyChanged += parent_PropertyChanged;
      mValidateCommand = new DelegateCommand(DoValidate, CanValidate);
    }

    private bool CanValidate(object parameter)
    {
      return !string.IsNullOrWhiteSpace(SelectedColumnID);
    }

    private void DoValidate(object parameter)
    {
      ActualTotal =
        mParent.Items.Sum(i => (decimal)i[SelectedColumnID]) +
        mParent.Taxes.Sum(t => t.Amount);
    }

    private void parent_PropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      ExpectedTotal = 0;
    }
  }
}
