namespace Electric_Scale.frm
{
    partial class frmWeightingSheet
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
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWeightingSheet));
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style25 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style26 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style27 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style28 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style29 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style30 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style31 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style32 = new C1.Win.C1List.Style();
            this.c1dateDateOut = new C1.Win.C1Input.C1DateEdit();
            this.lblDateOut = new System.Windows.Forms.Label();
            this.c1dateDateIn = new C1.Win.C1Input.C1DateEdit();
            this.lblDateIn = new System.Windows.Forms.Label();
            this.tdbcCustomer = new C1.Win.C1List.C1Combo();
            this.tdbcProduct = new C1.Win.C1List.C1Combo();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblTruckNo = new System.Windows.Forms.Label();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.lblVoucherNo = new System.Windows.Forms.Label();
            this.txtVoucherNo = new System.Windows.Forms.TextBox();
            this.grpFilterCondition = new System.Windows.Forms.GroupBox();
            this.chkDisabled = new System.Windows.Forms.CheckBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.c1ContextMenu = new C1.Win.C1Command.C1ContextMenu();
            this.c1CommandLinkAdd = new C1.Win.C1Command.C1CommandLink();
            this.mnuAdd = new C1.Win.C1Command.C1Command();
            this.c1CommandLinkView = new C1.Win.C1Command.C1CommandLink();
            this.mnuView = new C1.Win.C1Command.C1Command();
            this.c1CommandLinkEdit = new C1.Win.C1Command.C1CommandLink();
            this.mnuEdit = new C1.Win.C1Command.C1Command();
            this.c1CommandLinkDelete1st = new C1.Win.C1Command.C1CommandLink();
            this.mnuDelete1st = new C1.Win.C1Command.C1Command();
            this.c1CommandLinkDelete2nd = new C1.Win.C1Command.C1CommandLink();
            this.mnuDelete2nd = new C1.Win.C1Command.C1Command();
            this.c1CommandLinkReuseWS = new C1.Win.C1Command.C1CommandLink();
            this.mnuReuseWS = new C1.Win.C1Command.C1Command();
            this.c1CommandLinkPrint = new C1.Win.C1Command.C1CommandLink();
            this.mnuPrint = new C1.Win.C1Command.C1Command();
            this.mnuEdit2nd = new C1.Win.C1Command.C1Command();
            this.mnuSysInfo = new C1.Win.C1Command.C1Command();
            this.c1CommandHolder1 = new C1.Win.C1Command.C1CommandHolder();
            this.mnuFind = new C1.Win.C1Command.C1Command();
            this.mnuListAll = new C1.Win.C1Command.C1Command();
            this.tdbg = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
            this.grpListofWeightingSheets = new System.Windows.Forms.GroupBox();
            this.c1RptWeightingSheet = new C1.Win.C1Report.C1Report();
            this.btnHotkey = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.c1dateDateOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1dateDateIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcProduct)).BeginInit();
            this.grpFilterCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbg)).BeginInit();
            this.grpListofWeightingSheets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1RptWeightingSheet)).BeginInit();
            this.SuspendLayout();
            // 
            // c1dateDateOut
            // 
            this.c1dateDateOut.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.c1dateDateOut.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType | C1.Win.C1Input.FormatInfoInheritFlags.NullText)
                        | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1dateDateOut.EmptyAsNull = true;
            this.c1dateDateOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1dateDateOut.ForeColor = System.Drawing.Color.Blue;
            this.c1dateDateOut.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1dateDateOut.Location = new System.Drawing.Point(575, 45);
            this.c1dateDateOut.MaxLength = 10;
            this.c1dateDateOut.Name = "c1dateDateOut";
            this.c1dateDateOut.Size = new System.Drawing.Size(164, 20);
            this.c1dateDateOut.TabIndex = 13;
            this.c1dateDateOut.TabStop = false;
            this.c1dateDateOut.Tag = null;
            this.c1dateDateOut.TrimStart = true;
            this.c1dateDateOut.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.c1dateDateOut.ValueChanged += new System.EventHandler(this.c1dateDateOut_ValueChanged);
            // 
            // lblDateOut
            // 
            this.lblDateOut.AutoSize = true;
            this.lblDateOut.Location = new System.Drawing.Point(502, 50);
            this.lblDateOut.Name = "lblDateOut";
            this.lblDateOut.Size = new System.Drawing.Size(48, 13);
            this.lblDateOut.TabIndex = 12;
            this.lblDateOut.Text = "Date out";
            // 
            // c1dateDateIn
            // 
            this.c1dateDateIn.CustomFormat = "dd/MM/yyyy";
            this.c1dateDateIn.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.c1dateDateIn.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1dateDateIn.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1dateDateIn.EditFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1dateDateIn.EditFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)(((((C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat | C1.Win.C1Input.FormatInfoInheritFlags.NullText)
                        | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1dateDateIn.EmptyAsNull = true;
            this.c1dateDateIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.c1dateDateIn.ForeColor = System.Drawing.Color.Blue;
            this.c1dateDateIn.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate;
            this.c1dateDateIn.Location = new System.Drawing.Point(575, 19);
            this.c1dateDateIn.MaxLength = 10;
            this.c1dateDateIn.Name = "c1dateDateIn";
            this.c1dateDateIn.Size = new System.Drawing.Size(164, 20);
            this.c1dateDateIn.TabIndex = 11;
            this.c1dateDateIn.TabStop = false;
            this.c1dateDateIn.Tag = null;
            this.c1dateDateIn.TrimStart = true;
            this.c1dateDateIn.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            this.c1dateDateIn.ValueChanged += new System.EventHandler(this.c1dateDateIn_ValueChanged);
            // 
            // lblDateIn
            // 
            this.lblDateIn.AutoSize = true;
            this.lblDateIn.Location = new System.Drawing.Point(502, 22);
            this.lblDateIn.Name = "lblDateIn";
            this.lblDateIn.Size = new System.Drawing.Size(41, 13);
            this.lblDateIn.TabIndex = 10;
            this.lblDateIn.Text = "Date in";
            // 
            // tdbcCustomer
            // 
            this.tdbcCustomer.AddItemSeparator = ';';
            this.tdbcCustomer.AllowColMove = false;
            this.tdbcCustomer.AllowSort = false;
            this.tdbcCustomer.AlternatingRows = true;
            this.tdbcCustomer.AutoCompletion = true;
            this.tdbcCustomer.AutoDropDown = true;
            this.tdbcCustomer.Caption = "";
            this.tdbcCustomer.CaptionHeight = 17;
            this.tdbcCustomer.CaptionStyle = style17;
            this.tdbcCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tdbcCustomer.ColumnCaptionHeight = 17;
            this.tdbcCustomer.ColumnFooterHeight = 17;
            this.tdbcCustomer.ColumnWidth = 100;
            this.tdbcCustomer.ContentHeight = 15;
            this.tdbcCustomer.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcCustomer.DisplayMember = "CustomerID";
            this.tdbcCustomer.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcCustomer.DropDownWidth = 300;
            this.tdbcCustomer.EditorBackColor = System.Drawing.SystemColors.Window;
            this.tdbcCustomer.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcCustomer.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcCustomer.EditorHeight = 15;
            this.tdbcCustomer.EmptyRows = true;
            this.tdbcCustomer.EvenRowStyle = style18;
            this.tdbcCustomer.ExtendRightColumn = true;
            this.tdbcCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdbcCustomer.FooterStyle = style19;
            this.tdbcCustomer.HeadingStyle = style20;
            this.tdbcCustomer.HighLightRowStyle = style21;
            this.tdbcCustomer.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcCustomer.Images"))));
            this.tdbcCustomer.ItemHeight = 15;
            this.tdbcCustomer.Location = new System.Drawing.Point(85, 72);
            this.tdbcCustomer.MatchEntryTimeout = ((long)(2000));
            this.tdbcCustomer.MaxDropDownItems = ((short)(8));
            this.tdbcCustomer.MaxLength = 32767;
            this.tdbcCustomer.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcCustomer.Name = "tdbcCustomer";
            this.tdbcCustomer.OddRowStyle = style22;
            this.tdbcCustomer.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcCustomer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcCustomer.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcCustomer.SelectedStyle = style23;
            this.tdbcCustomer.Size = new System.Drawing.Size(136, 21);
            this.tdbcCustomer.Style = style24;
            this.tdbcCustomer.TabIndex = 8;
            this.tdbcCustomer.ValueMember = "CustomerID";
            this.tdbcCustomer.Close += new C1.Win.C1List.CloseEventHandler(this.tdbcCustomer_Close);
            this.tdbcCustomer.SelectedValueChanged += new System.EventHandler(this.tdbcCustomer_SelectedValueChanged);
            this.tdbcCustomer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbcCustomer_KeyDown);
            this.tdbcCustomer.PropBag = resources.GetString("tdbcCustomer.PropBag");
            // 
            // tdbcProduct
            // 
            this.tdbcProduct.AddItemSeparator = ';';
            this.tdbcProduct.AllowColMove = false;
            this.tdbcProduct.AllowSort = false;
            this.tdbcProduct.AlternatingRows = true;
            this.tdbcProduct.AutoCompletion = true;
            this.tdbcProduct.AutoDropDown = true;
            this.tdbcProduct.Caption = "";
            this.tdbcProduct.CaptionHeight = 17;
            this.tdbcProduct.CaptionStyle = style25;
            this.tdbcProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tdbcProduct.ColumnCaptionHeight = 17;
            this.tdbcProduct.ColumnFooterHeight = 17;
            this.tdbcProduct.ColumnWidth = 100;
            this.tdbcProduct.ContentHeight = 15;
            this.tdbcProduct.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcProduct.DisplayMember = "ProductID";
            this.tdbcProduct.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcProduct.DropDownWidth = 300;
            this.tdbcProduct.EditorBackColor = System.Drawing.SystemColors.Window;
            this.tdbcProduct.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcProduct.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcProduct.EditorHeight = 15;
            this.tdbcProduct.EmptyRows = true;
            this.tdbcProduct.EvenRowStyle = style26;
            this.tdbcProduct.ExtendRightColumn = true;
            this.tdbcProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdbcProduct.FooterStyle = style27;
            this.tdbcProduct.HeadingStyle = style28;
            this.tdbcProduct.HighLightRowStyle = style29;
            this.tdbcProduct.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcProduct.Images"))));
            this.tdbcProduct.ItemHeight = 15;
            this.tdbcProduct.Location = new System.Drawing.Point(85, 45);
            this.tdbcProduct.MatchEntryTimeout = ((long)(2000));
            this.tdbcProduct.MaxDropDownItems = ((short)(8));
            this.tdbcProduct.MaxLength = 32767;
            this.tdbcProduct.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcProduct.Name = "tdbcProduct";
            this.tdbcProduct.OddRowStyle = style30;
            this.tdbcProduct.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcProduct.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcProduct.SelectedStyle = style31;
            this.tdbcProduct.Size = new System.Drawing.Size(136, 21);
            this.tdbcProduct.Style = style32;
            this.tdbcProduct.TabIndex = 5;
            this.tdbcProduct.ValueMember = "ProductID";
            this.tdbcProduct.Close += new C1.Win.C1List.CloseEventHandler(this.tdbcProduct_Close);
            this.tdbcProduct.SelectedValueChanged += new System.EventHandler(this.tdbcProduct_SelectedValueChanged);
            this.tdbcProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbcProduct_KeyDown);
            this.tdbcProduct.PropBag = resources.GetString("tdbcProduct.PropBag");
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerName.Location = new System.Drawing.Point(227, 73);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(229, 20);
            this.txtCustomerName.TabIndex = 9;
            this.txtCustomerName.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Blue;
            this.txtProductName.Location = new System.Drawing.Point(227, 46);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(229, 20);
            this.txtProductName.TabIndex = 6;
            this.txtProductName.TabStop = false;
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(8, 76);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 7;
            this.lblCustomer.Text = "Customer";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(8, 50);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Product";
            // 
            // lblTruckNo
            // 
            this.lblTruckNo.AutoSize = true;
            this.lblTruckNo.Location = new System.Drawing.Point(275, 22);
            this.lblTruckNo.Name = "lblTruckNo";
            this.lblTruckNo.Size = new System.Drawing.Size(50, 13);
            this.lblTruckNo.TabIndex = 2;
            this.lblTruckNo.Text = "Truck no";
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTruckNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTruckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckNo.ForeColor = System.Drawing.Color.Blue;
            this.txtTruckNo.Location = new System.Drawing.Point(340, 19);
            this.txtTruckNo.MaxLength = 9;
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(116, 20);
            this.txtTruckNo.TabIndex = 3;
            this.txtTruckNo.TextChanged += new System.EventHandler(this.txtTruckNo_TextChanged);
            // 
            // lblVoucherNo
            // 
            this.lblVoucherNo.AutoSize = true;
            this.lblVoucherNo.Location = new System.Drawing.Point(8, 22);
            this.lblVoucherNo.Name = "lblVoucherNo";
            this.lblVoucherNo.Size = new System.Drawing.Size(62, 13);
            this.lblVoucherNo.TabIndex = 0;
            this.lblVoucherNo.Text = "Voucher no";
            // 
            // txtVoucherNo
            // 
            this.txtVoucherNo.BackColor = System.Drawing.SystemColors.Window;
            this.txtVoucherNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVoucherNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherNo.ForeColor = System.Drawing.Color.Blue;
            this.txtVoucherNo.Location = new System.Drawing.Point(85, 19);
            this.txtVoucherNo.MaxLength = 7;
            this.txtVoucherNo.Name = "txtVoucherNo";
            this.txtVoucherNo.Size = new System.Drawing.Size(136, 20);
            this.txtVoucherNo.TabIndex = 1;
            this.txtVoucherNo.TextChanged += new System.EventHandler(this.txtVoucherNo_TextChanged);
            // 
            // grpFilterCondition
            // 
            this.grpFilterCondition.Controls.Add(this.chkDisabled);
            this.grpFilterCondition.Controls.Add(this.btnShowAll);
            this.grpFilterCondition.Controls.Add(this.c1dateDateOut);
            this.grpFilterCondition.Controls.Add(this.txtVoucherNo);
            this.grpFilterCondition.Controls.Add(this.lblDateOut);
            this.grpFilterCondition.Controls.Add(this.lblVoucherNo);
            this.grpFilterCondition.Controls.Add(this.c1dateDateIn);
            this.grpFilterCondition.Controls.Add(this.txtTruckNo);
            this.grpFilterCondition.Controls.Add(this.lblDateIn);
            this.grpFilterCondition.Controls.Add(this.lblTruckNo);
            this.grpFilterCondition.Controls.Add(this.tdbcCustomer);
            this.grpFilterCondition.Controls.Add(this.lblProduct);
            this.grpFilterCondition.Controls.Add(this.tdbcProduct);
            this.grpFilterCondition.Controls.Add(this.lblCustomer);
            this.grpFilterCondition.Controls.Add(this.txtCustomerName);
            this.grpFilterCondition.Controls.Add(this.txtProductName);
            this.grpFilterCondition.Location = new System.Drawing.Point(9, 12);
            this.grpFilterCondition.Name = "grpFilterCondition";
            this.grpFilterCondition.Size = new System.Drawing.Size(750, 103);
            this.grpFilterCondition.TabIndex = 0;
            this.grpFilterCondition.TabStop = false;
            this.grpFilterCondition.Text = "Filter condition";
            // 
            // chkDisabled
            // 
            this.chkDisabled.AutoSize = true;
            this.chkDisabled.Location = new System.Drawing.Point(505, 75);
            this.chkDisabled.Name = "chkDisabled";
            this.chkDisabled.Size = new System.Drawing.Size(67, 17);
            this.chkDisabled.TabIndex = 15;
            this.chkDisabled.Text = "Disabled";
            this.chkDisabled.UseVisualStyleBackColor = true;
            this.chkDisabled.CheckedChanged += new System.EventHandler(this.chkDisabled_CheckedChanged);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(655, 71);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(84, 22);
            this.btnShowAll.TabIndex = 14;
            this.btnShowAll.Text = "&Show all";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(827, 666);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(76, 22);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "&Actions...";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(909, 666);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // c1ContextMenu
            // 
            this.c1ContextMenu.CommandLinks.AddRange(new C1.Win.C1Command.C1CommandLink[] {
            this.c1CommandLinkAdd,
            this.c1CommandLinkView,
            this.c1CommandLinkEdit,
            this.c1CommandLinkDelete1st,
            this.c1CommandLinkDelete2nd,
            this.c1CommandLinkReuseWS,
            this.c1CommandLinkPrint});
            this.c1ContextMenu.Name = "c1ContextMenu";
            // 
            // c1CommandLinkAdd
            // 
            this.c1CommandLinkAdd.Command = this.mnuAdd;
            this.c1CommandLinkAdd.Text = "&Add weighting sheet";
            // 
            // mnuAdd
            // 
            this.mnuAdd.Name = "mnuAdd";
            this.mnuAdd.Text = "Add weighting sheet";
            this.mnuAdd.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuAdd_Click);
            // 
            // c1CommandLinkView
            // 
            this.c1CommandLinkView.Command = this.mnuView;
            this.c1CommandLinkView.SortOrder = 1;
            // 
            // mnuView
            // 
            this.mnuView.Name = "mnuView";
            this.mnuView.Text = "&View weighting sheet info";
            this.mnuView.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuView_Click);
            // 
            // c1CommandLinkEdit
            // 
            this.c1CommandLinkEdit.Command = this.mnuEdit;
            this.c1CommandLinkEdit.SortOrder = 2;
            this.c1CommandLinkEdit.Text = "Edit weighting sheet info";
            // 
            // mnuEdit
            // 
            this.mnuEdit.Name = "mnuEdit";
            this.mnuEdit.Text = "Edit weighting sheet info";
            this.mnuEdit.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuEdit_Click);
            // 
            // c1CommandLinkDelete1st
            // 
            this.c1CommandLinkDelete1st.Command = this.mnuDelete1st;
            this.c1CommandLinkDelete1st.Delimiter = true;
            this.c1CommandLinkDelete1st.SortOrder = 3;
            this.c1CommandLinkDelete1st.Text = "Delete &1st weighting sheet info";
            // 
            // mnuDelete1st
            // 
            this.mnuDelete1st.Name = "mnuDelete1st";
            this.mnuDelete1st.Text = "Delete 1st weighting sheet";
            this.mnuDelete1st.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuDelete1st_Click);
            // 
            // c1CommandLinkDelete2nd
            // 
            this.c1CommandLinkDelete2nd.Command = this.mnuDelete2nd;
            this.c1CommandLinkDelete2nd.SortOrder = 4;
            this.c1CommandLinkDelete2nd.Text = "Delete &2nd weighting sheet info";
            // 
            // mnuDelete2nd
            // 
            this.mnuDelete2nd.Name = "mnuDelete2nd";
            this.mnuDelete2nd.Text = "Delete &2sd weight sheet info";
            this.mnuDelete2nd.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuDelete2sd_Click);
            // 
            // c1CommandLinkReuseWS
            // 
            this.c1CommandLinkReuseWS.Command = this.mnuReuseWS;
            this.c1CommandLinkReuseWS.SortOrder = 5;
            // 
            // mnuReuseWS
            // 
            this.mnuReuseWS.Name = "mnuReuseWS";
            this.mnuReuseWS.Text = "Re-use this weighting sheet";
            this.mnuReuseWS.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuReuseWS_Click);
            // 
            // c1CommandLinkPrint
            // 
            this.c1CommandLinkPrint.Command = this.mnuPrint;
            this.c1CommandLinkPrint.Delimiter = true;
            this.c1CommandLinkPrint.SortOrder = 6;
            // 
            // mnuPrint
            // 
            this.mnuPrint.Name = "mnuPrint";
            this.mnuPrint.Text = "&Print";
            this.mnuPrint.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuPrint_Click);
            // 
            // mnuEdit2nd
            // 
            this.mnuEdit2nd.Name = "mnuEdit2nd";
            this.mnuEdit2nd.Text = "Edit &2nd weighting sheet info";
            this.mnuEdit2nd.Click += new C1.Win.C1Command.ClickEventHandler(this.mnuEdit_Click);
            // 
            // mnuSysInfo
            // 
            this.mnuSysInfo.Name = "mnuSysInfo";
            this.mnuSysInfo.Text = "&System info";
            // 
            // c1CommandHolder1
            // 
            this.c1CommandHolder1.Commands.Add(this.c1ContextMenu);
            this.c1CommandHolder1.Commands.Add(this.mnuDelete1st);
            this.c1CommandHolder1.Commands.Add(this.mnuDelete2nd);
            this.c1CommandHolder1.Commands.Add(this.mnuFind);
            this.c1CommandHolder1.Commands.Add(this.mnuListAll);
            this.c1CommandHolder1.Commands.Add(this.mnuSysInfo);
            this.c1CommandHolder1.Commands.Add(this.mnuPrint);
            this.c1CommandHolder1.Commands.Add(this.mnuView);
            this.c1CommandHolder1.Commands.Add(this.mnuAdd);
            this.c1CommandHolder1.Commands.Add(this.mnuEdit);
            this.c1CommandHolder1.Commands.Add(this.mnuEdit2nd);
            this.c1CommandHolder1.Commands.Add(this.mnuReuseWS);
            this.c1CommandHolder1.Owner = this;
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
            // tdbg
            // 
            this.tdbg.AllowColMove = false;
            this.tdbg.AllowColSelect = false;
            this.tdbg.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None;
            this.tdbg.AllowSort = false;
            this.tdbg.AllowUpdate = false;
            this.tdbg.AlternatingRows = true;
            this.tdbg.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.c1CommandHolder1.SetC1Command(this.tdbg, this.c1ContextMenu);
            this.c1CommandHolder1.SetC1ContextMenu(this.tdbg, this.c1ContextMenu);
            this.tdbg.ColumnFooters = true;
            this.tdbg.EmptyRows = true;
            this.tdbg.FlatStyle = C1.Win.C1TrueDBGrid.FlatModeEnum.Standard;
            this.tdbg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbg.GroupByCaption = "Drag a column header here to group by that column";
            this.tdbg.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbg.Images"))));
            this.tdbg.Location = new System.Drawing.Point(6, 18);
            this.tdbg.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;
            this.tdbg.MultiSelect = C1.Win.C1TrueDBGrid.MultiSelectEnum.None;
            this.tdbg.Name = "tdbg";
            this.tdbg.PreviewInfo.Location = new System.Drawing.Point(0, 0);
            this.tdbg.PreviewInfo.Size = new System.Drawing.Size(0, 0);
            this.tdbg.PreviewInfo.ZoomFactor = 75;
            this.tdbg.PrintInfo.PageSettings = ((System.Drawing.Printing.PageSettings)(resources.GetObject("tdbg.PrintInfo.PageSettings")));
            this.tdbg.RecordSelectors = false;
            this.tdbg.Size = new System.Drawing.Size(964, 511);
            this.tdbg.SplitDividerSize = new System.Drawing.Size(0, 0);
            this.tdbg.SpringMode = true;
            this.tdbg.TabAcrossSplits = true;
            this.tdbg.TabAction = C1.Win.C1TrueDBGrid.TabActionEnum.ColumnNavigation;
            this.tdbg.TabIndex = 1;
            this.tdbg.Tag = "COL";
            this.tdbg.DoubleClick += new System.EventHandler(this.tdbg_DoubleClick);
            this.tdbg.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbg_KeyDown);
            this.tdbg.PropBag = resources.GetString("tdbg.PropBag");
            // 
            // grpListofWeightingSheets
            // 
            this.grpListofWeightingSheets.BackColor = System.Drawing.SystemColors.ControlLight;
            this.grpListofWeightingSheets.Controls.Add(this.tdbg);
            this.grpListofWeightingSheets.Location = new System.Drawing.Point(9, 125);
            this.grpListofWeightingSheets.Name = "grpListofWeightingSheets";
            this.grpListofWeightingSheets.Size = new System.Drawing.Size(976, 535);
            this.grpListofWeightingSheets.TabIndex = 1;
            this.grpListofWeightingSheets.TabStop = false;
            this.grpListofWeightingSheets.Text = "List of weighting sheets";
            // 
            // c1RptWeightingSheet
            // 
            this.c1RptWeightingSheet.ReportDefinition = resources.GetString("c1RptWeightingSheet.ReportDefinition");
            this.c1RptWeightingSheet.ReportName = "Weighting sheet";
            // 
            // btnHotkey
            // 
            this.btnHotkey.Location = new System.Drawing.Point(9, 666);
            this.btnHotkey.Name = "btnHotkey";
            this.btnHotkey.Size = new System.Drawing.Size(76, 22);
            this.btnHotkey.TabIndex = 5;
            this.btnHotkey.Text = "&Hot keys";
            this.btnHotkey.UseVisualStyleBackColor = true;
            this.btnHotkey.Click += new System.EventHandler(this.btnHotkey_Click);
            // 
            // frmWeightingSheet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(994, 695);
            this.Controls.Add(this.btnHotkey);
            this.Controls.Add(this.grpListofWeightingSheets);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.grpFilterCondition);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmWeightingSheet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MT001 - Weighting sheet";
            this.Load += new System.EventHandler(this.frmWeightingSheet_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmWeightingSheet_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.c1dateDateOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1dateDateIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcProduct)).EndInit();
            this.grpFilterCondition.ResumeLayout(false);
            this.grpFilterCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1CommandHolder1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbg)).EndInit();
            this.grpListofWeightingSheets.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.c1RptWeightingSheet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private C1.Win.C1Input.C1DateEdit c1dateDateOut;
        private System.Windows.Forms.Label lblDateOut;
        private C1.Win.C1Input.C1DateEdit c1dateDateIn;
        private System.Windows.Forms.Label lblDateIn;
        private C1.Win.C1List.C1Combo tdbcCustomer;
        private C1.Win.C1List.C1Combo tdbcProduct;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblTruckNo;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.Label lblVoucherNo;
        private System.Windows.Forms.TextBox txtVoucherNo;
        private System.Windows.Forms.GroupBox grpFilterCondition;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.Button btnClose;
        private C1.Win.C1Command.C1ContextMenu c1ContextMenu;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkEdit;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkDelete1st;
        private C1.Win.C1Command.C1Command mnuDelete1st;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkDelete2nd;
        private C1.Win.C1Command.C1Command mnuDelete2nd;
        private C1.Win.C1Command.C1Command mnuSysInfo;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkPrint;
        private C1.Win.C1Command.C1Command mnuPrint;
        private C1.Win.C1Command.C1CommandHolder c1CommandHolder1;
        private C1.Win.C1Command.C1Command mnuFind;
        private C1.Win.C1Command.C1Command mnuListAll;
        private System.Windows.Forms.GroupBox grpListofWeightingSheets;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkView;
        private C1.Win.C1Command.C1Command mnuView;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkAdd;
        private C1.Win.C1Command.C1Command mnuAdd;
        private System.Windows.Forms.CheckBox chkDisabled;
        private C1.Win.C1Command.C1Command mnuEdit;
        private C1.Win.C1Report.C1Report c1RptWeightingSheet;
        private C1.Win.C1Command.C1Command mnuEdit2nd;
        private C1.Win.C1Command.C1CommandLink c1CommandLinkReuseWS;
        private C1.Win.C1Command.C1Command mnuReuseWS;
        private System.Windows.Forms.Button btnHotkey;
        private C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbg;
    }
}