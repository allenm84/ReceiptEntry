using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.Services
{
  public class DataContractService : ISaveFileService
  {
    private readonly DataContractFile<SaveFile> dcf;

    public DataContractService(string filepath)
    {
      dcf = new DataContractFile<SaveFile>(filepath);
    }

    public SaveFile PullSaveFile()
    {
      SaveFile file;
      dcf.TryRead(out file);
      if (file == null)
      {
        file = new SaveFile
        {
          Columns = new ReceiptColumn[0],
          Merchants = new Merchant[0],
          Names = new HelpfulName[0],
          Receipts = new Receipt[0],
        };
      }
      return file;
    }

    public void PushSaveFile(SaveFile file)
    {
      dcf.TryWrite(file);
    }
  }
}
