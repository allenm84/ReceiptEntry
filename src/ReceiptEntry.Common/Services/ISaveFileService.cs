using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  public interface ISaveFileService
  {
    SaveFile PullSaveFile();
    void PushSaveFile(SaveFile file);
  }
}
