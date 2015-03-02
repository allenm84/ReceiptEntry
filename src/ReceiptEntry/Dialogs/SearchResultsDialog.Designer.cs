namespace ReceiptEntry
{
  partial class SearchResultsDialog
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
      this.btnPrevious = new DevExpress.XtraEditors.SimpleButton();
      this.btnNext = new DevExpress.XtraEditors.SimpleButton();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.btnPrevious);
      this.layoutControl1.Controls.Add(this.btnNext);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(816, 190, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(304, 47);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // btnPrevious
      // 
      this.btnPrevious.Location = new System.Drawing.Point(12, 12);
      this.btnPrevious.Name = "btnPrevious";
      this.btnPrevious.Size = new System.Drawing.Size(76, 22);
      this.btnPrevious.StyleController = this.layoutControl1;
      this.btnPrevious.TabIndex = 6;
      this.btnPrevious.Text = "< Previous";
      this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
      // 
      // btnNext
      // 
      this.btnNext.Location = new System.Drawing.Point(216, 12);
      this.btnNext.Name = "btnNext";
      this.btnNext.Size = new System.Drawing.Size(76, 22);
      this.btnNext.StyleController = this.layoutControl1;
      this.btnNext.TabIndex = 5;
      this.btnNext.Text = "Next >";
      this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "Root";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem1});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "Root";
      this.layoutControlGroup1.Size = new System.Drawing.Size(304, 47);
      this.layoutControlGroup1.Text = "Root";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.btnNext;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(204, 0);
      this.layoutControlItem2.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem2.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(80, 27);
      this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.btnPrevious;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem3.MaxSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.MinSize = new System.Drawing.Size(80, 26);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(80, 27);
      this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // emptySpaceItem1
      // 
      this.emptySpaceItem1.AllowHotTrack = false;
      this.emptySpaceItem1.CustomizationFormText = "emptySpaceItem1";
      this.emptySpaceItem1.Location = new System.Drawing.Point(80, 0);
      this.emptySpaceItem1.Name = "emptySpaceItem1";
      this.emptySpaceItem1.Size = new System.Drawing.Size(193, 27);
      this.emptySpaceItem1.Text = "emptySpaceItem1";
      this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
      // 
      // SearchResultsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(304, 47);
      this.Controls.Add(this.layoutControl1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
      this.Name = "SearchResultsDialog";
      this.Text = "SearchResultsDialog";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private DevExpress.XtraEditors.SimpleButton btnPrevious;
    private DevExpress.XtraEditors.SimpleButton btnNext;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
  }
}