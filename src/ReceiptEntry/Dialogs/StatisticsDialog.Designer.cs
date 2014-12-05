namespace ReceiptEntry
{
  partial class StatisticsDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StatisticsDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.gridCategories = new Janus.Windows.GridEX.GridEX();
      this.gridData = new Janus.Windows.GridEX.GridEX();
      this.progStatus = new System.Windows.Forms.ProgressBar();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridData)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
      this.tableLayoutPanel1.Controls.Add(this.gridCategories, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.gridData, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.progStatus, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 3;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(627, 341);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(63, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Categories:";
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(123, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(34, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Data:";
      // 
      // gridCategories
      // 
      this.gridCategories.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridCategories.Location = new System.Drawing.Point(3, 23);
      this.gridCategories.Name = "gridCategories";
      this.gridCategories.Size = new System.Drawing.Size(114, 286);
      this.gridCategories.TabIndex = 2;
      this.gridCategories.SelectionChanged += new System.EventHandler(this.gridCategories_SelectionChanged);
      // 
      // gridData
      // 
      this.gridData.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridData.Location = new System.Drawing.Point(123, 23);
      this.gridData.Name = "gridData";
      this.gridData.Size = new System.Drawing.Size(501, 286);
      this.gridData.TabIndex = 3;
      // 
      // progStatus
      // 
      this.tableLayoutPanel1.SetColumnSpan(this.progStatus, 2);
      this.progStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progStatus.Location = new System.Drawing.Point(3, 315);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(621, 23);
      this.progStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progStatus.TabIndex = 4;
      // 
      // StatisticsDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(627, 341);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "StatisticsDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "ReceiptEntry Statistics";
      this.Load += new System.EventHandler(this.StatisticsDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridCategories)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.gridData)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private Janus.Windows.GridEX.GridEX gridCategories;
    private Janus.Windows.GridEX.GridEX gridData;
    private System.Windows.Forms.ProgressBar progStatus;
  }
}