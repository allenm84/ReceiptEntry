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

    private readonly MerchantListViewModel mMerchants;
    public MerchantListViewModel Merchants
    {
      get { return mMerchants; }
    }

    public SaveFileViewModel(ISaveFileService service)
    {
      mService = service;

      var saveFile = service.PullSaveFile();
      mMerchants = new MerchantListViewModel(this, saveFile.Merchants);
    }
  }
}
