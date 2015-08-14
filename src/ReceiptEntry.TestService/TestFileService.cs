using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;

namespace ReceiptEntry.Services
{
  public class TestFileService : ISaveFileService
  {
    static ulong sID = 0;
    static string ID
    {
      get { return string.Format("{0:D20}", sID++); }
    }

    static ReceiptColumnReference[] Build(ReceiptColumn[] columns, params int[] indices)
    {
      return indices
        .Select(i => new ReceiptColumnReference { ColumnID = columns[i].ID })
        .ToArray();
    }

    private SaveFile saveFile;

    public TestFileService()
    {
      saveFile = new SaveFile();
      
      saveFile.Columns = new ReceiptColumn[]
      {
        new ReceiptColumn{ ID = ID, Name = "Item", Type = ReceiptColumnType.Text },
        new ReceiptColumn{ ID = ID, Name = "Price", Type = ReceiptColumnType.Dollars },
        new ReceiptColumn{ ID = ID, Name = "Quantity", Type = ReceiptColumnType.Number },
        new ReceiptColumn{ ID = ID, Name = "Lbs", Type = ReceiptColumnType.Number },
        new ReceiptColumn{ ID = ID, Name = "Price/Lb", Type = ReceiptColumnType.Dollars },
        new ReceiptColumn{ ID = ID, Name = "Gallons", Type = ReceiptColumnType.Number },
        new ReceiptColumn{ ID = ID, Name = "Price/Gallon", Type = ReceiptColumnType.Dollars },
        new ReceiptColumn{ ID = ID, Name = "Code", Type = ReceiptColumnType.Text },
      };

      saveFile.Merchants = new Merchant[]
      {
        new Merchant{ ID = ID, Columns = Build(saveFile.Columns, 0, 7, 1, 2), Name = "Walmart" },
        new Merchant{ ID = ID, Columns = Build(saveFile.Columns, 0, 1, 2), Name = "Target" },
        new Merchant{ ID = ID, Columns = Build(saveFile.Columns, 5, 6), Name = "QwikPik" },
      };

      saveFile.Names = new HelpfulName[]
      {
        new HelpfulName{ ID = ID, Name = "Apple" },
      };

      saveFile.Receipts = new Receipt[0];
    }

    public SaveFile PullSaveFile()
    {
      return saveFile;
    }

    public void PushSaveFile(SaveFile file)
    {
      saveFile = file;
    }
  }
}
