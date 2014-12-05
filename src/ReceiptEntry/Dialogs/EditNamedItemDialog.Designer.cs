namespace ReceiptEntry
{
  partial class EditNamedItemDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditNamedItemDialog));
      DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
      this.btnOK = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
      this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
      this.cboBrand = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.brandSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewBrands = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colBrandName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.cboCategory = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.pathSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewPaths = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colFullPath = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlGroup4 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.numSize = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.cboMeasurement = new DevExpress.XtraEditors.LookUpEdit();
      this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup5 = new DevExpress.XtraLayout.LayoutControlGroup();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboBrand.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewBrands)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.pathSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewPaths)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSize.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMeasurement.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).BeginInit();
      this.SuspendLayout();
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(98, 306);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(76, 22);
      this.btnOK.StyleController = this.layoutControl1;
      this.btnOK.TabIndex = 7;
      this.btnOK.Text = "OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.cboMeasurement);
      this.layoutControl1.Controls.Add(this.btnRefresh);
      this.layoutControl1.Controls.Add(this.numSize);
      this.layoutControl1.Controls.Add(this.btnCancel);
      this.layoutControl1.Controls.Add(this.btnOK);
      this.layoutControl1.Controls.Add(this.cboBrand);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.cboCategory);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(569, 63, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(266, 340);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnRefresh
      // 
      this.btnRefresh.AutoWidthInLayoutControl = true;
      this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
      this.btnRefresh.Location = new System.Drawing.Point(216, 43);
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(26, 22);
      this.btnRefresh.StyleController = this.layoutControl1;
      this.btnRefresh.TabIndex = 9;
      this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(178, 306);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(76, 22);
      this.btnCancel.StyleController = this.layoutControl1;
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel";
      // 
      // cboBrand
      // 
      this.cboBrand.CausesValidation = false;
      this.cboBrand.Location = new System.Drawing.Point(24, 179);
      this.cboBrand.Name = "cboBrand";
      this.cboBrand.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboBrand.Properties.DataSource = this.brandSource;
      this.cboBrand.Properties.DisplayMember = "Name";
      this.cboBrand.Properties.NullText = "[Select a brand]";
      this.cboBrand.Properties.ShowAddNewButton = true;
      this.cboBrand.Properties.ValueMember = "ID";
      this.cboBrand.Properties.View = this.gridViewBrands;
      this.cboBrand.Size = new System.Drawing.Size(218, 20);
      this.cboBrand.StyleController = this.layoutControl1;
      this.cboBrand.TabIndex = 6;
      this.cboBrand.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.cboBrand_AddNewValue);
      // 
      // brandSource
      // 
      this.brandSource.DataSource = typeof(ReceiptEntry.Brand);
      // 
      // gridViewBrands
      // 
      this.gridViewBrands.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colBrandName});
      this.gridViewBrands.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewBrands.Name = "gridViewBrands";
      this.gridViewBrands.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewBrands.OptionsView.ShowColumnHeaders = false;
      this.gridViewBrands.OptionsView.ShowGroupPanel = false;
      this.gridViewBrands.OptionsView.ShowIndicator = false;
      this.gridViewBrands.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colBrandName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colBrandName
      // 
      this.colBrandName.FieldName = "Name";
      this.colBrandName.Name = "colBrandName";
      this.colBrandName.Visible = true;
      this.colBrandName.VisibleIndex = 0;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(24, 112);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(218, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 5;
      // 
      // cboCategory
      // 
      this.cboCategory.CausesValidation = false;
      this.cboCategory.Location = new System.Drawing.Point(24, 43);
      this.cboCategory.Name = "cboCategory";
      this.cboCategory.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboCategory.Properties.DataSource = this.pathSource;
      this.cboCategory.Properties.DisplayMember = "FullPath";
      this.cboCategory.Properties.NullText = "[Select a category]";
      this.cboCategory.Properties.ShowFooter = false;
      this.cboCategory.Properties.ValueMember = "ID";
      this.cboCategory.Properties.View = this.gridViewPaths;
      this.cboCategory.Size = new System.Drawing.Size(188, 20);
      this.cboCategory.StyleController = this.layoutControl1;
      this.cboCategory.TabIndex = 4;
      // 
      // pathSource
      // 
      this.pathSource.DataSource = typeof(CategoryPath);
      // 
      // gridViewPaths
      // 
      this.gridViewPaths.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFullPath});
      this.gridViewPaths.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.gridViewPaths.Name = "gridViewPaths";
      this.gridViewPaths.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.gridViewPaths.OptionsView.ShowColumnHeaders = false;
      this.gridViewPaths.OptionsView.ShowGroupPanel = false;
      this.gridViewPaths.OptionsView.ShowIndicator = false;
      this.gridViewPaths.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colFullPath, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colFullPath
      // 
      this.colFullPath.FieldName = "FullPath";
      this.colFullPath.Name = "colFullPath";
      this.colFullPath.Visible = true;
      this.colFullPath.VisibleIndex = 0;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem2,
            this.layoutControlGroup2,
            this.layoutControlGroup3,
            this.layoutControlGroup4,
            this.layoutControlGroup5});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(266, 340);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtName;
      this.layoutControlItem2.CustomizationFormText = "Name:";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(222, 24);
      this.layoutControlItem2.Text = "Name:";
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.cboBrand;
      this.layoutControlItem3.CustomizationFormText = "Brand (Optional):";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(222, 24);
      this.layoutControlItem3.Text = "Brand:";
      this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnOK;
      this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
      this.layoutControlItem4.Location = new System.Drawing.Point(86, 294);
      this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.Text = "layoutControlItem4";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnCancel;
      this.layoutControlItem5.CustomizationFormText = "layoutControlItem5";
      this.layoutControlItem5.Location = new System.Drawing.Point(166, 294);
      this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem5.Text = "layoutControlItem5";
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextToControlDistance = 0;
      this.layoutControlItem5.TextVisible = false;
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.CustomizationFormText = "emptySpaceItem2";
      this.emptySpaceItem2.Location = new System.Drawing.Point(0, 294);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(86, 26);
      this.emptySpaceItem2.Text = "emptySpaceItem2";
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnRefresh;
      this.layoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.BottomCenter;
      this.layoutControlItem6.CustomizationFormText = "layoutControlItem6";
      this.layoutControlItem6.Location = new System.Drawing.Point(192, 0);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(30, 26);
      this.layoutControlItem6.Text = "layoutControlItem6";
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextToControlDistance = 0;
      this.layoutControlItem6.TextVisible = false;
      this.layoutControlItem6.TrimClientAreaToControl = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboCategory;
      this.layoutControlItem1.CustomizationFormText = "Category:";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(192, 26);
      this.layoutControlItem1.Text = "Category:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Category:";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem6,
            this.layoutControlItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(246, 69);
      this.layoutControlGroup2.Text = "Category:";
      // 
      // layoutControlGroup3
      // 
      this.layoutControlGroup3.CustomizationFormText = "Name:";
      this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2});
      this.layoutControlGroup3.Location = new System.Drawing.Point(0, 69);
      this.layoutControlGroup3.Name = "layoutControlGroup3";
      this.layoutControlGroup3.Size = new System.Drawing.Size(246, 67);
      this.layoutControlGroup3.Text = "Name:";
      // 
      // layoutControlGroup4
      // 
      this.layoutControlGroup4.CustomizationFormText = "Brand (Optional):";
      this.layoutControlGroup4.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3});
      this.layoutControlGroup4.Location = new System.Drawing.Point(0, 136);
      this.layoutControlGroup4.Name = "layoutControlGroup4";
      this.layoutControlGroup4.Size = new System.Drawing.Size(246, 67);
      this.layoutControlGroup4.Text = "Brand (Optional):";
      // 
      // numSize
      // 
      this.numSize.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numSize.Location = new System.Drawing.Point(96, 246);
      this.numSize.Name = "numSize";
      this.numSize.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
      this.numSize.Properties.Mask.EditMask = "\\d+(\\.\\d(\\d)?)?";
      this.numSize.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
      this.numSize.Properties.Mask.ShowPlaceHolders = false;
      this.numSize.Size = new System.Drawing.Size(146, 20);
      this.numSize.StyleController = this.layoutControl1;
      this.numSize.TabIndex = 13;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.numSize;
      this.layoutControlItem7.CustomizationFormText = "Size:";
      this.layoutControlItem7.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(222, 24);
      this.layoutControlItem7.Text = "Size:";
      this.layoutControlItem7.TextSize = new System.Drawing.Size(69, 13);
      // 
      // cboMeasurement
      // 
      this.cboMeasurement.Location = new System.Drawing.Point(96, 270);
      this.cboMeasurement.Name = "cboMeasurement";
      this.cboMeasurement.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboMeasurement.Properties.NullText = "[No Measurement]";
      this.cboMeasurement.Size = new System.Drawing.Size(146, 20);
      this.cboMeasurement.StyleController = this.layoutControl1;
      this.cboMeasurement.TabIndex = 14;
      // 
      // layoutControlItem8
      // 
      this.layoutControlItem8.Control = this.cboMeasurement;
      this.layoutControlItem8.CustomizationFormText = "Measurement:";
      this.layoutControlItem8.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem8.Name = "layoutControlItem8";
      this.layoutControlItem8.Size = new System.Drawing.Size(222, 24);
      this.layoutControlItem8.Text = "Measurement:";
      this.layoutControlItem8.TextSize = new System.Drawing.Size(69, 13);
      // 
      // layoutControlGroup5
      // 
      this.layoutControlGroup5.CustomizationFormText = "Packaging:";
      this.layoutControlGroup5.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem7,
            this.layoutControlItem8});
      this.layoutControlGroup5.Location = new System.Drawing.Point(0, 203);
      this.layoutControlGroup5.Name = "layoutControlGroup5";
      this.layoutControlGroup5.Size = new System.Drawing.Size(246, 91);
      this.layoutControlGroup5.Text = "Packaging:";
      // 
      // EditNamedItemDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(266, 340);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditNamedItemDialog";
      this.Text = "EditNamedItemDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboBrand.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewBrands)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategory.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.pathSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewPaths)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup4)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numSize.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMeasurement.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup5)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SearchLookUpEdit cboCategory;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewPaths;
    private System.Windows.Forms.BindingSource pathSource;
    private DevExpress.XtraGrid.Columns.GridColumn colFullPath;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.SimpleButton btnCancel;
    private DevExpress.XtraEditors.SimpleButton btnOK;
    private DevExpress.XtraEditors.SearchLookUpEdit cboBrand;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewBrands;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private System.Windows.Forms.BindingSource brandSource;
    private DevExpress.XtraGrid.Columns.GridColumn colBrandName;
    private DevExpress.XtraEditors.SimpleButton btnRefresh;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup4;
    private DevExpress.XtraEditors.SpinEdit numSize;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraEditors.LookUpEdit cboMeasurement;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
  }
}