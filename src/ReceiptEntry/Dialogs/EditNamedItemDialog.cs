using DevExpress.Data;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
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
  public partial class EditNamedItemDialog : BaseForm
  {
    private bool cancelClose = false;
    private NamedItem item;

    public EditNamedItemDialog(NamedItem item)
    {
      this.item = item;

      InitializeComponent();
      RefreshCategories();
      FillMeasurements();
      brandSource.DataSource = SaveFile.Brands;

      cboCategory.EditValue = item.CategoryID;
      txtName.DataBindings.Add("Text", item, "Name");
      cboBrand.EditValue = item.BrandID;
      numSize.Value = item.Size;
      cboMeasurement.EditValue = item.Measurement;
    }

    private void FillMeasurements()
    {
      var combo = cboMeasurement.Properties;
      combo.DataSource = Enum.GetValues(typeof(Measurement))
        .Cast<Measurement>()
        .Select(m => new { Value = m, Display = m })
        .ToList();
      combo.DisplayMember = "Display";
      combo.ValueMember = "Value";
      combo.Columns.Add(new LookUpColumnInfo("Display") { SortOrder = ColumnSortOrder.Ascending });
      combo.ShowHeader = false;
    }

    private void RefreshCategories()
    {
      pathSource.DataSource = Categories.Paths.ToList();
    }

    private void cboBrand_AddNewValue(object sender, AddNewValueEventArgs e)
    {
      var brand = new Brand
      {
        ID = Pool.ID,
        Name = cboBrand.GetSearchText(),
      };

      using (var dlg = new EditBrandDialog(brand))
      {
        dlg.Text = "Add Brand";
        if (dlg.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          brandSource.Add(brand);
          e.NewValue = brand.ID;
          e.Cancel = false;
        }
        else
        {
          e.Cancel = true;
        }
      }
    }

    private void btnRefresh_Click(object sender, EventArgs e)
    {
      RefreshCategories();
    }

    protected override void OnFormClosing(FormClosingEventArgs e)
    {
      if (cancelClose)
      {
        cancelClose = false;
        e.Cancel = true;
      }
      base.OnFormClosing(e);
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      item.BrandID = cboBrand.EditValue as string;
      item.CategoryID = cboCategory.EditValue as string;
      item.Size = numSize.Value;
      item.Measurement = (Measurement)cboMeasurement.EditValue;

      if (string.IsNullOrWhiteSpace(item.CategoryID))
      {
        cancelClose = true;
        XtraMessageBox.Show(this,
          "Please select a category", "Invalid", 
          MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }
  }
}
