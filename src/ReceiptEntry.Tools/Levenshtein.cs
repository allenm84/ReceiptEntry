﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReceiptEntry.Tools
{
  public static class Levenshtein
  {
    private static int Min(int a, int b, int c)
    {
      return Math.Min(Math.Min(a, b), c);
    }

    public static int DistanceIgnoreCase(string s, string t)
    {
      return Distance(s.ToLower(), t.ToLower());
    }

    public static int Distance(StringBuilder s, StringBuilder t)
    {
      // for all i and j, d[i,j] will hold the Levenshtein distance between
      // the first i characters of s and the first j characters of t;
      // note that d has (m+1)x(n+1) values
      var m = s.Length;
      var n = t.Length;
      var d = new int[m + 1, n + 1];

      // create the iteration variables
      char tChar, sChar;
      int j, i;

      // the distance of any first string to an empty second string
      for (i = 0; i <= m; ++i)
        d[i, 0] = i;

      // the distance of any second string to an empty first string
      for (j = 0; j <= n; ++j)
        d[0, j] = j;

      // for j from 1 to n
      for (j = 1; j <= n; ++j)
      {
        tChar = t[j - 1];

        // for i from 1 to m
        for (i = 1; i <= m; ++i)
        {
          sChar = s[i - 1];

          // if s[i] = t[j]
          d[i, j] = (tChar == sChar)
            ? // no operation required
            d[i - 1, j - 1]
            : // a deletion
            // an insertion
            // a substitution
            Min(
              d[i - 1, j] + 1,
              d[i, j - 1] + 1,
              d[i - 1, j - 1] + 1);
        }
      }

      return d[m, n];
    }

    public static int Distance(string s, string t)
    {
      // for all i and j, d[i,j] will hold the Levenshtein distance between
      // the first i characters of s and the first j characters of t;
      // note that d has (m+1)x(n+1) values
      var m = s.Length;
      var n = t.Length;
      var d = new int[m + 1, n + 1];

      // create the iteration variables
      char tChar, sChar;
      int j, i;

      // the distance of any first string to an empty second string
      for (i = 0; i <= m; ++i)
        d[i, 0] = i;

      // the distance of any second string to an empty first string
      for (j = 0; j <= n; ++j)
        d[0, j] = j;

      // for j from 1 to n
      for (j = 1; j <= n; ++j)
      {
        tChar = t[j - 1];

        // for i from 1 to m
        for (i = 1; i <= m; ++i)
        {
          sChar = s[i - 1];

          // if s[i] = t[j]
          d[i, j] = (tChar == sChar)
            ? // no operation required
            d[i - 1, j - 1]
            : // a deletion
            // an insertion
            // a substitution
            Min(
              d[i - 1, j] + 1,
              d[i, j - 1] + 1,
              d[i - 1, j - 1] + 1);
        }
      }

      return d[m, n];
    }
  }
}