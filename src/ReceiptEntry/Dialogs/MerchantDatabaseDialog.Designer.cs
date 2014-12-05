namespace ReceiptEntry
{
  partial class MerchantDatabaseDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MerchantDatabaseDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new Janus.Windows.EditControls.UIButton();
      this.btnCancel = new Janus.Windows.EditControls.UIButton();
      this.gridMerchants = new Janus.Windows.GridEX.GridEX();
      this.pnlButtons = new System.Windows.Forms.TableLayoutPanel();
      this.btnAdd = new Janus.Windows.EditControls.UIButton();
      this.btnEdit = new Janus.Windows.EditControls.UIButton();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridMerchants)).BeginInit();
      this.pnlButtons.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.gridMerchants, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.pnlButtons, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 412);
      this.tableLayoutPanel1.TabIndex = 2;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel1.SetColumnSpan(this.tableLayoutPanel2, 2);
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 382);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(374, 30);
      this.tableLayoutPanel2.TabIndex = 2;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(217, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(297, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      // 
      // gridMerchants
      // 
      this.gridMerchants.AllowCardSizing = false;
      this.gridMerchants.AllowColumnDrag = false;
      this.gridMerchants.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
      this.gridMerchants.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText;
      this.gridMerchants.ColumnAutoResize = true;
      this.gridMerchants.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
      this.gridMerchants.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridMerchants.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
      this.gridMerchants.GridLines = Janus.Windows.GridEX.GridLines.RowOutline;
      this.gridMerchants.GroupByBoxVisible = false;
      this.gridMerchants.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
      this.gridMerchants.Location = new System.Drawing.Point(3, 3);
      this.gridMerchants.Name = "gridMerchants";
      this.gridMerchants.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
      this.gridMerchants.Size = new System.Drawing.Size(288, 376);
      this.gridMerchants.TabIndex = 0;
      this.gridMerchants.SelectionChanged += new System.EventHandler(this.gridMerchants_SelectionChanged);
      // 
      // pnlButtons
      // 
      this.pnlButtons.ColumnCount = 1;
      this.pnlButtons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.pnlButtons.Controls.Add(this.btnAdd, 0, 0);
      this.pnlButtons.Controls.Add(this.btnEdit, 0, 1);
      this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlButtons.Location = new System.Drawing.Point(294, 0);
      this.pnlButtons.Margin = new System.Windows.Forms.Padding(0);
      this.pnlButtons.Name = "pnlButtons";
      this.pnlButtons.RowCount = 3;
      this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.pnlButtons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.pnlButtons.Size = new System.Drawing.Size(80, 382);
      this.pnlButtons.TabIndex = 1;
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnAdd.Location = new System.Drawing.Point(3, 3);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(74, 23);
      this.btnAdd.TabIndex = 0;
      this.btnAdd.Text = "Add";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnEdit
      // 
      this.btnEdit.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnEdit.Location = new System.Drawing.Point(3, 33);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(74, 23);
      this.btnEdit.TabIndex = 1;
      this.btnEdit.Text = "Edit";
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // MerchantDatabaseDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(374, 412);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MerchantDatabaseDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Merchants";
      this.Load += new System.EventHandler(this.MerchantDatabaseDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridMerchants)).EndInit();
      this.pnlButtons.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private Janus.Windows.EditControls.UIButton btnOK;
    private Janus.Windows.EditControls.UIButton btnCancel;
    private Janus.Windows.GridEX.GridEX gridMerchants;
    private System.Windows.Forms.TableLayoutPanel pnlButtons;
    private Janus.Windows.EditControls.UIButton btnAdd;
    private Janus.Windows.EditControls.UIButton btnEdit;
  }
}