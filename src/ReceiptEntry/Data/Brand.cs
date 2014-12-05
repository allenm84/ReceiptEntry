﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Brand", Namespace = SaveFile.Namespace)]
  public class Brand : ExtensibleDataObject
  {
    [DataMember]
    public string ID { get; set; }
    [DataMember]
    public string Name { get; set; }
  }
}
