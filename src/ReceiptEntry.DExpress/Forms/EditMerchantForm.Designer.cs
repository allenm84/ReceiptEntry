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
      this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.okCancelButtons1 = new ReceiptEntry.DExpress.OKCancelButtons();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.splitterItem1 = new DevExpress.XtraLayout.SplitterItem();
      this.listBoxControl2 = new DevExpress.XtraEditors.ListBoxControl();
      this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.listBoxControl2);
      this.layoutControl1.Controls.Add(this.listBoxControl1);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.textEdit1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(696, 188, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(361, 331);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
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
      this.layoutControlGroup1.Size = new System.Drawing.Size(361, 331);
      this.layoutControlGroup1.TextVisible = false;
      // 
      // textEdit1
      // 
      this.textEdit1.Location = new System.Drawing.Point(12, 28);
      this.textEdit1.Name = "textEdit1";
      this.textEdit1.Size = new System.Drawing.Size(337, 20);
      this.textEdit1.StyleController = this.layoutControl1;
      this.textEdit1.TabIndex = 4;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.textEdit1;
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(341, 40);
      this.layoutControlItem1.Text = "Name:";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(57, 13);
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.CancelText = "Cancel";
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 293);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.OKText = "OK";
      this.okCancelButtons1.Size = new System.Drawing.Size(337, 26);
      this.okCancelButtons1.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.okCancelButtons1;
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 281);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(341, 30);
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextVisible = false;
      // 
      // listBoxControl1
      // 
      this.listBoxControl1.Location = new System.Drawing.Point(24, 99);
      this.listBoxControl1.Name = "listBoxControl1";
      this.listBoxControl1.Size = new System.Drawing.Size(149, 178);
      this.listBoxControl1.StyleController = this.layoutControl1;
      this.listBoxControl1.TabIndex = 6;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.listBoxControl1;
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(153, 198);
      this.layoutControlItem3.Text = "Available(0)";
      this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem3.TextSize = new System.Drawing.Size(57, 13);
      // 
      // layoutControlGroup2
      // 
      this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.splitterItem1});
      this.layoutControlGroup2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlGroup2.Name = "layoutControlGroup2";
      this.layoutControlGroup2.Size = new System.Drawing.Size(341, 241);
      this.layoutControlGroup2.Text = "Columns";
      // 
      // splitterItem1
      // 
      this.splitterItem1.AllowHotTrack = true;
      this.splitterItem1.Location = new System.Drawing.Point(153, 0);
      this.splitterItem1.Name = "splitterItem1";
      this.splitterItem1.Size = new System.Drawing.Size(5, 198);
      // 
      // listBoxControl2
      // 
      this.listBoxControl2.Location = new System.Drawing.Point(182, 99);
      this.listBoxControl2.Name = "listBoxControl2";
      this.listBoxControl2.Size = new System.Drawing.Size(155, 178);
      this.listBoxControl2.StyleController = this.layoutControl1;
      this.listBoxControl2.TabIndex = 7;
      // 
      // layoutControlItem4
      // 
      this.layoutControlItem4.Control = this.listBoxControl2;
      this.layoutControlItem4.Location = new System.Drawing.Point(158, 0);
      this.layoutControlItem4.Name = "layoutControlItem4";
      this.layoutControlItem4.Size = new System.Drawing.Size(159, 198);
      this.layoutControlItem4.Text = "Current(0)";
      this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem4.TextSize = new System.Drawing.Size(57, 13);
      // 
      // EditMerchantForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(361, 331);
      this.Controls.Add(this.layoutControl1);
      this.Name = "EditMerchantForm";
      this.Text = "EditMerchantForm";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.splitterItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.listBoxControl2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.TextEdit textEdit1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraEditors.ListBoxControl listBoxControl2;
    private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    private DevExpress.XtraLayout.SplitterItem splitterItem1;
  }
}