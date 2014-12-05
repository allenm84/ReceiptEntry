namespace ReceiptEntry
{
  partial class NamedItemsDialog
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
      this.gridControl1 = new DevExpress.XtraGrid.GridControl();
      this.namedItemSource = new System.Windows.Forms.BindingSource(this.components);
      this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colBrandID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboBrands = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.brandSource = new System.Windows.Forms.BindingSource(this.components);
      this.colCategoryID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.cboCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.categoryPathSource = new System.Windows.Forms.BindingSource(this.components);
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colSize = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colMeasurement = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.namedItemSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboBrands)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategories)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoryPathSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.gridControl1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(472, 298);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // gridControl1
      // 
      this.gridControl1.Cursor = System.Windows.Forms.Cursors.Default;
      this.gridControl1.DataSource = this.namedItemSource;
      this.gridControl1.Location = new System.Drawing.Point(12, 12);
      this.gridControl1.MainView = this.gridView1;
      this.gridControl1.Name = "gridControl1";
      this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cboBrands,
            this.cboCategories});
      this.gridControl1.Size = new System.Drawing.Size(448, 274);
      this.gridControl1.TabIndex = 4;
      this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
      // 
      // namedItemSource
      // 
      this.namedItemSource.DataSource = typeof(ReceiptEntry.NamedItem);
      // 
      // gridView1
      // 
      this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colBrandID,
            this.colCategoryID,
            this.colID,
            this.colSize,
            this.colMeasurement});
      this.gridView1.GridControl = this.gridControl1;
      this.gridView1.Name = "gridView1";
      this.gridView1.OptionsBehavior.Editable = false;
      this.gridView1.OptionsBehavior.ReadOnly = true;
      this.gridView1.OptionsCustomization.AllowColumnMoving = false;
      this.gridView1.OptionsCustomization.AllowGroup = false;
      this.gridView1.OptionsCustomization.AllowQuickHideColumns = false;
      this.gridView1.OptionsView.ColumnAutoWidth = false;
      this.gridView1.OptionsView.ShowGroupPanel = false;
      this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // colBrandID
      // 
      this.colBrandID.Caption = "Brand";
      this.colBrandID.ColumnEdit = this.cboBrands;
      this.colBrandID.FieldName = "BrandID";
      this.colBrandID.Name = "colBrandID";
      this.colBrandID.Visible = true;
      this.colBrandID.VisibleIndex = 1;
      // 
      // cboBrands
      // 
      this.cboBrands.AutoHeight = false;
      this.cboBrands.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboBrands.DataSource = this.brandSource;
      this.cboBrands.DisplayMember = "Name";
      this.cboBrands.Name = "cboBrands";
      this.cboBrands.NullText = "[No Brand]";
      this.cboBrands.ValueMember = "ID";
      // 
      // brandSource
      // 
      this.brandSource.DataSource = typeof(ReceiptEntry.Brand);
      // 
      // colCategoryID
      // 
      this.colCategoryID.Caption = "Category";
      this.colCategoryID.ColumnEdit = this.cboCategories;
      this.colCategoryID.FieldName = "CategoryID";
      this.colCategoryID.Name = "colCategoryID";
      this.colCategoryID.Visible = true;
      this.colCategoryID.VisibleIndex = 2;
      // 
      // cboCategories
      // 
      this.cboCategories.AutoHeight = false;
      this.cboCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboCategories.DataSource = this.categoryPathSource;
      this.cboCategories.DisplayMember = "FullPath";
      this.cboCategories.Name = "cboCategories";
      this.cboCategories.ValueMember = "ID";
      // 
      // categoryPathSource
      // 
      this.categoryPathSource.DataSource = typeof(CategoryPath);
      // 
      // colID
      // 
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      // 
      // colSize
      // 
      this.colSize.FieldName = "Size";
      this.colSize.Name = "colSize";
      this.colSize.Visible = true;
      this.colSize.VisibleIndex = 3;
      // 
      // colMeasurement
      // 
      this.colMeasurement.FieldName = "Measurement";
      this.colMeasurement.Name = "colMeasurement";
      this.colMeasurement.Visible = true;
      this.colMeasurement.VisibleIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(472, 298);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.gridControl1;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(452, 278);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // NamedItemsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(472, 298);
      this.Controls.Add(this.layoutControl1);
      this.Name = "NamedItemsDialog";
      this.Text = "NamedItemsDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.namedItemSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboBrands)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.brandSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboCategories)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.categoryPathSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraGrid.GridControl gridControl1;
    private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource namedItemSource;
    private DevExpress.XtraGrid.Columns.GridColumn colBrandID;
    private DevExpress.XtraGrid.Columns.GridColumn colCategoryID;
    private DevExpress.XtraGrid.Columns.GridColumn colID;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private DevExpress.XtraGrid.Columns.GridColumn colSize;
    private DevExpress.XtraGrid.Columns.GridColumn colMeasurement;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboBrands;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cboCategories;
    private System.Windows.Forms.BindingSource brandSource;
    private System.Windows.Forms.BindingSource categoryPathSource;
  }
}