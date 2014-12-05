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
  public partial class SearchResultDialog : Form
  {
    public SearchResultDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
    }

    public void Open(SearchResult result, IWin32Window owner = null)
    {
      Text = result.Name;

      lblAverage.Text = string.Format("{0:c2}", result.Average);
      lblCount.Text=string.Format("{0}", result.Count);
      lblMaximum.Text = string.Format("{0:c2}", result.Max);
      lblMinimum.Text = string.Format("{0:c2}", result.Min);
      lblTotal.Text = string.Format("{0:c2}", result.Total);

      gridLinks.DataSource = new List<ReceiptLink>(result.Links);
      ShowDialog(owner);
    }

    private void SearchResultDialog_Load(object sender, EventArgs e)
    {
      gridLinks.SetPropertiesToList(false, false);
      gridLinks.RetrieveStructure();
      gridLinks.RootTable.Columns.HideAllExcept("Merchant", "Date");
      gridLinks.RootTable.Columns.LockColumnWidth("Date", 80);
      gridLinks.RootTable.SortKeys.Add("Merchant");
      gridLinks.RootTable.SortKeys.Add("Date");
    }
  }
}
