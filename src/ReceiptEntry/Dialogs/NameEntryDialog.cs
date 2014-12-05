using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class NameEntryDialog : Form
  {
    private INameIDItem dataSource;

    public NameEntryDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
    }

    public void BindTo(INameIDItem item)
    {
      dataSource = item;
      editBox1.DataBindings.Add("Text", dataSource, "Name");
    }
  }
}
