namespace ReceiptEntry
{
  partial class EditReceiptItemDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditReceiptItemDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new Janus.Windows.EditControls.UIButton();
      this.btnCancel = new Janus.Windows.EditControls.UIButton();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.numPer = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.numTotal = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.numQuantity = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.btnQuantityCalculator = new Janus.Windows.EditControls.UIButton();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.gridMapping = new Janus.Windows.GridEX.GridEX();
      this.btnEditMapping = new Janus.Windows.EditControls.UIButton();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridMapping)).BeginInit();
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
      this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 231);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 3;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
      this.tableLayoutPanel2.Controls.Add(this.btnOK, 1, 0);
      this.tableLayoutPanel2.Controls.Add(this.btnCancel, 2, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 201);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 30);
      this.tableLayoutPanel2.TabIndex = 1;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(78, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(158, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel3.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.label2, 0, 3);
      this.tableLayoutPanel3.Controls.Add(this.label3, 0, 5);
      this.tableLayoutPanel3.Controls.Add(this.label4, 0, 7);
      this.tableLayoutPanel3.Controls.Add(this.numPer, 0, 6);
      this.tableLayoutPanel3.Controls.Add(this.numTotal, 0, 8);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 4);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 2);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 10;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(235, 201);
      this.tableLayoutPanel3.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(38, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Name:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(53, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Quantity:";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 103);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(78, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Price Per Item:";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 153);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(61, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Total Price:";
      // 
      // numPer
      // 
      this.numPer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numPer.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
      this.numPer.ButtonText = "U";
      this.numPer.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
      this.numPer.Location = new System.Drawing.Point(3, 124);
      this.numPer.Name = "numPer";
      this.numPer.Size = new System.Drawing.Size(229, 21);
      this.numPer.TabIndex = 6;
      this.numPer.Text = "$0.00";
      this.numPer.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      this.numPer.ButtonClick += new System.EventHandler(this.btnCalculatePer_Click);
      // 
      // numTotal
      // 
      this.numTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numTotal.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
      this.numTotal.ButtonText = "U";
      this.numTotal.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
      this.numTotal.Location = new System.Drawing.Point(3, 174);
      this.numTotal.Name = "numTotal";
      this.numTotal.Size = new System.Drawing.Size(229, 21);
      this.numTotal.TabIndex = 7;
      this.numTotal.Text = "$0.00";
      this.numTotal.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      this.numTotal.ButtonClick += new System.EventHandler(this.btnCalculateTotal_Click);
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 2;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
      this.tableLayoutPanel4.Controls.Add(this.numQuantity, 0, 0);
      this.tableLayoutPanel4.Controls.Add(this.btnQuantityCalculator, 1, 0);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 70);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 1;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(235, 30);
      this.tableLayoutPanel4.TabIndex = 9;
      // 
      // numQuantity
      // 
      this.numQuantity.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numQuantity.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.TextButton;
      this.numQuantity.ButtonText = "U";
      this.numQuantity.Location = new System.Drawing.Point(3, 4);
      this.numQuantity.Margin = new System.Windows.Forms.Padding(3, 3, 1, 3);
      this.numQuantity.Name = "numQuantity";
      this.numQuantity.Size = new System.Drawing.Size(204, 21);
      this.numQuantity.TabIndex = 8;
      this.numQuantity.Text = "0.00";
      this.numQuantity.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      this.numQuantity.ButtonClick += new System.EventHandler(this.btnCalculateQuantity_Click);
      // 
      // btnQuantityCalculator
      // 
      this.btnQuantityCalculator.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.btnQuantityCalculator.Location = new System.Drawing.Point(209, 4);
      this.btnQuantityCalculator.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
      this.btnQuantityCalculator.Name = "btnQuantityCalculator";
      this.btnQuantityCalculator.Size = new System.Drawing.Size(23, 21);
      this.btnQuantityCalculator.TabIndex = 9;
      this.btnQuantityCalculator.Text = "C";
      this.btnQuantityCalculator.Click += new System.EventHandler(this.btnQuantityCalculator_Click);
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel5.Controls.Add(this.gridMapping, 0, 0);
      this.tableLayoutPanel5.Controls.Add(this.btnEditMapping, 1, 0);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 20);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 1;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(235, 30);
      this.tableLayoutPanel5.TabIndex = 10;
      // 
      // gridMapping
      // 
      this.gridMapping.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridMapping.Location = new System.Drawing.Point(3, 3);
      this.gridMapping.Name = "gridMapping";
      this.gridMapping.Size = new System.Drawing.Size(178, 24);
      this.gridMapping.TabIndex = 0;
      // 
      // btnEditMapping
      // 
      this.btnEditMapping.Location = new System.Drawing.Point(187, 3);
      this.btnEditMapping.Name = "btnEditMapping";
      this.btnEditMapping.Size = new System.Drawing.Size(45, 23);
      this.btnEditMapping.TabIndex = 1;
      this.btnEditMapping.Text = "Edit";
      this.btnEditMapping.Click += new System.EventHandler(this.btnEditMapping_Click);
      // 
      // EditReceiptItemDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(235, 231);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "EditReceiptItemDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EditReceiptItemDialog_FormClosing);
      this.Load += new System.EventHandler(this.EditReceiptItemDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel3.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.tableLayoutPanel5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridMapping)).EndInit();
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
    private System.Windows.Forms.Label label4;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numPer;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numTotal;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numQuantity;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private Janus.Windows.EditControls.UIButton btnQuantityCalculator;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private Janus.Windows.GridEX.GridEX gridMapping;
    private Janus.Windows.EditControls.UIButton btnEditMapping;
  }
}