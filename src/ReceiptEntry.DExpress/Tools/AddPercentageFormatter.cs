using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiptEntry.DExpress
{
  public class AddPercentageFormatter : IFormatProvider, ICustomFormatter
  {
    object IFormatProvider.GetFormat(Type formatType)
    {
      if (formatType == typeof(ICustomFormatter))
      {
        return this;
      }
      return null;
    }

    string ICustomFormatter.Format(string format, object arg, IFormatProvider formatProvider)
    {
      if (arg == null) throw new ArgumentNullException("arg");
      return string.Format("{0}%", arg);
    }
  }
}
