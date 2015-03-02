using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReceiptEntry
{
  public partial class SearchOptionsDialog : BaseForm
  {
    public SearchOptionsDialog()
    {
      InitializeComponent();
    }

    public SearchOptions CreateOptions()
    {
      return new SearchOptions
      {
        IncludeSimilar = checkEdit1.Checked,
        SearchItemCode = checkEdit2.Checked,
        Text = txtSearchText.Text,
      };
    }
  }
}