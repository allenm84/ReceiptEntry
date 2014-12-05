using DevExpress.Utils.Win;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Editors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry
{
  public static class Extensions
  {
    static Dictionary<Type, DataContractSerializer> serializers = new Dictionary<Type, DataContractSerializer>();

    public static string GetSearchText(this SearchLookUpEdit search)
    {
      PopupSearchLookUpEditForm f = (search as IPopupControl).PopupWindow as PopupSearchLookUpEditForm;
      SearchEditLookUpPopup popup = f.ActiveControl as SearchEditLookUpPopup;
      return popup.FindText;
    }

    public static T Duplicate<T>(this T value) where T : class
    {
      Type key = typeof(T);
      DataContractSerializer dcs;
      if (!serializers.TryGetValue(key, out dcs))
      {
        dcs = new DataContractSerializer(key);
        serializers[key] = dcs;
      }

      using (var stream = new MemoryStream())
      {
        dcs.WriteObject(stream, value);
        stream.Position = 0;
        return dcs.ReadObject(stream) as T;
      }
    }
  }
}
