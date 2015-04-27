using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Threading;

namespace ReceiptEntry
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
      Application.ThreadException += Application_ThreadException;

      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      SkinManager.EnableFormSkins();
      SkinManager.Default.RegisterAssembly(typeof(Office2010BlackBlue).Assembly);
      UserLookAndFeel.Default.SetSkinStyle("Office2010BlackBlue");

      using (var form = new MainForm())
      {
        Application.Run(form);
      }
    }

    static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
    {
      MessageBox.Show(e.Exception.ToString());
    }
  }
}
