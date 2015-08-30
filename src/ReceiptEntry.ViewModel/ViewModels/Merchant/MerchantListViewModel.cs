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
  public class MerchantListViewModel : BaseListViewModel<MerchantViewModel>
  {
    private readonly ParameterDelegateCommand<MergeMerchantsParameter> mMergeMerchantsCommand;
    public ICommand MergeMerchantsCommand
    {
      get { return mMergeMerchantsCommand; }
    }

    internal MerchantListViewModel(SaveFileViewModel parent, IEnumerable<Merchant> merchants)
      : base(parent)
    {
      mMergeMerchantsCommand = new ParameterDelegateCommand<MergeMerchantsParameter>(DoMergeMerchants);

      foreach (var merchant in merchants)
      {
        mItems.Add(new MerchantViewModel(merchant, parent.Columns));
      }

      Accept();
    }

    private void DoMergeMerchants(MergeMerchantsParameter parameter)
    {
      // create the merged merchant
      var merged = CreateItem();
      merged.Name = parameter.Name;
      merged.UnselectAvailableColumns();

      // create a distinct set of column ids that exist in all the merchants
      var currentColumns = parameter.Merchants
        .SelectMany(m => m.CurrentColumns.Select(c => c.ColumnID))
        .Distinct();

      // move each of the columns that we need from available to current for the
      // merged merchant
      var availableColumns = merged.AvailableColumns.ToDictionary(c => c.ColumnID);
      foreach (var id in currentColumns)
      {
        var available = availableColumns[id];
        available.IsSelected = true;
      }
      availableColumns.Clear();
      merged.MoveSelectedToCurrentCommand.Execute(null);

      // create a list of all the receipts to replace
      var receipts = new List<ReceiptViewModel>();

      // replace the old merchants with the new merchants
      foreach (var m in parameter.Merchants)
      {
        mItems.Remove(m);
        foreach (var r in mParent.Receipts.Items)
        {
          // skip all the receipts that aren't valid
          if (r.MerchantID != m.ID)
          {
            continue;
          }

          // replace the merchant
          receipts.Add(r);
        }
      }

      // add the merchant to the list
      mItems.Add(merged);

      // replace the merchnat
      receipts.ForEach(r => r.MerchantID = merged.ID);

      // accept the changes
      merged.AcceptCommand.Execute(null);
    }

    public override MerchantViewModel CreateItem()
    {
      return new MerchantViewModel(ID.Next, "<New Merchant>", null, mParent.Columns);
    }

    public MerchantViewModel Fetch(string id)
    {
      return base.Fetch(v => v.ID == id);
    }
  }
}
