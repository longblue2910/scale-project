namespace Electric_Scale.frm
{
    partial class frmProduct
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
            C1.Win.C1Command.C1CommandLink mnuAddLink;
            C1.Win.C1Command.C1CommandLink mnuEditLink;
            C1.Win.C1Command.C1CommandLink mnuDeleteLink;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduct));
            this.mnuAdd = new C1.Win.C1Command.C1Command();
            this.mnuEdit = new C1.Win.C1Command.C1Command();
            this.mnuDelete = new C1.Win.C1Command.C1Command();
            this.mnuView = new C1.Win.C1Command.C1Command();
            this.mnuSysInfo = new C1.Win.C1Command.C1Command();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.C1ContextMenu = new C1.Win.C1Command.C1ContextMenu();
            this.mnuPrintLink = new C1.Win.C1Command.C1CommandLink();
            this.mnuPrint = new C1.Win.C1Command.C1Command();
            this.mnuFind = new C1.Win.C1Command.C1Command();
            this.mnuListAll = new C1.Win.C1Command.C1Command();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.tdbg = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grpFilterCondition = new System.Windows.Forms.GroupBox();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.grpListofProducts = new System.Windows.Forms.GroupBox();
            mnuAddLink = new C1.Win.C1Command.C1CommandLink();
            mnuEditLink = new C1.Win.C1Command.C1CommandLink();
            mnuDeleteLink = new C1.Win.C1Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbg)).BeginInit();
            this.grpFilterCondition.SuspendLayout();
            this.grpListofProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuAddLink
            // 
            mnuAddLink.Command = this.mnuAdd;
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Text = "&Add";
            this.mnuAdd.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuAdd_Click);
            // 
            // mnuEditLink
            // 
            mnuEditLink.Command = this.mnuEdit;
            mnuEditLink.SortOrder = 1;
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "&Edit";
            this.mnuEdit.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuEdit_Click);
            // 
            // mnuDeleteLink
            // 
            mnuDeleteLink.Command = this.mnuDelete;
            mnuDeleteLink.SortOrder = 2;
            // 
            // mnuDelete
            // 
            this.mnuDelete.Name = "mnuDelete";
            this.mnuDelete.Text = "&Delete";
            this.mnuDelete.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuDelete_Click);
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Text = "&View";
            // 
            // mnuSysInfo
            // 
            this.mnuSysInfo.Name = "mnuSysInfo";
            this.mnuSysInfo.Text = "&System info";
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(404, 354);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(76, 22);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "&Actions...";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(486, 354);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // C1ContextMenu
            // 
            this.C1ContextMenu.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            mnuAddLink,
            mnuEditLink,
            mnuDeleteLink,
            this.mnuPrintLink});
            this.C1ContextMenu.Name = "C1ContextMenu";
            // 
            // mnuPrintLink
            // 
            this.mnuPrintLink.Command = this.mnuPrint;
            this.mnuPrintLink.Delimiter = true;
            this.mnuPrintLink.SortOrder = 3;
            // 
            // mnuPrint
            // 
            this.mnuPrint.Enabled = false;
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Text = "&Print";
            this.mnuPrint.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuPrint_Click);
            // 
            // mnuFind
            // 
            this.mnuFind.Name = "mnuFind";
            this.mnuFind.Text = "&Find";
            // 
            // mnuListAll
            // 
            this.mnuListAll.Name = "mnuListAll";
            this.mnuListAll.Text = "&List all";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.C1ContextMenu);
            this.c1CommandHolder1.Commands.Add(this.mnuAdd);
            this.c1CommandHolder1.Commands.Add(this.mnuView);
            this.c1CommandHolder1.Commands.Add(this.mnuEdit);
            this.c1CommandHolder1.Commands.Add(this.mnuDelete);
            this.c1CommandHolder1.Commands.Add(this.mnuFind);
            this.c1CommandHolder1.Commands.Add(this.mnuListAll);
            this.c1CommandHolder1.Commands.Add(this.mnuSysInfo);
            this.c1CommandHolder1.Commands.Add(this.mnuPrint);
            this.c1CommandHolder1.Owner = this;
            // 
            // tdbg
            // 
            this.tdbg.AllowColMove = false;
            this.tdbg.AllowColSelect = false;
            this.tdbg.AllowDelete = true;
            this.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbg.AllowSort = false;
            this.tdbg.AllowUpdate = false;
            this.tdbg.AlternatingRows = true;
            this.c1CommandHolder1.SetC1Command(this.tdbg, this.C1ContextMenu);
            this.c1CommandHolder1.SetC1ContextMenu(this.tdbg, this.C1ContextMenu);
            this.tdbg.EmptyRows = true;
            this.tdbg.ExtendRightColumn = true;
            this.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard;
            this.tdbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbg.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbg.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbg.Images"))));
            this.tdbg.Location = new System.Drawing.Point(9, 19);
            this.tdbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.tdbg.Name = "tdbg";
            this.tdbg.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbg.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbg.PreviewInfo.ZoomFactor = 75;
            this.tdbg.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbg.PrintInfo.PageSettings")));
            this.tdbg.Size = new System.Drawing.Size(536, 238);
            this.tdbg.TabAcrossSplits = true;
            this.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;
            this.tdbg.TabIndex = 0;
            this.tdbg.Tag = "COL";
            this.tdbg.WrapCellPointer = true;
            this.tdbg.DoubleClick += new System.EventHandler(this.tdbg_DoubleClick);
            this.tdbg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbg_KeyDown);
            this.tdbg.PropBag = resources.GetString("tdbg.PropBag");
            // 
            // grpFilterCondition
            // 
            this.grpFilterCondition.Controls.Add(this.chkDisabled);
            this.grpFilterCondition.Controls.Add(this.btnShowAll);
            this.grpFilterCondition.Controls.Add(this.txtProductName);
            this.grpFilterCondition.Controls.Add(this.txtProductCode);
            this.grpFilterCondition.Controls.Add(this.lblProductCode);
            this.grpFilterCondition.Controls.Add(this.lblProductName);
            this.grpFilterCondition.Location = new System.Drawing.Point(8, 6);
            this.grpFilterCondition.Name = "grpFilterCondition";
            this.grpFilterCondition.Size = new System.Drawing.Size(554, 73);
            this.grpFilterCondition.TabIndex = 0;
            this.grpFilterCondition.TabStop = false;
            this.grpFilterCondition.Text = "Filter condition";
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(325, 23);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkDisabled.TabIndex = 4;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            this.chkDisabled.CheckedChanged += new System.EventHandler(this.chkDisabled_CheckedChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(461, 44);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(84, 22);
            this.btnShowAll.TabIndex = 5;
            this.btnShowAll.Text = "Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductName.Location = new System.Drawing.Point(83, 46);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(309, 20);
            this.txtProductName.TabIndex = 3;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // txtProductCode
            // 
            this.txtProductCode.BackColor = System.Drawing.SystemColors.Window;
            this.txtProductCode.Location = new System.Drawing.Point(83, 20);
            this.txtProductCode.MaxLength = 20;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(122, 20);
            this.txtProductCode.TabIndex = 1;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(6, 23);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(71, 13);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product code";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Location = new System.Drawing.Point(6, 49);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(73, 13);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Product name";
            // 
            // grpListofProducts
            // 
            this.grpListofProducts.Controls.Add(this.tdbg);
            this.grpListofProducts.Location = new System.Drawing.Point(8, 85);
            this.grpListofProducts.Name = "grpListofProducts";
            this.grpListofProducts.Size = new System.Drawing.Size(554, 263);
            this.grpListofProducts.TabIndex = 1;
            this.grpListofProducts.TabStop = false;
            this.grpListofProducts.Text = "List of Products";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(570, 382);
            this.Controls.Add(this.grpFilterCondition);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpListofProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MT003 - Product";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmProduct_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbg)).EndInit();
            this.grpFilterCondition.ResumeLayout(false);
            this.grpFilterCondition.PerformLayout();
            this.grpListofProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnClose;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbg;
        private C1.Win.C1Command.C1ContextMenu C1ContextMenu;
        private C1.Win.C1Command.C1Command mnuAdd;
        private C1.Win.C1Command.C1Command mnuView;
        private C1.Win.C1Command.C1Command mnuEdit;
        private C1.Win.C1Command.C1Command mnuDelete;
        internal C1.Win.C1Command.C1Command mnuFind;
        internal C1.Win.C1Command.C1Command mnuListAll;
        private C1.Win.C1Command.C1Command mnuSysInfo;
        internal C1.Win.C1Command.C1CommandLink mnuPrintLink;
        internal C1.Win.C1Command.C1Command mnuPrint;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private System.Windows.Forms.GroupBox grpFilterCondition;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.GroupBox grpListofProducts;
    }
}