namespace ReceiptEntry
{
  partial class SearchDialog
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchDialog));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.txtSearch = new Janus.Windows.GridEX.EditControls.EditBox();
      this.gridSearchResults = new Janus.Windows.GridEX.GridEX();
      this.progStatus = new System.Windows.Forms.ProgressBar();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.label2 = new System.Windows.Forms.Label();
      this.chkHideSimilar = new Janus.Windows.EditControls.UICheckBox();
      this.tableLayoutPanel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
      this.tableLayoutPanel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.txtSearch, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.gridSearchResults, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.progStatus, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 5;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(297, 379);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // label1
      // 
      this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(3, 3);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(98, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Text to search for:";
      // 
      // txtSearch
      // 
      this.txtSearch.AcceptsReturn = true;
      this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSearch.ButtonImage = ((System.Drawing.Image)(resources.GetObject("txtSearch.ButtonImage")));
      this.txtSearch.ButtonStyle = Janus.Windows.GridEX.EditControls.EditButtonStyle.Image;
      this.txtSearch.Location = new System.Drawing.Point(3, 23);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(291, 24);
      this.txtSearch.TabIndex = 2;
      this.txtSearch.ButtonClick += new System.EventHandler(this.txtSearch_ButtonClick);
      this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
      // 
      // gridSearchResults
      // 
      this.gridSearchResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridSearchResults.Location = new System.Drawing.Point(3, 73);
      this.gridSearchResults.Name = "gridSearchResults";
      this.gridSearchResults.Size = new System.Drawing.Size(291, 274);
      this.gridSearchResults.TabIndex = 3;
      this.gridSearchResults.RowDoubleClick += new Janus.Windows.GridEX.RowActionEventHandler(this.gridSearchResults_RowDoubleClick);
      // 
      // progStatus
      // 
      this.progStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progStatus.Location = new System.Drawing.Point(3, 353);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(291, 23);
      this.progStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progStatus.TabIndex = 4;
      // 
      // tableLayoutPanel2
      // 
      this.tableLayoutPanel2.ColumnCount = 2;
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
      this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
      this.tableLayoutPanel2.Controls.Add(this.chkHideSimilar, 1, 0);
      this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 50);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(297, 20);
      this.tableLayoutPanel2.TabIndex = 5;
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 3);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(82, 13);
      this.label2.TabIndex = 1;
      this.label2.Text = "Search Results:";
      // 
      // chkHideSimilar
      // 
      this.chkHideSimilar.Anchor = System.Windows.Forms.AnchorStyles.Right;
      this.chkHideSimilar.AutoSize = true;
      this.chkHideSimilar.Location = new System.Drawing.Point(185, 3);
      this.chkHideSimilar.Name = "chkHideSimilar";
      this.chkHideSimilar.ShowFocusRectangle = false;
      this.chkHideSimilar.Size = new System.Drawing.Size(109, 14);
      this.chkHideSimilar.TabIndex = 2;
      this.chkHideSimilar.Text = "Hide Similar Results";
      this.chkHideSimilar.CheckedChanged += new System.EventHandler(this.chkHideSimilar_CheckedChanged);
      // 
      // SearchDialog
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(297, 379);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "SearchDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ReceiptEntry Search";
      this.Load += new System.EventHandler(this.SearchDialog_Load);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.tableLayoutPanel2.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private Janus.Windows.GridEX.EditControls.EditBox txtSearch;
    private Janus.Windows.GridEX.GridEX gridSearchResults;
    private System.Windows.Forms.ProgressBar progStatus;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private Janus.Windows.EditControls.UICheckBox chkHideSimilar;
  }
}