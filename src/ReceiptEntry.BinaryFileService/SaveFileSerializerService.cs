using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReceiptEntry.Model;
using ReceiptEntry.Tools;

namespace ReceiptEntry.Services
{
  public sealed class SaveFileSerializerService : ISaveFileService
  {
    private readonly SaveFileSerializer mSerializer;
    private readonly string mFilepath;

    public SaveFileSerializerService(string filepath)
    {
      mFilepath = filepath;
      mSerializer = new SaveFileSerializer();
    }

    public SaveFile PullSaveFile()
    {
      using (var stream = File.OpenRead(mFilepath))
      {
        return mSerializer.Read(stream);
      }
    }

    public void PushSaveFile(SaveFile file)
    {
      using (var stream = File.Create(mFilepath))
      {
        mSerializer.Write(stream, file);
      }
    }
  }
}
