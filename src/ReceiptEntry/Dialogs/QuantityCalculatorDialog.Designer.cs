namespace ReceiptEntry
{
  partial class QuantityCalculatorDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuantityCalculatorDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new Janus.Windows.EditControls.UIButton();
      this.btnCancel = new Janus.Windows.EditControls.UIButton();
      this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
      this.optUnits = new System.Windows.Forms.RadioButton();
      this.optPrice = new System.Windows.Forms.RadioButton();
      this.label4 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.numActualPrice = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.numActualUnits = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.numRatioUnits = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.numRatioPrice = new Janus.Windows.GridEX.EditControls.NumericEditBox();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.tableLayoutPanel3.SuspendLayout();
      this.tableLayoutPanel5.SuspendLayout();
      this.tableLayoutPanel4.SuspendLayout();
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
      this.tableLayoutPanel1.Size = new System.Drawing.Size(176, 232);
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
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 202);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(176, 30);
      this.tableLayoutPanel2.TabIndex = 2;
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(19, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(99, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      // 
      // tableLayoutPanel3
      // 
      this.tableLayoutPanel3.ColumnCount = 1;
      this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel5, 0, 1);
      this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
      this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel3.Name = "tableLayoutPanel3";
      this.tableLayoutPanel3.RowCount = 2;
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel3.Size = new System.Drawing.Size(176, 202);
      this.tableLayoutPanel3.TabIndex = 3;
      // 
      // tableLayoutPanel5
      // 
      this.tableLayoutPanel5.ColumnCount = 2;
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel5.Controls.Add(this.optUnits, 0, 2);
      this.tableLayoutPanel5.Controls.Add(this.optPrice, 0, 4);
      this.tableLayoutPanel5.Controls.Add(this.label4, 0, 3);
      this.tableLayoutPanel5.Controls.Add(this.label3, 0, 1);
      this.tableLayoutPanel5.Controls.Add(this.numActualPrice, 1, 4);
      this.tableLayoutPanel5.Controls.Add(this.numActualUnits, 1, 2);
      this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 101);
      this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel5.Name = "tableLayoutPanel5";
      this.tableLayoutPanel5.RowCount = 6;
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel5.Size = new System.Drawing.Size(176, 101);
      this.tableLayoutPanel5.TabIndex = 1;
      // 
      // optUnits
      // 
      this.optUnits.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.optUnits.AutoSize = true;
      this.optUnits.Checked = true;
      this.optUnits.Location = new System.Drawing.Point(8, 28);
      this.optUnits.Name = "optUnits";
      this.optUnits.Size = new System.Drawing.Size(14, 13);
      this.optUnits.TabIndex = 3;
      this.optUnits.TabStop = true;
      this.optUnits.UseVisualStyleBackColor = true;
      this.optUnits.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // optPrice
      // 
      this.optPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.optPrice.AutoSize = true;
      this.optPrice.Location = new System.Drawing.Point(8, 78);
      this.optPrice.Name = "optPrice";
      this.optPrice.Size = new System.Drawing.Size(14, 13);
      this.optPrice.TabIndex = 4;
      this.optPrice.TabStop = true;
      this.optPrice.UseVisualStyleBackColor = true;
      this.optPrice.CheckedChanged += new System.EventHandler(this.option_CheckedChanged);
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.tableLayoutPanel5.SetColumnSpan(this.label4, 2);
      this.label4.Location = new System.Drawing.Point(3, 53);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(67, 13);
      this.label4.TabIndex = 1;
      this.label4.Text = "Actual Price:";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.tableLayoutPanel5.SetColumnSpan(this.label3, 2);
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(68, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Actual Units:";
      // 
      // numActualPrice
      // 
      this.numActualPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numActualPrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
      this.numActualPrice.Location = new System.Drawing.Point(33, 74);
      this.numActualPrice.Name = "numActualPrice";
      this.numActualPrice.Size = new System.Drawing.Size(140, 21);
      this.numActualPrice.TabIndex = 3;
      this.numActualPrice.Text = "$0.00";
      this.numActualPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      // 
      // numActualUnits
      // 
      this.numActualUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numActualUnits.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
      this.numActualUnits.Location = new System.Drawing.Point(33, 24);
      this.numActualUnits.Name = "numActualUnits";
      this.numActualUnits.Size = new System.Drawing.Size(140, 21);
      this.numActualUnits.TabIndex = 2;
      this.numActualUnits.Text = "0";
      this.numActualUnits.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      // 
      // tableLayoutPanel4
      // 
      this.tableLayoutPanel4.ColumnCount = 1;
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel4.Controls.Add(this.label2, 0, 3);
      this.tableLayoutPanel4.Controls.Add(this.numRatioUnits, 0, 2);
      this.tableLayoutPanel4.Controls.Add(this.numRatioPrice, 0, 4);
      this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel4.Name = "tableLayoutPanel4";
      this.tableLayoutPanel4.RowCount = 6;
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel4.Size = new System.Drawing.Size(176, 101);
      this.tableLayoutPanel4.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Ratio Units:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(62, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Ratio Price:";
      // 
      // numRatioUnits
      // 
      this.numRatioUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numRatioUnits.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.General;
      this.numRatioUnits.Location = new System.Drawing.Point(3, 24);
      this.numRatioUnits.Name = "numRatioUnits";
      this.numRatioUnits.Size = new System.Drawing.Size(170, 21);
      this.numRatioUnits.TabIndex = 2;
      this.numRatioUnits.Text = "0";
      this.numRatioUnits.Value = new decimal(new int[] {
            0,
            0,
            0,
            0});
      // 
      // numRatioPrice
      // 
      this.numRatioPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.numRatioPrice.FormatMask = Janus.Windows.GridEX.NumericEditFormatMask.Currency;
      this.numRatioPrice.Location = new System.Drawing.Point(3, 74);
      this.numRatioPrice.Name = "numRatioPrice";
      this.numRatioPrice.Size = new System.Drawing.Size(170, 21);
      this.numRatioPrice.TabIndex = 3;
      this.numRatioPrice.Text = "$0.00";
      this.numRatioPrice.Value = new decimal(new int[] {
            0,
            0,
            0,
            131072});
      // 
      // QuantityCalculatorDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(176, 232);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "QuantityCalculatorDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Calculator";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuantityCalculatorDialog_FormClosing);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel3.ResumeLayout(false);
      this.tableLayoutPanel5.ResumeLayout(false);
      this.tableLayoutPanel5.PerformLayout();
      this.tableLayoutPanel4.ResumeLayout(false);
      this.tableLayoutPanel4.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private Janus.Windows.EditControls.UIButton btnOK;
    private Janus.Windows.EditControls.UIButton btnCancel;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numActualPrice;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numActualUnits;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numRatioUnits;
    private Janus.Windows.GridEX.EditControls.NumericEditBox numRatioPrice;
    private System.Windows.Forms.RadioButton optPrice;
    private System.Windows.Forms.RadioButton optUnits;
  }
}