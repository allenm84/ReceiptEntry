﻿namespace ReceiptEntry
{
  partial class DuplicateAmountDialog
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
      this.spinEdit1 = new DevExpress.XtraEditors.SpinEdit();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.okCancelButtons1 = new ReceiptEntry.OKCancelButtons();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Controls.Add(this.spinEdit1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(217, 92);
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
            this.layoutControlItem2});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(217, 92);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // spinEdit1
      // 
      this.spinEdit1.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.spinEdit1.Location = new System.Drawing.Point(12, 28);
      this.spinEdit1.Name = "spinEdit1";
      this.spinEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
      this.spinEdit1.Properties.IsFloatValue = false;
      this.spinEdit1.Properties.Mask.EditMask = "N00";
      this.spinEdit1.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
      this.spinEdit1.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.spinEdit1.Size = new System.Drawing.Size(193, 20);
      this.spinEdit1.StyleController = this.layoutControl1;
      this.spinEdit1.TabIndex = 4;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.spinEdit1;
      this.layoutControlItem1.CustomizationFormText = "How many copies would you like?";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(197, 40);
      this.layoutControlItem1.Text = "How many copies would you like?";
      this.layoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top;
      this.layoutControlItem1.TextSize = new System.Drawing.Size(158, 13);
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 52);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.Size = new System.Drawing.Size(193, 26);
      this.okCancelButtons1.TabIndex = 5;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.okCancelButtons1;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 40);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(197, 32);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // DuplicateAmountDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(217, 92);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "DuplicateAmountDialog";
      this.Text = "Amount";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.spinEdit1.Properties)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraEditors.SpinEdit spinEdit1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
  }
}