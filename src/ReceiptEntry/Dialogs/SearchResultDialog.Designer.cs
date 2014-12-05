namespace ReceiptEntry
{
  partial class SearchResultDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchResultDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.gridLinks = new Janus.Windows.GridEX.GridEX();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.lblCount = new System.Windows.Forms.Label();
      this.lblMinimum = new System.Windows.Forms.Label();
      this.lblAverage = new System.Windows.Forms.Label();
      this.lblMaximum = new System.Windows.Forms.Label();
      this.lblTotal = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridLinks)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel1.Controls.Add(this.gridLinks, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 1;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 288);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // gridLinks
      // 
      this.gridLinks.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridLinks.Location = new System.Drawing.Point(3, 3);
      this.gridLinks.Name = "gridLinks";
      this.gridLinks.Size = new System.Drawing.Size(309, 282);
      this.gridLinks.TabIndex = 1;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 1;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
      this.tableLayoutPanel2.Controls.Add(this.label3, 0, 5);
      this.tableLayoutPanel2.Controls.Add(this.label4, 0, 7);
      this.tableLayoutPanel2.Controls.Add(this.label5, 0, 9);
      this.tableLayoutPanel2.Controls.Add(this.lblCount, 0, 2);
      this.tableLayoutPanel2.Controls.Add(this.lblMinimum, 0, 4);
      this.tableLayoutPanel2.Controls.Add(this.lblAverage, 0, 6);
      this.tableLayoutPanel2.Controls.Add(this.lblMaximum, 0, 8);
      this.tableLayoutPanel2.Controls.Add(this.lblTotal, 0, 10);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(315, 0);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 12;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(120, 288);
      this.tableLayoutPanel2.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 32);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Count:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 78);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(51, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Minimum:";
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 124);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(52, 13);
      this.label3.TabIndex = 2;
      this.label3.Text = "Average:";
      // 
      // label4
      // 
      this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(3, 170);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(55, 13);
      this.label4.TabIndex = 3;
      this.label4.Text = "Maximum:";
      // 
      // label5
      // 
      this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(3, 216);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(35, 13);
      this.label5.TabIndex = 4;
      this.label5.Text = "Total:";
      // 
      // lblCount
      // 
      this.lblCount.BackColor = System.Drawing.SystemColors.Window;
      this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblCount.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblCount.Location = new System.Drawing.Point(3, 52);
      this.lblCount.Margin = new System.Windows.Forms.Padding(3);
      this.lblCount.Name = "lblCount";
      this.lblCount.Size = new System.Drawing.Size(114, 20);
      this.lblCount.TabIndex = 5;
      this.lblCount.Text = "0";
      this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblMinimum
      // 
      this.lblMinimum.BackColor = System.Drawing.SystemColors.Window;
      this.lblMinimum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMinimum.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMinimum.Location = new System.Drawing.Point(3, 98);
      this.lblMinimum.Margin = new System.Windows.Forms.Padding(3);
      this.lblMinimum.Name = "lblMinimum";
      this.lblMinimum.Size = new System.Drawing.Size(114, 20);
      this.lblMinimum.TabIndex = 6;
      this.lblMinimum.Text = "$0.00";
      this.lblMinimum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblAverage
      // 
      this.lblAverage.BackColor = System.Drawing.SystemColors.Window;
      this.lblAverage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblAverage.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblAverage.Location = new System.Drawing.Point(3, 144);
      this.lblAverage.Margin = new System.Windows.Forms.Padding(3);
      this.lblAverage.Name = "lblAverage";
      this.lblAverage.Size = new System.Drawing.Size(114, 20);
      this.lblAverage.TabIndex = 7;
      this.lblAverage.Text = "$0.00";
      this.lblAverage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblMaximum
      // 
      this.lblMaximum.BackColor = System.Drawing.SystemColors.Window;
      this.lblMaximum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblMaximum.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblMaximum.Location = new System.Drawing.Point(3, 190);
      this.lblMaximum.Margin = new System.Windows.Forms.Padding(3);
      this.lblMaximum.Name = "lblMaximum";
      this.lblMaximum.Size = new System.Drawing.Size(114, 20);
      this.lblMaximum.TabIndex = 8;
      this.lblMaximum.Text = "$0.00";
      this.lblMaximum.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblTotal
      // 
      this.lblTotal.BackColor = System.Drawing.SystemColors.Window;
      this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblTotal.Dock = System.Windows.Forms.DockStyle.Fill;
      this.lblTotal.Location = new System.Drawing.Point(3, 236);
      this.lblTotal.Margin = new System.Windows.Forms.Padding(3);
      this.lblTotal.Name = "lblTotal";
      this.lblTotal.Size = new System.Drawing.Size(114, 20);
      this.lblTotal.TabIndex = 9;
      this.lblTotal.Text = "$0.00";
      this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // SearchResultDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(435, 288);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "SearchResultDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "SearchResultDialog";
      this.Load += new System.EventHandler(this.SearchResultDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridLinks)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private Janus.Windows.GridEX.GridEX gridLinks;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label lblCount;
    private System.Windows.Forms.Label lblMinimum;
    private System.Windows.Forms.Label lblAverage;
    private System.Windows.Forms.Label lblMaximum;
    private System.Windows.Forms.Label lblTotal;
  }
}