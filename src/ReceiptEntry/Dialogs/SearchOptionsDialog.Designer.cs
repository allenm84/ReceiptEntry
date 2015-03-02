namespace ReceiptEntry
{
  partial class SearchOptionsDialog
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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.okCancelButtons1 = new ReceiptEntry.OKCancelButtons();
      this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
      this.txtSearchText = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.checkEdit2 = new DevExpress.XtraEditors.CheckEdit();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearchText.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.checkEdit2);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.checkEdit1);
      this.layoutControl1.Controls.Add(this.txtSearchText);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(284, 180);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 141);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.Size = new System.Drawing.Size(260, 26);
      this.okCancelButtons1.TabIndex = 6;
      // 
      // checkEdit1
      // 
      this.checkEdit1.Location = new System.Drawing.Point(24, 83);
      this.checkEdit1.Name = "checkEdit1";
      this.checkEdit1.Properties.Caption = "Include Similar matches";
      this.checkEdit1.Size = new System.Drawing.Size(236, 19);
      this.checkEdit1.StyleController = this.layoutControl1;
      this.checkEdit1.TabIndex = 5;
      // 
      // txtSearchText
      // 
      this.txtSearchText.Location = new System.Drawing.Point(12, 28);
      this.txtSearchText.Name = "txtSearchText";
      this.txtSearchText.Size = new System.Drawing.Size(260, 20);
      this.txtSearchText.StyleController = this.layoutControl1;
      this.txtSearchText.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlGroup2,
            this.layoutControlItem3});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(284, 180);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.txtSearchText;
      this.layoutControlItem1.CustomizationFormText = "What are you searching for?";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(264, 40);
      this.layoutControlItem1.Text = "What are you searching for?";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(137, 13);
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.CustomizationFormText = "Options";
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem4});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(264, 89);
      this.layoutControlGroup2.Text = "Options";
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.checkEdit1;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(240, 23);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.okCancelButtons1;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 129);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(264, 31);
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // checkEdit2
      // 
      this.checkEdit2.Location = new System.Drawing.Point(24, 106);
      this.checkEdit2.Name = "checkEdit2";
      this.checkEdit2.Properties.Caption = "Search Item Code";
      this.checkEdit2.Size = new System.Drawing.Size(236, 19);
      this.checkEdit2.StyleController = this.layoutControl1;
      this.checkEdit2.TabIndex = 7;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.checkEdit2;
      this.layoutControlItem4.CustomizationFormText = "layoutControlItem4";
      this.layoutControlItem4.Location = new System.Drawing.Point(0, 23);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(240, 23);
      this.layoutControlItem4.Text = "layoutControlItem4";
      this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem4.TextToControlDistance = 0;
      this.layoutControlItem4.TextVisible = false;
      // 
      // SearchOptionsDialog
      // 
      this.AcceptButton = this.okCancelButtons1.OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.okCancelButtons1.Cancel;
      this.ClientSize = new System.Drawing.Size(284, 180);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchOptionsDialog";
      this.Text = "SearchReceiptOptionsDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtSearchText.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.checkEdit2.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit txtSearchText;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraEditors.CheckEdit checkEdit1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraEditors.CheckEdit checkEdit2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
  }
}