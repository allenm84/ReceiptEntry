namespace ReceiptEntry.DExpress
{
  partial class EditMerchantForm
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
      this.btnUpdateOrder = new DevExpress.XtraEditors.SimpleButton();
      this.btnNone = new DevExpress.XtraEditors.SimpleButton();
      this.btnAll = new DevExpress.XtraEditors.SimpleButton();
      this.btnAddNew = new DevExpress.XtraEditors.SimpleButton();
      this.gridCurrentColumns = new DevExpress.XtraGrid.GridControl();
      this.bsCurrent = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewCurrentColumns = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colOrder = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colCurrentColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemLookUpEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.bsColumns = new System.Windows.Forms.BindingSource(this.components);
      this.gridAvailableColumns = new DevExpress.XtraGrid.GridControl();
      this.bsAvailable = new System.Windows.Forms.BindingSource(this.components);
      this.gridViewAvailableColumns = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colAvailableColumnID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.repositoryItemLookUpEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
      this.okCancelButtons1 = new ReceiptEntry.DExpress.OKCancelButtons();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.lciAvailable = new DevExpress.XtraLayout.LayoutControlItem();
      this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
      this.lciCurrent = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCurrentColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCurrent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAvailableColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsAvailable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAvailableColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lciAvailable)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.lciCurrent)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnUpdateOrder);
      this.layoutControl1.Controls.Add(this.btnNone);
      this.layoutControl1.Controls.Add(this.btnAll);
      this.layoutControl1.Controls.Add(this.btnAddNew);
      this.layoutControl1.Controls.Add(this.gridCurrentColumns);
      this.layoutControl1.Controls.Add(this.gridAvailableColumns);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(860, 222, 490, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(392, 331);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnUpdateOrder
      // 
      this.btnUpdateOrder.Location = new System.Drawing.Point(201, 255);
      this.btnUpdateOrder.Name = "btnUpdateOrder";
      this.btnUpdateOrder.Size = new System.Drawing.Size(76, 22);
      this.btnUpdateOrder.StyleController = this.layoutControl1;
      this.btnUpdateOrder.TabIndex = 11;
      this.btnUpdateOrder.Text = "Update";
      // 
      // btnNone
      // 
      this.btnNone.Location = new System.Drawing.Point(292, 255);
      this.btnNone.Name = "btnNone";
      this.btnNone.Size = new System.Drawing.Size(76, 22);
      this.btnNone.StyleController = this.layoutControl1;
      this.btnNone.TabIndex = 10;
      this.btnNone.Text = "None";
      // 
      // btnAll
      // 
      this.btnAll.Location = new System.Drawing.Point(116, 255);
      this.btnAll.Name = "btnAll";
      this.btnAll.Size = new System.Drawing.Size(76, 22);
      this.btnAll.StyleController = this.layoutControl1;
      this.btnAll.TabIndex = 9;
      this.btnAll.Text = "All";
      // 
      // btnAddNew
      // 
      this.btnAddNew.Location = new System.Drawing.Point(24, 255);
      this.btnAddNew.Name = "btnAddNew";
      this.btnAddNew.Size = new System.Drawing.Size(76, 22);
      this.btnAddNew.StyleController = this.layoutControl1;
      this.btnAddNew.TabIndex = 8;
      this.btnAddNew.Text = "Add New";
      this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
      // 
      // gridCurrentColumns
      // 
      this.gridCurrentColumns.DataSource = this.bsCurrent;
      this.gridCurrentColumns.Location = new System.Drawing.Point(201, 99);
      this.gridCurrentColumns.MainView = this.gridViewCurrentColumns;
      this.gridCurrentColumns.Name = "gridCurrentColumns";
      this.gridCurrentColumns.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit2});
      this.gridCurrentColumns.Size = new System.Drawing.Size(167, 152);
      this.gridCurrentColumns.TabIndex = 7;
      this.gridCurrentColumns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCurrentColumns});
      // 
      // bsCurrent
      // 
      this.bsCurrent.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptColumnReferenceViewModel);
      // 
      // gridViewCurrentColumns
      // 
      this.gridViewCurrentColumns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrder,
            this.colCurrentColumnID});
      this.gridViewCurrentColumns.GridControl = this.gridCurrentColumns;
      this.gridViewCurrentColumns.Name = "gridViewCurrentColumns";
      // 
      // colOrder
      // 
      this.colOrder.AppearanceCell.Options.UseTextOptions = true;
      this.colOrder.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.colOrder.Caption = "colOrder";
      this.colOrder.FieldName = "Order";
      this.colOrder.MaxWidth = 40;
      this.colOrder.MinWidth = 40;
      this.colOrder.Name = "colOrder";
      this.colOrder.OptionsColumn.ShowCaption = false;
      this.colOrder.Visible = true;
      this.colOrder.VisibleIndex = 0;
      this.colOrder.Width = 40;
      // 
      // colCurrentColumnID
      // 
      this.colCurrentColumnID.ColumnEdit = this.repositoryItemLookUpEdit2;
      this.colCurrentColumnID.FieldName = "ColumnID";
      this.colCurrentColumnID.Name = "colCurrentColumnID";
      this.colCurrentColumnID.OptionsColumn.ReadOnly = true;
      this.colCurrentColumnID.Visible = true;
      this.colCurrentColumnID.VisibleIndex = 1;
      this.colCurrentColumnID.Width = 142;
      // 
      // repositoryItemLookUpEdit2
      // 
      this.repositoryItemLookUpEdit2.AutoHeight = false;
      this.repositoryItemLookUpEdit2.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemLookUpEdit2.DataSource = this.bsColumns;
      this.repositoryItemLookUpEdit2.DisplayMember = "Name";
      this.repositoryItemLookUpEdit2.Name = "repositoryItemLookUpEdit2";
      this.repositoryItemLookUpEdit2.ValueMember = "ID";
      // 
      // bsColumns
      // 
      this.bsColumns.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptColumnViewModel);
      // 
      // gridAvailableColumns
      // 
      this.gridAvailableColumns.DataSource = this.bsAvailable;
      this.gridAvailableColumns.Location = new System.Drawing.Point(24, 99);
      this.gridAvailableColumns.MainView = this.gridViewAvailableColumns;
      this.gridAvailableColumns.Name = "gridAvailableColumns";
      this.gridAvailableColumns.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemLookUpEdit1});
      this.gridAvailableColumns.Size = new System.Drawing.Size(168, 152);
      this.gridAvailableColumns.TabIndex = 6;
      this.gridAvailableColumns.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewAvailableColumns});
      this.gridAvailableColumns.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.gridAvailableColumns_MouseDoubleClick);
      // 
      // bsAvailable
      // 
      this.bsAvailable.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptColumnReferenceViewModel);
      // 
      // gridViewAvailableColumns
      // 
      this.gridViewAvailableColumns.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAvailableColumnID});
      this.gridViewAvailableColumns.GridControl = this.gridAvailableColumns;
      this.gridViewAvailableColumns.Name = "gridViewAvailableColumns";
      this.gridViewAvailableColumns.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colAvailableColumnID, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colAvailableColumnID
      // 
      this.colAvailableColumnID.ColumnEdit = this.repositoryItemLookUpEdit1;
      this.colAvailableColumnID.FieldName = "ColumnID";
      this.colAvailableColumnID.Name = "colAvailableColumnID";
      this.colAvailableColumnID.OptionsColumn.ReadOnly = true;
      this.colAvailableColumnID.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
      this.colAvailableColumnID.Visible = true;
      this.colAvailableColumnID.VisibleIndex = 0;
      // 
      // repositoryItemLookUpEdit1
      // 
      this.repositoryItemLookUpEdit1.AutoHeight = false;
      this.repositoryItemLookUpEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.repositoryItemLookUpEdit1.DataSource = this.bsColumns;
      this.repositoryItemLookUpEdit1.DisplayMember = "Name";
      this.repositoryItemLookUpEdit1.Name = "repositoryItemLookUpEdit1";
      this.repositoryItemLookUpEdit1.ValueMember = "ID";
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.CancelText = "Cancel";
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 293);
      this.okCancelButtons1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.OKText = "OK";
      this.okCancelButtons1.Size = new System.Drawing.Size(368, 26);
      this.okCancelButtons1.TabIndex = 5;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(12, 28);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(368, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlGroup2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(392, 331);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtName;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(372, 40);
      this.layoutControlItem1.Text = "Name:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(69, 13);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.okCancelButtons1;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 281);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(372, 30);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAvailable,
            this.splitterItem1,
            this.lciCurrent,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7,
            this.emptySpaceItem1,
            this.emptySpaceItem2,
            this.layoutControlItem3});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(372, 241);
      this.layoutControlGroup2.Text = "Columns for Merchant";
      // 
      // lciAvailable
      // 
      this.lciAvailable.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.lciAvailable.AppearanceItemCaption.Options.UseFont = true;
      this.lciAvailable.Control = this.gridAvailableColumns;
      this.lciAvailable.Location = new System.Drawing.Point(0, 0);
      this.lciAvailable.Name = "lciAvailable";
      this.lciAvailable.Size = new System.Drawing.Size(172, 172);
      this.lciAvailable.Text = "Available(0)";
      this.lciAvailable.TextLocation = DevExpress.Utils.Locations.Top;
      this.lciAvailable.TextSize = new System.Drawing.Size(69, 13);
      // 
      // splitterItem1
      // 
      this.splitterItem1.AllowHotTrack = true;
      this.splitterItem1.Location = new System.Drawing.Point(172, 0);
      this.splitterItem1.Name = "splitterItem1";
      this.splitterItem1.Size = new System.Drawing.Size(5, 198);
      // 
      // lciCurrent
      // 
      this.lciCurrent.AppearanceItemCaption.FontStyleDelta = System.Drawing.FontStyle.Bold;
      this.lciCurrent.AppearanceItemCaption.Options.UseFont = true;
      this.lciCurrent.Control = this.gridCurrentColumns;
      this.lciCurrent.Location = new System.Drawing.Point(177, 0);
      this.lciCurrent.Name = "lciCurrent";
      this.lciCurrent.Size = new System.Drawing.Size(171, 172);
      this.lciCurrent.Text = "Current(0)";
      this.lciCurrent.TextLocation = DevExpress.Utils.Locations.Top;
      this.lciCurrent.TextSize = new System.Drawing.Size(69, 13);
      // 
      // layoutControlItem5
      // 
      this.layoutControlItem5.Control = this.btnAddNew;
      this.layoutControlItem5.Location = new System.Drawing.Point(0, 172);
      this.layoutControlItem5.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.Name = "layoutControlItem5";
      this.layoutControlItem5.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem5.TextVisible = false;
      // 
      // layoutControlItem6
      // 
      this.layoutControlItem6.Control = this.btnAll;
      this.layoutControlItem6.Location = new System.Drawing.Point(92, 172);
      this.layoutControlItem6.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem6.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem6.Name = "layoutControlItem6";
      this.layoutControlItem6.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem6.TextVisible = false;
      // 
      // layoutControlItem7
      // 
      this.layoutControlItem7.Control = this.btnNone;
      this.layoutControlItem7.Location = new System.Drawing.Point(268, 172);
      this.layoutControlItem7.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem7.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem7.Name = "layoutControlItem7";
      this.layoutControlItem7.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem7.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem7.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.Location = new System.Drawing.Point(257, 172);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(11, 26);
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // emptySpaceItem2
      // 
      this.emptySpaceItem2.AllowHotTrack = false;
      this.emptySpaceItem2.Location = new System.Drawing.Point(80, 172);
      this.emptySpaceItem2.Name = "emptySpaceItem2";
      this.emptySpaceItem2.Size = new System.Drawing.Size(12, 26);
      this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnUpdateOrder;
      this.layoutControlItem3.Location = new System.Drawing.Point(177, 172);
      this.layoutControlItem3.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextVisible = false;
      // 
      // EditMerchantForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(392, 331);
      this.Controls.Add(this.layoutControl1);
      this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
      this.Name = "EditMerchantForm";
      this.Text = "EditMerchantForm";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridCurrentColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsCurrent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewCurrentColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridAvailableColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsAvailable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridViewAvailableColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.repositoryItemLookUpEdit1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lciAvailable)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.lciCurrent)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.SplitterItem splitterItem1;
    private DevExpress.XtraGrid.GridControl gridCurrentColumns;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewCurrentColumns;
    private DevExpress.XtraGrid.GridControl gridAvailableColumns;
    private DevExpress.XtraGrid.Views.Grid.GridView gridViewAvailableColumns;
    private DevExpress.XtraLayout.LayoutControlItem lciAvailable;
    private DevExpress.XtraLayout.LayoutControlItem lciCurrent;
    private System.Windows.Forms.BindingSource bsAvailable;
    private DevExpress.XtraGrid.Columns.GridColumn colAvailableColumnID;
    private System.Windows.Forms.BindingSource bsCurrent;
    private DevExpress.XtraGrid.Columns.GridColumn colCurrentColumnID;
    private System.Windows.Forms.BindingSource bsColumns;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit1;
    private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemLookUpEdit2;
    private DevExpress.XtraEditors.SimpleButton btnAll;
    private DevExpress.XtraEditors.SimpleButton btnAddNew;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    private DevExpress.XtraEditors.SimpleButton btnNone;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    private DevExpress.XtraGrid.Columns.GridColumn colOrder;
    private DevExpress.XtraEditors.SimpleButton btnUpdateOrder;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
  }
}