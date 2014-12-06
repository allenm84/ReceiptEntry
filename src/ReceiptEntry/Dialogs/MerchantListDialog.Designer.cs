namespace ReceiptEntry
{
  partial class MerchantListDialog
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
      this.editorButtons = new ReceiptEntry.EditorButtons();
      this.lstMerchants = new DevExpress.XtraEditors.ListBoxControl();
      this.okCancelButtons1 = new ReceiptEntry.OKCancelButtons();
      this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
      this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
      this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
      this.layoutControl1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.lstMerchants)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
      this.SuspendLayout();
      // 
      // layoutControl1
      // 
      this.layoutControl1.Controls.Add(this.editorButtons);
      this.layoutControl1.Controls.Add(this.lstMerchants);
      this.layoutControl1.Controls.Add(this.okCancelButtons1);
      this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.layoutControl1.Location = new System.Drawing.Point(0, 0);
      this.layoutControl1.Name = "layoutControl1";
      this.layoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(634, 87, 250, 350);
      this.layoutControl1.Root = this.layoutControlGroup1;
      this.layoutControl1.Size = new System.Drawing.Size(322, 261);
      this.layoutControl1.TabIndex = 0;
      this.layoutControl1.Text = "layoutControl1";
      // 
      // editorButtons
      // 
      this.editorButtons.Location = new System.Drawing.Point(230, 12);
      this.editorButtons.MaximumSize = new System.Drawing.Size(80, 0);
      this.editorButtons.MinimumSize = new System.Drawing.Size(80, 120);
      this.editorButtons.Name = "editorButtons";
      this.editorButtons.Size = new System.Drawing.Size(80, 207);
      this.editorButtons.TabIndex = 6;
      this.editorButtons.AddClick += new System.EventHandler(this.editorButtons_AddClick);
      this.editorButtons.EditClick += new System.EventHandler(this.editorButtons_EditClick);
      this.editorButtons.RemoveClick += new System.EventHandler(this.editorButtons_RemoveClick);
      this.editorButtons.ClearClick += new System.EventHandler(this.editorButtons_ClearClick);
      // 
      // lstMerchants
      // 
      this.lstMerchants.IncrementalSearch = true;
      this.lstMerchants.Location = new System.Drawing.Point(12, 12);
      this.lstMerchants.Name = "lstMerchants";
      this.lstMerchants.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
      this.lstMerchants.Size = new System.Drawing.Size(214, 207);
      this.lstMerchants.SortOrder = System.Windows.Forms.SortOrder.Ascending;
      this.lstMerchants.StyleController = this.layoutControl1;
      this.lstMerchants.TabIndex = 5;
      this.lstMerchants.SelectedIndexChanged += new System.EventHandler(this.lstMerchants_SelectedIndexChanged);
      this.lstMerchants.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstMerchants_MouseDoubleClick);
      // 
      // okCancelButtons1
      // 
      this.okCancelButtons1.Location = new System.Drawing.Point(12, 223);
      this.okCancelButtons1.MaximumSize = new System.Drawing.Size(0, 26);
      this.okCancelButtons1.MinimumSize = new System.Drawing.Size(170, 26);
      this.okCancelButtons1.Name = "okCancelButtons1";
      this.okCancelButtons1.Size = new System.Drawing.Size(298, 26);
      this.okCancelButtons1.TabIndex = 4;
      // 
      // layoutControlGroup1
      // 
      this.layoutControlGroup1.CustomizationFormText = "layoutControlGroup1";
      this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
      this.layoutControlGroup1.GroupBordersVisible = false;
      this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem2,
            this.layoutControlItem1,
            this.layoutControlItem3});
      this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
      this.layoutControlGroup1.Name = "layoutControlGroup1";
      this.layoutControlGroup1.Size = new System.Drawing.Size(322, 261);
      this.layoutControlGroup1.Text = "layoutControlGroup1";
      this.layoutControlGroup1.TextVisible = false;
      // 
      // layoutControlItem2
      // 
      this.layoutControlItem2.Control = this.lstMerchants;
      this.layoutControlItem2.CustomizationFormText = "layoutControlItem2";
      this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
      this.layoutControlItem2.Name = "layoutControlItem2";
      this.layoutControlItem2.Size = new System.Drawing.Size(218, 211);
      this.layoutControlItem2.Text = "layoutControlItem2";
      this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem2.TextToControlDistance = 0;
      this.layoutControlItem2.TextVisible = false;
      // 
      // layoutControlItem1
      // 
      this.layoutControlItem1.Control = this.okCancelButtons1;
      this.layoutControlItem1.CustomizationFormText = "layoutControlItem1";
      this.layoutControlItem1.Location = new System.Drawing.Point(0, 211);
      this.layoutControlItem1.Name = "layoutControlItem1";
      this.layoutControlItem1.Size = new System.Drawing.Size(302, 30);
      this.layoutControlItem1.Text = "layoutControlItem1";
      this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem1.TextToControlDistance = 0;
      this.layoutControlItem1.TextVisible = false;
      // 
      // layoutControlItem3
      // 
      this.layoutControlItem3.Control = this.editorButtons;
      this.layoutControlItem3.CustomizationFormText = "layoutControlItem3";
      this.layoutControlItem3.Location = new System.Drawing.Point(218, 0);
      this.layoutControlItem3.Name = "layoutControlItem3";
      this.layoutControlItem3.Size = new System.Drawing.Size(84, 211);
      this.layoutControlItem3.Text = "layoutControlItem3";
      this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
      this.layoutControlItem3.TextToControlDistance = 0;
      this.layoutControlItem3.TextVisible = false;
      // 
      // MerchantListDialog
      // 
      this.AcceptButton = this.okCancelButtons1.OK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.okCancelButtons1.Cancel;
      this.ClientSize = new System.Drawing.Size(322, 261);
      this.Controls.Add(this.layoutControl1);
      this.Name = "MerchantListDialog";
      this.Text = "Merchants";
      ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
      this.layoutControl1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.lstMerchants)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private DevExpress.XtraLayout.LayoutControl layoutControl1;
    private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
    private OKCancelButtons okCancelButtons1;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    private DevExpress.XtraEditors.ListBoxControl lstMerchants;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    private EditorButtons editorButtons;
    private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
  }
}