using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Drawing;

namespace ReceiptEntry
{
  [DataContract(Name = "Options", Namespace = SaveFile.Namespace)]
  public class Options : IExtensibleDataObject
  {
    public ExtensionDataObject ExtensionData { get; set; }

    [DataMember(Order = 0)]
    public Size MainWindowSize { get; set; }
  }
}
