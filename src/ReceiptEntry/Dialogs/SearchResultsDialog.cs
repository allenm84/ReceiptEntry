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
    private class TextScore
    {
      public string Text { get; set; }
      public double Score { get; set; }
    }

    private readonly IReceiptDisplay display;
    private readonly SearchOptions options;

    private int currentIndex = 0;
    private Receipt[] receipts = null;

    private int previousResultIndex = -1;
    private int resultIndex = 0;
    private List<Receipt> results = new List<Receipt>();

    public SearchResultsDialog(SearchOptions options, IReceiptDisplay display)
    {
      this.options = options;
      this.display = display;
      this.receipts = display.Receipts.ToArray();
      InitializeComponent();
      NextResultAsync();
    }

    private void LoadResult(Receipt r)
    {
      display.SelectReceipt(r);
      UpdateButtons();
    }

    private void UpdateButtons()
    {
      btnNext.Enabled = (resultIndex < (results.Count - 1)) || (currentIndex < receipts.Length);
      btnPrevious.Enabled = resultIndex > 0;
    }

    private async void NextResultAsync()
    {
      await Task.Yield();
      NextResult();
    }

    private void NextResult()
    {
      if (resultIndex < results.Count)
      {
        LoadResult(results[resultIndex++]);
      }
      else
      {
        bool found = false;
        for (; !found && currentIndex < receipts.Length; ++currentIndex)
        {
          found = IsMatch(receipts[currentIndex]);
        }

        if (found)
        {
          var r = receipts[currentIndex];
          previousResultIndex = results.Count;
          results.Add(r);
          LoadResult(r);
          resultIndex = results.Count;
        }
        else
        {
          if (results.Count == 0)
          {
            MessageHelper.Inform(this, "No results found!");
            Close();
          }
          else
          {
            MessageHelper.Inform(this, "Reached the end of the receipts. You can hit Back/Next to cycle through the results.");
          }
        }
      }
    }

    private void PreviousResult()
    {
      if (resultIndex == results.Count)
      {
        resultIndex = previousResultIndex;
      }
      else
      {
        --resultIndex;
      }

      resultIndex = Math.Max(-1, resultIndex);

      if (resultIndex > -1)
      {
        LoadResult(results[resultIndex]);
      }
    }

    private TextScore CreateCandidate(string pattern, string input)
    {
      return new TextScore
      {
        Score = Levenshtein.Distance(pattern, input),
        Text = input,
      };
    }

    private bool IsMatch(Receipt receipt)
    {
      string text = options.Text;
      var candidates = new List<TextScore>();

      foreach (var item in receipt.Items)
      {
        candidates.Add(CreateCandidate(text, item.Name ?? ""));

        var shoppingListItem = ShoppingListAccessor.GetItem(item.ShoppingListItemID);
        if (shoppingListItem != null)
        {
          candidates.Add(CreateCandidate(text, shoppingListItem.Name));
        }

        if (options.SearchItemCode && !string.IsNullOrWhiteSpace(item.Code))
        {
          candidates.Add(CreateCandidate(text, item.Code));
        }
      }

      double max = candidates.Max(t => t.Score);
      foreach (var candidate in candidates)
      {
        candidate.Score = 1.0 - (candidate.Score / max);
      }

      foreach (var candidate in candidates)
      {
        if (string.Equals(candidate.Text, text, StringComparison.InvariantCultureIgnoreCase))
        {
          return true;
        }

        if (
          candidate.Text.IndexOf(text, StringComparison.InvariantCultureIgnoreCase) > -1 ||
          text.IndexOf(candidate.Text, StringComparison.InvariantCultureIgnoreCase) > -1)
        {
          return true;
        }

        if (options.IncludeSimilar && candidate.Score > 0.85)
        {
          return true;
        }
      }

      return false;
    }

    private void btnPrevious_Click(object sender, EventArgs e)
    {
      PreviousResult();
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      NextResult();
    }

    public static void Run(IWin32Window owner, IReceiptDisplay display, SearchOptions options)
    {
      using (SearchResultsDialog dlg = new SearchResultsDialog(options, display))
      {
        dlg.Text = "Search Results";
        dlg.ShowDialog(owner);
      }
    }
  }
}
