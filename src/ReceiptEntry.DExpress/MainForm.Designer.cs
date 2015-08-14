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
      DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
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
      this.repositoryItemSearchLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
      this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.repositoryItemGridLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit();
      this.repositoryItemGridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.gridViewReceipts = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.colMerchantID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridViewReceiptItems = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colDateYear = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colDateMonth = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearchText)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceiptItems)).BeginInit();
      this.SuspendLayout();
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
            this.repositoryItemSearchLookUpEdit1,
            this.repositoryItemGridLookUpEdit1,
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
      this.barDockControlTop.Size = new System.Drawing.Size(485, 62);
      // 
      // barDockControlBottom
      // 
      this.barDockControlBottom.CausesValidation = false;
      this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.barDockControlBottom.Location = new System.Drawing.Point(0, 455);
      this.barDockControlBottom.Size = new System.Drawing.Size(485, 0);
      // 
      // barDockControlLeft
      // 
      this.barDockControlLeft.CausesValidation = false;
      this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
      this.barDockControlLeft.Location = new System.Drawing.Point(0, 62);
      this.barDockControlLeft.Size = new System.Drawing.Size(0, 393);
      // 
      // barDockControlRight
      // 
      this.barDockControlRight.CausesValidation = false;
      this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
      this.barDockControlRight.Location = new System.Drawing.Point(485, 62);
      this.barDockControlRight.Size = new System.Drawing.Size(0, 393);
      // 
      // barStaticItem1
      // 
      this.barStaticItem1.Caption = "barStaticItem1";
      this.barStaticItem1.Id = 8;
      this.barStaticItem1.Name = "barStaticItem1";
      this.barStaticItem1.TextAlignment = System.Drawing.StringAlignment.Near;
      // 
      // repositoryItemSearchLookUpEdit1
      // 
      this.repositoryItemSearchLookUpEdit1.AutoHeight = false;
      this.repositoryItemSearchLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemSearchLookUpEdit1.Name = "repositoryItemSearchLookUpEdit1";
      this.repositoryItemSearchLookUpEdit1.View = this.repositoryItemSearchLookUpEdit1View;
      // 
      // repositoryItemSearchLookUpEdit1View
      // 
      this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
      this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      // 
      // repositoryItemGridLookUpEdit1
      // 
      this.repositoryItemGridLookUpEdit1.AutoHeight = false;
      this.repositoryItemGridLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemGridLookUpEdit1.Name = "repositoryItemGridLookUpEdit1";
      this.repositoryItemGridLookUpEdit1.View = this.repositoryItemGridLookUpEdit1View;
      // 
      // repositoryItemGridLookUpEdit1View
      // 
      this.repositoryItemGridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.repositoryItemGridLookUpEdit1View.Name = "repositoryItemGridLookUpEdit1View";
      this.repositoryItemGridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.repositoryItemGridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 62);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(485, 393);
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
      this.layoutControlGroup1.Size = new System.Drawing.Size(485, 393);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // gridControl1
      // 
      this.gridControl1.DataSource = this.bindingSource1;
      gridLevelNode1.LevelTemplate = this.gridViewReceiptItems;
      gridLevelNode1.RelationName = "Items";
      this.gridControl1.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
      this.gridControl1.Location = new System.Drawing.Point(12, 12);
      this.gridControl1.MainView = this.gridViewReceipts;
      this.gridControl1.MenuManager = this.barManager1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.Size = new System.Drawing.Size(461, 369);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewReceipts,
            this.gridViewReceiptItems});
      // 
      // gridViewReceipts
      // 
      this.gridViewReceipts.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMerchantID,
            this.colDate,
            this.colDateYear,
            this.colDateMonth});
      this.gridViewReceipts.GridControl = this.gridControl1;
      this.gridViewReceipts.Name = "gridViewReceipts";
      this.gridViewReceipts.OptionsView.ShowGroupPanel = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridControl1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(465, 373);
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextVisible = false;
      // 
      // bindingSource1
      // 
      this.bindingSource1.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptViewModel);
      // 
      // colMerchantID
      // 
      this.colMerchantID.FieldName = "MerchantID";
      this.colMerchantID.Name = "colMerchantID";
      this.colMerchantID.Visible = true;
      this.colMerchantID.VisibleIndex = 0;
      // 
      // colDate
      // 
      this.colDate.FieldName = "Date";
      this.colDate.Name = "colDate";
      this.colDate.Visible = true;
      this.colDate.VisibleIndex = 1;
      // 
      // gridViewReceiptItems
      // 
      this.gridViewReceiptItems.GridControl = this.gridControl1;
      this.gridViewReceiptItems.Name = "gridViewReceiptItems";
      // 
      // colDateYear
      // 
      this.colDateYear.Caption = "gridColumn1";
      this.colDateYear.Name = "colDateYear";
      this.colDateYear.Visible = true;
      this.colDateYear.VisibleIndex = 2;
      // 
      // colDateMonth
      // 
      this.colDateMonth.Caption = "gridColumn1";
      this.colDateMonth.Name = "colDateMonth";
      this.colDateMonth.Visible = true;
      this.colDateMonth.VisibleIndex = 3;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(485, 455);
      this.Controls.Add(this.layoutControl1);
      this.Controls.Add(this.barDockControlLeft);
      this.Controls.Add(this.barDockControlRight);
      this.Controls.Add(this.barDockControlBottom);
      this.Controls.Add(this.barDockControlTop);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "MainForm";
      this.Text = "ReceiptEntry";
      ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearchText)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemGridLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceipts)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewReceiptItems)).EndInit();
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
    private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit repositoryItemSearchLookUpEdit1;
    private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
    private DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit repositoryItemGridLookUpEdit1;
    private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemGridLookUpEdit1View;
    private DevExpress.XtraBars.BarButtonItem tbbViewStats;
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceipts;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource bindingSource1;
    private DevExpress.XtraGrid.Columns.GridColumn colMerchantID;
    private DevExpress.XtraGrid.Columns.GridColumn colDate;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewReceiptItems;
    private DevExpress.XtraGrid.Columns.GridColumn colDateYear;
    private DevExpress.XtraGrid.Columns.GridColumn colDateMonth;

  }
}

