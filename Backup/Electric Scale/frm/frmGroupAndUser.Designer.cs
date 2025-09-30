namespace Electric_Scale.frm
{
    partial class frmGroupAndUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGroupAndUser));
            this.mnuAddUser = new C1.Win.C1Command.C1Command();
            this.mnuEditUser = new C1.Win.C1Command.C1Command();
            this.mnuDeleteUser = new C1.Win.C1Command.C1Command();
            this.mnuView = new C1.Win.C1Command.C1Command();
            this.btnClose = new System.Windows.Forms.Button();
            this.C1ContextMenuUser = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.C1ContextMenuGroup = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLink2 = new C1.Win.C1Command.C1CommandLink();
            this.mnuAddGroup = new C1.Win.C1Command.C1Command();
            this.c1CommandLink3 = new C1.Win.C1Command.C1CommandLink();
            this.mnuEditGroup = new C1.Win.C1Command.C1Command();
            this.c1CommandLink4 = new C1.Win.C1Command.C1CommandLink();
            this.mnuDeleteGroup = new C1.Win.C1Command.C1Command();
            this.mnuPrintGroup = new C1.Win.C1Command.C1Command();
            this.tdbgUser = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.tdbgGroup = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grpListOfUser = new System.Windows.Forms.GroupBox();
            this.grpListofGroups = new System.Windows.Forms.GroupBox();
            this.grpFormPermission = new System.Windows.Forms.GroupBox();
            this.tdbgFormPermission = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.c1CommandLink1 = new C1.Win.C1Command.C1CommandLink();
            mnuAddLink = new C1.Win.C1Command.C1CommandLink();
            mnuEditLink = new C1.Win.C1Command.C1CommandLink();
            mnuDeleteLink = new C1.Win.C1Command.C1CommandLink();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgGroup)).BeginInit();
            this.grpListOfUser.SuspendLayout();
            this.grpListofGroups.SuspendLayout();
            this.grpFormPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgFormPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuAddLink
            // 
            mnuAddLink.Command = this.mnuAddUser;
            mnuAddLink.Text = "&Add user";
            // 
            // mnuAddUser
            // 
            this.mnuAddUser.Name = "mnuAddUser";
            this.mnuAddUser.Text = "&Add";
            this.mnuAddUser.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuAddUser_Click);
            // 
            // mnuEditLink
            // 
            mnuEditLink.Command = this.mnuEditUser;
            mnuEditLink.SortOrder = 1;
            mnuEditLink.Text = "&Edit user";
            // 
            // mnuEditUser
            // 
            this.mnuEditUser.Name = "mnuEditUser";
            this.mnuEditUser.Text = "&Edit";
            this.mnuEditUser.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuEditUser_Click);
            // 
            // mnuDeleteLink
            // 
            mnuDeleteLink.Command = this.mnuDeleteUser;
            mnuDeleteLink.SortOrder = 2;
            mnuDeleteLink.Text = "&Delete user";
            // 
            // mnuDeleteUser
            // 
            this.mnuDeleteUser.Name = "mnuDeleteUser";
            this.mnuDeleteUser.Text = "&Delete";
            this.mnuDeleteUser.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuDeleteUser_Click);
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Text = "&View";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(839, 644);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // C1ContextMenuUser
            // 
            this.C1ContextMenuUser.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            mnuAddLink,
            mnuEditLink,
            mnuDeleteLink});
            this.C1ContextMenuUser.Name = "C1ContextMenuUser";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.C1ContextMenuGroup);
            this.c1CommandHolder1.Commands.Add(this.mnuAddGroup);
            this.c1CommandHolder1.Commands.Add(this.mnuEditGroup);
            this.c1CommandHolder1.Commands.Add(this.mnuDeleteGroup);
            this.c1CommandHolder1.Commands.Add(this.mnuPrintGroup);
            this.c1CommandHolder1.Commands.Add(this.C1ContextMenuUser);
            this.c1CommandHolder1.Commands.Add(this.mnuAddUser);
            this.c1CommandHolder1.Commands.Add(this.mnuView);
            this.c1CommandHolder1.Commands.Add(this.mnuEditUser);
            this.c1CommandHolder1.Commands.Add(this.mnuDeleteUser);
            this.c1CommandHolder1.Owner = this;
            // 
            // C1ContextMenuGroup
            // 
            this.C1ContextMenuGroup.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLink2,
            this.c1CommandLink3,
            this.c1CommandLink4});
            this.C1ContextMenuGroup.Name = "C1ContextMenuGroup";
            // 
            // c1CommandLink2
            // 
            this.c1CommandLink2.Command = this.mnuAddGroup;
            // 
            // mnuAddGroup
            // 
            this.mnuAddGroup.Name = "mnuAddGroup";
            this.mnuAddGroup.Text = "&Add group";
            this.mnuAddGroup.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuAddGroup_Click);
            // 
            // c1CommandLink3
            // 
            this.c1CommandLink3.Command = this.mnuEditGroup;
            this.c1CommandLink3.SortOrder = 1;
            this.c1CommandLink3.Text = "&Edit group";
            // 
            // mnuEditGroup
            // 
            this.mnuEditGroup.Name = "mnuEditGroup";
            this.mnuEditGroup.Text = "&Edit";
            this.mnuEditGroup.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuEditGroup_Click);
            // 
            // c1CommandLink4
            // 
            this.c1CommandLink4.Command = this.mnuDeleteGroup;
            this.c1CommandLink4.SortOrder = 2;
            this.c1CommandLink4.Text = "&Delete group";
            // 
            // mnuDeleteGroup
            // 
            this.mnuDeleteGroup.Name = "mnuDeleteGroup";
            this.mnuDeleteGroup.Text = "&Delete";
            this.mnuDeleteGroup.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuDeleteGroup_Click);
            // 
            // mnuPrintGroup
            // 
            this.mnuPrintGroup.Enabled = false;
            this.mnuPrintGroup.Name = "mnuPrintGroup";
            this.mnuPrintGroup.Text = "&Print";
            // 
            // tdbgUser
            // 
            this.tdbgUser.AllowColMove = false;
            this.tdbgUser.AllowColSelect = false;
            this.tdbgUser.AllowDelete = true;
            this.tdbgUser.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbgUser.AllowSort = false;
            this.tdbgUser.AllowUpdate = false;
            this.tdbgUser.AlternatingRows = true;
            this.c1CommandHolder1.SetC1ContextMenu(this.tdbgUser, this.C1ContextMenuUser);
            this.tdbgUser.EmptyRows = true;
            this.tdbgUser.ExtendRightColumn = true;
            this.tdbgUser.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard;
            this.tdbgUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbgUser.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbgUser.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbgUser.Images"))));
            this.tdbgUser.Location = new System.Drawing.Point(5, 19);
            this.tdbgUser.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.tdbgUser.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.tdbgUser.Name = "tdbgUser";
            this.tdbgUser.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbgUser.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbgUser.PreviewInfo.ZoomFactor = 75;
            this.tdbgUser.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbgUser.PrintInfo.PageSettings")));
            this.tdbgUser.Size = new System.Drawing.Size(897, 303);
            this.tdbgUser.SplitDividerSize = new System.Drawing.Size(0, 0);
            this.tdbgUser.TabAcrossSplits = true;
            this.tdbgUser.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;
            this.tdbgUser.TabIndex = 0;
            this.tdbgUser.Tag = "COL";
            this.tdbgUser.WrapCellPointer = true;
            this.tdbgUser.MouseHover += new System.EventHandler(this.tdbgUser_MouseHover);
            this.tdbgUser.DoubleClick += new System.EventHandler(this.tdbgUser_DoubleClick);
            this.tdbgUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbgUser_KeyDown);
            this.tdbgUser.PropBag = resources.GetString("tdbgUser.PropBag");
            // 
            // tdbgGroup
            // 
            this.tdbgGroup.AllowColMove = false;
            this.tdbgGroup.AllowColSelect = false;
            this.tdbgGroup.AllowDelete = true;
            this.tdbgGroup.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbgGroup.AllowSort = false;
            this.tdbgGroup.AllowUpdate = false;
            this.tdbgGroup.AlternatingRows = true;
            this.c1CommandHolder1.SetC1ContextMenu(this.tdbgGroup, this.C1ContextMenuGroup);
            this.tdbgGroup.EmptyRows = true;
            this.tdbgGroup.ExtendRightColumn = true;
            this.tdbgGroup.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard;
            this.tdbgGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbgGroup.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbgGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbgGroup.Images"))));
            this.tdbgGroup.Location = new System.Drawing.Point(5, 18);
            this.tdbgGroup.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.tdbgGroup.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.tdbgGroup.Name = "tdbgGroup";
            this.tdbgGroup.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbgGroup.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbgGroup.PreviewInfo.ZoomFactor = 75;
            this.tdbgGroup.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbgGroup.PrintInfo.PageSettings")));
            this.tdbgGroup.Size = new System.Drawing.Size(411, 271);
            this.tdbgGroup.TabAcrossSplits = true;
            this.tdbgGroup.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;
            this.tdbgGroup.TabIndex = 0;
            this.tdbgGroup.Tag = "COL";
            this.tdbgGroup.WrapCellPointer = true;
            this.tdbgGroup.MouseHover += new System.EventHandler(this.tdbgGroup_MouseHover);
            this.tdbgGroup.DoubleClick += new System.EventHandler(this.tdbgGroup_DoubleClick);
            this.tdbgGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbgGroup_KeyDown);
            this.tdbgGroup.RowColChange += new C1.Win.C1TrueDBGrid.RowColChangeEventHandler(this.tdbgGroup_RowColChange);
            this.tdbgGroup.PropBag = resources.GetString("tdbgGroup.PropBag");
            // 
            // grpListOfUser
            // 
            this.grpListOfUser.Controls.Add(this.tdbgUser);
            this.grpListOfUser.Location = new System.Drawing.Point(8, 313);
            this.grpListOfUser.Name = "grpListOfUser";
            this.grpListOfUser.Size = new System.Drawing.Size(907, 325);
            this.grpListOfUser.TabIndex = 2;
            this.grpListOfUser.TabStop = false;
            this.grpListOfUser.Text = "List of users belong group above";
            // 
            // grpListofGroups
            // 
            this.grpListofGroups.Controls.Add(this.tdbgGroup);
            this.grpListofGroups.Location = new System.Drawing.Point(8, 9);
            this.grpListofGroups.Name = "grpListofGroups";
            this.grpListofGroups.Size = new System.Drawing.Size(421, 295);
            this.grpListofGroups.TabIndex = 0;
            this.grpListofGroups.TabStop = false;
            this.grpListofGroups.Text = "List of groups";
            // 
            // grpFormPermission
            // 
            this.grpFormPermission.Controls.Add(this.tdbgFormPermission);
            this.grpFormPermission.Location = new System.Drawing.Point(442, 9);
            this.grpFormPermission.Name = "grpFormPermission";
            this.grpFormPermission.Size = new System.Drawing.Size(473, 295);
            this.grpFormPermission.TabIndex = 1;
            this.grpFormPermission.TabStop = false;
            this.grpFormPermission.Text = "Form permission";
            // 
            // tdbgFormPermission
            // 
            this.tdbgFormPermission.AllowColMove = false;
            this.tdbgFormPermission.AllowColSelect = false;
            this.tdbgFormPermission.AllowDelete = true;
            this.tdbgFormPermission.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbgFormPermission.AllowSort = false;
            this.tdbgFormPermission.AllowUpdate = false;
            this.tdbgFormPermission.AlternatingRows = true;
            this.tdbgFormPermission.EmptyRows = true;
            this.tdbgFormPermission.ExtendRightColumn = true;
            this.tdbgFormPermission.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard;
            this.tdbgFormPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbgFormPermission.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbgFormPermission.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbgFormPermission.Images"))));
            this.tdbgFormPermission.Location = new System.Drawing.Point(5, 18);
            this.tdbgFormPermission.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.tdbgFormPermission.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.tdbgFormPermission.Name = "tdbgFormPermission";
            this.tdbgFormPermission.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbgFormPermission.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbgFormPermission.PreviewInfo.ZoomFactor = 75;
            this.tdbgFormPermission.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbgFormPermission.PrintInfo.PageSettings")));
            this.tdbgFormPermission.Size = new System.Drawing.Size(463, 271);
            this.tdbgFormPermission.TabAcrossSplits = true;
            this.tdbgFormPermission.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;
            this.tdbgFormPermission.TabIndex = 0;
            this.tdbgFormPermission.Tag = "COL";
            this.tdbgFormPermission.WrapCellPointer = true;
            this.tdbgFormPermission.PropBag = resources.GetString("tdbgFormPermission.PropBag");
            // 
            // frmGroupAndUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(924, 675);
            this.Controls.Add(this.grpListOfUser);
            this.Controls.Add(this.grpListofGroups);
            this.Controls.Add(this.grpFormPermission);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmGroupAndUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MT005 - Group and user";
            this.Load += new System.EventHandler(this.frmGroupAndUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmGroupAndUser_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgGroup)).EndInit();
            this.grpListOfUser.ResumeLayout(false);
            this.grpListofGroups.ResumeLayout(false);
            this.grpFormPermission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tdbgFormPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private C1.Win.C1Command.C1ContextMenu C1ContextMenuUser;
        private C1.Win.C1Command.C1Command mnuAddUser;
        private C1.Win.C1Command.C1Command mnuView;
        private C1.Win.C1Command.C1Command mnuEditUser;
        private C1.Win.C1Command.C1Command mnuDeleteUser;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private System.Windows.Forms.GroupBox grpListOfUser;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgUser;
        private System.Windows.Forms.GroupBox grpListofGroups;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgGroup;
        private System.Windows.Forms.GroupBox grpFormPermission;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgFormPermission;
        private C1.Win.C1Command.C1ContextMenu C1ContextMenuGroup;
        private C1.Win.C1Command.C1CommandLink c1CommandLink2;
        private C1.Win.C1Command.C1Command mnuAddGroup;
        private C1.Win.C1Command.C1CommandLink c1CommandLink1;
        private C1.Win.C1Command.C1CommandLink c1CommandLink3;
        private C1.Win.C1Command.C1Command mnuEditGroup;
        private C1.Win.C1Command.C1CommandLink c1CommandLink4;
        private C1.Win.C1Command.C1Command mnuDeleteGroup;
        private C1.Win.C1Command.C1Command mnuPrintGroup;

    }
}