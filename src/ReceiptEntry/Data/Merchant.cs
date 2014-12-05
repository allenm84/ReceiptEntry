﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Merchant", Namespace = SaveFile.Namespace)]
  public class Merchant : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
    [DataMember]
    public bool IsGrocery { get; set; }
  }
}
