using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.Tools
{
  public static class Expressions
  {
    public static string NameOf<TSource, TType>(this Expression<Func<TSource, TType>> propertyLambda)
    {
      return info(propertyLambda).Name;
    }

    public static PropertyInfo info<TSource, TType>(this Expression<Func<TSource, TType>> propertyLambda)
    {
      if (propertyLambda == null)
        throw new ArgumentNullException("propertyLambda");

      var body = propertyLambda.Body;

      // make sure that we're actually accessing a property
      var member = body as MemberExpression;
      if (member == null)
        throw new ArgumentException(String.Format("Expression '{0}' refers to a method, not a property.",
          propertyLambda.ToString()));

      // and that its actually a property
      var propInfo = member.Member as PropertyInfo;
      if (propInfo == null)
        throw new ArgumentException(String.Format("Expression '{0}' refers to a field, not a property.",
          propertyLambda.ToString()));

      return propInfo;
    }
  }

}
