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
using DevExpress.XtraEditors.Controls;
using DevExpress.Data;
using System.Linq.Expressions;
using System.Reflection;

namespace ReceiptEntry
{
  public static class Extensions
  {
    public static string Get<TSource, TType>(this Expression<Func<TSource, TType>> propertyLambda)
    {
      var info = GetPropertyInfo(propertyLambda);
      return info.Name;
    }

    public static PropertyInfo GetPropertyInfo<TSource, TType>(this Expression<Func<TSource, TType>> propertyLambda)
    {
      Expression body = propertyLambda;
      if (body is LambdaExpression)
      {
        body = ((LambdaExpression)body).Body;
      }

      MemberExpression me = null;
      switch (body.NodeType)
      {
        case ExpressionType.Convert:
        case ExpressionType.ConvertChecked:
          var ue = body as UnaryExpression;
          me = ((ue != null) ? ue.Operand : null) as MemberExpression;
          break;
        default:
          me = body as MemberExpression;
          break;
      }

      if (me != null)
      {
        return me.Member as PropertyInfo;
      }

      return null;
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

    public static void FillWithEnum<T>(this LookUpEdit lookUp, Func<T, string> getText = null)
    {
      lookUp.Properties.FillWithEnum(getText);
    }

    public static void FillWithEnum<T>(this RepositoryItemLookUpEdit lookUp, Func<T, string> getText = null)
    {
      if (getText == null)
      {
        getText = (x) => x.ToString();
      }

      var values = (T[])Enum.GetValues(typeof(T));
      lookUp.DataSource = values
        .Select(v => new { Value = v, Display = getText(v) })
        .ToArray();
      lookUp.DisplayMember = "Display";
      lookUp.ValueMember = "Value";
      lookUp.ShowHeader = false;
      lookUp.Columns.Add(new LookUpColumnInfo("Display")
      {
        Visible = true,
        SortOrder = ColumnSortOrder.Ascending
      });
    }
  }
}
