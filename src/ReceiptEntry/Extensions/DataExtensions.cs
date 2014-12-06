using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class DataExtensions
  {
    static readonly Dictionary<ReceiptItemProperty, string> propertyDisplayText;
    static DataExtensions()
    {
      propertyDisplayText = new Dictionary<ReceiptItemProperty, string>();
      propertyDisplayText[ReceiptItemProperty.Code] = "Code";
      propertyDisplayText[ReceiptItemProperty.Name] = "Name";
      propertyDisplayText[ReceiptItemProperty.Price] = "Price";
      propertyDisplayText[ReceiptItemProperty.Quantity] = "Quantity";
      propertyDisplayText[ReceiptItemProperty.ShoppingListItemID] = "Shopping List Item";
    }

    public static string GetDisplay(this ReceiptItemProperty property)
    {
      return propertyDisplayText[property];
    }

    public static T Duplicate<T>(this T item) where T : ExtensibleDataObject
    {
      var dcs = new DataContractSerializer(typeof(T));
      using (var stream = new MemoryStream())
      {
        dcs.WriteObject(stream, item);
        stream.Position = 0;
        return dcs.ReadObject(stream) as T;
      }
    }
  }
}
