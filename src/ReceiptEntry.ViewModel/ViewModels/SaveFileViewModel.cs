using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.ViewModel
{
  public class SaveFileViewModel : BaseNotifyPropertyChanged
  {
    private readonly ISaveFileService mService;

    private readonly ReceiptColumnListViewModel mColumns;
    public ReceiptColumnListViewModel Columns
    {
      get { return mColumns; }
    }

    private readonly MerchantListViewModel mMerchants;
    public MerchantListViewModel Merchants
    {
      get { return mMerchants; }
    }

    public SaveFileViewModel(ISaveFileService service)
    {
      mService = service;

      var saveFile = service.PullSaveFile();

      mColumns = new ReceiptColumnListViewModel(this, saveFile.Columns);
      mMerchants = new MerchantListViewModel(this, saveFile.Merchants);
    }
  }
}
