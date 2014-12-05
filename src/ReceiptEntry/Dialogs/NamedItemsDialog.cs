using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReceiptEntry
{
  public partial class NamedItemsDialog : BaseForm
  {
    public NamedItemsDialog(IList<NamedItem> items)
    {
      InitializeComponent();
      namedItemSource.DataSource = items;
      brandSource.DataSource = SaveFile.Brands;
      RefreshCategories();
    }

    private void RefreshCategories()
    {
      gridView1.BeginDataUpdate();
      categoryPathSource.DataSource = Categories.Paths.ToList();
      gridView1.EndDataUpdate();
    }
  }
}
