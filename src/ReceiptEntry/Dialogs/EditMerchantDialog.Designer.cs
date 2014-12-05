namespace ReceiptEntry
{
  partial class EditMerchantDialog
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
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.okCancelButtons1 = new ReceiptEntry.OKCancelButtons();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.txtName = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.cboMerchantType = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.merchantTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchantType.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantTypeBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.cboMerchantType);
      this.layoutControl1.Controls.Add(this.txtName);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(284, 99);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(284, 99);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 60);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.Size = new System.Drawing.Size(260, 26);
      this.okCancelButtons1.TabIndex = 4;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.okCancelButtons1;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 48);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(264, 31);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(47, 12);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(225, 20);
      this.txtName.StyleController = this.layoutControl1;
      this.txtName.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.txtName;
      this.layoutControlItem2.CustomizationFormText = "Name:";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(264, 24);
      this.layoutControlItem2.Text = "Name:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(31, 13);
      // 
      // cboMerchantType
      // 
      this.cboMerchantType.Location = new System.Drawing.Point(47, 36);
      this.cboMerchantType.Name = "cboMerchantType";
      this.cboMerchantType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboMerchantType.Properties.DataSource = this.merchantTypeBindingSource;
      this.cboMerchantType.Properties.DisplayMember = "Name";
      this.cboMerchantType.Properties.NullText = "[Select a merchant type]";
      this.cboMerchantType.Properties.ShowAddNewButton = true;
      this.cboMerchantType.Properties.ValueMember = "ID";
      this.cboMerchantType.Properties.View = this.searchLookUpEdit1View;
      this.cboMerchantType.Size = new System.Drawing.Size(225, 20);
      this.cboMerchantType.StyleController = this.layoutControl1;
      this.cboMerchantType.TabIndex = 6;
      this.cboMerchantType.AddNewValue += new DevExpress.XtraEditors.Controls.AddNewValueEventHandler(this.searchLookUpEdit1_AddNewValue);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.cboMerchantType;
      this.layoutControlItem3.CustomizationFormText = "Type:";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 24);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(264, 24);
      this.layoutControlItem3.Text = "Type:";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(31, 13);
      // 
      // searchLookUpEdit1View
      // 
      this.searchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName});
      this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
      this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.searchLookUpEdit1View.OptionsView.ShowColumnHeaders = false;
      this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
      this.searchLookUpEdit1View.OptionsView.ShowIndicator = false;
      this.searchLookUpEdit1View.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // merchantTypeBindingSource
      // 
      this.merchantTypeBindingSource.DataSource = typeof(ReceiptEntry.MerchantType);
      // 
      // colName
      // 
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // EditMerchantDialog
      // 
      this.AcceptButton = this.okCancelButtons1.OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.okCancelButtons1.Cancel;
      this.ClientSize = new System.Drawing.Size(284, 99);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditMerchantDialog";
      this.Text = "EditMerchantDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchantType.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantTypeBindingSource)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SearchLookUpEdit cboMerchantType;
    private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
    private DevExpress.XtraEditors.TextEdit txtName;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private System.Windows.Forms.BindingSource merchantTypeBindingSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
  }
}