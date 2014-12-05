namespace ReceiptEntry
{
  partial class MainForm
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
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.uiCommandManager = new Janus.Windows.UI.CommandBars.UICommandManager(this.components);
      this.BottomRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
      this.uiCommandBar = new Janus.Windows.UI.CommandBars.UICommandBar();
      this.tbbSave = new Janus.Windows.UI.CommandBars.UICommand("SaveCommand");
      this.Separator2 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
      this.tbbMerchantsDatabase = new Janus.Windows.UI.CommandBars.UICommand("MerchantDatabaseCommand");
      this.tbbItemsDatabase = new Janus.Windows.UI.CommandBars.UICommand("ItemsDatabaseCommand");
      this.Separator1 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
      this.tbbAddReceipt = new Janus.Windows.UI.CommandBars.UICommand("AddReceiptCommand");
      this.tbbEditReceipt = new Janus.Windows.UI.CommandBars.UICommand("EditReceiptCommand");
      this.tbbRemoveReceipt = new Janus.Windows.UI.CommandBars.UICommand("RemoveReceiptCommand");
      this.Separator3 = new Janus.Windows.UI.CommandBars.UICommand("Separator");
      this.tbbStatistics = new Janus.Windows.UI.CommandBars.UICommand("StatisticsCommand");
      this.tbbSearch = new Janus.Windows.UI.CommandBars.UICommand("SearchCommand");
      this.SaveCommand = new Janus.Windows.UI.CommandBars.UICommand("SaveCommand");
      this.AddReceiptCommand = new Janus.Windows.UI.CommandBars.UICommand("AddReceiptCommand");
      this.EditReceiptCommand = new Janus.Windows.UI.CommandBars.UICommand("EditReceiptCommand");
      this.RemoveReceiptCommand = new Janus.Windows.UI.CommandBars.UICommand("RemoveReceiptCommand");
      this.ItemsDatabaseCommand = new Janus.Windows.UI.CommandBars.UICommand("ItemsDatabaseCommand");
      this.MerchantDatabaseCommand = new Janus.Windows.UI.CommandBars.UICommand("MerchantDatabaseCommand");
      this.StatisticsCommand = new Janus.Windows.UI.CommandBars.UICommand("StatisticsCommand");
      this.SearchCommand = new Janus.Windows.UI.CommandBars.UICommand("SearchCommand");
      this.LeftRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
      this.RightRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
      this.TopRebar1 = new Janus.Windows.UI.CommandBars.UIRebar();
      this.gridReceipts = new Janus.Windows.GridEX.GridEX();
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.progStatus = new System.Windows.Forms.ProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).BeginInit();
      this.TopRebar1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).BeginInit();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // uiCommandManager
      // 
      this.uiCommandManager.AllowClose = Janus.Windows.UI.InheritableBoolean.False;
      this.uiCommandManager.AllowCustomize = Janus.Windows.UI.InheritableBoolean.False;
      this.uiCommandManager.AllowMerge = false;
      this.uiCommandManager.BottomRebar = this.BottomRebar1;
      this.uiCommandManager.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar});
      this.uiCommandManager.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.SaveCommand,
            this.AddReceiptCommand,
            this.EditReceiptCommand,
            this.RemoveReceiptCommand,
            this.ItemsDatabaseCommand,
            this.MerchantDatabaseCommand,
            this.StatisticsCommand,
            this.SearchCommand});
      this.uiCommandManager.ContainerControl = this;
      this.uiCommandManager.Id = new System.Guid("2f451b2c-23b8-4d75-a347-afc65480f7f6");
      this.uiCommandManager.LeftRebar = this.LeftRebar1;
      this.uiCommandManager.LockCommandBars = true;
      this.uiCommandManager.RightRebar = this.RightRebar1;
      this.uiCommandManager.ShowAddRemoveButton = Janus.Windows.UI.InheritableBoolean.False;
      this.uiCommandManager.ShowCustomizeButton = Janus.Windows.UI.InheritableBoolean.False;
      this.uiCommandManager.ShowQuickCustomizeMenu = false;
      this.uiCommandManager.Tag = null;
      this.uiCommandManager.TopRebar = this.TopRebar1;
      // 
      // BottomRebar1
      // 
      this.BottomRebar1.CommandManager = this.uiCommandManager;
      this.BottomRebar1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.BottomRebar1.Location = new System.Drawing.Point(0, 471);
      this.BottomRebar1.Name = "BottomRebar1";
      this.BottomRebar1.Size = new System.Drawing.Size(550, 0);
      // 
      // uiCommandBar
      // 
      this.uiCommandBar.CommandManager = this.uiCommandManager;
      this.uiCommandBar.Commands.AddRange(new Janus.Windows.UI.CommandBars.UICommand[] {
            this.tbbSave,
            this.Separator2,
            this.tbbMerchantsDatabase,
            this.tbbItemsDatabase,
            this.Separator1,
            this.tbbAddReceipt,
            this.tbbEditReceipt,
            this.tbbRemoveReceipt,
            this.Separator3,
            this.tbbStatistics,
            this.tbbSearch});
      this.uiCommandBar.FullRow = true;
      this.uiCommandBar.Key = "TopCommandBar";
      this.uiCommandBar.Location = new System.Drawing.Point(0, 0);
      this.uiCommandBar.Name = "uiCommandBar";
      this.uiCommandBar.RowIndex = 0;
      this.uiCommandBar.Size = new System.Drawing.Size(550, 28);
      this.uiCommandBar.Text = "TopCommandBar";
      // 
      // tbbSave
      // 
      this.tbbSave.Key = "SaveCommand";
      this.tbbSave.Name = "tbbSave";
      // 
      // Separator2
      // 
      this.Separator2.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
      this.Separator2.Key = "Separator";
      this.Separator2.Name = "Separator2";
      // 
      // tbbMerchantsDatabase
      // 
      this.tbbMerchantsDatabase.Key = "MerchantDatabaseCommand";
      this.tbbMerchantsDatabase.Name = "tbbMerchantsDatabase";
      // 
      // tbbItemsDatabase
      // 
      this.tbbItemsDatabase.Key = "ItemsDatabaseCommand";
      this.tbbItemsDatabase.Name = "tbbItemsDatabase";
      // 
      // Separator1
      // 
      this.Separator1.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
      this.Separator1.Key = "Separator";
      this.Separator1.Name = "Separator1";
      // 
      // tbbAddReceipt
      // 
      this.tbbAddReceipt.Key = "AddReceiptCommand";
      this.tbbAddReceipt.Name = "tbbAddReceipt";
      // 
      // tbbEditReceipt
      // 
      this.tbbEditReceipt.Key = "EditReceiptCommand";
      this.tbbEditReceipt.Name = "tbbEditReceipt";
      // 
      // tbbRemoveReceipt
      // 
      this.tbbRemoveReceipt.Key = "RemoveReceiptCommand";
      this.tbbRemoveReceipt.Name = "tbbRemoveReceipt";
      // 
      // Separator3
      // 
      this.Separator3.CommandType = Janus.Windows.UI.CommandBars.CommandType.Separator;
      this.Separator3.Key = "Separator";
      this.Separator3.Name = "Separator3";
      // 
      // tbbStatistics
      // 
      this.tbbStatistics.Key = "StatisticsCommand";
      this.tbbStatistics.Name = "tbbStatistics";
      // 
      // tbbSearch
      // 
      this.tbbSearch.Key = "SearchCommand";
      this.tbbSearch.Name = "tbbSearch";
      // 
      // SaveCommand
      // 
      this.SaveCommand.Image = ((System.Drawing.Image)(resources.GetObject("SaveCommand.Image")));
      this.SaveCommand.Key = "SaveCommand";
      this.SaveCommand.Name = "SaveCommand";
      this.SaveCommand.Shortcut = System.Windows.Forms.Shortcut.CtrlS;
      this.SaveCommand.Text = "Save";
      this.SaveCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.SaveCommand_Click);
      // 
      // AddReceiptCommand
      // 
      this.AddReceiptCommand.Image = ((System.Drawing.Image)(resources.GetObject("AddReceiptCommand.Image")));
      this.AddReceiptCommand.Key = "AddReceiptCommand";
      this.AddReceiptCommand.Name = "AddReceiptCommand";
      this.AddReceiptCommand.Text = "Add";
      this.AddReceiptCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.AddReceiptCommand_Click);
      // 
      // EditReceiptCommand
      // 
      this.EditReceiptCommand.Image = ((System.Drawing.Image)(resources.GetObject("EditReceiptCommand.Image")));
      this.EditReceiptCommand.Key = "EditReceiptCommand";
      this.EditReceiptCommand.Name = "EditReceiptCommand";
      this.EditReceiptCommand.Text = "Edit";
      this.EditReceiptCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.EditReceiptCommand_Click);
      // 
      // RemoveReceiptCommand
      // 
      this.RemoveReceiptCommand.Image = ((System.Drawing.Image)(resources.GetObject("RemoveReceiptCommand.Image")));
      this.RemoveReceiptCommand.Key = "RemoveReceiptCommand";
      this.RemoveReceiptCommand.Name = "RemoveReceiptCommand";
      this.RemoveReceiptCommand.Shortcut = System.Windows.Forms.Shortcut.Del;
      this.RemoveReceiptCommand.Text = "Remove";
      this.RemoveReceiptCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.RemoveReceiptCommand_Click);
      // 
      // ItemsDatabaseCommand
      // 
      this.ItemsDatabaseCommand.Image = ((System.Drawing.Image)(resources.GetObject("ItemsDatabaseCommand.Image")));
      this.ItemsDatabaseCommand.Key = "ItemsDatabaseCommand";
      this.ItemsDatabaseCommand.Name = "ItemsDatabaseCommand";
      this.ItemsDatabaseCommand.Text = "Items";
      this.ItemsDatabaseCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.ItemsDatabaseCommand_Click);
      // 
      // MerchantDatabaseCommand
      // 
      this.MerchantDatabaseCommand.Image = ((System.Drawing.Image)(resources.GetObject("MerchantDatabaseCommand.Image")));
      this.MerchantDatabaseCommand.Key = "MerchantDatabaseCommand";
      this.MerchantDatabaseCommand.Name = "MerchantDatabaseCommand";
      this.MerchantDatabaseCommand.Text = "Merchants";
      this.MerchantDatabaseCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.MerchantDatabaseCommand_Click);
      // 
      // StatisticsCommand
      // 
      this.StatisticsCommand.Image = ((System.Drawing.Image)(resources.GetObject("StatisticsCommand.Image")));
      this.StatisticsCommand.Key = "StatisticsCommand";
      this.StatisticsCommand.Name = "StatisticsCommand";
      this.StatisticsCommand.Text = "Stats";
      this.StatisticsCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.StatisticsCommand_Click);
      // 
      // SearchCommand
      // 
      this.SearchCommand.Image = ((System.Drawing.Image)(resources.GetObject("SearchCommand.Image")));
      this.SearchCommand.Key = "SearchCommand";
      this.SearchCommand.Name = "SearchCommand";
      this.SearchCommand.Text = "Search";
      this.SearchCommand.Click += new Janus.Windows.UI.CommandBars.CommandEventHandler(this.SearchCommand_Click);
      // 
      // LeftRebar1
      // 
      this.LeftRebar1.CommandManager = this.uiCommandManager;
      this.LeftRebar1.Dock = System.Windows.Forms.DockStyle.Left;
      this.LeftRebar1.Location = new System.Drawing.Point(0, 28);
      this.LeftRebar1.Name = "LeftRebar1";
      this.LeftRebar1.Size = new System.Drawing.Size(0, 443);
      // 
      // RightRebar1
      // 
      this.RightRebar1.CommandManager = this.uiCommandManager;
      this.RightRebar1.Dock = System.Windows.Forms.DockStyle.Right;
      this.RightRebar1.Location = new System.Drawing.Point(550, 28);
      this.RightRebar1.Name = "RightRebar1";
      this.RightRebar1.Size = new System.Drawing.Size(0, 443);
      // 
      // TopRebar1
      // 
      this.TopRebar1.CommandBars.AddRange(new Janus.Windows.UI.CommandBars.UICommandBar[] {
            this.uiCommandBar});
      this.TopRebar1.CommandManager = this.uiCommandManager;
      this.TopRebar1.Controls.Add(this.uiCommandBar);
      this.TopRebar1.Dock = System.Windows.Forms.DockStyle.Top;
      this.TopRebar1.Location = new System.Drawing.Point(0, 0);
      this.TopRebar1.Name = "TopRebar1";
      this.TopRebar1.Size = new System.Drawing.Size(550, 28);
      // 
      // gridReceipts
      // 
      this.gridReceipts.AllowCardSizing = false;
      this.gridReceipts.AllowColumnDrag = false;
      this.gridReceipts.AllowEdit = Janus.Windows.GridEX.InheritableBoolean.False;
      this.gridReceipts.CellToolTip = Janus.Windows.GridEX.CellToolTip.TruncatedText;
      this.gridReceipts.ColumnAutoResize = true;
      this.gridReceipts.ColumnHeaders = Janus.Windows.GridEX.InheritableBoolean.False;
      this.gridReceipts.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gridReceipts.FocusCellDisplayMode = Janus.Windows.GridEX.FocusCellDisplayMode.UseSelectedFormatStyle;
      this.gridReceipts.GridLines = Janus.Windows.GridEX.GridLines.None;
      this.gridReceipts.GroupByBoxVisible = false;
      this.gridReceipts.HideSelection = Janus.Windows.GridEX.HideSelection.HighlightInactive;
      this.gridReceipts.Location = new System.Drawing.Point(3, 3);
      this.gridReceipts.Name = "gridReceipts";
      this.gridReceipts.SelectionMode = Janus.Windows.GridEX.SelectionMode.MultipleSelection;
      this.gridReceipts.Size = new System.Drawing.Size(544, 408);
      this.gridReceipts.TabIndex = 4;
      this.gridReceipts.SelectionChanged += new System.EventHandler(this.gridReceipts_SelectionChanged);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 1;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.gridReceipts, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.progStatus, 0, 1);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 28);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
      this.tableLayoutPanel1.Size = new System.Drawing.Size(550, 443);
      this.tableLayoutPanel1.TabIndex = 5;
      // 
      // progStatus
      // 
      this.progStatus.Dock = System.Windows.Forms.DockStyle.Fill;
      this.progStatus.Location = new System.Drawing.Point(3, 417);
      this.progStatus.Name = "progStatus";
      this.progStatus.Size = new System.Drawing.Size(544, 23);
      this.progStatus.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
      this.progStatus.TabIndex = 5;
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(550, 471);
      this.Controls.Add(this.tableLayoutPanel1);
      this.Controls.Add(this.LeftRebar1);
      this.Controls.Add(this.RightRebar1);
      this.Controls.Add(this.TopRebar1);
      this.Controls.Add(this.BottomRebar1);
      this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "MainForm";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Receipt Entry";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
      this.Load += new System.EventHandler(this.MainForm_Load);
      ((System.ComponentModel.ISupportInitialize)(this.uiCommandManager)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.BottomRebar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.uiCommandBar)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.LeftRebar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.RightRebar1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.TopRebar1)).EndInit();
      this.TopRebar1.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gridReceipts)).EndInit();
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private Janus.Windows.UI.CommandBars.UICommandManager uiCommandManager;
    private Janus.Windows.UI.CommandBars.UIRebar BottomRebar1;
    private Janus.Windows.UI.CommandBars.UICommandBar uiCommandBar;
    private Janus.Windows.UI.CommandBars.UICommand tbbSave;
    private Janus.Windows.UI.CommandBars.UICommand Separator1;
    private Janus.Windows.UI.CommandBars.UICommand tbbAddReceipt;
    private Janus.Windows.UI.CommandBars.UICommand tbbEditReceipt;
    private Janus.Windows.UI.CommandBars.UICommand SaveCommand;
    private Janus.Windows.UI.CommandBars.UICommand AddReceiptCommand;
    private Janus.Windows.UI.CommandBars.UICommand EditReceiptCommand;
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private Janus.Windows.GridEX.GridEX gridReceipts;
    private Janus.Windows.UI.CommandBars.UIRebar LeftRebar1;
    private Janus.Windows.UI.CommandBars.UIRebar RightRebar1;
    private Janus.Windows.UI.CommandBars.UIRebar TopRebar1;
    private Janus.Windows.UI.CommandBars.UICommand tbbRemoveReceipt;
    private Janus.Windows.UI.CommandBars.UICommand RemoveReceiptCommand;
    private Janus.Windows.UI.CommandBars.UICommand tbbMerchantsDatabase;
    private Janus.Windows.UI.CommandBars.UICommand tbbItemsDatabase;
    private Janus.Windows.UI.CommandBars.UICommand ItemsDatabaseCommand;
    private Janus.Windows.UI.CommandBars.UICommand MerchantDatabaseCommand;
    private Janus.Windows.UI.CommandBars.UICommand Separator2;
    private Janus.Windows.UI.CommandBars.UICommand Separator3;
    private System.Windows.Forms.ProgressBar progStatus;
    private Janus.Windows.UI.CommandBars.UICommand tbbStatistics;
    private Janus.Windows.UI.CommandBars.UICommand StatisticsCommand;
    private Janus.Windows.UI.CommandBars.UICommand tbbSearch;
    private Janus.Windows.UI.CommandBars.UICommand SearchCommand;

  }
}

