namespace ReceiptEntry.DExpress
{
  partial class MainForm
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.gridReceipts = new DevExpress.XtraGrid.GridControl();
      this.bsReceipts = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colMerchantID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboMerchants = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.bsMerchants = new System.Windows.Forms.BindingSource(this.components);
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateYear = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateMonth = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbColumns = new DevExpress.XtraBars.BarButtonItem();
      this.tbbNames = new DevExpress.XtraBars.BarButtonItem();
      this.tbbMerchants = new DevExpress.XtraBars.BarButtonItem();
      this.tbbAddReceipt = new DevExpress.XtraBars.BarButtonItem();
      this.tbbViewStats = new DevExpress.XtraBars.BarButtonItem();
      this.bar2 = new DevExpress.XtraBars.Bar();
      this.tbbSearchText = new DevExpress.XtraBars.BarEditItem();
      this.txtSearchText = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
      this.tbbSearch = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchants)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMerchants)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearchText)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // gridReceipts
      // 
      this.gridReceipts.DataSource = this.bsReceipts;
      this.gridReceipts.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.gridReceipts.Location = new System.Drawing.Point(12, 12);
      this.gridReceipts.MainView = this.gridViewReceipts;
      this.gridReceipts.MenuManager = this.barManager1;
      this.gridReceipts.Name = "gridReceipts";
      this.gridReceipts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboMerchants});
      this.gridReceipts.Size = new System.Drawing.Size(542, 466);
      this.gridReceipts.TabIndex = 4;
      this.gridReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReceipts});
      this.gridReceipts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridReceipts_MouseDoubleClick);
      // 
      // bsReceipts
      // 
      this.bsReceipts.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptViewModel);
      // 
      // gridViewReceipts
      // 
      this.gridViewReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMerchantID,
            this.colDate,
            this.colDateYear,
            this.colDateMonth,
            this.colTotal});
      this.gridViewReceipts.GridControl = this.gridReceipts;
      this.gridViewReceipts.GroupCount = 3;
      this.gridViewReceipts.GroupFormat = "[#image]{1} - {2}";
      this.gridViewReceipts.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Total", null, "{0:c2}")});
      this.gridViewReceipts.Name = "gridViewReceipts";
      this.gridViewReceipts.OptionsView.ShowColumnHeaders = false;
      this.gridViewReceipts.OptionsView.ShowGroupPanel = false;
      this.gridViewReceipts.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateYear, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDateMonth, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colDate, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.gridViewReceipts.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewReceipts_CustomUnboundColumnData);
      this.gridViewReceipts.CustomRowFilter += new DevExpress.XtraGrid.Views.Base.RowFilterEventHandler(this.gridViewReceipts_CustomRowFilter);
      // 
      // colMerchantID
      // 
      this.colMerchantID.ColumnEdit = this.cboMerchants;
      this.colMerchantID.FieldName = "MerchantID";
      this.colMerchantID.Name = "colMerchantID";
      this.colMerchantID.Visible = true;
      this.colMerchantID.VisibleIndex = 0;
      this.colMerchantID.Width = 290;
      // 
      // cboMerchants
      // 
      this.cboMerchants.AutoHeight = false;
      this.cboMerchants.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboMerchants.DataSource = this.bsMerchants;
      this.cboMerchants.DisplayMember = "Name";
      this.cboMerchants.Name = "cboMerchants";
      this.cboMerchants.ValueMember = "ID";
      // 
      // bsMerchants
      // 
      this.bsMerchants.DataSource = typeof(ReceiptEntry.ViewModel.MerchantViewModel);
      // 
      // colDate
      // 
      this.colDate.FieldName = "Date";
      this.colDate.Name = "colDate";
      this.colDate.Visible = true;
      this.colDate.VisibleIndex = 1;
      // 
      // colDateYear
      // 
      this.colDateYear.Caption = "Year";
      this.colDateYear.FieldName = "Year";
      this.colDateYear.Name = "colDateYear";
      this.colDateYear.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.colDateYear.Visible = true;
      this.colDateYear.VisibleIndex = 2;
      // 
      // colDateMonth
      // 
      this.colDateMonth.Caption = "Month";
      this.colDateMonth.FieldName = "Month";
      this.colDateMonth.Name = "colDateMonth";
      this.colDateMonth.UnboundType = DevExpress.Data.UnboundColumnType.String;
      this.colDateMonth.Visible = true;
      this.colDateMonth.VisibleIndex = 2;
      // 
      // colTotal
      // 
      this.colTotal.DisplayFormat.FormatString = "c2";
      this.colTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colTotal.FieldName = "Total";
      this.colTotal.MaxWidth = 80;
      this.colTotal.MinWidth = 80;
      this.colTotal.Name = "colTotal";
      this.colTotal.Visible = true;
      this.colTotal.VisibleIndex = 1;
      this.colTotal.Width = 80;
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1,
            this.bar2});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.tbbMerchants,
            this.tbbColumns,
            this.tbbNames,
            this.tbbAddReceipt,
            this.tbbSearchText,
            this.barStaticItem1,
            this.tbbSearch,
            this.tbbViewStats});
      this.barManager1.MaxItemId = 11;
      this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.txtSearchText});
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbColumns, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbNames, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbMerchants, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbAddReceipt, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbViewStats, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
      this.bar1.OptionsBar.AllowQuickCustomization = false;
      this.bar1.OptionsBar.DisableClose = true;
      this.bar1.OptionsBar.DisableCustomization = true;
      this.bar1.OptionsBar.DrawDragBorder = false;
      this.bar1.OptionsBar.UseWholeRow = true;
      this.bar1.Text = "Tools";
      // 
      // tbbSave
      // 
      this.tbbSave.Caption = "Save";
      this.tbbSave.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.Glyph")));
      this.tbbSave.Id = 0;
      this.tbbSave.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSave.LargeGlyph")));
      this.tbbSave.Name = "tbbSave";
      // 
      // tbbColumns
      // 
      this.tbbColumns.Caption = "Columns";
      this.tbbColumns.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbColumns.Glyph")));
      this.tbbColumns.Id = 2;
      this.tbbColumns.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbColumns.LargeGlyph")));
      this.tbbColumns.Name = "tbbColumns";
      this.tbbColumns.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbColumns_ItemClick);
      // 
      // tbbNames
      // 
      this.tbbNames.Caption = "Names";
      this.tbbNames.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbNames.Glyph")));
      this.tbbNames.Id = 3;
      this.tbbNames.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbNames.LargeGlyph")));
      this.tbbNames.Name = "tbbNames";
      this.tbbNames.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbNames_ItemClick);
      // 
      // tbbMerchants
      // 
      this.tbbMerchants.Caption = "Merchants";
      this.tbbMerchants.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbMerchants.Glyph")));
      this.tbbMerchants.Id = 1;
      this.tbbMerchants.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbMerchants.LargeGlyph")));
      this.tbbMerchants.Name = "tbbMerchants";
      this.tbbMerchants.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbMerchants_ItemClick);
      // 
      // tbbAddReceipt
      // 
      this.tbbAddReceipt.Caption = "New Receipt";
      this.tbbAddReceipt.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbAddReceipt.Glyph")));
      this.tbbAddReceipt.Id = 4;
      this.tbbAddReceipt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbAddReceipt.LargeGlyph")));
      this.tbbAddReceipt.Name = "tbbAddReceipt";
      this.tbbAddReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbAddReceipt_ItemClick);
      // 
      // tbbViewStats
      // 
      this.tbbViewStats.Caption = "Stats";
      this.tbbViewStats.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbViewStats.Glyph")));
      this.tbbViewStats.Id = 10;
      this.tbbViewStats.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbViewStats.LargeGlyph")));
      this.tbbViewStats.Name = "tbbViewStats";
      this.tbbViewStats.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbViewStats_ItemClick);
      // 
      // bar2
      // 
      this.bar2.BarName = "Custom 3";
      this.bar2.DockCol = 0;
      this.bar2.DockRow = 1;
      this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSearchText, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(this.tbbSearch)});
      this.bar2.OptionsBar.AllowQuickCustomization = false;
      this.bar2.OptionsBar.DisableClose = true;
      this.bar2.OptionsBar.DisableCustomization = true;
      this.bar2.OptionsBar.DrawDragBorder = false;
      this.bar2.OptionsBar.UseWholeRow = true;
      this.bar2.Text = "Custom 3";
      // 
      // tbbSearchText
      // 
      this.tbbSearchText.AutoFillWidth = true;
      this.tbbSearchText.Caption = "Search:";
      this.tbbSearchText.Edit = this.txtSearchText;
      this.tbbSearchText.Id = 7;
      this.tbbSearchText.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSearchText.LargeGlyph")));
      this.tbbSearchText.Name = "tbbSearchText";
      // 
      // txtSearchText
      // 
      this.txtSearchText.AutoHeight = false;
      this.txtSearchText.Name = "txtSearchText";
      // 
      // tbbSearch
      // 
      this.tbbSearch.Caption = "Peform Search";
      this.tbbSearch.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbSearch.Glyph")));
      this.tbbSearch.Id = 9;
      this.tbbSearch.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbSearch.LargeGlyph")));
      this.tbbSearch.Name = "tbbSearch";
      this.tbbSearch.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSearch_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.barDockControlTop.Size = new System.Drawing.Size(566, 70);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 560);
      this.barDockControlBottom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.barDockControlBottom.Size = new System.Drawing.Size(566, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 70);
      this.barDockControlLeft.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 490);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(566, 70);
      this.barDockControlRight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 490);
      // 
      // barStaticItem1
      // 
      this.barStaticItem1.Caption = "barStaticItem1";
      this.barStaticItem1.Id = 8;
      this.barStaticItem1.Name = "barStaticItem1";
      this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridReceipts);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 70);
      this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(566, 490);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(566, 490);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridReceipts;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(546, 470);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(566, 560);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
      this.Name = "MainForm";
      this.Text = "ReceiptEntry";
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchants)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMerchants)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearchText)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraBars.BarManager barManager1;
    private DevExpress.XtraBars.Bar bar1;
    private DevExpress.XtraBars.BarDockControl barDockControlTop;
    private DevExpress.XtraBars.BarDockControl barDockControlBottom;
    private DevExpress.XtraBars.BarDockControl barDockControlLeft;
    private DevExpress.XtraBars.BarDockControl barDockControlRight;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraBars.BarButtonItem tbbSave;
    private DevExpress.XtraBars.BarButtonItem tbbMerchants;
    private DevExpress.XtraBars.BarButtonItem tbbColumns;
    private DevExpress.XtraBars.BarButtonItem tbbNames;
    private DevExpress.XtraBars.BarButtonItem tbbAddReceipt;
    private DevExpress.XtraBars.Bar bar2;
    private DevExpress.XtraBars.BarEditItem tbbSearchText;
    private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit txtSearchText;
    private DevExpress.XtraBars.BarButtonItem tbbSearch;
    private DevExpress.XtraBars.BarStaticItem barStaticItem1;
    private DevExpress.XtraBars.BarButtonItem tbbViewStats;
    private DevExpress.XtraGrid.GridControl gridReceipts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceipts;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource bsReceipts;
    private DevExpress.XtraGrid.Columns.GridColumn colMerchantID;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colDateYear;
    private DevExpress.XtraGrid.Columns.GridColumn colDateMonth;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMerchants;
    private System.Windows.Forms.BindingSource bsMerchants;
    private DevExpress.XtraGrid.Columns.GridColumn colTotal;

  }
}

