﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Model
{
  [DataContract(Name = "SaveFile", Namespace = SaveFile.Namespace)]
  public class ReceiptItemName : BaseIDName
  {
    [DataMember(Order = 0)]
    public string Alias { get; set; }
  }
}
