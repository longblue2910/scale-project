namespace Electric_Scale.frm
{
    partial class frmEditGroup
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
            C1.Win.C1List.Style style49 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style50 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style51 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style52 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style53 = new C1.Win.C1List.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditGroup));
            C1.Win.C1List.Style style54 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style55 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style56 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style57 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style58 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style59 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style60 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style61 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style62 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style63 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style64 = new C1.Win.C1List.Style();
            C1.Win.C1TrueDBGrid.Style style65 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style66 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style67 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style68 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style69 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style70 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style71 = new C1.Win.C1TrueDBGrid.Style();
            C1.Win.C1TrueDBGrid.Style style72 = new C1.Win.C1TrueDBGrid.Style();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPosition = new System.Windows.Forms.Label();
            this.grpGroupInformation = new System.Windows.Forms.GroupBox();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.tdbcDepartment = new C1.Win.C1List.C1Combo();
            this.tdbcPosition = new C1.Win.C1List.C1Combo();
            this.lblGroupName = new System.Windows.Forms.Label();
            this.txtGroupName = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.grpFormPermission = new System.Windows.Forms.GroupBox();
            this.tdbdPermission = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
            this.tdbgFormPermission = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grpGroupInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcDepartment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcPosition)).BeginInit();
            this.grpFormPermission.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbdPermission)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgFormPermission)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(18, 67);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(62, 13);
            this.lblDepartment.TabIndex = 2;
            this.lblDepartment.Text = "Department";
            // 
            // lblPosition
            // 
            this.lblPosition.AutoSize = true;
            this.lblPosition.Location = new System.Drawing.Point(18, 104);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(44, 13);
            this.lblPosition.TabIndex = 4;
            this.lblPosition.Text = "Position";
            // 
            // grpGroupInformation
            // 
            this.grpGroupInformation.Controls.Add(this.chkDisabled);
            this.grpGroupInformation.Controls.Add(this.tdbcDepartment);
            this.grpGroupInformation.Controls.Add(this.tdbcPosition);
            this.grpGroupInformation.Controls.Add(this.lblGroupName);
            this.grpGroupInformation.Controls.Add(this.lblPosition);
            this.grpGroupInformation.Controls.Add(this.lblDepartment);
            this.grpGroupInformation.Controls.Add(this.txtGroupName);
            this.grpGroupInformation.Location = new System.Drawing.Point(5, 6);
            this.grpGroupInformation.Name = "grpGroupInformation";
            this.grpGroupInformation.Size = new System.Drawing.Size(248, 299);
            this.grpGroupInformation.TabIndex = 0;
            this.grpGroupInformation.TabStop = false;
            this.grpGroupInformation.Text = "Group infomation";
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(21, 142);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkDisabled.TabIndex = 6;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // tdbcDepartment
            // 
            this.tdbcDepartment.AddItemSeparator = ';';
            this.tdbcDepartment.AllowColMove = false;
            this.tdbcDepartment.AllowSort = false;
            this.tdbcDepartment.AlternatingRows = true;
            this.tdbcDepartment.AutoCompletion = true;
            this.tdbcDepartment.AutoDropDown = true;
            this.tdbcDepartment.Caption = "";
            this.tdbcDepartment.CaptionHeight = 17;
            this.tdbcDepartment.CaptionStyle = style49;
            this.tdbcDepartment.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tdbcDepartment.ColumnCaptionHeight = 17;
            this.tdbcDepartment.ColumnFooterHeight = 17;
            this.tdbcDepartment.ColumnWidth = 100;
            this.tdbcDepartment.ContentHeight = 15;
            this.tdbcDepartment.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcDepartment.DisplayMember = "DepartmentID";
            this.tdbcDepartment.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcDepartment.DropDownWidth = 300;
            this.tdbcDepartment.EditorBackColor = System.Drawing.Color.Beige;
            this.tdbcDepartment.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcDepartment.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcDepartment.EditorHeight = 15;
            this.tdbcDepartment.EmptyRows = true;
            this.tdbcDepartment.EvenRowStyle = style50;
            this.tdbcDepartment.ExtendRightColumn = true;
            this.tdbcDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcDepartment.FooterStyle = style51;
            this.tdbcDepartment.HeadingStyle = style52;
            this.tdbcDepartment.HighLightRowStyle = style53;
            this.tdbcDepartment.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcDepartment.Images"))));
            this.tdbcDepartment.ItemHeight = 15;
            this.tdbcDepartment.Location = new System.Drawing.Point(101, 64);
            this.tdbcDepartment.MatchEntryTimeout = ((long)(2000));
            this.tdbcDepartment.MaxDropDownItems = ((short)(8));
            this.tdbcDepartment.MaxLength = 32767;
            this.tdbcDepartment.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcDepartment.Name = "tdbcDepartment";
            this.tdbcDepartment.OddRowStyle = style54;
            this.tdbcDepartment.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcDepartment.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcDepartment.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcDepartment.SelectedStyle = style55;
            this.tdbcDepartment.Size = new System.Drawing.Size(126, 21);
            this.tdbcDepartment.Style = style56;
            this.tdbcDepartment.TabIndex = 3;
            this.tdbcDepartment.ValueMember = "DepartmentID";
            this.tdbcDepartment.Close += new C1.Win.C1List.CloseEventHandler(this.tdbcDepartment_Close);
            this.tdbcDepartment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbcDepartment_KeyDown);
            this.tdbcDepartment.PropBag = resources.GetString("tdbcDepartment.PropBag");
            // 
            // tdbcPosition
            // 
            this.tdbcPosition.AddItemSeparator = ';';
            this.tdbcPosition.AllowColMove = false;
            this.tdbcPosition.AllowSort = false;
            this.tdbcPosition.AlternatingRows = true;
            this.tdbcPosition.AutoCompletion = true;
            this.tdbcPosition.AutoDropDown = true;
            this.tdbcPosition.Caption = "";
            this.tdbcPosition.CaptionHeight = 17;
            this.tdbcPosition.CaptionStyle = style57;
            this.tdbcPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tdbcPosition.ColumnCaptionHeight = 17;
            this.tdbcPosition.ColumnFooterHeight = 17;
            this.tdbcPosition.ColumnWidth = 100;
            this.tdbcPosition.ContentHeight = 15;
            this.tdbcPosition.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcPosition.DisplayMember = "PositionID";
            this.tdbcPosition.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcPosition.DropDownWidth = 300;
            this.tdbcPosition.EditorBackColor = System.Drawing.Color.Beige;
            this.tdbcPosition.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcPosition.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcPosition.EditorHeight = 15;
            this.tdbcPosition.EmptyRows = true;
            this.tdbcPosition.EvenRowStyle = style58;
            this.tdbcPosition.ExtendRightColumn = true;
            this.tdbcPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcPosition.FooterStyle = style59;
            this.tdbcPosition.HeadingStyle = style60;
            this.tdbcPosition.HighLightRowStyle = style61;
            this.tdbcPosition.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcPosition.Images"))));
            this.tdbcPosition.ItemHeight = 15;
            this.tdbcPosition.Location = new System.Drawing.Point(101, 99);
            this.tdbcPosition.MatchEntryTimeout = ((long)(2000));
            this.tdbcPosition.MaxDropDownItems = ((short)(8));
            this.tdbcPosition.MaxLength = 32767;
            this.tdbcPosition.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcPosition.Name = "tdbcPosition";
            this.tdbcPosition.OddRowStyle = style62;
            this.tdbcPosition.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcPosition.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcPosition.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcPosition.SelectedStyle = style63;
            this.tdbcPosition.Size = new System.Drawing.Size(126, 21);
            this.tdbcPosition.Style = style64;
            this.tdbcPosition.TabIndex = 5;
            this.tdbcPosition.ValueMember = "PositionID";
            this.tdbcPosition.Close += new C1.Win.C1List.CloseEventHandler(this.tdbcPosition_Close);
            this.tdbcPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbcPosition_KeyDown);
            this.tdbcPosition.PropBag = resources.GetString("tdbcPosition.PropBag");
            // 
            // lblGroupName
            // 
            this.lblGroupName.AutoSize = true;
            this.lblGroupName.Location = new System.Drawing.Point(18, 33);
            this.lblGroupName.Name = "lblGroupName";
            this.lblGroupName.Size = new System.Drawing.Size(65, 13);
            this.lblGroupName.TabIndex = 0;
            this.lblGroupName.Text = "Group name";
            // 
            // txtGroupName
            // 
            this.txtGroupName.BackColor = System.Drawing.Color.Beige;
            this.txtGroupName.Location = new System.Drawing.Point(101, 30);
            this.txtGroupName.MaxLength = 30;
            this.txtGroupName.Name = "txtGroupName";
            this.txtGroupName.Size = new System.Drawing.Size(126, 20);
            this.txtGroupName.TabIndex = 1;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(94, 322);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 22);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(12, 322);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 22);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(177, 322);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // grpFormPermission
            // 
            this.grpFormPermission.Controls.Add(this.tdbdPermission);
            this.grpFormPermission.Controls.Add(this.tdbgFormPermission);
            this.grpFormPermission.Location = new System.Drawing.Point(264, 6);
            this.grpFormPermission.Name = "grpFormPermission";
            this.grpFormPermission.Size = new System.Drawing.Size(562, 338);
            this.grpFormPermission.TabIndex = 1;
            this.grpFormPermission.TabStop = false;
            this.grpFormPermission.Text = "Form permission";
            // 
            // tdbdPermission
            // 
            this.tdbdPermission.AllowColMove = false;
            this.tdbdPermission.AllowColSelect = false;
            this.tdbdPermission.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbdPermission.AllowSort = false;
            this.tdbdPermission.AlternatingRows = true;
            this.tdbdPermission.CaptionStyle = style65;
            this.tdbdPermission.ColumnCaptionHeight = 17;
            this.tdbdPermission.ColumnFooterHeight = 17;
            this.tdbdPermission.DisplayMember = "PermissionID";
            this.tdbdPermission.EmptyRows = true;
            this.tdbdPermission.EvenRowStyle = style66;
            this.tdbdPermission.ExtendRightColumn = true;
            this.tdbdPermission.FetchRowStyles = false;
            this.tdbdPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbdPermission.FooterStyle = style67;
            this.tdbdPermission.HeadingStyle = style68;
            this.tdbdPermission.HighLightRowStyle = style69;
            this.tdbdPermission.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbdPermission.Images"))));
            this.tdbdPermission.Location = new System.Drawing.Point(445, 49);
            this.tdbdPermission.Name = "tdbdPermission";
            this.tdbdPermission.OddRowStyle = style70;
            this.tdbdPermission.RecordSelectorStyle = style71;
            this.tdbdPermission.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tdbdPermission.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbdPermission.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.Single;
            this.tdbdPermission.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbdPermission.ScrollTips = false;
            this.tdbdPermission.Size = new System.Drawing.Size(112, 147);
            this.tdbdPermission.Style = style72;
            this.tdbdPermission.TabIndex = 1;
            this.tdbdPermission.TabStop = false;
            this.tdbdPermission.ValueMember = "PermissionID";
            this.tdbdPermission.Visible = false;
            this.tdbdPermission.PropBag = resources.GetString("tdbdPermission.PropBag");
            // 
            // tdbgFormPermission
            // 
            this.tdbgFormPermission.AllowColMove = false;
            this.tdbgFormPermission.AllowColSelect = false;
            this.tdbgFormPermission.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbgFormPermission.AllowSort = false;
            this.tdbgFormPermission.AlternatingRows = true;
            this.tdbgFormPermission.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.tdbgFormPermission.EmptyRows = true;
            this.tdbgFormPermission.ExtendRightColumn = true;
            this.tdbgFormPermission.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard;
            this.tdbgFormPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbgFormPermission.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbgFormPermission.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbgFormPermission.Images"))));
            this.tdbgFormPermission.Location = new System.Drawing.Point(5, 15);
            this.tdbgFormPermission.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor;
            this.tdbgFormPermission.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.tdbgFormPermission.Name = "tdbgFormPermission";
            this.tdbgFormPermission.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbgFormPermission.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbgFormPermission.PreviewInfo.ZoomFactor = 75;
            this.tdbgFormPermission.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbgFormPermission.PrintInfo.PageSettings")));
            this.tdbgFormPermission.Size = new System.Drawing.Size(552, 318);
            this.tdbgFormPermission.TabAcrossSplits = true;
            this.tdbgFormPermission.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;
            this.tdbgFormPermission.TabIndex = 2;
            this.tdbgFormPermission.Tag = "COL";
            this.tdbgFormPermission.WrapCellPointer = true;
            this.tdbgFormPermission.BeforeColUpdate += new C1.Win.C1TrueDBGrid.BeforeColUpdateEventHandler(this.tdbgFormPermission_BeforeColUpdate);
            this.tdbgFormPermission.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbgFormPermission_KeyDown);
            this.tdbgFormPermission.PropBag = resources.GetString("tdbgFormPermission.PropBag");
            // 
            // frmEditGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(831, 349);
            this.Controls.Add(this.grpFormPermission);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpGroupInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEditGroup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FC007 - Edit group";
            this.Load += new System.EventHandler(this.frmEditGroup_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditGroup_KeyDown);
            this.grpGroupInformation.ResumeLayout(false);
            this.grpGroupInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcDepartment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcPosition)).EndInit();
            this.grpFormPermission.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tdbdPermission)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbgFormPermission)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.GroupBox grpGroupInformation;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtGroupName;
        private System.Windows.Forms.Label lblGroupName;
        private C1.Win.C1List.C1Combo tdbcPosition;
        private System.Windows.Forms.GroupBox grpFormPermission;
        private C1.Win.C1List.C1Combo tdbcDepartment;
        private System.Windows.Forms.CheckBox chkDisabled;
        private C1.Win.C1TrueDBGrid.C1TrueDBDropdown tdbdPermission;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbgFormPermission;
    }
}