using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Janus.Windows.GridEX;

namespace ReceiptEntry
{
  public partial class DataSelectionDialog<TData> : Form where TData : class, INameIDItem
  {
    const string FilterInstructions = "[Filter Items by typing here]";

    private BindingList<TData> itemBindingList = new BindingList<TData>();

    public TData SelectedItem
    {
      get
      {
        return gridItems.GetSelectedItems<TData>().First();
      }
    }

    public string Filter
    {
      get { return txtFilter.Text; }
      set { txtFilter.Text = value; }
    }

    public bool FilterVisible
    {
      get { return pnlFilter.Visible; }
      set { pnlFilter.Visible = value; }
    }

    public Action<TData> AddNewItem { get; set; }
    public Func<string, TData> CreateNewItem { get; set; }
    public Func<string, IEnumerable<TData>> GetMatchesTo { get; set; }

    public DataSelectionDialog()
    {
      InitializeComponent();
      MinimumSize = Size;

      SystemManager.ApplyScheme(this);

      itemBindingList.ListChanged += new ListChangedEventHandler(itemBindingList_ListChanged);
    }

    private void UpdateButtons()
    {
      btnOK.Enabled = (gridItems.SelectedItems.Count == 1);
    }

    private void FilterItems()
    {
      itemBindingList.Clear();
      itemBindingList.ResetBindings();

      if (string.IsNullOrEmpty(txtFilter.Text)) return;
      if (txtFilter.Text.Equals(FilterInstructions)) return;

      var matches = GetMatchesTo(txtFilter.Text);
      foreach (var match in matches)
      {
        itemBindingList.Add(match);
      }
      itemBindingList.ResetBindings();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      gridItems.DataSource = itemBindingList;
      gridItems.RetrieveStructure();

      gridItems.RootTable.Columns.HideAllExcept("Name");
      gridItems.RootTable.SortKeys.Add("Name");

      UpdateButtons();
    }

    private void itemBindingList_ListChanged(object sender, ListChangedEventArgs e)
    {
      UpdateButtons();
    }

    private void gridItems_SelectionChanged(object sender, EventArgs e)
    {
      UpdateButtons();
    }

    private void txtFilter_Enter(object sender, EventArgs e)
    {
      if (txtFilter.Text.Equals(FilterInstructions))
      {
        txtFilter.Text = string.Empty;
      }
    }

    private void txtFilter_Leave(object sender, EventArgs e)
    {
      if (string.IsNullOrEmpty(txtFilter.Text))
      {
        txtFilter.Text = FilterInstructions;
      }
    }

    private void txtFilter_TextChanged(object sender, EventArgs e)
    {
      FilterItems();
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      bool keepGoing = true;
      if (itemBindingList.Count > 0)
      {
        var result = MessageBox.Show(this, "There are items that match the text you entered. Are you sure you want to add this item?",
          "Add", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        keepGoing = (result == System.Windows.Forms.DialogResult.OK);
      }

      if (txtFilter.Text == FilterInstructions)
      {
        var result = MessageBox.Show(this,
          string.Format("'{0}' is not a valid item name.", FilterInstructions), "Add",
           MessageBoxButtons.OK, MessageBoxIcon.None);
        keepGoing = false;
      }

      if (!keepGoing) return;

      AddNewItem(CreateNewItem(txtFilter.Text));
      FilterItems();
    }
  }
}
