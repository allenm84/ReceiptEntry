namespace ReceiptEntry
{
  partial class ReceiptGridControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.gridReceipts = new DevExpress.XtraGrid.GridControl();
      this.gridViewReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMerchantID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboMerchants = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateMonth = new DevExpress.XtraGrid.Columns.GridColumn();
      this.receiptSource = new System.Windows.Forms.BindingSource(this.components);
      this.merchantSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchants)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.receiptSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantSource)).BeginInit();
      this.SuspendLayout();
      // 
      // gridReceipts
      // 
      this.gridReceipts.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridReceipts.DataSource = this.receiptSource;
      this.gridReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridReceipts.Location = new System.Drawing.Point(0, 0);
      this.gridReceipts.MainView = this.gridViewReceipts;
      this.gridReceipts.Name = "gridReceipts";
      this.gridReceipts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboMerchants});
      this.gridReceipts.Size = new System.Drawing.Size(327, 298);
      this.gridReceipts.TabIndex = 5;
      this.gridReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReceipts});
      this.gridReceipts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gridReceipts_KeyDown);
      this.gridReceipts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridReceipts_MouseDoubleClick);
      // 
      // receiptSource
      // 
      this.receiptSource.DataSource = typeof(ReceiptEntry.Receipt);
      // 
      // gridViewReceipts
      // 
      this.gridViewReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colMerchantID,
            this.colTotal,
            this.colDateMonth});
      this.gridViewReceipts.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
      this.gridViewReceipts.GridControl = this.gridReceipts;
      this.gridViewReceipts.GroupCount = 2;
      this.gridViewReceipts.GroupFormat = "{1} {2}";
      this.gridViewReceipts.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "{0:c2}")});
      this.gridViewReceipts.Name = "gridViewReceipts";
      this.gridViewReceipts.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewReceipts.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
      this.gridViewReceipts.OptionsBehavior.AllowIncrementalSearch = true;
      this.gridViewReceipts.OptionsBehavior.Editable = false;
      this.gridViewReceipts.OptionsBehavior.ReadOnly = true;
      this.gridViewReceipts.OptionsCustomization.AllowColumnMoving = false;
      this.gridViewReceipts.OptionsCustomization.AllowColumnResizing = false;
      this.gridViewReceipts.OptionsCustomization.AllowFilter = false;
      this.gridViewReceipts.OptionsCustomization.AllowQuickHideColumns = false;
      this.gridViewReceipts.OptionsMenu.EnableColumnMenu = false;
      this.gridViewReceipts.OptionsMenu.EnableFooterMenu = false;
      this.gridViewReceipts.OptionsMenu.EnableGroupPanelMenu = false;
      this.gridViewReceipts.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewReceipts.OptionsSelection.MultiSelect = true;
      this.gridViewReceipts.OptionsView.ShowColumnHeaders = false;
      this.gridViewReceipts.OptionsView.ShowGroupPanel = false;
      this.gridViewReceipts.OptionsView.ShowIndicator = false;
      this.gridViewReceipts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateMonth, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.gridViewReceipts.CustomColumnGroup += new DevExpress.XtraGrid.Views.Base.CustomColumnSortEventHandler(this.gridViewReceipts_CustomColumnGroup);
      this.gridViewReceipts.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewReceipts_CustomUnboundColumnData);
      // 
      // colDate
      // 
      this.colDate.DisplayFormat.FormatString = "yyyy";
      this.colDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colDate.FieldName = "Date";
      this.colDate.GroupFormat.FormatString = "yyyy";
      this.colDate.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colDate.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateYear;
      this.colDate.Name = "colDate";
      this.colDate.Visible = true;
      this.colDate.VisibleIndex = 0;
      // 
      // colMerchantID
      // 
      this.colMerchantID.ColumnEdit = this.cboMerchants;
      this.colMerchantID.FieldName = "MerchantID";
      this.colMerchantID.Name = "colMerchantID";
      this.colMerchantID.Visible = true;
      this.colMerchantID.VisibleIndex = 0;
      this.colMerchantID.Width = 194;
      // 
      // cboMerchants
      // 
      this.cboMerchants.AutoHeight = false;
      this.cboMerchants.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboMerchants.DataSource = this.merchantSource;
      this.cboMerchants.DisplayMember = "Name";
      this.cboMerchants.Name = "cboMerchants";
      this.cboMerchants.ValueMember = "ID";
      // 
      // merchantSource
      // 
      this.merchantSource.DataSource = typeof(ReceiptEntry.Merchant);
      // 
      // colTotal
      // 
      this.colTotal.DisplayFormat.FormatString = "c2";
      this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colTotal.FieldName = "Total";
      this.colTotal.MaxWidth = 90;
      this.colTotal.MinWidth = 90;
      this.colTotal.Name = "colTotal";
      this.colTotal.OptionsColumn.ReadOnly = true;
      this.colTotal.Visible = true;
      this.colTotal.VisibleIndex = 1;
      this.colTotal.Width = 90;
      // 
      // colDateMonth
      // 
      this.colDateMonth.Caption = "Month";
      this.colDateMonth.DisplayFormat.FormatString = "MM - MMMM";
      this.colDateMonth.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colDateMonth.FieldName = "Month";
      this.colDateMonth.GroupFormat.FormatString = "MM - MMMM";
      this.colDateMonth.GroupFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colDateMonth.GroupInterval = DevExpress.XtraGrid.ColumnGroupInterval.DateMonth;
      this.colDateMonth.Name = "colDateMonth";
      this.colDateMonth.UnboundType = DevExpress.Data.UnboundColumnType.DateTime;
      this.colDateMonth.Visible = true;
      this.colDateMonth.VisibleIndex = 2;
      // 
      // ReceiptGrid
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.gridReceipts);
      this.Name = "ReceiptGrid";
      this.Size = new System.Drawing.Size(327, 298);
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchants)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.receiptSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraGrid.GridControl gridReceipts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceipts;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colMerchantID;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMerchants;
    private DevExpress.XtraGrid.Columns.GridColumn colTotal;
    private DevExpress.XtraGrid.Columns.GridColumn colDateMonth;
    private System.Windows.Forms.BindingSource receiptSource;
    private System.Windows.Forms.BindingSource merchantSource;
  }
}
