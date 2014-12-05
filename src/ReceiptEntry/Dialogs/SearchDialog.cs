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
  public partial class SearchDialog : Form, IDoWorkView
  {
    private DoWorkController mController;

    public SearchDialog()
    {
      InitializeComponent();
      mController = new DoWorkController(this);
      SystemManager.ApplyScheme(this);
    }

    #region IDoWorkView Members

    public void ShowError(string text)
    {
      MessageBox.Show(this, text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }

    public void SetIsWorking(bool working)
    {
      Cursor = working ? Cursors.WaitCursor : Cursors.Default;
      tableLayoutPanel1.Enabled = !working;
      progStatus.Visible = working;
    }

    #endregion

    private void DoSearch()
    {
      if (string.IsNullOrEmpty(txtSearch.Text))
      {
        MessageBox.Show(this, "Please enter in the text to search for.", "Search", 
          MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }

      mController.StartWorker(DoSearchWork, DoSearchRunWorkerCompleted,
        new { Text = txtSearch.Text });
    }

    private void DoSearchWork(DoWorkInput input)
    {
      // get the search text that the user entered
      dynamic arg = input.Argument;
      string text = arg.Text;

      // create the search results list
      var results = new List<SearchResult>();
      input.Result = results;

      // create an inline function to add a result
      Func<SearchResultType, SearchResult> create =
        (t) => new SearchResult { Type = t };

      // group by the item ids to avoid duplicates
      var groups = from link in
                     from receipt in SaveFile.Instance.Receipts
                     from item in receipt.Items
                     select new ReceiptLink(item, receipt)
                   group link by link.ItemID into itemGroup
                   select itemGroup;

      // go through all the groups
      foreach (var value in groups)
      {
        // find the matching named item
        var item = Common.GetNamedItem(value.Key);

        // create a null search result
        SearchResult result = null;

        // does this named item match?
        if (string.Equals(item.Name, text, StringComparison.InvariantCultureIgnoreCase))
        {
          result = create(SearchResultType.Exact);
        }
        else if (item.Name.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1)
        {
          result = create(SearchResultType.Close);
        }
        else if (Levenshtein.Percentage(item.Name, text) > 0.4)
        {
          result = create(SearchResultType.Similar);
        }

        // if the result is not null, then add it
        if (result != null)
        {
          result.Count = value.Count();
          result.Min = value.Min(v => decimal.Divide(v.Price, v.Quantity));
          result.Average = value.Average(v => decimal.Divide(v.Price, v.Quantity));
          result.Max = value.Max(v => decimal.Divide(v.Price, v.Quantity));
          result.Total = value.Sum(v => v.Price);
          result.Name = item.Name;
          result.Links = value.ToArray();
          results.Add(result);
        }
      }

      // if there aren't any results, then add one
      if (results.Count == 0)
      {
        results.Add(new SearchResult { Name = "Nothing", Type = SearchResultType.No });
      }
    }

    private void DoSearchRunWorkerCompleted(DoWorkOutput output)
    {
      gridSearchResults.DataSource = output.GetResult<List<SearchResult>>();
      gridSearchResults.Refetch();
    }

    private void DoShowResult(SearchResult result)
    {
      using (SearchResultDialog dlg = new SearchResultDialog())
      {
        dlg.Open(result, this);
      }
    }

    private void SearchDialog_Load(object sender, EventArgs e)
    {
      gridSearchResults.SetPropertiesToList(false, false);
      gridSearchResults.DataSource = new List<SearchResult>();
      gridSearchResults.RetrieveStructure();
      gridSearchResults.RootTable.Columns.HideAllExcept("Name");

      var grpType = gridSearchResults.RootTable.Groups.Add("Type");
      grpType.GroupPrefix = "";
      grpType.GroupFormatString = "{0} matches";
      grpType.GroupFormatMode = Janus.Windows.GridEX.FormatMode.UseStringFormat;
    }

    private void txtSearch_KeyPress(object sender, KeyPressEventArgs e)
    {
      if (e.KeyChar == (char)13)
      {
        DoSearch();
        e.Handled = true;
      }
    }

    private void txtSearch_ButtonClick(object sender, EventArgs e)
    {
      DoSearch();
    }

    private void chkHideSimilar_CheckedChanged(object sender, EventArgs e)
    {
      if (chkHideSimilar.Checked)
      {
        gridSearchResults.ApplyFilter("Type",
          Janus.Windows.GridEX.ConditionOperator.NotEqual,
          SearchResultType.Similar);
      }
      else
      {
        gridSearchResults.RemoveFilters();
      }
    }

    private void gridSearchResults_RowDoubleClick(object sender, Janus.Windows.GridEX.RowActionEventArgs e)
    {
      if (e.Row == null) return;
      if (e.Row.RowType != Janus.Windows.GridEX.RowType.Record) return;

      var result = e.Row.DataRow as SearchResult;
      if (result == null) return;

      if (result.Type == SearchResultType.No) return;
      DoShowResult(result);
    }
  }
}
