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
  public partial class StatisticsDialog : Form, IDoWorkView
  {
    static Lazy<StatisticCategory[]> categories;
    static StatisticsDialog()
    {
      categories = new Lazy<StatisticCategory[]>(GetCategories, true);
    }

    static StatisticCategory[] GetCategories()
    {
      Type type = typeof(StatisticCategory);
      return type.Assembly.GetTypes()
        .Where(t => !t.IsAbstract && t.IsSubclassOf(type))
        .Select(t => Creator.CreateInstance(t) as StatisticCategory)
        .ToArray();
    }

    private DoWorkController workController;
    private StatisticCategory previousCategory;

    public StatisticsDialog()
    {
      InitializeComponent();
      SystemManager.ApplyScheme(this);
      workController = new DoWorkController(this);
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

    private void UpdateCategoryData()
    {
      if (workController.IsBusy) return;

      if (gridCategories.SelectedItems.Count != 1) return;
      var row = gridCategories.SelectedItems[0].GetRow();

      if (previousCategory != null)
      {
        previousCategory.Cleanup(gridData);
        previousCategory = null;
      }

      var category = row.DataRow as StatisticCategory;
      if (category == null) return;

      category.InitializeProperties(gridData);
      previousCategory = category;

      workController.StartWorker(UpdateWork, UpdateCompleted, 
        new { Category = category });
    }

    private void UpdateWork(DoWorkInput input)
    {
      dynamic arg = input.Argument;
      StatisticCategory category = arg.Category;

      input.Result = new
      {
        DataSource = category.GetDataSource(),
        Category = category,
      };
    }

    private void UpdateCompleted(DoWorkOutput output)
    {
      dynamic result = output.Result;
      StatisticCategory category = result.Category;

      gridData.DataSource = result.DataSource;
      gridData.RetrieveStructure();

      category.SetupTables(gridData);
      gridData.Row = 0;
    }

    private void StatisticsDialog_Load(object sender, EventArgs e)
    {
      gridCategories.SelectionChanged += new EventHandler(gridCategories_SelectionChanged);
      gridCategories.SetPropertiesToList(false, false);
      gridCategories.DataSource = categories.Value.ToList();
      gridCategories.RetrieveStructure();
      gridCategories.RootTable.Columns.HideAllExcept("Name");
      UpdateCategoryData();
    }

    private void gridCategories_SelectionChanged(object sender, EventArgs e)
    {
      UpdateCategoryData();
    }
  }
}
