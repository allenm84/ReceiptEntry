﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;
using DevExpress.XtraLayout.Utils;

namespace ReceiptEntry.DExpress
{
  public partial class EditorButtons : XtraUserControl
  {
    private bool mAllowRemove = true;

    public event EventHandler AddClick
    {
      add { btnAdd.Click += value; }
      remove { btnAdd.Click -= value; }
    }

    public event EventHandler EditClick
    {
      add { btnEdit.Click += value; }
      remove { btnEdit.Click -= value; }
    }

    public event EventHandler RemoveClick
    {
      add { btnRemove.Click += value; }
      remove { btnRemove.Click -= value; }
    }

    public event EventHandler ClearClick
    {
      add { btnClear.Click += value; }
      remove { btnClear.Click -= value; }
    }

    [Browsable(false)]
    public bool EditVisible
    {
      get { return layoutControlItem2.GetIsVisible(); }
      set { layoutControlItem2.SetIsVisible(value); }
    }

    [Browsable(false)]
    public bool AllowRemove
    {
      get { return mAllowRemove; }
      set { mAllowRemove = value; }
    }

    public EditorButtons()
    {
      InitializeComponent();
    }

    public void UpdateButtons(int selectionCount, bool isDataRow, int totalCount)
    {
      btnAdd.Enabled = true;
      btnEdit.Enabled = selectionCount == 1 && isDataRow;
      btnRemove.Enabled = selectionCount > 0 && mAllowRemove;
      btnClear.Enabled = totalCount > 0;
    }

    public void Remove()
    {
      if (btnRemove.Enabled)
      {
        btnRemove.PerformClick();
      }
    }
  }

  public static class EditorButtonsExtensions
  {
    public static void SetIsVisible(this BaseLayoutItem item, bool visible)
    {
      item.Visibility = visible
        ? LayoutVisibility.Always
        : LayoutVisibility.Never;
    }

    public static bool GetIsVisible(this BaseLayoutItem item)
    {
      return item.Visible;
    }
  }
}