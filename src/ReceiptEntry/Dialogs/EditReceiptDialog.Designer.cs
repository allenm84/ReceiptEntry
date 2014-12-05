namespace ReceiptEntry
{
  partial class EditReceiptDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReceiptDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new Janus.Windows.EditControls.UIButton();
      this.btnCancel = new Janus.Windows.EditControls.UIButton();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
      this.gridMapping = new Janus.Windows.GridEX.GridEX();
      this.btnEditMapping = new Janus.Windows.EditControls.UIButton();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.numTax = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.label5 = new System.Windows.Forms.Label();
      this.numTotal = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.btnEdit = new Janus.Windows.EditControls.UIButton();
      this.btnAdd = new Janus.Windows.EditControls.UIButton();
      this.gridItems = new Janus.Windows.GridEX.GridEX();
      this.cboCalendar = new System.Windows.Forms.DateTimePicker();
      this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
      this.gridPaidBy = new Janus.Windows.GridEX.GridEX();
      this.btnEditPaidBy = new Janus.Windows.EditControls.UIButton();
      this.label6 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridMapping)).BeginInit();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
      this.tableLayoutPanel7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridPaidBy)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(318, 424);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 394);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(318, 30);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(161, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 23);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(241, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 23);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "Cancel";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel7, 0, 11);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel6, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 2);
      this.tableLayoutPanel3.Controls.Add(this.label3, 0, 4);
      this.tableLayoutPanel3.Controls.Add(this.label4, 0, 6);
      this.tableLayoutPanel3.Controls.Add(this.numTax, 0, 7);
      this.tableLayoutPanel3.Controls.Add(this.label5, 0, 8);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 5);
      this.tableLayoutPanel3.Controls.Add(this.cboCalendar, 0, 3);
      this.tableLayoutPanel3.Controls.Add(this.numTotal, 0, 9);
      this.tableLayoutPanel3.Controls.Add(this.label6, 0, 10);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 12;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(318, 394);
      this.tableLayoutPanel3.TabIndex = 0;
      // 
      // tableLayoutPanel6
      // 
      this.tableLayoutPanel6.ColumnCount = 2;
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel6.Controls.Add(this.gridMapping, 0, 0);
      this.tableLayoutPanel6.Controls.Add(this.btnEditMapping, 1, 0);
      this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 20);
      this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel6.Name = "tableLayoutPanel6";
      this.tableLayoutPanel6.RowCount = 1;
      this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel6.Size = new System.Drawing.Size(318, 30);
      this.tableLayoutPanel6.TabIndex = 11;
      // 
      // gridMapping
      // 
      this.gridMapping.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridMapping.Location = new System.Drawing.Point(3, 3);
      this.gridMapping.Name = "gridMapping";
      this.gridMapping.Size = new System.Drawing.Size(261, 24);
      this.gridMapping.TabIndex = 0;
      // 
      // btnEditMapping
      // 
      this.btnEditMapping.Location = new System.Drawing.Point(270, 3);
      this.btnEditMapping.Name = "btnEditMapping";
      this.btnEditMapping.Size = new System.Drawing.Size(45, 23);
      this.btnEditMapping.TabIndex = 1;
      this.btnEditMapping.Text = "Edit";
      this.btnEditMapping.Click += new System.EventHandler(this.btnEditMapping_Click);
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(56, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Merchant:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Date:";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(38, 13);
      this.label3.TabIndex = 4;
      this.label3.Text = "Items:";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 247);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(29, 13);
      this.label4.TabIndex = 6;
      this.label4.Text = "Tax:";
      // 
      // numTax
      // 
      this.numTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numTax.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
      this.numTax.Location = new System.Drawing.Point(3, 268);
      this.numTax.Name = "numTax";
      this.numTax.Size = new System.Drawing.Size(312, 21);
      this.numTax.TabIndex = 7;
      this.numTax.Text = "$0.00";
      this.numTax.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      this.numTax.ValueChanged += new System.EventHandler(this.numTax_ValueChanged);
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 297);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 13);
      this.label5.TabIndex = 8;
      this.label5.Text = "Total:";
      // 
      // numTotal
      // 
      this.numTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numTotal.Enabled = false;
      this.numTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
      this.numTotal.Location = new System.Drawing.Point(3, 318);
      this.numTotal.Name = "numTotal";
      this.numTotal.Size = new System.Drawing.Size(312, 21);
      this.numTotal.TabIndex = 9;
      this.numTotal.Text = "$0.00";
      this.numTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel4, 1, 0);
      this.tableLayoutPanel5.Controls.Add(this.gridItems, 0, 0);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 120);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(318, 124);
      this.tableLayoutPanel5.TabIndex = 5;
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Controls.Add(this.btnEdit, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.btnAdd, 0, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(238, 0);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 3;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(80, 124);
      this.tableLayoutPanel4.TabIndex = 1;
      // 
      // btnEdit
      // 
      this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnEdit.Location = new System.Drawing.Point(3, 33);
      this.btnEdit.Name = "btnEdit";
      this.btnEdit.Size = new System.Drawing.Size(74, 23);
      this.btnEdit.TabIndex = 2;
      this.btnEdit.Text = "Edit";
      this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.Location = new System.Drawing.Point(3, 3);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(74, 23);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Add";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // gridItems
      // 
      this.gridItems.AllowCardSizing = false;
      this.gridItems.AllowColumnDrag = false;
      this.gridItems.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
      this.gridItems.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText;
      this.gridItems.ColumnAutoResize = true;
      this.gridItems.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
      this.gridItems.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridItems.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
      this.gridItems.GridLines = Janus.Windows.GridEX.GridLines.None;
      this.gridItems.GroupByBoxVisible = false;
      this.gridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
      this.gridItems.Location = new System.Drawing.Point(3, 3);
      this.gridItems.Name = "gridItems";
      this.gridItems.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
      this.gridItems.Size = new System.Drawing.Size(232, 118);
      this.gridItems.TabIndex = 0;
      this.gridItems.SelectionChanged += new System.EventHandler(this.gridItems_SelectionChanged);
      // 
      // cboCalendar
      // 
      this.cboCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.cboCalendar.Location = new System.Drawing.Point(3, 74);
      this.cboCalendar.Name = "cboCalendar";
      this.cboCalendar.Size = new System.Drawing.Size(312, 21);
      this.cboCalendar.TabIndex = 10;
      // 
      // tableLayoutPanel7
      // 
      this.tableLayoutPanel7.ColumnCount = 2;
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel7.Controls.Add(this.gridPaidBy, 0, 0);
      this.tableLayoutPanel7.Controls.Add(this.btnEditPaidBy, 1, 0);
      this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel7.Location = new System.Drawing.Point(0, 364);
      this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel7.Name = "tableLayoutPanel7";
      this.tableLayoutPanel7.RowCount = 1;
      this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel7.Size = new System.Drawing.Size(318, 30);
      this.tableLayoutPanel7.TabIndex = 12;
      // 
      // gridPaidBy
      // 
      this.gridPaidBy.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridPaidBy.Location = new System.Drawing.Point(3, 3);
      this.gridPaidBy.Name = "gridPaidBy";
      this.gridPaidBy.Size = new System.Drawing.Size(261, 24);
      this.gridPaidBy.TabIndex = 0;
      // 
      // btnEditPaidBy
      // 
      this.btnEditPaidBy.Location = new System.Drawing.Point(270, 3);
      this.btnEditPaidBy.Name = "btnEditPaidBy";
      this.btnEditPaidBy.Size = new System.Drawing.Size(45, 23);
      this.btnEditPaidBy.TabIndex = 1;
      this.btnEditPaidBy.Text = "Edit";
      this.btnEditPaidBy.Click += new System.EventHandler(this.btnEditPaidBy_Click);
      // 
      // label6
      // 
      this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(3, 347);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(46, 13);
      this.label6.TabIndex = 13;
      this.label6.Text = "Paid By:";
      // 
      // EditReceiptDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(318, 424);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditReceiptDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Load += new System.EventHandler(this.EditReceiptDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridMapping)).EndInit();
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
      this.tableLayoutPanel7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridPaidBy)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private Janus.Windows.EditControls.UIButton btnOK;
    private Janus.Windows.EditControls.UIButton btnCancel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private Janus.Windows.GridEX.GridEX gridItems;
    private Janus.Windows.EditControls.UIButton btnAdd;
    private Janus.Windows.EditControls.UIButton btnEdit;
    private System.Windows.Forms.Label label4;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numTax;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private System.Windows.Forms.Label label5;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numTotal;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.DateTimePicker cboCalendar;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    private Janus.Windows.GridEX.GridEX gridMapping;
    private Janus.Windows.EditControls.UIButton btnEditMapping;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
    private Janus.Windows.GridEX.GridEX gridPaidBy;
    private Janus.Windows.EditControls.UIButton btnEditPaidBy;
    private System.Windows.Forms.Label label6;
  }
}