using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Janus.Windows.Common;
using System.IO;

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
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      SingleInstanceApplicationController.Run(new MainForm());
    }
  }
}
