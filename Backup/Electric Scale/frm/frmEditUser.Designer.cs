namespace Electric_Scale.frm
{
    partial class frmEditUser
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
            C1.Win.C1List.Style style1 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style2 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style3 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style4 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style5 = new C1.Win.C1List.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditUser));
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblGroup = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblUserName = new System.Windows.Forms.Label();
            this.grpUserInformation = new System.Windows.Forms.GroupBox();
            this.tdbcGroup = new C1.Win.C1List.C1Combo();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.grpUserInformation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.LightYellow;
            this.txtFullName.Location = new System.Drawing.Point(305, 19);
            this.txtFullName.MaxLength = 50;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(196, 20);
            this.txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(243, 22);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(52, 13);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full name";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.SystemColors.Window;
            this.txtAddress.Location = new System.Drawing.Point(89, 74);
            this.txtAddress.MaxLength = 100;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(412, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // lblGroup
            // 
            this.lblGroup.AutoSize = true;
            this.lblGroup.Location = new System.Drawing.Point(7, 50);
            this.lblGroup.Name = "lblGroup";
            this.lblGroup.Size = new System.Drawing.Size(36, 13);
            this.lblGroup.TabIndex = 4;
            this.lblGroup.Text = "Group";
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.Color.LightYellow;
            this.txtUserName.Location = new System.Drawing.Point(89, 19);
            this.txtUserName.MaxLength = 20;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(132, 20);
            this.txtUserName.TabIndex = 1;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(7, 22);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 13);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "UserName";
            // 
            // grpUserInformation
            // 
            this.grpUserInformation.Controls.Add(this.tdbcGroup);
            this.grpUserInformation.Controls.Add(this.lblFullName);
            this.grpUserInformation.Controls.Add(this.lblPhone);
            this.grpUserInformation.Controls.Add(this.lblEmail);
            this.grpUserInformation.Controls.Add(this.lblAddress);
            this.grpUserInformation.Controls.Add(this.lblGroup);
            this.grpUserInformation.Controls.Add(this.txtFullName);
            this.grpUserInformation.Controls.Add(this.txtPhone);
            this.grpUserInformation.Controls.Add(this.txtEmail);
            this.grpUserInformation.Controls.Add(this.txtAddress);
            this.grpUserInformation.Controls.Add(this.lblUserName);
            this.grpUserInformation.Controls.Add(this.txtUserName);
            this.grpUserInformation.Location = new System.Drawing.Point(5, 6);
            this.grpUserInformation.Name = "grpUserInformation";
            this.grpUserInformation.Size = new System.Drawing.Size(511, 134);
            this.grpUserInformation.TabIndex = 0;
            this.grpUserInformation.TabStop = false;
            this.grpUserInformation.Text = "User infomation";
            // 
            // tdbcGroup
            // 
            this.tdbcGroup.AddItemSeparator = ';';
            this.tdbcGroup.AllowColMove = false;
            this.tdbcGroup.AllowSort = false;
            this.tdbcGroup.AlternatingRows = true;
            this.tdbcGroup.AutoCompletion = true;
            this.tdbcGroup.AutoDropDown = true;
            this.tdbcGroup.Caption = "";
            this.tdbcGroup.CaptionHeight = 17;
            this.tdbcGroup.CaptionStyle = style1;
            this.tdbcGroup.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tdbcGroup.ColumnCaptionHeight = 17;
            this.tdbcGroup.ColumnFooterHeight = 17;
            this.tdbcGroup.ColumnWidth = 100;
            this.tdbcGroup.ContentHeight = 15;
            this.tdbcGroup.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcGroup.DisplayMember = "GroupName";
            this.tdbcGroup.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcGroup.DropDownWidth = 300;
            this.tdbcGroup.EditorBackColor = System.Drawing.Color.LightYellow;
            this.tdbcGroup.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcGroup.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcGroup.EditorHeight = 15;
            this.tdbcGroup.EmptyRows = true;
            this.tdbcGroup.EvenRowStyle = style2;
            this.tdbcGroup.ExtendRightColumn = true;
            this.tdbcGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcGroup.FooterStyle = style3;
            this.tdbcGroup.HeadingStyle = style4;
            this.tdbcGroup.HighLightRowStyle = style5;
            this.tdbcGroup.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcGroup.Images"))));
            this.tdbcGroup.ItemHeight = 15;
            this.tdbcGroup.Location = new System.Drawing.Point(89, 46);
            this.tdbcGroup.MatchEntryTimeout = ((long)(2000));
            this.tdbcGroup.MaxDropDownItems = ((short)(8));
            this.tdbcGroup.MaxLength = 32767;
            this.tdbcGroup.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcGroup.Name = "tdbcGroup";
            this.tdbcGroup.OddRowStyle = style6;
            this.tdbcGroup.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcGroup.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcGroup.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcGroup.SelectedStyle = style7;
            this.tdbcGroup.Size = new System.Drawing.Size(132, 21);
            this.tdbcGroup.Style = style8;
            this.tdbcGroup.TabIndex = 5;
            this.tdbcGroup.ValueMember = "GroupID";
            this.tdbcGroup.Close += new C1.Win.C1List.CloseEventHandler(this.tdbcGroup_Close);
            this.tdbcGroup.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbcGroup_KeyDown);
            this.tdbcGroup.PropBag = resources.GetString("tdbcGroup.PropBag");
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(243, 50);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(38, 13);
            this.lblPhone.TabIndex = 6;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(8, 78);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(45, 13);
            this.lblAddress.TabIndex = 8;
            this.lblAddress.Text = "Address";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.Window;
            this.txtPhone.Location = new System.Drawing.Point(305, 47);
            this.txtPhone.MaxLength = 16;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(196, 20);
            this.txtPhone.TabIndex = 7;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.Window;
            this.txtEmail.Location = new System.Drawing.Point(89, 101);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(412, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(357, 149);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(76, 22);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "&Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(275, 149);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(76, 22);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(440, 149);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(5, 152);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkDisabled.TabIndex = 1;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            // 
            // frmEditUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(521, 175);
            this.Controls.Add(this.chkDisabled);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpUserInformation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmEditUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FC008 - Edit user";
            this.Load += new System.EventHandler(this.frmEditUser_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEditUser_KeyDown);
            this.grpUserInformation.ResumeLayout(false);
            this.grpUserInformation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblGroup;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.GroupBox grpUserInformation;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private C1.Win.C1List.C1Combo tdbcGroup;
        private System.Windows.Forms.CheckBox chkDisabled;
        private System.Windows.Forms.TextBox txtPhone;
    }
}