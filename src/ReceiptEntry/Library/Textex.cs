using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry
{
  public static class Textex
  {
    private static int min(params int[] values)
    {
      return values.Min();
    }

    public static int LevenshteinDistance(string x, string y)
    {
      return LevenshteinDistance(x, y, true);
    }

    public static int LevenshteinDistance(string x, string y, bool lower)
    {
      string s = lower ? x.ToLower() : x;
      string t = lower ? y.ToLower() : y;

      // for all i and j, d[i,j] will hold the Levenshtein distance between
      // the first i characters of s and the first j characters of t;
      // note that d has (m+1)x(n+1) values
      int m = s.Length;
      int n = t.Length;
      int[,] d = new int[m + 1, n + 1];

      // the distance of any first string to an empty second string
      for (int i = 0; i <= m; ++i)
        d[i, 0] = i;

      // the distance of any second string to an empty first string
      for (int j = 0; j <= n; ++j)
        d[0, j] = j;

      // for j from 1 to n
      for (int j = 1; j <= n; ++j)
      {
        char c1 = t[j - 1];

        // for i from 1 to m
        for (int i = 1; i <= m; ++i)
        {
          char c2 = s[i - 1];
          int cost = (c1 == c2) ? 0 : 1;
          d[i, j] = min(
            d[i - 1, j] + 1,    // a deletion
            d[i, j - 1] + 1,    // an insertion
            d[i, j - 1] + cost  // a substitution
            );
        }
      }

      return d[m, n];
    }

    public static int DamerauLevenshteinDistance(string x, string y)
    {
      return DamerauLevenshteinDistance(x, y, true);
    }

    public static int DamerauLevenshteinDistance(string x, string y, bool lower)
    {
      string s = lower ? x.ToLower() : x;
      string t = lower ? y.ToLower() : y;

      var m = s.Length;
      var n = t.Length;

      // d is a table with lenStr1+1 rows and lenStr2+1 columns
      int[,] d = new int[m + 1, n + 1];

      // i and j are used to iterate over str1 and str2
      int i, j, cost;

      // for loop is inclusive, need table 1 row/column larger than string length.
      for (i = 0; i <= m; ++i)
        d[i, 0] = i;
      for (j = 1; j <= n; ++j)
        d[0, j] = j;

      // Pseudo-code assumes string indices start at 1, not 0.
      // If implemented, make sure to start comparing at 1st letter of strings.
      for (i = 1; i <= m; ++i)
      {
        char c1 = s[i - 1];
        for (j = 1; j <= n; ++j)
        {
          char c2 = t[j - 1];
          cost = (c1 == c2) ? 0 : 1;
          d[i, j] = min(
            d[i - 1, j] + 1,        // deletion
            d[i, j - 1] + 1,        // insertion
            d[i - 1, j - 1] + cost  // substitution
            );

          if (i > 1 && j > 1 && c1 == t[j - 2] && s[i - 2] == c2)
          {
            d[i, j] = min(
              d[i, j],
              d[i - 2, j - 2] + cost   // transposition
              );
          }
        }
      }

      return d[m, n];
    }

    public static bool IndexOf(string input, string pattern)
    {
      return (input ?? "").IndexOf((pattern ?? ""),
        StringComparison.InvariantCultureIgnoreCase) > -1;
    }

    public static bool Contains(string input, string pattern)
    {
      string x = (input ?? "").ToLower();
      string y = (pattern ?? "").ToLower();
      return x.Contains(y);
    }

    public static bool Equals(string value1, string value2)
    {
      return string.Equals(value1 ?? "", value2 ?? "", 
        StringComparison.InvariantCultureIgnoreCase);
    }

    public static bool LessThan(string left, string right)
    {
      string l = left.ToLower();
      string r = right.ToLower();

      return l.CompareTo(r) < 0;
    }

    public static bool GreaterThan(string left, string right)
    {
      string l = left.ToLower();
      string r = right.ToLower();

      return l.CompareTo(r) > 0;
    }
  }
}
