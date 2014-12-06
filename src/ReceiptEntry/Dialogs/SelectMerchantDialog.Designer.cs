namespace ReceiptEntry
{
  partial class SelectMerchantDialog
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
      this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
      this.okCancelButtons1 = new ReceiptEntry.OKCancelButtons();
      this.cboMerchant = new DevExpress.XtraEditors.SearchLookUpEdit();
      this.merchantSource = new System.Windows.Forms.BindingSource(this.components);
      this.cboMerchantView = new DevExpress.XtraGrid.Views.Grid.GridView();
      this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
      this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchant.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchantView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.labelControl1);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.cboMerchant);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(696, 158, 368, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(447, 128);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // labelControl1
      // 
      this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
      this.labelControl1.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
      this.labelControl1.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
      this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
      this.labelControl1.Location = new System.Drawing.Point(12, 12);
      this.labelControl1.Name = "labelControl1";
      this.labelControl1.Size = new System.Drawing.Size(423, 50);
      this.labelControl1.StyleController = this.layoutControl1;
      this.labelControl1.TabIndex = 17;
      this.labelControl1.Text = "Message";
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 90);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.Size = new System.Drawing.Size(423, 26);
      this.okCancelButtons1.TabIndex = 16;
      this.okCancelButtons1.OKClick += new System.EventHandler(this.okCancelButtons1_OKClick);
      // 
      // cboMerchant
      // 
      this.cboMerchant.Location = new System.Drawing.Point(64, 66);
      this.cboMerchant.Name = "cboMerchant";
      this.cboMerchant.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboMerchant.Properties.DataSource = this.merchantSource;
      this.cboMerchant.Properties.DisplayMember = "Name";
      this.cboMerchant.Properties.NullText = "[Select a merchant]";
      this.cboMerchant.Properties.ValueMember = "ID";
      this.cboMerchant.Properties.View = this.cboMerchantView;
      this.cboMerchant.Size = new System.Drawing.Size(371, 20);
      this.cboMerchant.StyleController = this.layoutControl1;
      this.cboMerchant.TabIndex = 13;
      // 
      // merchantSource
      // 
      this.merchantSource.DataSource = typeof(ReceiptEntry.Merchant);
      // 
      // cboMerchantView
      // 
      this.cboMerchantView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colName});
      this.cboMerchantView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
      this.cboMerchantView.Name = "cboMerchantView";
      this.cboMerchantView.OptionsSelection.EnableAppearanceFocusedCell = false;
      this.cboMerchantView.OptionsView.ShowGroupPanel = false;
      this.cboMerchantView.OptionsView.ShowIndicator = false;
      this.cboMerchantView.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colName, DevExpress.Data.ColumnSortOrder.Ascending)});
      // 
      // colID
      // 
      this.colID.FieldName = "ID";
      this.colID.Name = "colID";
      // 
      // colName
      // 
      this.colName.Caption = "Name";
      this.colName.FieldName = "Name";
      this.colName.Name = "colName";
      this.colName.Visible = true;
      this.colName.VisibleIndex = 0;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem10,
            this.layoutControlItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(447, 128);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboMerchant;
      this.layoutControlItem1.CustomizationFormText = "Merchant:";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 54);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(427, 24);
      this.layoutControlItem1.Text = "Merchant:";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(49, 13);
      // 
      // layoutControlItem10
      // 
      this.layoutControlItem10.Control = this.okCancelButtons1;
      this.layoutControlItem10.CustomizationFormText = "layoutControlItem10";
      this.layoutControlItem10.Location = new System.Drawing.Point(0, 78);
      this.layoutControlItem10.Name = "layoutControlItem10";
      this.layoutControlItem10.Size = new System.Drawing.Size(427, 30);
      this.layoutControlItem10.Text = "layoutControlItem10";
      this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem10.TextToControlDistance = 0;
      this.layoutControlItem10.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.labelControl1;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.MinSize = new System.Drawing.Size(14, 17);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(427, 54);
      this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // SelectMerchantDialog
      // 
      this.AcceptButton = this.okCancelButtons1.OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.okCancelButtons1.Cancel;
      this.ClientSize = new System.Drawing.Size(447, 128);
      this.Controls.Add(this.layoutControl1);
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SelectMerchantDialog";
      this.Text = "SelectMerchantDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchant.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.merchantSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboMerchantView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SearchLookUpEdit cboMerchant;
    private DevExpress.XtraGrid.Views.Grid.GridView cboMerchantView;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private System.Windows.Forms.BindingSource merchantSource;
    private DevExpress.XtraGrid.Columns.GridColumn colName;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
    private DevExpress.XtraGrid.Columns.GridColumn colID;
    private DevExpress.XtraEditors.LabelControl labelControl1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;

  }
}

