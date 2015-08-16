namespace ReceiptEntry.DExpress
{
  partial class ValidateReceiptTotalForm
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
      this.cboQuantityColumns = new DevExpress.XtraEditors.LookUpEdit();
      this.bsQuantityColumns = new System.Windows.Forms.BindingSource(this.components);
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.cboPriceColumns = new DevExpress.XtraEditors.LookUpEdit();
      this.bsPriceColumns = new System.Windows.Forms.BindingSource(this.components);
      this.numActual = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.cboQuantityColumns.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsQuantityColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.cboPriceColumns.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPriceColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numActual.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // cboQuantityColumns
      // 
      this.cboQuantityColumns.Location = new System.Drawing.Point(12, 76);
      this.cboQuantityColumns.Name = "cboQuantityColumns";
      this.cboQuantityColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboQuantityColumns.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.cboQuantityColumns.Properties.DataSource = this.bsQuantityColumns;
      this.cboQuantityColumns.Properties.DisplayMember = "Name";
      this.cboQuantityColumns.Properties.NullText = "[Select a column]";
      this.cboQuantityColumns.Properties.ShowFooter = false;
      this.cboQuantityColumns.Properties.ShowHeader = false;
      this.cboQuantityColumns.Properties.ShowLines = false;
      this.cboQuantityColumns.Properties.ValueMember = "ID";
      this.cboQuantityColumns.Size = new System.Drawing.Size(235, 22);
      this.cboQuantityColumns.StyleController = this.layoutControl1;
      this.cboQuantityColumns.TabIndex = 8;
      // 
      // bsQuantityColumns
      // 
      this.bsQuantityColumns.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptColumnViewModel);
      // 
      // layoutControl1
      // 
      this.layoutControl1.AutoScroll = false;
      this.layoutControl1.Controls.Add(this.cboPriceColumns);
      this.layoutControl1.Controls.Add(this.numActual);
      this.layoutControl1.Controls.Add(this.cboQuantityColumns);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(616, 88, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(259, 172);
      this.layoutControl1.TabIndex = 9;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // cboPriceColumns
      // 
      this.cboPriceColumns.Location = new System.Drawing.Point(12, 31);
      this.cboPriceColumns.Name = "cboPriceColumns";
      this.cboPriceColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboPriceColumns.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.cboPriceColumns.Properties.DataSource = this.bsPriceColumns;
      this.cboPriceColumns.Properties.DisplayMember = "Name";
      this.cboPriceColumns.Properties.NullText = "[Select a column]";
      this.cboPriceColumns.Properties.ShowFooter = false;
      this.cboPriceColumns.Properties.ShowHeader = false;
      this.cboPriceColumns.Properties.ShowLines = false;
      this.cboPriceColumns.Properties.ValueMember = "ID";
      this.cboPriceColumns.Size = new System.Drawing.Size(235, 22);
      this.cboPriceColumns.StyleController = this.layoutControl1;
      this.cboPriceColumns.TabIndex = 4;
      // 
      // bsPriceColumns
      // 
      this.bsPriceColumns.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptColumnViewModel);
      // 
      // numActual
      // 
      this.numActual.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numActual.Location = new System.Drawing.Point(12, 121);
      this.numActual.Name = "numActual";
      this.numActual.Properties.DisplayFormat.FormatString = "c2";
      this.numActual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.numActual.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.numActual.Size = new System.Drawing.Size(235, 22);
      this.numActual.StyleController = this.layoutControl1;
      this.numActual.TabIndex = 6;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem4});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(259, 172);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboPriceColumns;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(239, 45);
      this.layoutControlItem1.Text = "Price Column:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(99, 16);
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.cboQuantityColumns;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 45);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(239, 45);
      this.layoutControlItem2.Text = "Quantity Column:";
      this.layoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem2.TextSize = new System.Drawing.Size(99, 16);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.numActual;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 90);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(239, 62);
      this.layoutControlItem4.Text = "Calculated Total:";
      this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(99, 16);
      // 
      // ValidateReceiptTotalForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(259, 172);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ValidateReceiptTotalForm";
      this.Text = "Validate Total";
      ((System.ComponentModel.ISupportInitialize)(this.cboQuantityColumns.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsQuantityColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.cboPriceColumns.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsPriceColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numActual.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraEditors.LookUpEdit cboPriceColumns;
    private DevExpress.XtraEditors.SpinEdit numActual;
    private System.Windows.Forms.BindingSource bsPriceColumns;
    private DevExpress.XtraEditors.LookUpEdit cboQuantityColumns;
    private System.Windows.Forms.BindingSource bsQuantityColumns;
    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;

  }
}