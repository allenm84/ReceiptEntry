using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  [DataContract(Name = "Unit", Namespace = SaveFile.Namespace)]
  public enum Unit
  {
    [EnumMember]
    Slice,
    [EnumMember]
    Unit,
    [EnumMember]
    Teaspoon,
    [EnumMember]
    Tablespoon,
    [EnumMember]
    FluidOunce,
    [EnumMember]
    Gill,
    [EnumMember]
    Cup,
    [EnumMember]
    Pint,
    [EnumMember]
    Quart,
    [EnumMember]
    Gallon,
    [EnumMember]
    Milliliter,
    [EnumMember]
    Liter,
    [EnumMember]
    Deciliter,
    [EnumMember]
    Pound,
    [EnumMember]
    Ounce,
    [EnumMember]
    Microgram,
    [EnumMember]
    Milligram,
    [EnumMember]
    Gram,
    [EnumMember]
    Kilogram,
  }
}
