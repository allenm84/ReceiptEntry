using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Janus.Windows.Common;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public static class SystemManager
  {
    static VisualStyleManager visualStyleManager;
    static SystemManager()
    {
      visualStyleManager = new VisualStyleManager();

      var blueScheme = new JanusColorScheme("Office2007Blue");
      blueScheme.Office2007ColorScheme = Office2007ColorScheme.Blue;
      blueScheme.VisualStyle = VisualStyle.Office2007;
      visualStyleManager.ColorSchemes.Add(blueScheme);

      var silverScheme = new JanusColorScheme("Office2007Silver");
      silverScheme.Office2007ColorScheme = Office2007ColorScheme.Silver;
      silverScheme.VisualStyle = VisualStyle.Office2007;
      visualStyleManager.ColorSchemes.Add(silverScheme);

      visualStyleManager.DefaultColorScheme = "Office2007Silver";
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="window"></param>
    /// <returns></returns>
    public static bool Confirmed(IWin32Window window)
    {
      var result = MessageBox.Show(window, "Are you sure?", "Confirm",
        MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
      return result == DialogResult.OK;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="control"></param>
    public static void ApplyScheme(Control control)
    {
      // first, add the control to the sceme
      visualStyleManager.AddControl(control, true);

      // next, watch for controls being added and removed
      control.ControlAdded += new ControlEventHandler(control_ControlsChanged);
      control.ControlRemoved += new ControlEventHandler(control_ControlsChanged);
    }

    static void control_ControlsChanged(object sender, ControlEventArgs e)
    {
      visualStyleManager.AddControl((Control)sender, true);
    }
  }
}
