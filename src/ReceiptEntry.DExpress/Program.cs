using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Drawing;

namespace ReceiptEntry.DExpress
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

      BonusSkins.Register();
      SkinManager.EnableFormSkins();
      SkinManager.Default.RegisterAssembly(typeof(Office2010BlackBlue).Assembly);
      UserLookAndFeel.Default.SetSkinStyle("Office2010BlackBlue");

      Skin skin = TabSkins.GetSkin(UserLookAndFeel.Default.ActiveLookAndFeel);
      SkinElement element = skin[TabSkins.SkinTabPane];
      element.Color.SolidImageCenterColor = SystemColors.Control;

      Application.Run(new MainForm());
    }
  }
}
