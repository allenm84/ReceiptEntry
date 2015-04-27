using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraLayout.Utils;
using Shopping;

namespace ReceiptEntry
{
  public partial class SearchResultsDialog : BaseForm
  {
    static ulong searchID = 0;

    private class TextScore
    {
      public string Text { get; set; }
      public double Score { get; set; }
      public ReceiptItem Item { get; set; }
    }

    private readonly string searchResultID;
    private readonly SearchOptions options;
    private readonly Receipt[] pool;
    private bool cancelSearch = false;

    public SearchResultsDialog(SearchOptions options, IEnumerable<Receipt> pool, object merchantSource, object receiptSource)
    {
      this.searchResultID = (searchID++).ToString();

      this.options = options;
      this.pool = pool.ToArray();

      InitializeComponent();
      receiptGridControl1.Bind(merchantSource, receiptSource);
      receiptGridControl1.SearchResultID = searchResultID;

      BeginSearch(new Progress<Receipt>(AddResult));
    }

    private void SetIsWorking(bool working)
    {
      UseWaitCursor = working;
      layoutControlItem1.Visibility = working
        ? LayoutVisibility.Always
        : LayoutVisibility.Never;
    }

    private async void BeginSearch(IProgress<Receipt> progress)
    {
      receiptGridControl1.BeginDataUpdate();

      SetIsWorking(true);
      await Task.Run(() =>
      {
        foreach (var r in pool)
        {
          if (cancelSearch)
          {
            break;
          }

          if (IsMatch(r))
          {
            progress.Report(r);
            Application.DoEvents();
          }
        }
      });

      receiptGridControl1.EndDataUpdate();

      if (cancelSearch)
      {
        return;
      }

      int count = receiptGridControl1.ReceiptSource.Count;
      Text = string.Format("Found {0} receipt{1} matching '{2}'", count, count == 1 ? "" : "s", options.Text);
      SetIsWorking(false);
    }

    private void AddResult(Receipt r)
    {
      if (IsDisposed || Disposing)
        return;

      receiptGridControl1.ReceiptSource.Add(r);
    }

    private TextScore CreateCandidate(string pattern, string input, ReceiptItem item)
    {
      return new TextScore
      {
        Score = Levenshtein.Distance(pattern, input),
        Text = input,
        Item = item,
      };
    }

    private bool IsMatch(Receipt receipt)
    {
      string text = options.Text;
      var candidates = new List<TextScore>();

      foreach (var item in receipt.Items)
      {
        candidates.Add(CreateCandidate(text, item.Name ?? "", item));

        var shoppingListItem = ShoppingListAccessor.GetItem(item.ShoppingListItemID);
        if (shoppingListItem != null)
        {
          candidates.Add(CreateCandidate(text, shoppingListItem.Name, item));
        }

        if (options.SearchItemCode && !string.IsNullOrWhiteSpace(item.Code))
        {
          candidates.Add(CreateCandidate(text, item.Code, item));
        }
      }

      double max = candidates.Max(t => t.Score);
      foreach (var candidate in candidates)
      {
        candidate.Score = 1.0 - (candidate.Score / max);
      }

      foreach (var candidate in candidates)
      {
        if (options.IncludeExact)
        {
          if (string.Equals(candidate.Text, text, StringComparison.InvariantCultureIgnoreCase))
          {
            candidate.Item.SearchIDs.Add(searchResultID);
            return true;
          }
        }
        else
        {
          if (
            candidate.Text.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1 ||
            text.IndexOf(candidate.Text, StringComparison.InvariantCultureIgnoreCase) > -1)
          {
            candidate.Item.SearchIDs.Add(searchResultID);
            return true;
          }

          if (options.IncludeSimilar && candidate.Score > 0.85)
          {
            candidate.Item.SearchIDs.Add(searchResultID);
            return true;
          }
        }
      }

      return false;
    }

    protected override void OnFormClosed(FormClosedEventArgs e)
    {
      cancelSearch = true;
      base.OnFormClosed(e);
    }

    public static void Run(Form owner, SearchOptions options, IEnumerable<Receipt> pool, object merchantSource, object receiptSource)
    {
      var dlg = new SearchResultsDialog(options, pool, merchantSource, receiptSource);
      dlg.Text = "Search Results";
      dlg.StartPosition = FormStartPosition.Manual;
      dlg.Location = new Point(owner.Location.X + (owner.Width - dlg.Width) / 2, owner.Location.Y + (owner.Height - dlg.Height) / 2);
      dlg.Show(owner);
    }
  }
}
