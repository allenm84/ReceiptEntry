﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using ReceiptEntry.ViewModel;

namespace ReceiptEntry.DExpress
{
  public partial class MerchantListForm : BaseForm, IGridListEditor
  {
    private readonly MerchantListViewModel mMerchants;

    public MerchantListForm(MerchantListViewModel merchants)
    {
      mMerchants = merchants;
      InitializeComponent();
      SetupMerchants();
    }

    private void SetupMerchants()
    {
      lstMerchants.AutoGenerateColumns = false;
      lstMerchants.Mode = GridListControlViewMode.List;
      lstMerchants.AddColumn((MerchantViewModel v) => v.Name);
      lstMerchants.Editor = this;
      lstMerchants.DataSource = mMerchants.Merchants;
    }

    public bool AllowEdit
    {
      get { return true; }
    }

    public bool AddValue(IWin32Window owner, out object newValue)
    {
      newValue = null;

      var merchant = mMerchants.CreateMerchant();
      using (var dlg = new EditMerchantForm(merchant))
      {
        dlg.Text = "Add Merchant";
        if (dlg.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
        {
          newValue = merchant;
          return true;
        }
      }

      return false;
    }

    public bool EditValue(IWin32Window owner, object original, out object editedValue)
    {
      editedValue = null;

      var merchant = original as MerchantViewModel;
      if (merchant == null)
      {
        return false;
      }

      using (var dlg = new EditMerchantForm(merchant))
      {
        dlg.Text = "Edit Merchant";
        if (dlg.ShowDialog(owner) == System.Windows.Forms.DialogResult.OK)
        {
          editedValue = merchant;
          return true;
        }
      }

      return false;
    }

    public int GetVisibleCount()
    {
      return mMerchants.Merchants.Count;
    }
  }
}