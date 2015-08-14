namespace ReceiptEntry.DExpress
{
  partial class EditReceiptForm
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.chkShowHelpfulName = new DevExpress.XtraEditors.CheckEdit();
      this.okCancelButtons1 = new ReceiptEntry.DExpress.OKCancelButtons();
      this.numTotal = new DevExpress.XtraEditors.SpinEdit();
      this.gridTaxes = new DevExpress.XtraGrid.GridControl();
      this.bsTaxes = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewTaxes = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colPercent = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colAmount = new DevExpress.XtraGrid.Columns.GridColumn();
      this.gridItems = new DevExpress.XtraGrid.GridControl();
      this.bsItems = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colHelpfulNameID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboNames = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
      this.bsNames = new System.Windows.Forms.BindingSource(this.components);
      this.cboViewNames = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.dtDate = new DevExpress.XtraEditors.DateEdit();
      this.cboMerchant = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.bsMerchants = new System.Windows.Forms.BindingSource(this.components);
      this.cboViewMerchant = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.simpleLabelItem1 = new DevExpress.XtraLayout.SimpleLabelItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chkShowHelpfulName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTotal.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridTaxes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsTaxes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTaxes)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboNames)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsNames)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboViewNames)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchant.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMerchants)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboViewMerchant)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.chkShowHelpfulName);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.numTotal);
      this.layoutControl1.Controls.Add(this.gridTaxes);
      this.layoutControl1.Controls.Add(this.gridItems);
      this.layoutControl1.Controls.Add(this.dtDate);
      this.layoutControl1.Controls.Add(this.cboMerchant);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(868, 144, 338, 448);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(379, 438);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // chkShowHelpfulName
      // 
      this.chkShowHelpfulName.AutoSizeInLayoutControl = true;
      this.chkShowHelpfulName.Location = new System.Drawing.Point(253, 92);
      this.chkShowHelpfulName.Name = "chkShowHelpfulName";
      this.chkShowHelpfulName.Properties.Caption = "Show Helpful Name";
      this.chkShowHelpfulName.Size = new System.Drawing.Size(114, 19);
      this.chkShowHelpfulName.StyleController = this.layoutControl1;
      this.chkShowHelpfulName.TabIndex = 10;
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.CancelText = "Cancel";
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 400);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.OKText = "OK";
      this.okCancelButtons1.Size = new System.Drawing.Size(355, 26);
      this.okCancelButtons1.TabIndex = 9;
      // 
      // numTotal
      // 
      this.numTotal.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numTotal.Location = new System.Drawing.Point(12, 376);
      this.numTotal.Name = "numTotal";
      this.numTotal.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.numTotal.Size = new System.Drawing.Size(355, 20);
      this.numTotal.StyleController = this.layoutControl1;
      this.numTotal.TabIndex = 8;
      // 
      // gridTaxes
      // 
      this.gridTaxes.DataSource = this.bsTaxes;
      this.gridTaxes.Location = new System.Drawing.Point(12, 266);
      this.gridTaxes.MainView = this.gridViewTaxes;
      this.gridTaxes.Name = "gridTaxes";
      this.gridTaxes.Size = new System.Drawing.Size(355, 90);
      this.gridTaxes.TabIndex = 7;
      this.gridTaxes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTaxes});
      // 
      // bsTaxes
      // 
      this.bsTaxes.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptTaxViewModel);
      // 
      // gridViewTaxes
      // 
      this.gridViewTaxes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPercent,
            this.colAmount});
      this.gridViewTaxes.GridControl = this.gridTaxes;
      this.gridViewTaxes.Name = "gridViewTaxes";
      this.gridViewTaxes.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.gridViewTaxes.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      this.gridViewTaxes.OptionsCustomization.AllowColumnMoving = false;
      this.gridViewTaxes.OptionsCustomization.AllowFilter = false;
      this.gridViewTaxes.OptionsCustomization.AllowGroup = false;
      this.gridViewTaxes.OptionsCustomization.AllowQuickHideColumns = false;
      this.gridViewTaxes.OptionsFilter.AllowColumnMRUFilterList = false;
      this.gridViewTaxes.OptionsFilter.AllowFilterEditor = false;
      this.gridViewTaxes.OptionsFilter.AllowFilterIncrementalSearch = false;
      this.gridViewTaxes.OptionsFilter.AllowMRUFilterList = false;
      this.gridViewTaxes.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
      this.gridViewTaxes.OptionsSelection.MultiSelect = true;
      this.gridViewTaxes.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewTaxes.OptionsView.ShowGroupPanel = false;
      this.gridViewTaxes.OptionsView.ShowIndicator = false;
      // 
      // colPercent
      // 
      this.colPercent.FieldName = "Percent";
      this.colPercent.Name = "colPercent";
      this.colPercent.Visible = true;
      this.colPercent.VisibleIndex = 0;
      // 
      // colAmount
      // 
      this.colAmount.DisplayFormat.FormatString = "c2";
      this.colAmount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.colAmount.FieldName = "Amount";
      this.colAmount.Name = "colAmount";
      this.colAmount.Visible = true;
      this.colAmount.VisibleIndex = 1;
      // 
      // gridItems
      // 
      this.gridItems.DataSource = this.bsItems;
      this.gridItems.Location = new System.Drawing.Point(12, 115);
      this.gridItems.MainView = this.gridViewItems;
      this.gridItems.Name = "gridItems";
      this.gridItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboNames});
      this.gridItems.Size = new System.Drawing.Size(355, 129);
      this.gridItems.TabIndex = 6;
      this.gridItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewItems});
      // 
      // bsItems
      // 
      this.bsItems.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptItemViewModel);
      // 
      // gridViewItems
      // 
      this.gridViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHelpfulNameID});
      this.gridViewItems.GridControl = this.gridItems;
      this.gridViewItems.Name = "gridViewItems";
      this.gridViewItems.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True;
      this.gridViewItems.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.True;
      this.gridViewItems.OptionsCustomization.AllowFilter = false;
      this.gridViewItems.OptionsCustomization.AllowGroup = false;
      this.gridViewItems.OptionsCustomization.AllowQuickHideColumns = false;
      this.gridViewItems.OptionsFilter.AllowColumnMRUFilterList = false;
      this.gridViewItems.OptionsFilter.AllowFilterEditor = false;
      this.gridViewItems.OptionsFilter.AllowFilterIncrementalSearch = false;
      this.gridViewItems.OptionsFilter.AllowMRUFilterList = false;
      this.gridViewItems.OptionsFilter.AllowMultiSelectInCheckedFilterPopup = false;
      this.gridViewItems.OptionsFind.AllowFindPanel = false;
      this.gridViewItems.OptionsMenu.EnableColumnMenu = false;
      this.gridViewItems.OptionsMenu.EnableFooterMenu = false;
      this.gridViewItems.OptionsMenu.EnableGroupPanelMenu = false;
      this.gridViewItems.OptionsNavigation.AutoFocusNewRow = true;
      this.gridViewItems.OptionsSelection.MultiSelect = true;
      this.gridViewItems.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top;
      this.gridViewItems.OptionsView.ShowGroupPanel = false;
      this.gridViewItems.CustomUnboundColumnData += new DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(this.gridViewItems_CustomUnboundColumnData);
      // 
      // colHelpfulNameID
      // 
      this.colHelpfulNameID.Caption = "Helpful Name";
      this.colHelpfulNameID.ColumnEdit = this.cboNames;
      this.colHelpfulNameID.FieldName = "HelpfulNameID";
      this.colHelpfulNameID.Name = "colHelpfulNameID";
      this.colHelpfulNameID.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
      this.colHelpfulNameID.Visible = true;
      this.colHelpfulNameID.VisibleIndex = 0;
      // 
      // cboNames
      // 
      this.cboNames.AutoHeight = false;
      this.cboNames.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboNames.DataSource = this.bsNames;
      this.cboNames.DisplayMember = "Name";
      this.cboNames.Name = "cboNames";
      this.cboNames.NullText = "[Select a helpful name]";
      this.cboNames.ShowAddNewButton = true;
      this.cboNames.ValueMember = "ID";
      this.cboNames.View = this.cboViewNames;
      this.cboNames.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboNames_AddNewValue);
      // 
      // bsNames
      // 
      this.bsNames.DataSource = typeof(ReceiptEntry.ViewModel.HelpfulNameViewModel);
      // 
      // cboViewNames
      // 
      this.cboViewNames.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.cboViewNames.Name = "cboViewNames";
      this.cboViewNames.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.cboViewNames.OptionsView.ShowColumnHeaders = false;
      this.cboViewNames.OptionsView.ShowGroupPanel = false;
      this.cboViewNames.OptionsView.ShowIndicator = false;
      // 
      // dtDate
      // 
      this.dtDate.EditValue = null;
      this.dtDate.Location = new System.Drawing.Point(12, 68);
      this.dtDate.Name = "dtDate";
      this.dtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.dtDate.Size = new System.Drawing.Size(355, 20);
      this.dtDate.StyleController = this.layoutControl1;
      this.dtDate.TabIndex = 5;
      // 
      // cboMerchant
      // 
      this.cboMerchant.Location = new System.Drawing.Point(12, 28);
      this.cboMerchant.Name = "cboMerchant";
      this.cboMerchant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboMerchant.Properties.DataSource = this.bsMerchants;
      this.cboMerchant.Properties.DisplayMember = "Name";
      this.cboMerchant.Properties.NullText = "[Select a merchant]";
      this.cboMerchant.Properties.ShowAddNewButton = true;
      this.cboMerchant.Properties.ValueMember = "ID";
      this.cboMerchant.Properties.View = this.cboViewMerchant;
      this.cboMerchant.Size = new System.Drawing.Size(355, 20);
      this.cboMerchant.StyleController = this.layoutControl1;
      this.cboMerchant.TabIndex = 4;
      this.cboMerchant.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboMerchant_AddNewValue);
      // 
      // bsMerchants
      // 
      this.bsMerchants.DataSource = typeof(ReceiptEntry.ViewModel.MerchantViewModel);
      // 
      // cboViewMerchant
      // 
      this.cboViewMerchant.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
      this.cboViewMerchant.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.cboViewMerchant.Name = "cboViewMerchant";
      this.cboViewMerchant.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.cboViewMerchant.OptionsView.ShowColumnHeaders = false;
      this.cboViewMerchant.OptionsView.ShowGroupPanel = false;
      this.cboViewMerchant.OptionsView.ShowIndicator = false;
      this.cboViewMerchant.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.simpleSeparator1,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.layoutControlItem3,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.simpleLabelItem1});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(379, 438);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboMerchant;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(359, 40);
      this.layoutControlItem1.Text = "Merchant:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 13);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.dtDate;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(359, 40);
      this.layoutControlItem2.Text = "Date:";
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(49, 13);
      // 
      // simpleSeparator1
      // 
      this.simpleSeparator1.AllowHotTrack = false;
      this.simpleSeparator1.Location = new System.Drawing.Point(0, 236);
      this.simpleSeparator1.Name = "simpleSeparator1";
      this.simpleSeparator1.Size = new System.Drawing.Size(359, 2);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.gridTaxes;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 238);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(359, 110);
      this.layoutControlItem4.Text = "Taxes:";
      this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(49, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.numTotal;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 348);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(359, 40);
      this.layoutControlItem5.Text = "Total:";
      this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem5.TextSize = new System.Drawing.Size(49, 13);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.gridItems;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 103);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(359, 133);
      this.layoutControlItem3.Text = "Items:";
      this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.okCancelButtons1;
      this.layoutControlItem6.Location = new System.Drawing.Point(0, 388);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(359, 30);
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.chkShowHelpfulName;
      this.layoutControlItem7.Location = new System.Drawing.Point(241, 80);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(118, 23);
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      // 
      // simpleLabelItem1
      // 
      this.simpleLabelItem1.AllowHotTrack = false;
      this.simpleLabelItem1.Location = new System.Drawing.Point(0, 80);
      this.simpleLabelItem1.Name = "simpleLabelItem1";
      this.simpleLabelItem1.Size = new System.Drawing.Size(241, 23);
      this.simpleLabelItem1.Text = "Items:";
      this.simpleLabelItem1.TextSize = new System.Drawing.Size(49, 13);
      // 
      // EditReceiptForm
      // 
      this.AcceptButton = this.okCancelButtons1.OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.okCancelButtons1.Cancel;
      this.ClientSize = new System.Drawing.Size(379, 438);
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditReceiptForm";
      this.Text = "EditReceiptForm";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chkShowHelpfulName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numTotal.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridTaxes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsTaxes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewTaxes)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewItems)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboNames)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsNames)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboViewNames)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties.CalendarTimeProperties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dtDate.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchant.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsMerchants)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboViewMerchant)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.simpleLabelItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SearchLookUpEdit cboMerchant;
    private DevExpress.XtraGrid.Views.Grid.GridView cboViewMerchant;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.DateEdit dtDate;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraGrid.GridControl gridTaxes;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewTaxes;
    private DevExpress.XtraGrid.GridControl gridItems;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewItems;
    private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
    private DevExpress.XtraEditors.SpinEdit numTotal;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private System.Windows.Forms.BindingSource bsItems;
    private DevExpress.XtraGrid.Columns.GridColumn colHelpfulNameID;
    private System.Windows.Forms.BindingSource bsMerchants;
    private System.Windows.Forms.BindingSource bsTaxes;
    private DevExpress.XtraGrid.Columns.GridColumn colPercent;
    private DevExpress.XtraGrid.Columns.GridColumn colAmount;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraEditors.CheckEdit chkShowHelpfulName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.SimpleLabelItem simpleLabelItem1;
    private System.Windows.Forms.BindingSource bsNames;
    private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit cboNames;
    private DevExpress.XtraGrid.Views.Grid.GridView cboViewNames;
  }
}