namespace ReceiptEntry
{
  partial class DataSelectionDialog<TData>
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
      this.btnOK = new Janus.Windows.EditControls.UIButton();
      this.btnCancel = new Janus.Windows.EditControls.UIButton();
      this.pnlFilter = new System.Windows.Forms.TableLayoutPanel();
      this.txtFilter = new Janus.Windows.GridEX.EditControls.EditBox();
      this.btnAdd = new Janus.Windows.EditControls.UIButton();
      this.label3 = new System.Windows.Forms.Label();
      this.gridItems = new Janus.Windows.GridEX.GridEX();
      this.label2 = new System.Windows.Forms.Label();
      this.bgSearchWorker = new System.ComponentModel.BackgroundWorker();
      this.tableLayoutPanel1.SuspendLayout();
      this.tableLayoutPanel2.SuspendLayout();
      this.pnlFilter.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).BeginInit();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.pnlFilter, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.gridItems, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 4;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(317, 414);
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
      this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 384);
      this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
      this.tableLayoutPanel2.Name = "tableLayoutPanel2";
      this.tableLayoutPanel2.RowCount = 1;
      this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel2.Size = new System.Drawing.Size(317, 30);
      this.tableLayoutPanel2.TabIndex = 5;
      // 
      // btnOK
      // 
      this.btnOK.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.Location = new System.Drawing.Point(160, 3);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(74, 23);
      this.btnOK.TabIndex = 0;
      this.btnOK.Text = "OK";
      // 
      // btnCancel
      // 
      this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(240, 3);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(74, 23);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "Cancel";
      // 
      // pnlFilter
      // 
      this.pnlFilter.ColumnCount = 2;
      this.pnlFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.pnlFilter.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
      this.pnlFilter.Controls.Add(this.txtFilter, 0, 1);
      this.pnlFilter.Controls.Add(this.btnAdd, 1, 1);
      this.pnlFilter.Controls.Add(this.label3, 0, 0);
      this.pnlFilter.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlFilter.Location = new System.Drawing.Point(0, 0);
      this.pnlFilter.Margin = new System.Windows.Forms.Padding(0);
      this.pnlFilter.Name = "pnlFilter";
      this.pnlFilter.RowCount = 2;
      this.pnlFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
      this.pnlFilter.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.pnlFilter.Size = new System.Drawing.Size(317, 50);
      this.pnlFilter.TabIndex = 1;
      // 
      // txtFilter
      // 
      this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.txtFilter.Location = new System.Drawing.Point(3, 24);
      this.txtFilter.Name = "txtFilter";
      this.txtFilter.Size = new System.Drawing.Size(251, 21);
      this.txtFilter.TabIndex = 0;
      this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
      this.txtFilter.Enter += new System.EventHandler(this.txtFilter_Enter);
      this.txtFilter.Leave += new System.EventHandler(this.txtFilter_Leave);
      // 
      // btnAdd
      // 
      this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAdd.Location = new System.Drawing.Point(260, 23);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(54, 23);
      this.btnAdd.TabIndex = 1;
      this.btnAdd.Text = "Create";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // label3
      // 
      this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(3, 3);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(35, 13);
      this.label3.TabIndex = 0;
      this.label3.Text = "Filter:";
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
      this.gridItems.GroupByBoxVisible = false;
      this.gridItems.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
      this.gridItems.Location = new System.Drawing.Point(3, 73);
      this.gridItems.Name = "gridItems";
      this.gridItems.Size = new System.Drawing.Size(311, 308);
      this.gridItems.TabIndex = 3;
      this.gridItems.SelectionChanged += new System.EventHandler(this.gridItems_SelectionChanged);
      // 
      // label2
      // 
      this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(3, 53);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(65, 13);
      this.label2.TabIndex = 2;
      this.label2.Text = "Select Item:";
      // 
      // bgSearchWorker
      // 
      this.bgSearchWorker.WorkerReportsProgress = true;
      // 
      // DataSelectionDialog
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(317, 414);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Name = "DataSelectionDialog";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Items";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.tableLayoutPanel2.ResumeLayout(false);
      this.pnlFilter.ResumeLayout(false);
      this.pnlFilter.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridItems)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    private Janus.Windows.EditControls.UIButton btnOK;
    private Janus.Windows.EditControls.UIButton btnCancel;
    private System.Windows.Forms.Label label2;
    private Janus.Windows.GridEX.GridEX gridItems;
    private System.ComponentModel.BackgroundWorker bgSearchWorker;
    private System.Windows.Forms.Label label3;
    private Janus.Windows.GridEX.EditControls.EditBox txtFilter;
    private System.Windows.Forms.TableLayoutPanel pnlFilter;
    private Janus.Windows.EditControls.UIButton btnAdd;
  }
}