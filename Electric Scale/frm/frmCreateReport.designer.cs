namespace Electric_Scale.frm
{
    partial class frmCreateReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateReport));
            C1.Win.C1List.Style style6 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style7 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style8 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style9 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style10 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style11 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style12 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style13 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style14 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style15 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style16 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style17 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style18 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style19 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style20 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style21 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style22 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style23 = new C1.Win.C1List.Style();
            C1.Win.C1List.Style style24 = new C1.Win.C1List.Style();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.c1dateFromDate = new C1.Win.C1Input.C1DateEdit();
            this.c1DateToDate = new C1.Win.C1Input.C1DateEdit();
            this.lblTruckNo = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.lblScaleType = new System.Windows.Forms.Label();
            this.txtTruckNo = new System.Windows.Forms.TextBox();
            this.grpReportCondition = new System.Windows.Forms.GroupBox();
            this.tdbcCustomer = new C1.Win.C1List.C1Combo();
            this.tdbcProduct = new C1.Win.C1List.C1Combo();
            this.tdbcScaleType = new C1.Win.C1List.C1Combo();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.optExportToPrinter = new System.Windows.Forms.RadioButton();
            this.optExportToExcel = new System.Windows.Forms.RadioButton();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAction = new System.Windows.Forms.Button();
            this.grpExportType = new System.Windows.Forms.GroupBox();
            this.c1rptAllWeightingSheet = new C1.Win.C1Report.C1Report();
            this.grpReportBaseOn = new System.Windows.Forms.GroupBox();
            this.optCustomer = new System.Windows.Forms.RadioButton();
            this.optProduct = new System.Windows.Forms.RadioButton();
            this.optScaleType = new System.Windows.Forms.RadioButton();
            this.optTruckNo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.c1dateFromDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateToDate)).BeginInit();
            this.grpReportCondition.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcScaleType)).BeginInit();
            this.grpExportType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1rptAllWeightingSheet)).BeginInit();
            this.grpReportBaseOn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Location = new System.Drawing.Point(8, 130);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(54, 13);
            this.lblFromDate.TabIndex = 8;
            this.lblFromDate.Text = "From date";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Location = new System.Drawing.Point(256, 128);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(44, 13);
            this.lblToDate.TabIndex = 10;
            this.lblToDate.Text = "To date";
            // 
            // c1dateFromDate
            // 
            this.c1dateFromDate.BackColor = System.Drawing.Color.Beige;
            this.c1dateFromDate.CustomFormat = "dd/MM/yyyy";
            this.c1dateFromDate.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.c1dateFromDate.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1dateFromDate.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1dateFromDate.EmptyAsNull = true;
            this.c1dateFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.c1dateFromDate.ForeColor = System.Drawing.Color.Blue;
            this.c1dateFromDate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1dateFromDate.Location = new System.Drawing.Point(79, 127);
            this.c1dateFromDate.MaxLength = 10;
            this.c1dateFromDate.Name = "c1dateFromDate";
            this.c1dateFromDate.Size = new System.Drawing.Size(117, 20);
            this.c1dateFromDate.TabIndex = 9;
            this.c1dateFromDate.Tag = null;
            this.c1dateFromDate.TrimStart = true;
            this.c1dateFromDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // c1DateToDate
            // 
            this.c1DateToDate.BackColor = System.Drawing.Color.Beige;
            this.c1DateToDate.CustomFormat = "dd/MM/yyyy";
            this.c1DateToDate.DisplayFormat.CustomFormat = "dd/MM/yyyy";
            this.c1DateToDate.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1DateToDate.DisplayFormat.Inherit = ((C1.Win.C1Input.FormatInfoInheritFlags)((((C1.Win.C1Input.FormatInfoInheritFlags.NullText | C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimStart)
                        | C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd)));
            this.c1DateToDate.EmptyAsNull = true;
            this.c1DateToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.c1DateToDate.ForeColor = System.Drawing.Color.Blue;
            this.c1DateToDate.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat;
            this.c1DateToDate.Location = new System.Drawing.Point(319, 125);
            this.c1DateToDate.MaxLength = 10;
            this.c1DateToDate.Name = "c1DateToDate";
            this.c1DateToDate.Size = new System.Drawing.Size(117, 20);
            this.c1DateToDate.TabIndex = 11;
            this.c1DateToDate.Tag = null;
            this.c1DateToDate.TrimStart = true;
            this.c1DateToDate.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.DropDown;
            // 
            // lblTruckNo
            // 
            this.lblTruckNo.AutoSize = true;
            this.lblTruckNo.Location = new System.Drawing.Point(8, 23);
            this.lblTruckNo.Name = "lblTruckNo";
            this.lblTruckNo.Size = new System.Drawing.Size(50, 13);
            this.lblTruckNo.TabIndex = 0;
            this.lblTruckNo.Text = "Truck no";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(8, 58);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(44, 13);
            this.lblProduct.TabIndex = 4;
            this.lblProduct.Text = "Product";
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Location = new System.Drawing.Point(8, 94);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(51, 13);
            this.lblCustomer.TabIndex = 2;
            this.lblCustomer.Text = "Customer";
            // 
            // lblScaleType
            // 
            this.lblScaleType.AutoSize = true;
            this.lblScaleType.Location = new System.Drawing.Point(243, 23);
            this.lblScaleType.Name = "lblScaleType";
            this.lblScaleType.Size = new System.Drawing.Size(57, 13);
            this.lblScaleType.TabIndex = 6;
            this.lblScaleType.Text = "Scale type";
            // 
            // txtTruckNo
            // 
            this.txtTruckNo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtTruckNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTruckNo.Enabled = false;
            this.txtTruckNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTruckNo.ForeColor = System.Drawing.Color.Blue;
            this.txtTruckNo.Location = new System.Drawing.Point(79, 20);
            this.txtTruckNo.Name = "txtTruckNo";
            this.txtTruckNo.Size = new System.Drawing.Size(117, 20);
            this.txtTruckNo.TabIndex = 1;
            // 
            // grpReportCondition
            // 
            this.grpReportCondition.Controls.Add(this.tdbcCustomer);
            this.grpReportCondition.Controls.Add(this.tdbcProduct);
            this.grpReportCondition.Controls.Add(this.tdbcScaleType);
            this.grpReportCondition.Controls.Add(this.txtCustomerName);
            this.grpReportCondition.Controls.Add(this.txtProductName);
            this.grpReportCondition.Controls.Add(this.txtTruckNo);
            this.grpReportCondition.Controls.Add(this.lblFromDate);
            this.grpReportCondition.Controls.Add(this.lblToDate);
            this.grpReportCondition.Controls.Add(this.lblTruckNo);
            this.grpReportCondition.Controls.Add(this.c1dateFromDate);
            this.grpReportCondition.Controls.Add(this.lblScaleType);
            this.grpReportCondition.Controls.Add(this.c1DateToDate);
            this.grpReportCondition.Controls.Add(this.lblCustomer);
            this.grpReportCondition.Controls.Add(this.lblProduct);
            this.grpReportCondition.Location = new System.Drawing.Point(151, 12);
            this.grpReportCondition.Name = "grpReportCondition";
            this.grpReportCondition.Size = new System.Drawing.Size(447, 159);
            this.grpReportCondition.TabIndex = 0;
            this.grpReportCondition.TabStop = false;
            this.grpReportCondition.Text = "Report condition";
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
            this.tdbcCustomer.CaptionStyle = style1;
            this.tdbcCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tdbcCustomer.ColumnCaptionHeight = 17;
            this.tdbcCustomer.ColumnFooterHeight = 17;
            this.tdbcCustomer.ColumnWidth = 100;
            this.tdbcCustomer.ContentHeight = 15;
            this.tdbcCustomer.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcCustomer.DisplayMember = "CustomerID";
            this.tdbcCustomer.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcCustomer.DropDownWidth = 300;
            this.tdbcCustomer.EditorBackColor = System.Drawing.SystemColors.ControlLight;
            this.tdbcCustomer.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcCustomer.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcCustomer.EditorHeight = 15;
            this.tdbcCustomer.EmptyRows = true;
            this.tdbcCustomer.Enabled = false;
            this.tdbcCustomer.EvenRowStyle = style2;
            this.tdbcCustomer.ExtendRightColumn = true;
            this.tdbcCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdbcCustomer.FooterStyle = style3;
            this.tdbcCustomer.HeadingStyle = style4;
            this.tdbcCustomer.HighLightRowStyle = style5;
            this.tdbcCustomer.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcCustomer.Images"))));
            this.tdbcCustomer.ItemHeight = 15;
            this.tdbcCustomer.Location = new System.Drawing.Point(79, 91);
            this.tdbcCustomer.MatchEntryTimeout = ((long)(2000));
            this.tdbcCustomer.MaxDropDownItems = ((short)(8));
            this.tdbcCustomer.MaxLength = 32767;
            this.tdbcCustomer.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcCustomer.Name = "tdbcCustomer";
            this.tdbcCustomer.OddRowStyle = style6;
            this.tdbcCustomer.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcCustomer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcCustomer.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcCustomer.SelectedStyle = style7;
            this.tdbcCustomer.Size = new System.Drawing.Size(117, 21);
            this.tdbcCustomer.Style = style8;
            this.tdbcCustomer.TabIndex = 34;
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
            this.tdbcProduct.CaptionStyle = style9;
            this.tdbcProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tdbcProduct.ColumnCaptionHeight = 17;
            this.tdbcProduct.ColumnFooterHeight = 17;
            this.tdbcProduct.ColumnWidth = 100;
            this.tdbcProduct.ContentHeight = 15;
            this.tdbcProduct.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcProduct.DisplayMember = "ProductID";
            this.tdbcProduct.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcProduct.DropDownWidth = 300;
            this.tdbcProduct.EditorBackColor = System.Drawing.SystemColors.ControlLight;
            this.tdbcProduct.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.tdbcProduct.EditorForeColor = System.Drawing.SystemColors.WindowText;
            this.tdbcProduct.EditorHeight = 15;
            this.tdbcProduct.EmptyRows = true;
            this.tdbcProduct.Enabled = false;
            this.tdbcProduct.EvenRowStyle = style10;
            this.tdbcProduct.ExtendRightColumn = true;
            this.tdbcProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdbcProduct.FooterStyle = style11;
            this.tdbcProduct.HeadingStyle = style12;
            this.tdbcProduct.HighLightRowStyle = style13;
            this.tdbcProduct.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcProduct.Images"))));
            this.tdbcProduct.ItemHeight = 15;
            this.tdbcProduct.Location = new System.Drawing.Point(79, 55);
            this.tdbcProduct.MatchEntryTimeout = ((long)(2000));
            this.tdbcProduct.MaxDropDownItems = ((short)(8));
            this.tdbcProduct.MaxLength = 20;
            this.tdbcProduct.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcProduct.Name = "tdbcProduct";
            this.tdbcProduct.OddRowStyle = style14;
            this.tdbcProduct.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcProduct.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcProduct.SelectedStyle = style15;
            this.tdbcProduct.Size = new System.Drawing.Size(117, 21);
            this.tdbcProduct.Style = style16;
            this.tdbcProduct.TabIndex = 33;
            this.tdbcProduct.ValueMember = "ProductID";
            this.tdbcProduct.Close += new C1.Win.C1List.CloseEventHandler(this.tdbcProduct_Close);
            this.tdbcProduct.SelectedValueChanged += new System.EventHandler(this.tdbcProduct_SelectedValueChanged);
            this.tdbcProduct.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tdbcProduct_KeyDown);
            this.tdbcProduct.PropBag = resources.GetString("tdbcProduct.PropBag");
            // 
            // tdbcScaleType
            // 
            this.tdbcScaleType.AddItemSeparator = ';';
            this.tdbcScaleType.AllowColMove = false;
            this.tdbcScaleType.AllowSort = false;
            this.tdbcScaleType.AlternatingRows = true;
            this.tdbcScaleType.AutoCompletion = true;
            this.tdbcScaleType.AutoDropDown = true;
            this.tdbcScaleType.Caption = "";
            this.tdbcScaleType.CaptionHeight = 17;
            this.tdbcScaleType.CaptionStyle = style17;
            this.tdbcScaleType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tdbcScaleType.ColumnCaptionHeight = 17;
            this.tdbcScaleType.ColumnFooterHeight = 17;
            this.tdbcScaleType.ContentHeight = 15;
            this.tdbcScaleType.DeadAreaBackColor = System.Drawing.Color.Empty;
            this.tdbcScaleType.DisplayMember = "ScaleTypeName";
            this.tdbcScaleType.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown;
            this.tdbcScaleType.DropDownWidth = 119;
            this.tdbcScaleType.EditorBackColor = System.Drawing.SystemColors.ControlLight;
            this.tdbcScaleType.EditorFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.tdbcScaleType.EditorForeColor = System.Drawing.Color.Blue;
            this.tdbcScaleType.EditorHeight = 15;
            this.tdbcScaleType.EmptyRows = true;
            this.tdbcScaleType.Enabled = false;
            this.tdbcScaleType.EvenRowStyle = style18;
            this.tdbcScaleType.ExtendRightColumn = true;
            this.tdbcScaleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tdbcScaleType.FooterStyle = style19;
            this.tdbcScaleType.HeadingStyle = style20;
            this.tdbcScaleType.HighLightRowStyle = style21;
            this.tdbcScaleType.Images.Add(((System.Drawing.Image)(resources.GetObject("tdbcScaleType.Images"))));
            this.tdbcScaleType.ItemHeight = 15;
            this.tdbcScaleType.Location = new System.Drawing.Point(306, 19);
            this.tdbcScaleType.MatchEntryTimeout = ((long)(2000));
            this.tdbcScaleType.MaxDropDownItems = ((short)(8));
            this.tdbcScaleType.MaxLength = 32767;
            this.tdbcScaleType.MouseCursor = System.Windows.Forms.Cursors.Default;
            this.tdbcScaleType.Name = "tdbcScaleType";
            this.tdbcScaleType.OddRowStyle = style22;
            this.tdbcScaleType.RowDivider.Color = System.Drawing.Color.DarkGray;
            this.tdbcScaleType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None;
            this.tdbcScaleType.RowSubDividerColor = System.Drawing.Color.DarkGray;
            this.tdbcScaleType.SelectedStyle = style23;
            this.tdbcScaleType.Size = new System.Drawing.Size(130, 21);
            this.tdbcScaleType.Style = style24;
            this.tdbcScaleType.TabIndex = 32;
            this.tdbcScaleType.ValueMember = "ScaleTypeID";
            this.tdbcScaleType.PropBag = resources.GetString("tdbcScaleType.PropBag");
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.ForeColor = System.Drawing.Color.Blue;
            this.txtCustomerName.Location = new System.Drawing.Point(202, 91);
            this.txtCustomerName.MaxLength = 100;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(234, 20);
            this.txtCustomerName.TabIndex = 13;
            this.txtCustomerName.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Blue;
            this.txtProductName.Location = new System.Drawing.Point(202, 55);
            this.txtProductName.MaxLength = 100;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(234, 20);
            this.txtProductName.TabIndex = 12;
            this.txtProductName.TabStop = false;
            // 
            // optExportToPrinter
            // 
            this.optExportToPrinter.AutoSize = true;
            this.optExportToPrinter.Checked = true;
            this.optExportToPrinter.Location = new System.Drawing.Point(11, 19);
            this.optExportToPrinter.Name = "optExportToPrinter";
            this.optExportToPrinter.Size = new System.Drawing.Size(99, 17);
            this.optExportToPrinter.TabIndex = 0;
            this.optExportToPrinter.TabStop = true;
            this.optExportToPrinter.Text = "Export to printer";
            this.optExportToPrinter.UseVisualStyleBackColor = true;
            // 
            // optExportToExcel
            // 
            this.optExportToExcel.AutoSize = true;
            this.optExportToExcel.Location = new System.Drawing.Point(138, 19);
            this.optExportToExcel.Name = "optExportToExcel";
            this.optExportToExcel.Size = new System.Drawing.Size(95, 17);
            this.optExportToExcel.TabIndex = 1;
            this.optExportToExcel.Text = "Export to excel";
            this.optExportToExcel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(522, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(76, 22);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAction
            // 
            this.btnAction.Location = new System.Drawing.Point(440, 200);
            this.btnAction.Name = "btnAction";
            this.btnAction.Size = new System.Drawing.Size(76, 22);
            this.btnAction.TabIndex = 2;
            this.btnAction.Text = "&Actions...";
            this.btnAction.UseVisualStyleBackColor = true;
            this.btnAction.Click += new System.EventHandler(this.btnAction_Click);
            // 
            // grpExportType
            // 
            this.grpExportType.Controls.Add(this.optExportToExcel);
            this.grpExportType.Controls.Add(this.optExportToPrinter);
            this.grpExportType.Location = new System.Drawing.Point(151, 186);
            this.grpExportType.Name = "grpExportType";
            this.grpExportType.Size = new System.Drawing.Size(240, 45);
            this.grpExportType.TabIndex = 1;
            this.grpExportType.TabStop = false;
            this.grpExportType.Text = "Export type";
            // 
            // c1rptAllWeightingSheet
            // 
            this.c1rptAllWeightingSheet.ReportDefinition = resources.GetString("c1rptAllWeightingSheet.ReportDefinition");
            this.c1rptAllWeightingSheet.ReportName = "rptAllWeightingSheet_V";
            // 
            // grpReportBaseOn
            // 
            this.grpReportBaseOn.Controls.Add(this.optCustomer);
            this.grpReportBaseOn.Controls.Add(this.optProduct);
            this.grpReportBaseOn.Controls.Add(this.optScaleType);
            this.grpReportBaseOn.Controls.Add(this.optTruckNo);
            this.grpReportBaseOn.Location = new System.Drawing.Point(11, 12);
            this.grpReportBaseOn.Name = "grpReportBaseOn";
            this.grpReportBaseOn.Size = new System.Drawing.Size(125, 219);
            this.grpReportBaseOn.TabIndex = 4;
            this.grpReportBaseOn.TabStop = false;
            this.grpReportBaseOn.Text = "Report base on";
            // 
            // optCustomer
            // 
            this.optCustomer.AutoSize = true;
            this.optCustomer.Location = new System.Drawing.Point(16, 130);
            this.optCustomer.Name = "optCustomer";
            this.optCustomer.Size = new System.Drawing.Size(69, 17);
            this.optCustomer.TabIndex = 0;
            this.optCustomer.TabStop = true;
            this.optCustomer.Text = "Customer";
            this.optCustomer.UseVisualStyleBackColor = true;
            this.optCustomer.CheckedChanged += new System.EventHandler(this.optCustomer_CheckedChanged);
            // 
            // optProduct
            // 
            this.optProduct.AutoSize = true;
            this.optProduct.Location = new System.Drawing.Point(16, 92);
            this.optProduct.Name = "optProduct";
            this.optProduct.Size = new System.Drawing.Size(62, 17);
            this.optProduct.TabIndex = 0;
            this.optProduct.TabStop = true;
            this.optProduct.Text = "Product";
            this.optProduct.UseVisualStyleBackColor = true;
            this.optProduct.CheckedChanged += new System.EventHandler(this.optProduct_CheckedChanged);
            // 
            // optScaleType
            // 
            this.optScaleType.AutoSize = true;
            this.optScaleType.Location = new System.Drawing.Point(16, 56);
            this.optScaleType.Name = "optScaleType";
            this.optScaleType.Size = new System.Drawing.Size(75, 17);
            this.optScaleType.TabIndex = 0;
            this.optScaleType.TabStop = true;
            this.optScaleType.Text = "Scale type";
            this.optScaleType.UseVisualStyleBackColor = true;
            this.optScaleType.CheckedChanged += new System.EventHandler(this.optScaleType_CheckedChanged);
            // 
            // optTruckNo
            // 
            this.optTruckNo.AutoSize = true;
            this.optTruckNo.Location = new System.Drawing.Point(16, 21);
            this.optTruckNo.Name = "optTruckNo";
            this.optTruckNo.Size = new System.Drawing.Size(68, 17);
            this.optTruckNo.TabIndex = 0;
            this.optTruckNo.TabStop = true;
            this.optTruckNo.Text = "Truck no";
            this.optTruckNo.UseVisualStyleBackColor = true;
            this.optTruckNo.CheckedChanged += new System.EventHandler(this.optTruckNo_CheckedChanged);
            // 
            // frmCreateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(610, 244);
            this.Controls.Add(this.grpReportBaseOn);
            this.Controls.Add(this.btnAction);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpReportCondition);
            this.Controls.Add(this.grpExportType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCreateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RP009 - Create report";
            this.Load += new System.EventHandler(this.frmCreateReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCreateReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.c1dateFromDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c1DateToDate)).EndInit();
            this.grpReportCondition.ResumeLayout(false);
            this.grpReportCondition.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tdbcScaleType)).EndInit();
            this.grpExportType.ResumeLayout(false);
            this.grpExportType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.c1rptAllWeightingSheet)).EndInit();
            this.grpReportBaseOn.ResumeLayout(false);
            this.grpReportBaseOn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private C1.Win.C1Input.C1DateEdit c1dateFromDate;
        private C1.Win.C1Input.C1DateEdit c1DateToDate;
        private System.Windows.Forms.Label lblTruckNo;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Label lblScaleType;
        private System.Windows.Forms.TextBox txtTruckNo;
        private System.Windows.Forms.GroupBox grpReportCondition;
        private System.Windows.Forms.RadioButton optExportToPrinter;
        private System.Windows.Forms.RadioButton optExportToExcel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAction;
        private System.Windows.Forms.GroupBox grpExportType;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtProductName;
        private C1.Win.C1Report.C1Report c1rptAllWeightingSheet;
        private C1.Win.C1List.C1Combo tdbcScaleType;
        private C1.Win.C1List.C1Combo tdbcProduct;
        private C1.Win.C1List.C1Combo tdbcCustomer;
        private System.Windows.Forms.GroupBox grpReportBaseOn;
        private System.Windows.Forms.RadioButton optCustomer;
        private System.Windows.Forms.RadioButton optProduct;
        private System.Windows.Forms.RadioButton optScaleType;
        private System.Windows.Forms.RadioButton optTruckNo;
    }
}