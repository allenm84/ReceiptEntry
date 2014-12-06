namespace ReceiptEntry
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
      this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
      this.bar1 = new DevExpress.XtraBars.Bar();
      this.tbbSave = new DevExpress.XtraBars.BarButtonItem();
      this.tbbMerchants = new DevExpress.XtraBars.BarButtonItem();
      this.tbbShoppingListItems = new DevExpress.XtraBars.BarButtonItem();
      this.tbbNewReceipt = new DevExpress.XtraBars.BarButtonItem();
      this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
      this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.gridReceipts = new DevExpress.XtraGrid.GridControl();
      this.receiptSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMerchantID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboMerchants = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.merchantSource = new System.Windows.Forms.BindingSource(this.components);
      this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateMonth = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.receiptSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchants)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // barManager1
      // 
      this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
      this.barManager1.DockControls.Add(this.barDockControlTop);
      this.barManager1.DockControls.Add(this.barDockControlBottom);
      this.barManager1.DockControls.Add(this.barDockControlLeft);
      this.barManager1.DockControls.Add(this.barDockControlRight);
      this.barManager1.Form = this;
      this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.tbbSave,
            this.tbbMerchants,
            this.tbbShoppingListItems,
            this.tbbNewReceipt});
      this.barManager1.MaxItemId = 4;
      // 
      // bar1
      // 
      this.bar1.BarName = "Tools";
      this.bar1.DockCol = 0;
      this.bar1.DockRow = 0;
      this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
      this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbSave, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbMerchants, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbShoppingListItems, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.tbbNewReceipt, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
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
      this.tbbSave.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbSave_ItemClick);
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
      // tbbShoppingListItems
      // 
      this.tbbShoppingListItems.Caption = "Shopping List Items";
      this.tbbShoppingListItems.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbShoppingListItems.Glyph")));
      this.tbbShoppingListItems.Id = 2;
      this.tbbShoppingListItems.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbShoppingListItems.LargeGlyph")));
      this.tbbShoppingListItems.Name = "tbbShoppingListItems";
      this.tbbShoppingListItems.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbShoppingListItems_ItemClick);
      // 
      // tbbNewReceipt
      // 
      this.tbbNewReceipt.Caption = "New Receipt";
      this.tbbNewReceipt.Glyph = ((System.Drawing.Image)(resources.GetObject("tbbNewReceipt.Glyph")));
      this.tbbNewReceipt.Id = 3;
      this.tbbNewReceipt.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("tbbNewReceipt.LargeGlyph")));
      this.tbbNewReceipt.Name = "tbbNewReceipt";
      this.tbbNewReceipt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.tbbNewReceipt_ItemClick);
      // 
      // barDockControlTop
      // 
      this.barDockControlTop.CausesValidation = false;
      this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
      this.barDockControlTop.Size = new System.Drawing.Size(454, 31);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 464);
      this.barDockControlBottom.Size = new System.Drawing.Size(454, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 433);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(454, 31);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 433);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridReceipts);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 31);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(454, 433);
      this.layoutControl1.TabIndex = 4;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridReceipts
      // 
      this.gridReceipts.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridReceipts.DataSource = this.receiptSource;
      this.gridReceipts.Location = new System.Drawing.Point(24, 43);
      this.gridReceipts.MainView = this.gridViewReceipts;
      this.gridReceipts.MenuManager = this.barManager1;
      this.gridReceipts.Name = "gridReceipts";
      this.gridReceipts.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboMerchants});
      this.gridReceipts.Size = new System.Drawing.Size(406, 366);
      this.gridReceipts.TabIndex = 4;
      this.gridReceipts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReceipts});
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
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(454, 433);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Receipts";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(434, 413);
      this.layoutControlGroup2.Text = "Receipts";
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridReceipts;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(410, 370);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(454, 464);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ReceiptEntry";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.receiptSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchants)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
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
    private DevExpress.XtraBars.BarButtonItem tbbShoppingListItems;
    private DevExpress.XtraBars.BarButtonItem tbbNewReceipt;
    private DevExpress.XtraGrid.GridControl gridReceipts;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceipts;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource receiptSource;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Columns.GridColumn colMerchantID;
    private DevExpress.XtraGrid.Columns.GridColumn colTotal;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboMerchants;
    private System.Windows.Forms.BindingSource merchantSource;
    private DevExpress.XtraGrid.Columns.GridColumn colDateMonth;


  }
}

