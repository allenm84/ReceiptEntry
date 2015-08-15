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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.btnCalculate = new DevExpress.XtraEditors.SimpleButton();
      this.numActual = new DevExpress.XtraEditors.SpinEdit();
      this.numExpected = new DevExpress.XtraEditors.SpinEdit();
      this.cboColumns = new DevExpress.XtraEditors.LookUpEdit();
      this.bsColumns = new System.Windows.Forms.BindingSource(this.components);
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.numActual.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.numExpected.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboColumns.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsColumns)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnCalculate);
      this.layoutControl1.Controls.Add(this.numActual);
      this.layoutControl1.Controls.Add(this.numExpected);
      this.layoutControl1.Controls.Add(this.cboColumns);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(688, 163, 355, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(331, 221);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnCalculate
      // 
      this.btnCalculate.Location = new System.Drawing.Point(127, 171);
      this.btnCalculate.Name = "btnCalculate";
      this.btnCalculate.Size = new System.Drawing.Size(76, 22);
      this.btnCalculate.StyleController = this.layoutControl1;
      this.btnCalculate.TabIndex = 7;
      this.btnCalculate.Text = "Calculate";
      // 
      // numActual
      // 
      this.numActual.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numActual.Location = new System.Drawing.Point(200, 117);
      this.numActual.Name = "numActual";
      this.numActual.Properties.DisplayFormat.FormatString = "c2";
      this.numActual.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.numActual.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.numActual.Size = new System.Drawing.Size(107, 22);
      this.numActual.StyleController = this.layoutControl1;
      this.numActual.TabIndex = 6;
      // 
      // numExpected
      // 
      this.numExpected.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
      this.numExpected.Location = new System.Drawing.Point(200, 91);
      this.numExpected.Name = "numExpected";
      this.numExpected.Properties.DisplayFormat.FormatString = "c2";
      this.numExpected.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
      this.numExpected.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
      this.numExpected.Size = new System.Drawing.Size(107, 22);
      this.numExpected.StyleController = this.layoutControl1;
      this.numExpected.TabIndex = 5;
      // 
      // cboColumns
      // 
      this.cboColumns.Location = new System.Drawing.Point(12, 31);
      this.cboColumns.Name = "cboColumns";
      this.cboColumns.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.cboColumns.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Name", 43, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near, DevExpress.Data.ColumnSortOrder.Ascending)});
      this.cboColumns.Properties.DataSource = this.bsColumns;
      this.cboColumns.Properties.DisplayMember = "Name";
      this.cboColumns.Properties.NullText = "[Select a column]";
      this.cboColumns.Properties.ShowFooter = false;
      this.cboColumns.Properties.ShowHeader = false;
      this.cboColumns.Properties.ShowLines = false;
      this.cboColumns.Properties.ValueMember = "ID";
      this.cboColumns.Size = new System.Drawing.Size(307, 22);
      this.cboColumns.StyleController = this.layoutControl1;
      this.cboColumns.TabIndex = 4;
      // 
      // bsColumns
      // 
      this.bsColumns.DataSource = typeof(ReceiptEntry.ViewModel.ReceiptColumnViewModel);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.layoutControlItem4});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(331, 221);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.cboColumns;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(311, 45);
      this.layoutControlItem1.Text = "Select column to use as price:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(173, 16);
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 45);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(311, 98);
      this.layoutControlGroup2.Text = "Totals";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.numExpected;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(287, 26);
      this.layoutControlItem2.Text = "Expected:";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(173, 16);
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.numActual;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(287, 26);
      this.layoutControlItem3.Text = "Actual:";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(173, 16);
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.btnCalculate;
      this.layoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 143);
      this.layoutControlItem4.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(311, 58);
      this.layoutControlItem4.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextVisible = false;
      this.layoutControlItem4.TrimClientAreaToControl = false;
      // 
      // ValidateReceiptTotalForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(331, 221);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "ValidateReceiptTotalForm";
      this.Text = "Validate Total";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.numActual.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.numExpected.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.cboColumns.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.bsColumns)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.LookUpEdit cboColumns;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.SpinEdit numActual;
    private DevExpress.XtraEditors.SpinEdit numExpected;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.SimpleButton btnCalculate;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private System.Windows.Forms.BindingSource bsColumns;

  }
}