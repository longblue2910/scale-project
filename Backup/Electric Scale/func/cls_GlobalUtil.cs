using C1.Win.C1Command;
using C1.Win.C1Input;
using C1.Win.C1List;
using C1.Win.C1TrueDBGrid;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Electric_Scale.func
{
    #region Khai bao Enum

    #region EnumDataType
    /// <summary>
    /// Enum miêu tả các kiểu dữ liệu số được sử dụng dưới SQL
    /// </summary>
    public enum EnumDataType : int
    {
        /// <summary>
        /// Kieu du lieu TinyInt
        /// </summary>
        TinyInt = 1,
        /// <summary>
        /// Kieu du lieu Int
        /// </summary>
        Int = 2,
        /// <summary>
        /// Kieu du lieu Money
        /// </summary>
        Money = 3,
        /// <summary>
        /// Kieu du lieu SmallMoney
        /// </summary>
        SmallMoney = 4,
        /// <summary>
        /// Kieu du lieu Decimal(28,8)
        /// </summary>
        Number = 5
    }
    #endregion

    #region EnumFormState
    /// <summary>
    /// Enum mieu ta trang thai form
    /// </summary>
    public enum EnumFormState : int
    {
        /// <summary>
        /// Form o trang thai them moi
        /// </summary>
        FormAdd = 0,
        /// <summary>
        /// Form o trang thai sua
        /// </summary>
        FormEdit = 1,
        /// <summary>
        /// Form o trang thai xem
        /// </summary>
        FormView = 2
    }
    #endregion

    #region EnumPermission
    /// <summary>
    /// Enum mieu ta trang thai phan quyen cua form
    /// </summary>
    public enum EnumPermission : int
    {
        /// <summary>
        /// Chua co quyen
        /// </summary>
        None = 0,
        /// <summary>
        /// Quyen: Xem
        /// </summary>
        View = 1,
        /// <summary>
        /// Quyen: Xem, Thêm mới
        /// </summary>
        Add = 2,
        /// <summary>
        /// Quyen: Xem, Thêm mới, Sửa
        /// </summary>
        EditAdd = 3,
        /// <summary>
        /// Quyen: Xem, Thêm mới, Sửa, Xóa
        /// </summary>
        DeleteEditAdd = 4
    }
    #endregion

    #region EnumKey
    /// <summary>
    /// Enum mieu ta kiem tra phim nhan
    /// </summary>
    public enum EnumKey : int
    {
        /// <summary>
        /// Kiem tra cac so: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9
        /// </summary>
        Number = 0,
        /// <summary>
        /// Kiem tra cac so: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 va dau cham (.)
        /// </summary>
        NumberDot = 1,
        /// <summary>
        /// Kiem tra cac so: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 va dau trư (-)
        /// </summary>
        NumberSign = 2,
        /// <summary>
        /// Kiem tra cac so: 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, dau cham (.) va dau tru (-)
        /// </summary>
        NumberDotSign = 3,
        /// <summary>
        /// Kiem tra co trong chuoi truyen vao
        /// </summary>
        Custom = 4
    }
    #endregion
    #endregion

    #region Khai bao struct
    public struct StructureOption
    {
        #region Default tab
        /// <summary>
        /// Hoi truoc khi luu
        /// </summary>
        public bool MessageAskBeforeSave;
        /// <summary>
        /// Hoi truoc khi xoa
        /// </summary>
        public bool MessageAskBeforeDelete;
        /// <summary>
        /// Thông báo khi xử lý(Thêm, Xóa, Sửa) thành công
        /// </summary>
        public bool MessageWhenProcessOK;
        #endregion

        #region Language tab
        /// <summary>
        /// Luu lai ngon ngu su dung chuong trinh. 0: Tieng viet, 1: Tieng anh
        /// </summary>
        /// <remarks></remarks>
        public int Language;
        #endregion

        #region Converted coefficient tab
        /// <summary>
        /// Luu lai he so quy doi
        /// </summary>
        /// <remarks></remarks>
        public double ConvertedCoefficient;
        #endregion

        #region VoucherNo prefix tab
        /// <summary>
        /// Luu lai tiền tố của số phiếu
        /// </summary>
        /// <remarks></remarks>
        public string VoucherNoPrefix;
        #endregion

        #region others
        ///<summary>
        /// Hien thi man hinh duong dan bao cao
        /// </summary>
        ///<remarks></remarks>
        public bool ViewReportPath;
        #endregion
    }

    #endregion

    /// <summary>
    /// Lop nay lien quan den cac bien va ham toan cuc
    /// </summary>
    public static class cls_GlobalUtil
    {
        #region Khai bao hang toan cuc

        /// <summary>
        /// Dấu phẩy ", " dùng cho các lệnh SQL
        /// </summary>
        public const string COMMA = ", ";
        /// <summary>
        /// Mau BackColor chuan
        /// </summary>
        public const int COLOR_BACKCOLOR = 0XE0E0E0;

        public const double MaxMoney = 922337203685470;
        public const double MinMoney = -922337203685470;
        public const double MaxSmallMoney = 214748.3647;
        public const int MaxInt = 2147483647;
        public const byte MaxTinyInt = 255;
        public const decimal MaxDecimal = 999999999999999999M; //Dùng để kiểm tra Max Decimal(28,8) dưới SQL Server
        /// <summary>
        /// Hang so mac dinh cho ngày là __/__/____
        /// </summary>
        public const string MaskFormatDate = "__/__/____";
        public const string MaskFormatDateShort = "  /  /";

        /// <summary>
        /// Dùng cho form Chọn đường dẫn báo cáo: Standard Report
        /// </summary>
        /// <remarks></remarks>
        public const string PathReport9 = "\\XReports\\";
        //		public const string PathReportVE = "\\XReports\\VE-XReports\\";
        public const string PathReportE = "\\XReports\\E-XReports\\";

        /// <summary>
        /// Exe cua chuong trinh Electric Scale
        /// </summary>
        public const string EXE = "Electric Scale";

        #endregion

        #region Khai bao bien toan cuc

        /// <summary>
        /// User hien tai dang login vao he thong Electric Scale
        /// </summary>
        public static string gsUserLogin;
        /// <summary>
        /// Database hien tai dang dung
        /// </summary>
        public static string gsDatabaseName;
        /// <summary>
        /// User ket noi voi server dang dung
        /// </summary>
        public static string gsUserConnectionDB;
        /// <summary>
        /// SqlConnection toàn cục kết nối đến hệ thống
        /// </summary>
        public static SqlConnection gConn;
        /// <summary>
        /// Chuoi ket noi den Server
        /// </summary>
        public static string gsConnectionString;
        /// <summary>
        /// Chuoi ket noi den Server khi xuat report
        /// </summary>
        public static string gsConnectionStringForReport;
        /// <summary>
        /// Server dang dung
        /// </summary>        
        public static string gsServerName;
        /// <summary>
        /// Password ket noi den Server
        /// </summary>
        public static string gsPassword;
//        /// <summary>
//        /// Enum ngon ngu hien tai
//        /// </summary>
//        public static EnumLanguage geLanguage;
        ///// <summary>
        ///// Chuỗi '01' hoặc '84' miêu tả ngôn ngữ hiện tại
        ///// </summary>
        //public static string gsLanguage;

        /// <summary>
        /// Form ID dung de hien thi.
        /// </summary>
        public static string gsFormID;
        /// <summary>
        /// Form ID dùng de phan quyen.
        /// </summary>
        public static string gsFormIDPermission;
        /// <summary>
        /// Duong dan file Help
        /// </summary>
        public static string gsHelpFileName;

        /// <summary>
        /// Mau nen cua Control bat buoc nhap
        /// </summary>
        /// <remarks></remarks>
        public static System.Drawing.Color COLOR_BACKCOLOROBLIGATORY = Color.LightYellow;

        /// <summary>
        /// Caption cho MessageBox
        /// </summary>
        /// <remarks></remarks>
        public static string MsgAnnouncement;

        public static DataTable dtPer; // Bang du lieu chua phan quyen cua man hinh

        public static float iSizeFont = 8.25F; // Font chuan cua man hinh 1024 x 768

        //Kiem tra xem co su dung Unicode 
        public static bool gbInputbyUnicode = false;

        /// <summary>
        /// Kiem tra save OK chua
        /// </summary>
        /// <remarks></remarks>
        public static bool gbSavedOK = false;

        /// <summary>
        ///  Dùng cho form Chọn đường dẫn báo cáo
        /// </summary>
        /// <remarks></remarks>
        public static string gsReportPath;

        /// <summary>
        /// Luu tru cac thiet lap tuy chon
        /// </summary>
        public static StructureOption OptSys;

        /// <summary>
        /// Dung de luu control khi nhan phim 11
        /// </summary>
        public static Control gcControl;

        public static int T = 0;
        public static int tr = 0;
        #endregion

        #region Public void and method
     
        #region connect and disconnect to server
        public static void connect()
        {
            try
            {
                gConn = new SqlConnection(gsConnectionString);
                if (gConn.State == ConnectionState.Closed)
                    gConn.Open();
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Không thể kết nối tới server được. \n" + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Can not connect to server. \n" + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        public static void disconnect()
        {
            gConn.Close();
        }
        #endregion

        #region Set Image và Shortcut của Popupmenu
        /// <summary>
        /// Set Image và Shortcut của Popupmenu
        /// </summary>
        /// <param name="C1CmdHolder">C1CommandHolder cua popupmenu</param>
        /// <remarks>Gọi hàm SetShortcutPopupMenu(C1CommandHolder)tại form_load</remarks>
        [DebuggerStepThrough()]
        public static void SetShortcutPopupMenu(C1.Win.C1Command.C1CommandHolder C1CmdHolder)
		{   
            C1CmdHolder.Commands["mnuAdd"].Image = Properties.Resources.add.ToBitmap();
            C1CmdHolder.Commands["mnuAdd"].Shortcut = Shortcut.CtrlN;
            C1CmdHolder.Commands["mnuView"].Image = Properties.Resources.view.ToBitmap();
			C1CmdHolder.Commands["mnuView"].Shortcut = Shortcut.CtrlV;
            C1CmdHolder.Commands["mnuEdit"].Image = Properties.Resources.edit1.ToBitmap();
			C1CmdHolder.Commands["mnuEdit"].Shortcut = Shortcut.CtrlE;
            C1CmdHolder.Commands["mnuDelete"].Image = Properties.Resources.delete.ToBitmap(); ;
			C1CmdHolder.Commands["mnuDelete"].Shortcut = Shortcut.CtrlD;
//			C1CmdHolder.Commands["mnuFind"].Image = Properties.Resources.find;
//			C1CmdHolder.Commands["mnuFind"].Shortcut = Shortcut.CtrlF;
//			C1CmdHolder.Commands["mnuListAll"].Image = Properties.Resources.ListAll;
//			C1CmdHolder.Commands["mnuListAll"].Shortcut = Shortcut.CtrlA;
//			C1CmdHolder.Commands["mnuSysInfo"].Image = Properties.Resources.SysInfo;
//			C1CmdHolder.Commands["mnuSysInfo"].Shortcut = Shortcut.CtrlI;
			C1CmdHolder.Commands["mnuPrint"].Image = Properties.Resources.print;
			C1CmdHolder.Commands["mnuPrint"].Shortcut = Shortcut.CtrlP;
		}

        /// <summary>
        /// Set Image và Shortcut của Popupmenu cua man hinh Group and User
        /// </summary>
        /// <param name="C1CmdHolder">C1CommandHolder cua popupmenu</param>
        /// <remarks>Gọi hàm SetShortcutPopupMenu(C1CommandHolder)tại form_load</remarks>
        [DebuggerStepThrough()]
        public static void SetShortcutPopupMenuForGroupAndUserScreen(C1.Win.C1Command.C1CommandHolder C1CmdHolder)
        {
            //Set image va shortcut cho man hinh GroupandUser
            C1CmdHolder.Commands["mnuAddGroup"].Image = Properties.Resources.add.ToBitmap();
            C1CmdHolder.Commands["mnuAddGroup"].Shortcut = Shortcut.CtrlN;
            C1CmdHolder.Commands["mnuEditGroup"].Image = Properties.Resources.edit1.ToBitmap();
            C1CmdHolder.Commands["mnuEditGroup"].Shortcut = Shortcut.CtrlE;
            C1CmdHolder.Commands["mnuDeleteGroup"].Image = Properties.Resources.delete.ToBitmap(); ;
            C1CmdHolder.Commands["mnuDeleteGroup"].Shortcut = Shortcut.CtrlD;           

            C1CmdHolder.Commands["mnuAddUser"].Image = Properties.Resources.add.ToBitmap();
            C1CmdHolder.Commands["mnuAddUser"].Shortcut = Shortcut.CtrlN;
            C1CmdHolder.Commands["mnuEditUser"].Image = Properties.Resources.edit1.ToBitmap();
            C1CmdHolder.Commands["mnuEditUser"].Shortcut = Shortcut.CtrlE;
            C1CmdHolder.Commands["mnuDeleteUser"].Image = Properties.Resources.delete.ToBitmap(); ;
            C1CmdHolder.Commands["mnuDeleteUser"].Shortcut = Shortcut.CtrlD;            
        }

        /// <summary>
        /// Set Image và Shortcut của Popupmenu cua man hinh Weighting sheet
        /// </summary>
        /// <param name="C1CmdHolder">C1CommandHolder cua popupmenu</param>
        /// <remarks>Gọi hàm SetShortcutPopupMenu(C1CommandHolder)tại form_load</remarks>
        [DebuggerStepThrough()]
        public static void SetShortcutPopupMenuForWeightingSheetScreen(C1.Win.C1Command.C1CommandHolder C1CmdHolder, string sFormName)
        {
            if (sFormName == "frmWeightingSheet")
            {
                C1CmdHolder.Commands["mnuAdd"].Image = Properties.Resources.add.ToBitmap();
                C1CmdHolder.Commands["mnuAdd"].Shortcut = Shortcut.CtrlN;
            }
            C1CmdHolder.Commands["mnuView"].Image = Properties.Resources.view.ToBitmap();
            C1CmdHolder.Commands["mnuView"].Shortcut = Shortcut.CtrlV;
            C1CmdHolder.Commands["mnuEdit"].Image = Properties.Resources.edit1.ToBitmap();
            C1CmdHolder.Commands["mnuEdit"].Shortcut = Shortcut.CtrlE;
//            C1CmdHolder.Commands["mnuEdit2nd"].Image = Properties.Resources.Edit2nd.ToBitmap();
//            C1CmdHolder.Commands["mnuEdit2nd"].Shortcut = Shortcut.Ctrl2;
            C1CmdHolder.Commands["mnuDelete1st"].Image = Properties.Resources.delete.ToBitmap(); ;
            C1CmdHolder.Commands["mnuDelete1st"].Shortcut = Shortcut.ShiftDel;
            C1CmdHolder.Commands["mnuDelete2nd"].Image = Properties.Resources.delete2;
            C1CmdHolder.Commands["mnuDelete2nd"].Shortcut = Shortcut.CtrlD;
            C1CmdHolder.Commands["mnuReuseWS"].Image = Properties.Resources.undo1;
            C1CmdHolder.Commands["mnuReuseWS"].Shortcut = Shortcut.CtrlR;
            C1CmdHolder.Commands["mnuPrint"].Image = Properties.Resources.print;
            C1CmdHolder.Commands["mnuPrint"].Shortcut = Shortcut.CtrlI;
        }

        #endregion

        #region Do phan giai man hinh

        /// <summary>
        /// Điều chỉnh độ phân giải của form KHÔNG có popupmenu
        /// </summary>
        /// <param name="MainCtrl">truyen vao ten form</param>
        /// <remarks>cach goi tai form_load: SetResolutionForm (Me)</remarks>
        [DebuggerStepThrough()]
        public static void SetResolutionForm(Form MainCtrl)
        {
            SetResolutionForm(MainCtrl, null, null, null, null);
        }

        /// <summary>
        /// Điều chỉnh độ phân giải của form có C1ContextMenu
        /// </summary>
        /// <param name="MainCtrl">Ten form</param>
        /// <param name="ctrlMenu">C1ContextMenu</param>
        /// <remarks>cach goi tai form_load: SetResolutionForm (Me, C1ContextMenu)</remarks>
        [DebuggerStepThrough()]
        public static void SetResolutionForm(Form MainCtrl, C1.Win.C1Command.C1ContextMenu ctrlMenu)
        {
            SetResolutionForm(MainCtrl, ctrlMenu, null, null, null);
        }

        /// <summary>
        /// Điều chỉnh độ phân giải của form có 2 C1ContextMenu
        /// </summary>
        /// <param name="MainCtrl">Ten form</param>
        /// <param name="ctrlMenu1">C1ContextMenu</param>
        /// <param name="ctrlMenu2">C1ContextMenu1</param>
        /// <remarks>cach goi tai form_load: SetResolutionForm (Me, C1ContextMenu, C1ContextMenu1)</remarks>
        [DebuggerStepThrough()]
        public static void SetResolutionForm(Form MainCtrl, C1.Win.C1Command.C1ContextMenu ctrlMenu1, C1.Win.C1Command.C1ContextMenu ctrlMenu2)
        {
            SetResolutionForm(MainCtrl, ctrlMenu1, ctrlMenu2, null, null);
        }

        /// <summary>
        /// Điều chỉnh độ phân giải của form có 3 C1ContextMenu
        /// </summary>
        /// <param name="MainCtrl">T?form</param>
        /// <param name="ctrlMenu1">C1ContextMenu</param>
        /// <param name="ctrlMenu2">C1ContextMenu1</param>
        /// <param name="ctrlMenu3">C1ContextMenu2</param>
        /// <remarks>cach goi tai form_load: SetResolutionForm (Me, C1ContextMenu, C1ContextMenu1, C1ContextMenu2)</remarks>
        [DebuggerStepThrough()]
        public static void SetResolutionForm(Form MainCtrl, C1.Win.C1Command.C1ContextMenu ctrlMenu1, C1.Win.C1Command.C1ContextMenu ctrlMenu2, C1.Win.C1Command.C1ContextMenu ctrlMenu3)
        {
            SetResolutionForm(MainCtrl, ctrlMenu1, ctrlMenu2, ctrlMenu3, null);
        }

        /// <summary>
        /// Điều chỉnh độ phân giải của form có 4 popupmenu
        /// </summary>
        /// <param name="MainCtrl">Ten form</param>
        /// <param name="ctrlMenu1">C1ContextMenu</param>
        /// <param name="ctrlMenu2">C1ContextMenu1</param>
        /// <param name="ctrlMenu3">C1ContextMenu2</param>
        /// <param name="ctrlMenu4">C1ContextMenu3</param>
        /// <remarks>cach goi tai form_load: SetResolutionForm (Me, C1ContextMenu, C1ContextMenu1, C1ContextMenu2, C1ContextMenu3)</remarks>
        [DebuggerStepThrough()]
        public static void SetResolutionForm(Form MainCtrl, C1.Win.C1Command.C1ContextMenu ctrlMenu1, C1.Win.C1Command.C1ContextMenu ctrlMenu2, C1.Win.C1Command.C1ContextMenu ctrlMenu3, C1.Win.C1Command.C1ContextMenu ctrlMenu4)
        {
            int x_original = 1024;
            int y_original = 768;
            System.Drawing.Rectangle workingRectangle = Screen.PrimaryScreen.Bounds; //Screen.PrimaryScreen.WorkingArea
            double tile_x = 0;
            double tile_y = 0;
            int y_Location = 35;

            tile_x = workingRectangle.Width / (double)x_original;
            tile_y = workingRectangle.Height / (double)y_original;
            if (tile_x <= 1 || tile_y <= 1)
            {
                //Định lại vị trí cho màn hình thiết kế theo chuẩn lớn nhất (1024 x 680)
                if (MainCtrl.Width == workingRectangle.Width)
                {
                    MainCtrl.Location = new System.Drawing.Point(0, y_Location);
                }
                return;
            }

            iSizeFont = System.Convert.ToSingle(8.25 + tile_x);

            int iMaxWidthForm = 1024;
            int iMaxHeightForm = 680;
            bool bMaxForm = false;
            bMaxForm = (MainCtrl.Height == iMaxHeightForm) & (MainCtrl.Width == iMaxWidthForm);

            MainCtrl.Size = new System.Drawing.Size(System.Convert.ToInt32(MainCtrl.Width * tile_x), System.Convert.ToInt32(MainCtrl.Height * tile_y));
            if (bMaxForm) // Là form lớn nhất theo chuẩn 1024 x 680
            {
                MainCtrl.Location = new System.Drawing.Point(0, System.Convert.ToInt32(y_Location + tile_y * 4));
            }
            else
            {
                MainCtrl.Location = new System.Drawing.Point(System.Convert.ToInt32((workingRectangle.Width - MainCtrl.Width) / 2), System.Convert.ToInt32((workingRectangle.Height - MainCtrl.Height) / 2));
            }

            foreach (Control ctrl in MainCtrl.Controls)
            {
                SetResolutionControl(ctrl, tile_x, tile_y);
            }

            //------------------------------------------------
            //Set độ phân giải cho Popupmenu
            if (ctrlMenu1 != null)
            {
                SetResolutionC1ContextMenu(ctrlMenu1);
            }
            if (ctrlMenu2 != null)
            {
                SetResolutionC1ContextMenu(ctrlMenu2);
            }
            if (ctrlMenu3 != null)
            {
                SetResolutionC1ContextMenu(ctrlMenu3);
            }
            if (ctrlMenu4 != null)
            {
                SetResolutionC1ContextMenu(ctrlMenu4);
            }

        }


        private static void SetResolutionControl(Control ctrl, double tile_x, double tile_y)
        {
            if (ctrl.HasChildren == true)
            {
                foreach (Control ctrl1 in ctrl.Controls)
                {
                    SetResolutionControl(ctrl1, tile_x, tile_y);
                }
            }

            // Nếu Groupbox là đường phân cách
            if (ctrl.GetType().Name == "GroupBox" && ctrl.HasChildren == false)
            {
                ctrl.Location = new System.Drawing.Point(System.Convert.ToInt32(ctrl.Location.X * tile_x), System.Convert.ToInt32(ctrl.Location.Y * tile_y));
                ctrl.Font = new System.Drawing.Font(ctrl.Font.Name, iSizeFont, ctrl.Font.Style);

                ctrl.Width = System.Convert.ToInt32(ctrl.Width * tile_x);
                return;
            }

            //Set lại kích cỡ, vị trí control
            ctrl.Location = new System.Drawing.Point(System.Convert.ToInt32(ctrl.Location.X * tile_x), System.Convert.ToInt32(ctrl.Location.Y * tile_y));
            ctrl.Font = new System.Drawing.Font(ctrl.Font.Name, iSizeFont, ctrl.Font.Style);

            if (ctrl.GetType().Name != "Label")
            {
                ctrl.Width = System.Convert.ToInt32(ctrl.Width * tile_x);
            }
            else
            {
                Label lb = (Label)ctrl;
                if (lb.AutoSize == false && lb.Name.ToLower() != "lblimage")
                {
                    lb.Width = System.Convert.ToInt32(lb.Width * tile_x);
                }
            }
            ctrl.Height = System.Convert.ToInt32(ctrl.Height * tile_y);

            //Set lại các đặc tính riêng của từng control
            // If ctrl.GetType.Name = "C1TrueDBGrid" Then
            //Dim tdbg1 As New C1.Win.C1TrueDBGrid.C1TrueDBGrid
            //tdbg1 = CType(ctrl, C1.Win.C1TrueDBGrid.C1TrueDBGrid)
            //tdbg1.RowHeight = CInt(tdbg1.RowHeight * tile_y)
            //For i As Integer = 0 To tdbg1.Splits.ColCount - 1
            //    With tdbg1.Splits(i)
            //        For j As Integer = 0 To tdbg1.Columns.Count - 1
            //            .DisplayColumns(j).Width = CInt(.DisplayColumns(j).Width * tile_x)
            //            .DisplayColumns(j).HeadingStyle.Font = New System.Drawing.Font(.DisplayColumns(j).HeadingStyle.Font.Name, iSizeFont, .DisplayColumns(j).HeadingStyle.Font.Style)
            //            .DisplayColumns(j).FooterStyle.Font = New System.Drawing.Font(.DisplayColumns(j).FooterStyle.Font.Name, iSizeFont, .DisplayColumns(j).FooterStyle.Font.Style)
            //            .DisplayColumns(j).Style.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Center
            //        Next
            //        .ColumnCaptionHeight = CInt(.ColumnCaptionHeight * tile_x)
            //        .ColumnFooterHeight = CInt(.ColumnFooterHeight * tile_x)
            //        .SplitSize = CInt(.SplitSize * tile_x)
            //    End With

            //Next

            if (ctrl.GetType().Name == "C1TrueDBGrid")
            {
                C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbg1 = new C1.Win.C1TrueDBGrid.C1TrueDBGrid();
                tdbg1 = (C1.Win.C1TrueDBGrid.C1TrueDBGrid)ctrl;
                tdbg1.RowHeight = System.Convert.ToInt32(tdbg1.RowHeight * tile_y);

                for (int i = 0; i < tdbg1.Splits.ColCount; i++)
                {
                    C1.Win.C1TrueDBGrid.Split tempWith1 = tdbg1.Splits[i];
                    //object tempWith1 = tdbg1.Splits[i];
                    for (int j = 0; j < tdbg1.Columns.Count; j++)
                    {
                        tempWith1.DisplayColumns[j].Width = System.Convert.ToInt32(tempWith1.DisplayColumns[j].Width * tile_x);
                        tempWith1.DisplayColumns[j].HeadingStyle.Font = new System.Drawing.Font(tempWith1.DisplayColumns[j].HeadingStyle.Font.Name, iSizeFont, tempWith1.DisplayColumns[j].HeadingStyle.Font.Style);
                        tempWith1.DisplayColumns[j].FooterStyle.Font = new System.Drawing.Font(tempWith1.DisplayColumns[j].FooterStyle.Font.Name, iSizeFont, tempWith1.DisplayColumns[j].FooterStyle.Font.Style);
                        tempWith1.DisplayColumns[j].Style.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignVertEnum.Center;
                    }
                    tempWith1.ColumnCaptionHeight = System.Convert.ToInt32(tempWith1.ColumnCaptionHeight * tile_x);
                    tempWith1.ColumnFooterHeight = System.Convert.ToInt32(tempWith1.ColumnFooterHeight * tile_x);
                    tempWith1.SplitSize = System.Convert.ToInt32(tempWith1.SplitSize * tile_x);

                }
            }
            else if (ctrl.GetType().Name == "C1Combo")
            {
                C1.Win.C1List.C1Combo combo1 = new C1.Win.C1List.C1Combo();
                combo1 = (C1.Win.C1List.C1Combo)ctrl;
                combo1.ItemHeight = System.Convert.ToInt32(combo1.ItemHeight * tile_y);
                combo1.DropDownWidth = System.Convert.ToInt32(combo1.DropDownWidth * tile_y);
                for (int i = 0; i < combo1.Splits.Count; i++)
                {
                    //object tempWith2 = combo1.Splits[i];
                    C1.Win.C1List.Split tempWith2 = combo1.Splits[i];
                    for (int j = 0; j < combo1.Columns.Count; j++)
                    {
                        tempWith2.DisplayColumns[j].HeadingStyle.Font = new System.Drawing.Font(tempWith2.DisplayColumns[j].HeadingStyle.Font.Name, iSizeFont, tempWith2.DisplayColumns[j].HeadingStyle.Font.Style);
                        tempWith2.DisplayColumns[j].Width = System.Convert.ToInt32(tempWith2.DisplayColumns[j].Width * tile_x);
                    }
                }
                combo1.Splits[0].ColumnCaptionHeight = System.Convert.ToInt32(combo1.Splits[0].ColumnCaptionHeight * tile_x);
                combo1.VScrollBar.Width = System.Convert.ToInt32(combo1.VScrollBar.Width * tile_x);
                combo1.HScrollBar.Height = System.Convert.ToInt32(combo1.HScrollBar.Height * tile_y);

            }
            else if (ctrl.GetType().Name == "C1TrueDBDropdown")
            {
                C1.Win.C1TrueDBGrid.C1TrueDBDropdown dropdown1 = new C1.Win.C1TrueDBGrid.C1TrueDBDropdown();
                dropdown1 = (C1.Win.C1TrueDBGrid.C1TrueDBDropdown)ctrl;
                dropdown1.RowHeight = System.Convert.ToInt32(dropdown1.RowHeight * tile_y);
                dropdown1.ColumnCaptionHeight = System.Convert.ToInt32(dropdown1.ColumnCaptionHeight * tile_x);
                for (int i = 0; i < dropdown1.Columns.Count; i++)
                {
                    dropdown1.DisplayColumns[i].HeadingStyle.Font = new System.Drawing.Font(dropdown1.DisplayColumns[i].HeadingStyle.Font.Name, iSizeFont, dropdown1.DisplayColumns[i].HeadingStyle.Font.Style);
                    dropdown1.DisplayColumns[i].Width = System.Convert.ToInt32(dropdown1.DisplayColumns[i].Width * tile_x);
                }
            }
            else if (ctrl.GetType().Name == "C1DateEdit")
            {
                C1.Win.C1Input.C1DateEdit sc1dateEdit = null;
                System.Windows.Forms.MonthCalendar sMonthCalendar = new System.Windows.Forms.MonthCalendar();
                sc1dateEdit = (C1.Win.C1Input.C1DateEdit)ctrl;

                sc1dateEdit.Calendar.Font = new System.Drawing.Font(sc1dateEdit.Calendar.Font.Name, iSizeFont, sc1dateEdit.Calendar.Font.Style);
                sc1dateEdit.Calendar.Height = System.Convert.ToInt32(tile_y * sc1dateEdit.Calendar.Height);
                sc1dateEdit.Calendar.Width = System.Convert.ToInt32(tile_x * sc1dateEdit.Calendar.Height);
            }
            else if (ctrl.GetType().Name == "StatusStrip")
            {
                System.Windows.Forms.StatusStrip sStatusStrip = new System.Windows.Forms.StatusStrip();
                sStatusStrip = (System.Windows.Forms.StatusStrip)ctrl;
                for (int i = 0; i < sStatusStrip.Items.Count; i++)
                {
                    sStatusStrip.Items[i].Width = System.Convert.ToInt32(sStatusStrip.Items[i].Width * tile_x);
                }
            }
            else if (ctrl.GetType().Name == "Button")
            {
                System.Windows.Forms.Button sButton = new System.Windows.Forms.Button();
                sButton = (System.Windows.Forms.Button)ctrl;
                //if (sButton.Name.Contains("btnSetNewKey"))
                //{
                //	sButton.BackgroundImage = sButton.Image; //My.Resources.KEY
                //	sButton.BackgroundImageLayout = ImageLayout.Stretch;
                //	sButton.Image = null;
                //}
            }
            else if (ctrl.GetType().Name == "PictureBox")
            {
                System.Windows.Forms.PictureBox sPicture = new System.Windows.Forms.PictureBox();
                sPicture = (System.Windows.Forms.PictureBox)ctrl;
                sPicture.BackgroundImageLayout = ImageLayout.Stretch;

            }
            else if (ctrl.GetType().Name == "ComboBox")
            {
                System.Windows.Forms.ComboBox combo1 = new System.Windows.Forms.ComboBox();

                combo1 = (System.Windows.Forms.ComboBox)ctrl;
                combo1.ItemHeight = System.Convert.ToInt32(combo1.ItemHeight * tile_y);
                combo1.DropDownWidth = System.Convert.ToInt32(combo1.DropDownWidth * (tile_y + 0.1));
                //Height của combo = kích thước của Font
                combo1.Font = new System.Drawing.Font(combo1.Font.Name, System.Convert.ToSingle((int)Math.Floor(iSizeFont + tile_x * 2)), combo1.Font.Style);
            }
        }

        /// <summary>
        /// Điều chỉnh độ phân giải của menu
        /// </summary>
        /// <param name="ctrl"></param>
        /// <remarks>Cách gọi tại form_load: SetResolutionC1ContextMenu (C1ContextMenu)</remarks>
        private static void SetResolutionC1ContextMenu(C1.Win.C1Command.C1ContextMenu ctrl)
        {
            ctrl.Font = new System.Drawing.Font(ctrl.Font.Name, iSizeFont);
        }
        #endregion

        #region Ghi FooterText của dòng Tổng cộng
        /// <summary>
        /// Ghi FooterText của dòng Tổng cộng
        /// </summary>
        /// <param name="tdbg"></param>
        /// <param name="sColumnName">Tên cột gắn chữ Tổng cộng</param>
        /// <remarks>Cách gọi: FooterTotalGrid(tdbg, "ObjectID")</remarks>
        [DebuggerStepThrough()]
        public static void FooterTotalGrid(C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbg, string sColumnName)
        {
            if (cls_GlobalUtil.OptSys.Language == 0)
                tdbg.Columns[sColumnName].FooterText = "Tổng: " + tdbg.RowCount;
            else
                tdbg.Columns[sColumnName].FooterText = "Total: " + tdbg.RowCount;
        }

        /// <summary>
        /// Ghi FooterText của dòng Tổng cộng
        /// </summary>
        /// <param name="tdbg"></param>
        /// <param name="iColumnName">Index của cột gắn chữ Tổng cộng</param>
        /// <remarks>Cách gọi: FooterTotalGrid(tdbg, COL_ObjectID)</remarks>
        [DebuggerStepThrough()]
        public static void FooterTotalGrid(C1.Win.C1TrueDBGrid.C1TrueDBGrid tdbg, int iColumnName)
        {
            if (cls_GlobalUtil.OptSys.Language == 0)
                tdbg.Columns[iColumnName].FooterText = "Tổng: " + tdbg.RowCount;
            else
                tdbg.Columns[iColumnName].FooterText = "Total: " + tdbg.RowCount;
        }
        #endregion

        #region Message khi xu ly tren form (Delete, Save, Close)
        /// <summary>
        /// Message hoi truoc khi dong man hinh co nut Save
        /// </summary>
        /// <returns></returns>
        /// <remarks>Vao su kien FormClosing cua form viet doan code sau </remarks>
        //if (_FormState == EnumFormState.FormEdit)
        //	{
        //		if (!gbSavedOK)
        //		{
        //			if (! (cls_GlobalUtil.AskMsgBeforeClose()))
        //			{
        //				e.Cancel = true;
        //				return;
        //			}
        //		}
        //	}
        //	else if (_FormState == EnumFormState.FormAdd)
        //	{
        //		if (btnSave.Enabled)
        //		{
        //			if (! (cls_GlobalUtil.AskMsgBeforeClose()))
        //			{
        //				e.Cancel = true;
        //				return;
        //			}
        //		}
        //	}
        [DebuggerStepThrough()]
        public static bool AskMsgBeforeClose()
        {
            bool bResult = false;
            if (cls_GlobalUtil.OptSys.Language == 0)
            {
                bResult = System.Convert.ToBoolean(((cls_MessageBox.MsgAsk("Dữ liệu chưa được lưu. Bạn có muốn đóng không?", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) ? true : false));
            }
            else
            {
                bResult = System.Convert.ToBoolean(((cls_MessageBox.MsgAsk("Data has not been saved. Do you want close?", MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes) ? true : false));
            }
            return bResult;
        }

        /// <summary>
        /// Hoi truoc khi luu tuy thuoc vao thiet lap tuy chon
        /// </summary>
        public static DialogResult AskSave()
        {
            if (OptSys.MessageAskBeforeSave)
            {
                return cls_MessageBox.MsgAskSave();
            }
            else
            {
                return DialogResult.Yes;    //Luon dong y neu khong check vao thiet lap o tuy chon
            }
        }

        /// <summary>
        /// Kiểm tra có tồn tại dữ liệu trong bảng này chua
        /// </summary>
        ///  <param name="sTable">Tên bảng</param>
        /// <param name="sField">Tên Field cần kiểm tra</param>
        /// <param name="sFieldValue">Giá trị field cần kiểm tra</param>
        /// <returns>True : cho phép Delete</returns>
        /// <remarks></remarks>
        [DebuggerStepThrough]
        public static bool CheckForDelete(string sTable, string sField, string sFieldValue)
        {
            string sSQL = "";
            sSQL += "Select Top 1 1 From " + sTable;
            sSQL += " Where ";
            sSQL += sField + " = " + SQLString(sFieldValue);

            DataTable dt = null;
            dt = ReturnDataTable(sSQL);
            if (dt.Rows.Count > 0)
            {
                cls_MessageBox.MsgCanNotDelete();
                return false;
            }

            return true;
        }

        /// <summary>
        /// Thong bao truoc khi xoa
        /// </summary>    
        public static DialogResult AskDelete()
        {
            if (OptSys.MessageAskBeforeDelete)
            {
                return cls_MessageBox.MsgAskDelete();
            }
            else
            {
                return DialogResult.Yes;    //Luon dong y neu khong check vao thiet lap o tuy chon
            }
        }

        /// <summary>
        /// Thong bao khi luu thanh cong tuy thuoc vao thiet lap tuy chon
        /// </summary>
        public static void SaveOK()
        {
            if (OptSys.MessageWhenProcessOK)
            {
                cls_MessageBox.MsgSaveOK();
            }
        }

        /// <summary>
        /// Thong bao khi khong luu duoc du lieu
        /// </summary>
        public static void SaveNotOK()
        {
            cls_MessageBox.MsgSaveNotOK();
        }

        /// <summary>
        /// Thông báo sau khi xóa thành công
        /// </summary>
        public static void DeleteOK()
        {
            if (OptSys.MessageWhenProcessOK)
            {
                cls_MessageBox.MsgDeleteOK();
            }
        }

        /// <summary>
        /// Thong bao khi khong xoa duoc du lieu
        /// </summary>
        public static void DeleteNotOK()
        {
            cls_MessageBox.MsgDeleteNotOK();
        }
        #endregion

        #region Kiem tra gia tri co trong Dropdown

        /// <summary>
        /// Kiem tra gia tri co trong Dropdown
        /// </summary>
        /// <param name="tdbDD"></param>
        /// <param name="sValue"></param>
        /// <returns>true: co trong danh sach</returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static bool CheckDropdownInList(C1.Win.C1TrueDBGrid.C1TrueDBDropdown tdbDD, string sValue)
        {
            DataTable dt = ((DataTable)tdbDD.DataSource).Copy();
            Int32 row = ReturnRowTable(dt, tdbDD.DisplayMember, sValue);
            return row >= 0;
        }

        /// <summary>
        /// Kiểm tra giá trị có trong Dropdown có truyền KeysField
        /// </summary>
        /// <param name="tdbDD"></param>
        /// <param name="sKeysField"></param>
        /// <param name="sValue"></param>
        /// <returns>true: c??ong danh s?</returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static bool CheckDropdownInList(C1.Win.C1TrueDBGrid.C1TrueDBDropdown tdbDD, string sKeysField, string sValue)
        {
            DataTable dt = ((DataTable)tdbDD.DataSource).Copy();
            Int32 row = ReturnRowTable(dt, sKeysField, sValue);
            return row >= 0;
        }
        #endregion

        #region Load option system
        /// <summary>
        /// Load toan bo cac thong so tuy chon vao bien OptSys
        /// </summary>
        [DebuggerStepThrough()]
        public static void LoadOptions()
        {
            //===========Default tab================
            OptSys.MessageAskBeforeSave = Convert.ToBoolean(cls_Registry.GetOptionsSetting("MessageAskBeforeSave", "true"));
            OptSys.MessageAskBeforeDelete = Convert.ToBoolean(cls_Registry.GetOptionsSetting("MessageAskBeforeDelete", "true"));
            OptSys.MessageWhenProcessOK = Convert.ToBoolean(cls_Registry.GetOptionsSetting("MessageWhenProcessOK", "true"));
            //===========Language tab===============
            OptSys.Language = Convert.ToInt32(cls_Registry.GetOptionsSetting("Language", "1"));
            //===========Converted coefficient tab=================
            OptSys.ConvertedCoefficient = Convert.ToDouble(cls_Registry.GetOptionsSetting("ConvertedCoefficient", "0.0011"));
            //===========VoucherNo prefix tab=======================
            OptSys.VoucherNoPrefix = cls_Registry.GetOptionsSetting("VoucherNoPrefix");
            
            //OptSys.ViewReportPath = Convert.ToBoolean(cls_Registry.GetOptionsSetting("ShowReport", "false"));
        }
        #endregion

        #region Kiểm tra số hợp lệ không hợp lệ: Ham ESIsNumeric

        /// <summary>
        /// Kiểm tra số hợp lệ không hợp lệ thì gán = 0 và Trả về false
        /// </summary>
        /// <param name="sValue">Giá trị truyền vào và trả ra</param>
        /// <returns></returns>
        /// <remarks>Nếu số không hợp lệ thì trả về =0</remarks>
        [DebuggerStepThrough()]
        public static bool ESIsNumeric(string sValue)
        {
            if (!(Microsoft.VisualBasic.Information.IsNumeric(sValue)))
            {
                sValue = "0";
                return false;
            }
            return true;
        }

        ///<summary>
        ///Kiểm tra số hợp lệ không hợp lệ thì gán = 0 và Trả về false
        ///</summary>
        ///<param name="sValue">Giá trị truyền vào và trả ra</param>
        ///<param name="_EnumDataType">Kiểu dữ liệu dùng để kiểm tra</param>
        ///<returns></returns>
        ///<remarks>Nếu số không hợp lệ thì trả về =0</remarks>
        [DebuggerStepThrough()]
        public static bool ESIsNumeric(string sValue, EnumDataType _EnumDataType)
        {
            if (!(Microsoft.VisualBasic.Information.IsNumeric(sValue)))
            {
                sValue = "0";
                return false;
            }

            double dbValue = double.Parse(sValue);
            switch (_EnumDataType)
            {
                case EnumDataType.TinyInt:
                    if (dbValue > MaxTinyInt | dbValue < MaxTinyInt * (-1))
                    {
                        sValue = "0";
                        return false;
                    }
                    break;
                case EnumDataType.Int:
                    if (dbValue > MaxInt | dbValue < MaxInt * (-1))
                    {
                        sValue = "0";
                        return false;
                    }
                    break;
                case EnumDataType.Money:
                    if (dbValue > MaxMoney | dbValue < MaxMoney * (-1))
                    {
                        sValue = "0";
                        return false;
                    }
                    break;
                case EnumDataType.SmallMoney:
                    if (dbValue > MaxSmallMoney | dbValue < MaxSmallMoney * (-1))
                    {
                        sValue = "0";
                        return false;
                    }
                    break;
                case EnumDataType.Number:
                    if ((dbValue > (double)MaxDecimal | dbValue < (double)MaxDecimal * (-1)))
                    {
                        sValue = "0";
                        return false;
                    }
                    break;
            }
            dbValue = 0;

            return true;
        }
        #endregion

        #region Load ket qua khi tim kiem

        /// <summary>
        /// Load lại dữ liệu cho lưới sau khi tìm kiếm
        /// </summary>
        /// <param name="C1Grid"></param>
        /// <param name="dtRoot">Bảng dữ liệu trước khi tìm kiếm</param>
        /// <param name="sClauseFind">Điều kiện sau khi tìm kiếm</param>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static void LoadGridFind(C1.Win.C1TrueDBGrid.C1TrueDBGrid C1Grid, DataTable dtRoot, string sClauseFind)
        {
            DataTable dtF = null;
            dtF = dtRoot.Copy();
            dtF.DefaultView.RowFilter = sClauseFind.Replace("N'", "'");
            cls_C1LoadData.LoadDataSource(C1Grid, dtF);

        }

        /// <summary>
        /// Trả về một table sau khi đã được lọc
        /// </summary>
        /// <param name="dt">Bảng dữ liệu trước khi lọc</param>
        /// <param name="sWhereClause">Điều kiện lọc (ví dụ:  ObjectTypeID = 'KH')</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static DataTable ReturnTableFilter1(DataTable dt, string sWhereClause)
        {
            DataTable dt1 = null;
            DataTable dt2 = null;

            dt2 = dt.Copy();

            //dt2.PrimaryKey.Sort()
            dt2.DefaultView.RowFilter = sWhereClause;
            dt1 = dt2.DefaultView.ToTable();

            return dt1;

        }

        public static DataTable ReturnTableFilter(DataTable dt, string sWhereClause)
        {
            return ReturnTableFilter(dt, sWhereClause, false);
        }

        public static DataTable ReturnTableFilter(DataTable dt, string sWhereClause, bool bCopy)
        {
            if (bCopy) //Nêu muôn giu lai DataTable gôc (không thao tac trưc tiêp lên DataTable gôc) 
            {
                DataTable dt2 = null;
                dt2 = dt.Copy();
                dt2.DefaultView.RowFilter = sWhereClause;

                return dt2.DefaultView.ToTable();
            }
            else //Thao tac trưc tiêp trên DataTable gôc (thay đôi DefaultView - dư liêu nhin thây) nhưng dư liêu gôc vân giư nguyên (sô lương dong vân giư nguyên co thê dung đê RowFilter tiêp) 
            {
                dt.DefaultView.RowFilter = sWhereClause;
                return dt.DefaultView.ToTable();
            }
        }

        /// <summary>
        /// Trả về vị trí row của bảng sau khi tìm kiếm
        /// </summary>
        /// <param name="dt">Bảng dữ liệu</param>
        /// <param name="sKeysField">Khóa của bảng</param>
        /// <param name="sValue">Giá trị cần tìm</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static int ReturnRowTable(DataTable dt, string sKeysField, string sValue)
        {
            return ReturnRowTable(dt, sKeysField, sValue, "ASC");
        }

        ///<summary>
        /// Trả về vị trí row của bảng sau khi tìm kiếm
        /// </summary>
        /// <param name="dt">Bảng dữ liệu</param>
        /// <param name="sKeysField">Khóa của bảng</param>
        /// <param name="sValue">Giá trị cần tìm</param>
        /// <param name="sOrder">Thứ tự sắp xếp: ASC hay DESC </param>
        /// <returns></returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static int ReturnRowTable(DataTable dt, string sKeysField, string sValue, string sOrder)
        {
            dt.DefaultView.Sort = sKeysField + new String(' ', 1) + sOrder;
            return dt.DefaultView.Find(sValue);
        }
        #endregion

        #region Ket qua tra ve (DataTable/DataSet/Scalar) khi thuc thi truy van

        /// <summary>
        /// Hien thi bao loi trong qua trinh coding
        /// </summary>
        /// <param name="Text">Chuoi bao loi/param>
        [DebuggerStepThrough()]
        public static void MsgErr(string Text)
        {
            MessageBox.Show(Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        /// <summary>
        /// Tra ve DataSet tu chuoi SQL truyen vao
        /// </summary>
        /// <param name="SQL">Chuoi SQL can thuc thi</param>
        /// <returns>Trả về một DataSet nếu thực thi chuỗi SQL thành công, ngược lại sẽ báo lỗi bằng MsgErr</returns>
        //[DebuggerStepThrough()]
        public static DataSet ReturnDataSet(string SQL)
        {
            DataSet ds = new DataSet();
            //SqlConnection conn = new SqlConnection(gsConnectionString);
            connect();
            //SqlCommand cmd = new SqlCommand(SQL, conn);
            SqlCommand cmd = new SqlCommand(SQL, gConn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            try
            {
                //conn.Open();
                cmd.CommandTimeout = 0;
                da.Fill(ds);
                //conn.Close();
                disconnect();
                return ds;
            }
            catch
            {
                //conn.Close();
                disconnect();
                Clipboard.Clear();
                Clipboard.SetText(SQL);
                MsgErr("Error when excute SQL in function ReturnDataSet(). Paste your SQL code from Clipboard");
                WriteLogFile(SQL);
                return null;
            }
        }

        /// <summary>
        /// Trả về một DataSet từ chuỗi SQL truyền vào
        /// </summary>
        /// <param name="SQL">Chuỗi SQL cần thực thi</param>
        /// <param name="TableName">Mảng chứa tên các Table của DataSet</param>
        /// <returns>Trả về một DataSet nếu thực thi chuỗi SQL thành công, ngược lại sẽ báo lỗi bằng MsgErr</returns>
        [DebuggerStepThrough()]
        public static DataSet ReturnDataSet(string SQL, string[] TableName)
        {
            DataSet ds = ReturnDataSet(SQL);
            if (ds == null)
            {
                return null;
            }
            for (int i = 0; i < TableName.Length; i++)
            {
                ds.Tables[i].TableName = TableName[i];
            }
            return ds;
        }

        /// <summary>
        /// Trả về một DataTable từ chuỗi SQL
        /// </summary>
        /// <param name="SQL">Chuỗi SQL thực thực</param>
        /// <returns>DataTable nếu thực thi thành công lệnh SQL, ngược lại trả về null</returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static DataTable ReturnDataTable(string SQL)
        {
            DataSet ds = ReturnDataSet(SQL);
            if (ds == null)
            {
                return null;
            }
            return ds.Tables[0];
        }

        /// <summary>
        /// Thực thi câu lệnh SQL, trả về kết quả là hàng đâu tiên và cột đầu tiên theo dạng chuỗi
        /// </summary>
        /// <param name="SQL">Chuỗi SQL cần thực thi</param>
        /// <returns>Trả về một chuỗi nếu thực thi lệnh SQL thành công, ngược lại sẽ hiển thị MsgErr</returns>
        /// <remarks>Thường dùng để kiểm tra</remarks>
        [DebuggerStepThrough()]
        public static string ReturnScalar(string SQL)
        {
            try
            {
                DataTable dt = ReturnDataTable(SQL);
                if (dt.Rows.Count > 0) //Có dữ liệu trong bảng
                {
                    return dt.Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
                //dt = null;
            }
            catch
            {
                Clipboard.Clear();
                Clipboard.SetText(SQL);
                MsgErr("Error when excute function ReturnScalar(). Paste your SQL code from Clipboard");
                return "";
            }
        }

        public static int ReturnScalar_Identity(string sSQL)
        {
            try
            {
                sSQL = sSQL + " ; select @@identity ";
                return Convert.ToInt16( ReturnScalar(sSQL));
            }
            catch
            {                
                return 0;
            }
        }
        #endregion

        #region Chuyen doi kieu du lieu ho tro SQL

        #region SQLString
        /// <summary>
        /// Thay các dấu ' thành '' dùng trong các lệnh SQL
        /// </summary>
        /// <param name="Text">Chuỗi Text truyền vào</param>
        /// <remarks>Chú ý là kết quả trả về có dấu ' ở hai đầu chuỗi</remarks>
        [DebuggerStepThrough()]
        public static string SQLString(string Text)
        {
            Text = Text.Trim();
            return "'" + Text.Replace("'", "''") + "'";
        }

        /// <summary>
        /// Thay các dấu ' thành '' dùng trong các lệnh SQL
        /// </summary>
        /// <param name="Text">Chuỗi Text truyền vào</param>
        /// <remarks>Chú ý là kết quả trả về có dấu ' ở hai đầu chuỗi</remarks>
        [DebuggerStepThrough()]
        public static string SQLString(object Text)
        {
            if (Text == null)
            {
                return "''";
            }
            if (System.Convert.IsDBNull(Text))
            {
                return "''";
            }
            return SQLString(Text.ToString());
        }

        /// <summary>
        /// Thay các dấu ' thành '' dùng trong các lệnh SQL
        /// </summary>
        /// <param name="Bool">Giá trị bool, nếu true sẽ chuyển thành 1, ngược lại chuyển thành 0</param>
        /// <remarks>Chú ý là kết quả trả về có dấu ' ở hai đầu chuỗi</remarks>
        [DebuggerStepThrough()]
        public static string SQLString(bool Bool)
        {
            if (Bool)
            {
                return SQLString("1");
            }
            else
            {
                return SQLString("0");
            }
        }


        /// <summary>
        /// Chuyển chuỗi sang UNICODE
        /// </summary>
        /// <param name="Text">Chuỗi Text truyền vào</param>
        /// <remarks>Chú ý là kết quả trả về có dấu ' ở hai đầu chuỗi</remarks>
        [DebuggerStepThrough()]
        public static string SQLString(object Text, bool ConvertToVNI)
        {
            if (Text == null)
            {
                return "''";
            }
            if (System.Convert.IsDBNull(Text))
            {
                return "''";
            }
            return SQLString(Text.ToString(), ConvertToVNI);
        }


        /// <summary>
        /// Chuyển chuỗi sang UNICODE
        /// </summary>
        /// <param name="Text">Chuỗi Text truyền vào</param>
        /// <remarks>Chú ý là kết quả trả về có dấu ' ở hai đầu chuỗi</remarks>
        [DebuggerStepThrough()]
        public static string SQLString(string Text, bool ConvertToVNI)
        {
            Text = Text.Trim();
            if (ConvertToVNI)
            {
                Text = cls_ConvertFont.ConvertUnicodeToVni(Text);
            }
            return "'" + Text.Replace("'", "''") + "'";
        }
        #endregion

        #region InsertZero
        /// <summary>
        /// Thêm các số 0 vào chuỗi format
        /// </summary>
        /// <param name="NumZero">Số cần tạo</param>
        /// <returns>Các số 0 tương ứng và dấu chấm (nếu có)</returns>
        [DebuggerStepThrough()]
        public static string InsertZero(int NumZero)
        {
            string sRet = "";
            if (NumZero == 0)
            {
                sRet = "";
            }
            else
            {
                sRet = ".";
                for (int i = 0; i < NumZero; i++)
                {
                    sRet = sRet + "0";
                }
            }
            return sRet;
        }
        #endregion

        #region SQLNumber
        /// <summary>
        /// Trả về kiểu số
        /// </summary>
        /// <param name="Number">Số cần chuyển</param>
        [DebuggerStepThrough()]
        public static double ConvertToNumber(string Number)
        {
            if (Number == "")
            {
                return 0;
            }
            return System.Convert.ToDouble(Number);
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLNumber(string Number)
        {
            if (Number == "")
            {
                return "0";
            }
            //double dNumber = System.Convert.ToDouble(Number);
            //return string.Format("{}", dNumber);
            return System.Convert.ToDouble(Number).ToString();
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>		
        [DebuggerStepThrough()]
        public static string SQLNumber(bool Number)
        {
            return (Number ? "1" : "0").ToString();
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>		
        [DebuggerStepThrough()]
        public static string SQLNumber(object Number)
        {
            if (System.Convert.IsDBNull(Number))
            {
                return "0";
            }
            if (Number.ToString() == "true" || Number.ToString() == "false")
            {
                return SQLNumber(Convert.ToBoolean(Number));
            }
            return SQLNumber(System.Convert.ToString(Number));
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        /// <param name="StringFormat">Format số trước khi insert</param>
        [DebuggerStepThrough()]
        public static string SQLNumber(string Number, string StringFormat)
        {
            if (Number == "")
            {
                return "0";
            }
            double dNumber = System.Convert.ToDouble(Number);
            return String.Format(StringFormat, dNumber);
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLNumber(object Number, string StringFormat)
        {
            if (Number == null)
            {
                return "0";
            }
            if (System.Convert.IsDBNull(Number))
            {
                return "0";
            }
            double dNumber = System.Convert.ToDouble(Number);
            return String.Format(StringFormat, dNumber);
        }

        #endregion

        #region SQLMoney

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLMoney(string Number)
        {
            return SQLNumber(Number);
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLMoney(object Number)
        {
            return SQLNumber(Number);
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLMoney(string Number, string sFormat)
        {
            return System.Convert.ToDouble(SQLNumber(Number, sFormat)).ToString();
        }

        /// <summary>
        /// Trả về chuỗi kiểu số để lưu vào database
        /// </summary>
        /// <param name="Number">Số insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLMoney(object Number, string sFormat)
        {
            return System.Convert.ToDouble(SQLNumber(Number, sFormat)).ToString();
        }

        /// <summary>
        /// Trả về số dạng Double để tính toán
        /// </summary>
        /// <param name="Number">Số để tính toán</param>
        /// <param name="sFormat">Chuỗi format</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static double ConvertMoney(string Number, string sFormat)
        {
            return System.Convert.ToDouble(SQLNumber(Number, sFormat));
        }

        /// <summary>
        /// Trả về số dạng Double để tính toán
        /// </summary>
        /// <param name="Number">Số để tính toán</param>
        /// <param name="sFormat">Chuỗi format</param>
        /// <returns></returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static double ConvertMoney(object Number, string sFormat)
        {
            return System.Convert.ToDouble(SQLNumber(Number, sFormat));
        }
        #endregion

        #region SQLDateSave

        /// <summary>
        /// Trả về chuỗi kiểu ngày để lưu vào database ở dạng MM/dd/yyyy
        /// </summary>
        /// <param name="Date">Ngày insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLDateSave(string Date)
        {
            if (Date == "")
            {
                return "NULL";
            }
            if (Date == MaskFormatDateShort)
            {
                return "NULL";
            }
            if (Date == MaskFormatDate)
            {
                return "NULL";
            }
            System.DateTime dDate = System.Convert.ToDateTime(Date);
            return SQLString(dDate.ToString("MM/dd/yyyy"));

        }

        /// <summary>
        /// Trả về chuỗi kiểu ngày để lưu vào database ở dạng MM/dd/yyyy
        /// </summary>
        /// <param name="Date">Ngày insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLDateSave(object Date)
        {
            if (System.Convert.IsDBNull(Date))
            {
                return "NULL";
            }
            if (Date.ToString() == MaskFormatDateShort)
            {
                return "NULL";
            }
            if (Date.ToString() == MaskFormatDate)
            {
                return "NULL";
            }
            return SQLDateSave(Date.ToString());
        }

        /// <summary>
        /// Trả về chuỗi kiểu ngày để lưu vào database ở dạng MM/dd/yyyy HH:mm:ss
        /// </summary>
        /// <param name="Date">Ngày insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLDateTimeSave(string Date)
        {
            if (Date == "")
            {
                return "NULL";
            }
            System.DateTime dDate = System.Convert.ToDateTime(Date);
            return SQLString(dDate.ToString("MM/dd/yyyy HH:mm:ss"));
        }

        /// <summary>
        /// Trả về chuỗi kiểu ngày để lưu vào database ở dạng MM/dd/yyyy HH:mm:ss
        /// </summary>
        /// <param name="Date">Ngày insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLDateTimeSave(object Date)
        {
            if (System.Convert.IsDBNull(Date))
            {
                return "NULL";
            }
            return SQLDateTimeSave(Date.ToString());
        }

        /// <summary>
        /// Trả về chuỗi kiểu ngày để lưu vào database ở dạng MM/dd/yyyy HH:mm
        /// </summary>
        /// <param name="Date">Ngày insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLDateTimeNotSecondSave(string Date)
        {
            if (Date == "")
            {
                return "NULL";
            }
            System.DateTime dDate = System.Convert.ToDateTime(Date);
            return SQLString(dDate.ToString("MM/dd/yyyy HH:mm"));
        }

        /// <summary>
        /// Trả về chuỗi kiểu ngày để lưu vào database ở dạng MM/dd/yyyy HH:mm
        /// </summary>
        /// <param name="Date">Ngày insert vào database</param>
        [DebuggerStepThrough()]
        public static string SQLDateTimeNotSecondSave(object Date)
        {
            if (System.Convert.IsDBNull(Date))
            {
                return "NULL";
            }
            return SQLDateTimeSave(Date.ToString());
        }

        #endregion

        #region SQLDateShow

        /// <summary>
        /// Trả về kiểu chuỗi ngày format theo dạng dd/MM/yyyy
        /// </summary>
        /// <param name="Date">Kiểu ngày truyền vào</param>
        [DebuggerStepThrough()]
        public static string SQLDateShow(object Date)
        {
            if (System.Convert.IsDBNull(Date))
            {
                return "";
            }
            return SQLDateShow(Date.ToString());
        }

        /// <summary>
        /// Trả về kiểu chuỗi ngày format theo dạng dd/MM/yyyy
        /// </summary>
        /// <param name="Date">Kiểu ngày truyền vào</param>
        [DebuggerStepThrough()]
        public static string SQLDateShow(string Date)
        {
            if (Date.Trim() == "")
            {
                return "";
            }
            return Convert.ToDateTime(Date).ToString("dd/MM/yyyy");
        }

        /// <summary>
        /// Trả về kiểu chuỗi ngày format theo dạng dd/MM/yyyy HH:mm
        /// </summary>
        /// <param name="Date">Kiểu ngày truyền vào</param>
        [DebuggerStepThrough()]
        public static string SQLDateTimeNotSencondShow(object Date)
        {
            if (System.Convert.IsDBNull(Date))
            {
                return "";
            }
            return SQLDateTimeNotSencondShow(Date.ToString());
        }

        /// <summary>
        /// Trả về kiểu chuỗi ngày format theo dạng dd/MM/yyyy HH:mm
        /// </summary>
        /// <param name="Date">Kiểu ngày truyền vào</param>
        [DebuggerStepThrough()]
        public static string SQLDateTimeNotSencondShow(string Date)
        {
            if (Date.Trim() == "")
            {
                return "";
            }
            return Convert.ToDateTime(Date).ToString("dd/MM/yyyy HH:mm");
        }

        #endregion

        #endregion

        #region Kiểm tra phím nhấn
        /// <summary>
        /// Kiểm tra phím nhấn
        /// </summary>
        /// <param name="KeyChar">Ký tự cần kiểm tra</param>
        /// <param name="TypeCheck">Loại dữ liệu cần kiểm tra</param>
        /// <param name="CheckString">Chuỗi cần kiểm tra. Chỉ chấp nhận nếu tham số đầu tiên là Custom</param>
        /// <returns>Trả về true nếu phím nhấn hợp lệ, ngược lại trả về false</returns>
        [DebuggerStepThrough()]
        public static bool CheckKeyPress(char KeyChar, EnumKey TypeCheck)
        {
            return CheckKeyPress(KeyChar, TypeCheck, "");
        }
        [DebuggerStepThrough()]
        public static bool CheckKeyPress(char KeyChar, EnumKey TypeCheck, string CheckString)
        {
            string sCheck = "";
            if (KeyChar == (char)(91)) //[
            {
                return true;
            }
            if (KeyChar == (char)(93)) //]
            {
                return true;
            }
            if (KeyChar == '\b')
            {
                return false;
            }
            if (KeyChar == '\t')
            {
                return false;
            }
            if (KeyChar == '\r')
            {
                return false;
            }
            switch (TypeCheck)
            {
                case EnumKey.Number:
                    sCheck = "0123456789";
                    break;
                case EnumKey.NumberDot:
                    sCheck = "0123456789.";
                    break;
                case EnumKey.NumberSign:
                    sCheck = "0123456789-";
                    break;
                case EnumKey.NumberDotSign:
                    sCheck = "0123456789.-";
                    break;
                case EnumKey.Custom:
                    sCheck = CheckString;
                    break;
            }
            return sCheck.IndexOf(KeyChar) < 0;
        }

        /// <summary>
        /// Nhấn phím enter sẽ được hiểu bằng phím Tab
        /// </summary>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static void FormKeyEnter(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            Form con = (Form)sender;
            if (e.KeyCode == Keys.Enter)
            {
                UseEnterAsTab(con);
            }
        }
        #endregion

        #region Quyen man hinh: ham ReturnPermission

        /// <summary>
        /// Trả về là quyền của màn hình truyền vào
        /// </summary>
        /// <param name="FormID">Màn hình cần lấy quyền</param>
        [DebuggerStepThrough()]
        public static int ReturnPermission(string FormID)
        {
            //#If DEBUG
            try
            {
                if (dtPer == null)
                {
                    //string sConnectionStringAjiSys = "Data Source=" + gsServerName + ";Initial Catalog=Electric Scale;User ID=" + gsUserConnectionDB + ";Password=" + gsPassword + ";Connect Timeout = 0";
                    string sSQL = "";
//                    sSQL += "Select FormID, PermissionID From view_ReturnPermission";
//                    sSQL += " Where ";
//                    sSQL += "UserName = " + SQLString(gsUserLogin);
//                    sSQL += " Order by FormID";
                    sSQL += "Exec sp_ReturnPermission ";
                    sSQL += SQLString(gsUserLogin);
                    DataSet ds = ReturnDataSet(sSQL);
                    if (ds == null)
                    {
                        return -1;
                    }
                    dtPer = ds.Tables[0];                    
                }

                if (dtPer == null || dtPer.Rows.Count <= 0)
                {
                    return -1;
                }
                else
                {
                    int iRowFind = -1;
                    iRowFind = ReturnRowTable(dtPer, "FormID", FormID);
                    if (iRowFind >= 0)
                    {
                        if (dtPer.Rows[iRowFind]["PermissionID"].ToString().Trim().ToLower() == "none")
                            return 0;
                        else if (dtPer.Rows[iRowFind]["PermissionID"].ToString().ToLower() == "view")
                            return 1;
                        else if (dtPer.Rows[iRowFind]["PermissionID"].ToString().ToLower() == "add")
                            return 2;
                        else if (dtPer.Rows[iRowFind]["PermissionID"].ToString().ToLower() == "editadd")
                            return 3;
                        else
                            return 4;
                    }
                    else
                    {
                        return -1;
                    }

                }
            }
            catch(Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi ReturnPermission: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error ReturnPermission: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return -1;
            }
            //#endif
        }
        #endregion

        #region Kiểm tra phân quyền cho C1ContextMenu và lưới C1Grid : Ham CheckMenu

        /// <summary>
        /// Kiểm tra phân quyền cho C1ContextMenu và lưới C1Grid
        /// </summary>
        /// <param name="FormName">Tên form cần phân quyền</param>
        /// <param name="C1CommandHolder">C1CommandHolder lưu trữ các C1Command</param>
        /// <param name="GridRowCount">Số dòng của lưới. Truyền thông số như sau: tdbg.Splits(Split0).Rows.Count</param>
        /// <remarks>Hàm này chỉ có tác dụng nếu các C1ContextMenu có tên lần lượt như sau: 
        /// mnuView, mnuAdd, mnuEdit, mnuDelete, mnuPrint
        /// </remarks>
        [DebuggerStepThrough()]
        public static void CheckMenu(string FormName, C1.Win.C1Command.C1CommandHolder C1CommandHolder, int GridRowCount)
        {
            int per = ReturnPermission(FormName);
            foreach (C1.Win.C1Command.C1Command c in C1CommandHolder.Commands)
            {
                switch (c.Name)
                {
                    case "mnuView":  
                        c.Enabled = (per - 1 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuAdd":   
                        c.Enabled = (per - 2 >= 0);
                        break;
                    case "mnuAddGroup":
                        c.Enabled = (per - 2 >= 0);
                        break;
                    case "mnuAddUser":
                        c.Enabled = (per - 2 >= 0);
                        break;
                    case "mnuEdit":  
                        c.Enabled = (per - 3 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuEditGroup":
                        c.Enabled = (per - 3 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuEditUser":
                        c.Enabled = (per - 3 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuDelete": 
                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuDeleteGroup":
                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuDeleteUser":
                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuDelete1st":
                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuDelete2nd":
                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
                        break;
//                    case "mnuEdit1st":
//                        c.Enabled = (per - 3 >= 0) & GridRowCount > 0;
//                        break;
//                    case "mnuEdit2nd":
//                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
//                        break;
                    case "mnuReuseWS":
                        c.Enabled = (per - 4 >= 0) & GridRowCount > 0;
                        break;
                    case "mnuPrint":  
                        c.Enabled = GridRowCount > 0;
                        break;
                }
            }
        }
        #endregion

        #region Kiểm tra có tồn tại key của bảng hay không

        /// <summary>
        /// Kiểm tra xem có tồn tại ít nhất một hàng trong lệnh SQL không
        /// </summary>
        /// <param name="SQL">Lệnh SQL cần kiểm tra</param>
        [DebuggerStepThrough()]
        public static bool ExistRecord(string SQL)
        {
            DataTable dt = new DataTable();
            dt = ReturnDataTable(SQL);
            return dt.Rows.Count > 0;

        }

        /// <summary>
        /// Kiểm tra có tồn tại key của bảng hay không ?
        /// </summary>
        /// <param name="TableName">Bảng cần kiểm tra</param>
        /// <param name="Field">Khóa cần kiểm tra</param>
        /// <param name="Text">Giá trị cần kiểm tra</param>
        /// <returns>Trả về true nếu có khóa, ngược lại trả về false</returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static bool IsExistKey(string TableName, string Field, string Text)
        {
            string sSQL = "Select Top 1 1 From " + TableName + " Where " + Field + " = " + SQLString(Text);
            return ExistRecord(sSQL);
        }

        [DebuggerStepThrough()]
        public static bool IsExistKey(string TableName, string Field1, string Field2, string Text1, string Text2)
        {
            string sSQL = "Select Top 1 1 From " + TableName + " Where " + Field1 + " = " + SQLString(Text1) + " And " + Field2 + " = " + SQLString(Text2);
            return ExistRecord(sSQL);
        }

        /// <summary>
        /// Kiểm tra có tồn tại key của bảng hay không ?
        /// </summary>
        /// <param name="TableName">Bảng cần kiểm tra</param>
        /// <param name="Field">Khóa cần kiểm tra</param>
        /// <param name="Text">Giá trị cần kiểm tra</param>
        /// <returns>Trả về true nếu có khóa, ngược lại trả về false</returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static bool IsExistKey(string TableName, string[] Field, string[] Text)
        {
            string sSQL = "Select Top 1 1 From " + TableName + " Where ";
            if (Field.Length != Text.Length || Field.Length == 0 || Text.Length == 0)
            {
                return true;
            }
            for (int i = 0; i < Field.Length; i++)
            {
                sSQL += Field[i] + " = " + SQLString(Text[i]) + " And ";
            }
            sSQL = sSQL.Substring(0, sSQL.Length - " And ".Length);
            return ExistRecord(sSQL);
        }
        #endregion

        #region Others
        /// <summary>
        /// Trả về Số Double
        /// </summary>
        /// <param name="Text">Chuỗi truyền vào</param>
        [DebuggerStepThrough()]
        public static double Number(string Text)
        {
            Text = Text.Replace(",", "");
            Text = Text.Replace(" ", "");
            Text = Text.Replace("%", "");
            if (Text == "")
            {
                return 0;
            }
            return Convert.ToDouble(Text);
        }

        /// <summary>
        /// Trả về Số Double
        /// </summary>
        /// <param name="Text">Chuỗi truyền vào</param>
        [DebuggerStepThrough()]
        public static double Number(object Text)
        {
            return Number(Text.ToString());
        }
        #endregion

        #region Hot Keys in Grid

        /// <summary>
        /// Xóa nhiều dòng trên lưới nhập liệu
        /// </summary>
        /// <param name="c1Grid"></param>
        /// <remarks></remarks>
        public static void DeleteMultiRows(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid)
        {
            try
            {
                if (!c1Grid.AllowDelete | c1Grid.RowCount < 1)
                {
                    return;
                }
                if (cls_MessageBox.MsgAskDeleteRow() == System.Windows.Forms.DialogResult.Yes)
                {
                    C1.Win.C1TrueDBGrid.SelectedRowCollection tdbgSelectedRow = c1Grid.SelectedRows;
                    int i = 0;
                    ArrayList myAL = new ArrayList(); //Tạo mảng lưu lại chỉ số vừa chọn
                    if (tdbgSelectedRow.Count > 1)
                    {
                        for (i = 0; i < tdbgSelectedRow.Count; i++)
                        {
                            myAL.Add(tdbgSelectedRow[i]);
                        }
                        myAL.Sort(); //Sắp xếp tăng dần
                        for (i = myAL.Count - 1; i >= 0; i--)
                        {
                            c1Grid.Delete(System.Convert.ToInt32(myAL[i]));
                        }
                    }
                    else
                    {
                        c1Grid.Delete(c1Grid.Bookmark);
                    }
                }
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi DeleteMultiRows: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error DeleteMultiRows: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

            }
        }

        /// <summary>
        /// Nhấn phím Enter ở cột cuối cùng trên lưới thì nó sẽ nhảy xuống dòng kế tiếp
        /// </summary>
        /// <param name="c1Grid"></param>
        /// <param name="nFirstCol">Cột đầu tiên Focus tới</param>
        /// <param name="e"></param>
        /// <param name="iSplitFocus">vị trí của split cần Focus</param>
        /// <remarks>Gọi hàm tại sự kiện KeyDown của lưới</remarks>
        ///  Cách gọi :
        /// if (e.KeyCode = Keys.Enter)           
        ///     if (tdbg.Col = iLastCol)
        ///			HotKeyEnterGrid(tdbg, COL_VoucherNum, e)
        /// Biến iLastCol = CountCol(tdbg, tdbg.Splits.Count - 1) được gọi tại
        /// Form_Load đối với những lưới không có nhiều cột (không có nút nhấn để bật tắt các cột)
        /// Sự kiện Click của nút đối với những lưới có nhiều cột (có nút nhấn để bật tắt các cột)
        /// Lưu ý: đối với những lưới có ít cột mà các cột này không động thì gán chết cột cuối cùng cần hiển thị iLastCol = COL_Disabled
        [DebuggerStepThrough()]
        public static void HotKeyEnterGrid(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int nFirstCol, System.Windows.Forms.KeyEventArgs e)
        {
            HotKeyEnterGrid(c1Grid, nFirstCol, e, 0);
        }
        [DebuggerStepThrough()]
        public static void HotKeyEnterGrid(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int nFirstCol, System.Windows.Forms.KeyEventArgs e, int iSplitFocus)
        {
            try
            {
                c1Grid.UpdateData();

                c1Grid.SplitIndex = iSplitFocus;
                if (c1Grid.AllowAddNew == true)
                {
                    c1Grid.Row = c1Grid.Row + 1;
                }
                else
                {
                    c1Grid.Row = System.Convert.ToInt32(((c1Grid.RowCount == c1Grid.Row + 1) ? 0 : c1Grid.Row + 1));
                }
                c1Grid.Col = nFirstCol;
                e.SuppressKeyPress = true;
                e.Handled = true;
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi HotKeyEnterGrid: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error HotKeyEnterGrid: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }

        ///	<summary>
        /// Nhấn phím Ctrl+Insert: Thêm dòng mới
        /// Nhấn phím Ctrl+Delete: Xóa dòng hiện tại
        /// Nhấn phím Ctrl+Home: Con trỏ nhảy đến cột nhập liệu đầu tiên trên cùng 1 dòng
        /// Nhấn phím Ctrl+End: Con trỏ nhảy đến cột nhập liệu cuối cùng trên cùng 1 dòng
        /// Nhấn phím Ctrl+PageUp: Con trỏ nhảy đến dòng đầu tiên trên cùng 1 cột
        /// Nhấn phím Ctrl+PageDown: Con trỏ nhảy đến dòng cuối cùng trên cùng 1 cột
        /// Nhấn phím Ctrl+Right: Con trỏ nhảy đến cột đầu tiên của split liền sau
        /// Nhấn phím Ctrl+Left: Con trỏ nhảy đến cột đầu tiên của split liền trước
        /// Nhấn phím Ctrl+D: Copy diễn giải Master xuống Detail
        /// </summary>
        /// <param name="e"></param>
        /// <param name="c1Grid"></param>
        /// <param name="ColFirst"></param>
        /// <param name="SplitFirst"></param>
        /// <param name="SplitLast"></param>
        /// <param name="ColFocusKeyHome"></param>
        /// <param name="ColFocusKeyLeft"></param>
        /// <param name="ColFocusKeyRight"></param>
        /// <param name="ColDescription"></param>
        /// <param name="ValueDescription"></param>
        /// <remarks>G?i hàm t?i s? ki?n KeyDown c?a lu?i </remarks>
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst, int SplitLast, bool ColFocusKeyHome, bool ColFocusKeyLeft, bool ColFocusKeyRight, int ColDescription)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, SplitFirst, SplitLast, ColFocusKeyHome, ColFocusKeyLeft, ColFocusKeyRight, ColDescription, "");
        }
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst, int SplitLast, bool ColFocusKeyHome, bool ColFocusKeyLeft, bool ColFocusKeyRight)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, SplitFirst, SplitLast, ColFocusKeyHome, ColFocusKeyLeft, ColFocusKeyRight, -1, "");
        }
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst, int SplitLast, bool ColFocusKeyHome, bool ColFocusKeyLeft)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, SplitFirst, SplitLast, ColFocusKeyHome, ColFocusKeyLeft, true, -1, "");
        }
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst, int SplitLast, bool ColFocusKeyHome)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, SplitFirst, SplitLast, ColFocusKeyHome, true, true, -1, "");
        }
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst, int SplitLast)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, SplitFirst, SplitLast, true, true, true, -1, "");
        }
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, SplitFirst, 0, true, true, true, -1, "");
        }
        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst)
        {
            HotKeyDownGrid(e, c1Grid, ColFirst, 0, 0, true, true, true, -1, "");
        }

        [DebuggerStepThrough()]
        public static void HotKeyDownGrid(System.Windows.Forms.KeyEventArgs e, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int ColFirst, int SplitFirst, int SplitLast, bool ColFocusKeyHome, bool ColFocusKeyLeft, bool ColFocusKeyRight, int ColDescription, string ValueDescription)
        {
            try
            {
                if (e.Control)
                {
                    switch (e.KeyCode)
                    {
//                        case Keys.Insert: //Nhấn các phím Ctrl+Insert: Thêm dòng mới
//                            if (!c1Grid.AllowAddNew | c1Grid.RowCount < 1)
//                            {
//                                return;
//                            }
//
//                            if (c1Grid.Row == c1Grid.VisibleRows - 1)
//                            {
//                                c1Grid.FirstRow = c1Grid.Row;
//                            }
//                            c1Grid.SplitIndex = SplitFirst;
//                            c1Grid.Col = ColFirst;
//                            c1Grid.MoveLast();
//                            c1Grid.Row = System.Convert.ToInt32(((c1Grid.RowCount - 1 == c1Grid.Row) ? c1Grid.RowCount : c1Grid.Row + 1));
//
//
//                            break;
//                        case Keys.Delete: //Nhấn các phím Ctrl+Delete: Xóa dòng hiện tại
//                            if (!c1Grid.AllowDelete | c1Grid.RowCount < 1)
//                            {
//                                return;
//                            }
//
//                            if (c1Grid.Bookmark != c1Grid.Row + c1Grid.FirstRow)
//                            {
//                                return;
//                            }
//
//                            if (AskDelete() == System.Windows.Forms.DialogResult.Yes)
//                            {
//                                c1Grid.deDelete(c1Grid.Bookmark);
//                                c1Grid.UpdateData();
//                            }
//                            else
//                            {
//                                e.Handled = true;
//                            }
//
//                            break;
                        case Keys.Home: // Nhấn phím Ctrl+Home: Trở về cột nhập liệu đầu tiên trên cùng 1 dòng

                            c1Grid.SplitIndex = SplitFirst;
                            c1Grid.Col = ColVisible(c1Grid, c1Grid.SplitIndex, true);

                            break;
                        case Keys.End: // Nhấn phím Ctrl+End: Trở về cột nhập liệu cuối cùng trên cùng 1 dòng

                            if (SplitLast == 0)
                            {
                                c1Grid.SplitIndex = c1Grid.Splits.Count - 1;
                            }
                            else
                            {
                                c1Grid.SplitIndex = SplitLast;
                            }
                            c1Grid.Row = c1Grid.Bookmark;
                            c1Grid.Col = CountCol(c1Grid, c1Grid.SplitIndex);
                            break;
                        case Keys.PageUp: // Nhấn phím Ctrl+PageUp: Trở về dòng đầu tiên trên cùng 1 cột
                            e.SuppressKeyPress = true;
                            e.Handled = true;
                            c1Grid.MoveFirst();
                            break;
                        case Keys.PageDown: // Nhấn phím Ctrl+PageDown: Trở về dòng cuối cùng trên cùng 1 cột
                            e.SuppressKeyPress = true;
                            e.Handled = true;
                            c1Grid.MoveLast();
                            break;
                        case Keys.Right: // Nhấn phím Ctrl+Right: Con trỏ nhảy đến cột đầu tiên của split liền sau
                            e.Handled = true;
                            if (c1Grid.SplitIndex < c1Grid.Splits.Count - 1)
                            {
                                c1Grid.SplitIndex += 1;
                            }
                            c1Grid.Col = ColVisible(c1Grid, c1Grid.SplitIndex, ColFocusKeyRight);

                            c1Grid.UpdateData();

                            break;
                        case Keys.Left: // Nhấn phím Ctrl+Left: Con trỏ nhảy đến cột đầu tiên của split liền trước
                            e.Handled = true;
                            if (c1Grid.SplitIndex > 0)
                            {
                                c1Grid.SplitIndex -= 1;
                            }
                            c1Grid.Col = ColVisible(c1Grid, c1Grid.SplitIndex, ColFocusKeyLeft);

                            c1Grid.UpdateData();

                            break;
//                        case Keys.D: // Nhấn phím Ctrl+D: Copy diễn giải Master xuống Detail
//                            if (ValueDescription.Trim() == "" || c1Grid.RowCount < 1 | ColDescription < 0)
//                            {
//                                return;
//                            }
//
//                            int i = 0;
//                            DialogResult nvMsg = 0;
//                            nvMsg = D99C0008.MsgCopyDesctiption;
//
//                            switch (nvMsg)
//                            {
//                                case System.Windows.Forms.DialogResult.Yes:
//                                    for (i = 0; i < c1Grid.RowCount; i++)
//                                    {
//                                        c1Grid[i, ColDescription] = ValueDescription.Trim(' ');
//                                    }
//                                    c1Grid.UpdateData();
//                                    break;
//                                case System.Windows.Forms.DialogResult.No:
//                                    for (i = 0; i < c1Grid.RowCount; i++)
//                                    {
//                                        if (c1Grid[i, ColDescription].ToString() == "")
//                                        {
//                                            c1Grid[i, ColDescription] = ValueDescription.Trim(' ');
//                                        }
//                                    }
//                                    c1Grid.UpdateData();
//                                    break;
//                                default:
//                                    return;
//                            }
//                            break;
                    }


                }
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi HotKeyDownGrid: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error HotKeyDownGrid: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        /// <summary>
        /// Trả về cột cuối cùng có hiển thị
        /// </summary>
        /// <param name="c1Grid"></param>
        /// <param name="Split"></param>
        /// <returns></returns>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static int CountCol(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int Split)
        {
            for (int i = c1Grid.Columns.Count - 1; i >= 0; i--)
            {
                if (c1Grid.Splits[Split].DisplayColumns[i].Visible == true)
                {
                    return i;
                }
            }
            return 0;
        }

        //Trả về cột đầu tiên không bị khóa và có hiển thị

        private static int ColVisible(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int Split)
        {
            return ColVisible(c1Grid, Split, false);
        }

        private static int ColVisible(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int Split, bool ColFirst)
        {
            int i = 0;
            if (ColFirst == false)
            {
                for (i = c1Grid.Columns.Count - 1; i >= 0; i--)
                {
                    if (c1Grid.Splits[Split].DisplayColumns[i].Visible == true && c1Grid.Splits[Split].DisplayColumns[i].Locked == false)
                    {
                        return i;
                    }

                }
            }
            else
            {
                for (i = 0; i < c1Grid.Columns.Count; i++)
                {
                    if (c1Grid.Splits[Split].DisplayColumns[i].Visible == true && c1Grid.Splits[Split].DisplayColumns[i].Locked == false)
                    {
                        return i;
                    }
                }
            }
            return 0;
        }
        #endregion

        #region Hỗ trợ gõ Enter cũng giống như phím Tab
        /// <summary>
        /// Khi gõ phím Enter cũng giống như phím Tab
        /// </summary>
        /// <param name="frm"></param>
        /// <remarks></remarks>
        [DebuggerStepThrough()]
        public static void UseEnterAsTab(Form frm)
        {
            UseEnterAsTab(frm, true);
        }

        [DebuggerStepThrough()]
        public static void UseEnterAsTab(Form frm, bool bForward)
        {
            try
            {
                if ((frm.ActiveControl.GetType().Name != "GridEditor") & (frm.ActiveControl.GetType().Name != "C1TrueDBGrid")) //Khong phai luoi
                {
                    frm.SelectNextControl(frm.ActiveControl, bForward, true, true, false);
                }
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi UseEnterAsTab: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error UseEnterAsTab: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }
        #endregion

        #region HotKeyF11
        [DebuggerStepThrough()]
        public static void HotKeyF11(Form frm, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid)
        {
            HotKeyF11(frm, c1Grid, 0, -1);
        }

        [DebuggerStepThrough()]
        public static void HotKeyF11(Form frm, C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int iSplitFocus, int iColFocus)
        {
            try
            {
                if (c1Grid.MarqueeStyle == C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder || c1Grid.MarqueeStyle == C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell)
                {
                    if ((frm.ActiveControl.GetType().Name != "GridEditor") & (frm.ActiveControl.GetType().Name != "C1TrueDBGrid")) //Khong phai luoi
                    {

                        if ((frm.ActiveControl.GetType().Name == "EditorCtrl") | (frm.ActiveControl.GetType().Name == "C1TrueDBList")) //C1Combo
                        {
                            gcControl = frm.GetNextControl(frm.ActiveControl.Parent, false);
                        }
                        else
                        {
                            gcControl = frm.GetNextControl(frm.ActiveControl, false);
                        }

                        if (iColFocus != -1)
                        {
                            c1Grid.SplitIndex = iSplitFocus;
                            c1Grid.Col = iColFocus;
                        }

                        c1Grid.Focus();
                    }
                    else
                    {
                        frm.SelectNextControl(gcControl, true, true, true, false);
                    }

                }
                else
                {
                    if ((frm.ActiveControl.GetType().Name != "GridEditor") & (frm.ActiveControl.GetType().Name != "C1TrueDBGrid")) //Khong phai luoi
                    {

                        if ((frm.ActiveControl.GetType().Name == "EditorCtrl") | (frm.ActiveControl.GetType().Name == "C1TrueDBList")) //C1Combo
                        {
                            gcControl = frm.GetNextControl(frm.ActiveControl.Parent, false);
                        }
                        else
                        {
                            gcControl = frm.GetNextControl(frm.ActiveControl, false);
                        }
                        if (iColFocus != -1)
                        {
                            c1Grid.SplitIndex = iSplitFocus;
                            c1Grid.Col = iColFocus;
                        }
                        c1Grid.Focus();
                    }
                    else
                    {
                        c1Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.DottedCellBorder;
                        c1Grid.UpdateData();
                        frm.SelectNextControl(gcControl, true, true, true, false);
                        c1Grid.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.FloatingEditor;
                    }
                }
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi HotKeyF11: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error HotKeyF11: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }


        #endregion

        #region Set thuộc tính cho lưới

        /// <summary>
        /// Reset thanh kẻ Split của lưới C1 về 0
        /// </summary>
        /// <param name="c1Grid">Lưới C1</param>
        [DebuggerStepThrough()]
        public static void ResetSplitDividerSize(C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid)
        {
            c1Grid.SplitDividerSize = new Size(1, 1);
            for (Int32 i = 0; i < c1Grid.Splits.Count; i++)
            {
                c1Grid.Splits[i].BorderStyle = Border3DStyle.Flat;
            }

        }

        /// <summary>
        /// Set màu cho và Footer cho lưới Danh mục
        /// </summary>
        /// <param name="c1Grid">Lưới C1</param>
        /// <param name="FisrtSplits">Split đầu tiên của lưới</param>
        /// <param name="LastSplits">Split cuối cùng của lưới</param>
        /// <remarks>Chỉ dùng cho các lưới dạng Danh mục</remarks>
        [DebuggerStepThrough()]
        public static void ResetColorGrid(ref C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int FisrtSplits)
        {
            ResetColorGrid(ref c1Grid, FisrtSplits, 0);
        }
        [DebuggerStepThrough()]
        public static void ResetColorGrid(ref C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid)
        {
            ResetColorGrid(ref c1Grid, 0, 0);
        }

        [DebuggerStepThrough()]
        public static void ResetColorGrid(ref C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int FisrtSplits, int LastSplits)
        {
            c1Grid.FilterBarStyle.BackColor = Color.Moccasin;
            c1Grid.FilterBarStyle.GradientMode = C1.Win.C1TrueDBGrid.GradientModeEnum.Vertical;
            for (int i = FisrtSplits; i <= LastSplits; i++)
            {
                C1.Win.C1TrueDBGrid.Split tempWith1 = c1Grid.Splits[i];
                //object tempWith1 = c1Grid.Splits[i];
                tempWith1.HighLightRowStyle.BackColor = Color.Green;
                tempWith1.SelectedStyle.BackColor = SystemColors.Highlight;
                tempWith1.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRowRaiseCell;

                tempWith1.FooterStyle.BackColor = Color.FromArgb(COLOR_BACKCOLOR);
                tempWith1.FooterStyle.ForeColor = Color.Blue;
                tempWith1.FooterStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, FontStyle.Bold);
            }
        }

        /// <summary>
        /// Set Footer cho lưới
        /// </summary>
        /// <param name="c1Grid">Lưới C1</param>
        /// <param name="FisrtSplits">Split đầu tiên của lưới</param>
        /// <param name="LastSplits">Split cuối cùng của lưới</param>
        /// <remarks>Chủ yếu dùng cho các lưới dạng Nhập liệu</remarks>
        [DebuggerStepThrough()]
        public static void ResetFooterGrid(ref C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int FisrtSplits)
        {
            ResetFooterGrid(ref c1Grid, FisrtSplits, 0);
        }
        //[DebuggerStepThrough()]
        public static void ResetFooterGrid(ref C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid)
        {
            ResetFooterGrid(ref c1Grid, 0, 0);
        }

//        [DebuggerStepThrough()]
        public static void ResetFooterGrid(ref C1.Win.C1TrueDBGrid.C1TrueDBGrid c1Grid, int FisrtSplits, int LastSplits)
        {
            for (int i = FisrtSplits; i <= LastSplits; i++)
            {
                //object tempWith1 = c1Grid.Splits[i];
                C1.Win.C1TrueDBGrid.Split tempWith1 = c1Grid.Splits[i];
                tempWith1.FooterStyle.BackColor = Color.FromArgb(COLOR_BACKCOLOR);
                tempWith1.FooterStyle.ForeColor = Color.Blue;
                tempWith1.FooterStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.249999F, FontStyle.Bold);
            }
        }
        #endregion

        #region Kiểm tra trùng Khóa
        /// <summary>
        /// Kiểm tra trùng Khóa
        /// </summary>
        /// <param name="Table_Name"></param>
        /// <param name="Field_Name"></param>
        /// <param name="Field_Values1"></param>
        /// <param name="Field_Values2"></param>
        /// <returns></returns>
        [DebuggerStepThrough()]
        private static bool CheckDupKeyPrimary(string Table_Name, string Field_Name, string Field_Values1, string Field_Values2)
        {
            string sSQL = null;
            sSQL = "Select Top 1 1 From " + Table_Name + " " + System.Environment.NewLine;
            sSQL = sSQL + "Where " + Field_Name + " Between '" + Field_Values1 + "' And '" + Field_Values2 + "'";

            return ExistRecord(sSQL);
        }
        #endregion
                
        #region Ham thuc thi truy van

        /// <summary>
        /// Thực thi một chuỗi SQL có dùng Transaction
        /// </summary>
        ///<returns>Trả về true nếu thực thi chuỗi SQL thành công, ngược lại trả về false</returns>
        [DebuggerStepThrough()]
        public static bool ExecuteSQL(string strSQL)
        {
//            SqlConnection conn = new SqlConnection(gsConnectionString);
            connect();
            SqlCommand cmd = new SqlCommand(strSQL, gConn);
            SqlTransaction trans = null;
            if (strSQL.Trim() == "")
            {
                return false;
            }
            try
            {
                //conn.Open();
                trans = gConn.BeginTransaction();
                cmd.CommandTimeout = 0;
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                trans.Commit();
                //conn.Close();
                disconnect();
                return true;
            }
            catch
            {
                trans.Rollback();
                //conn.Close();
                disconnect();
                Clipboard.Clear();
                Clipboard.SetText(strSQL);
                MsgErr("Error when execute SQL in function ExecuteSQL(). Paste your SQL code from Clipboard");
                WriteLogFile(strSQL);
                return false;
            }

        }

        /// <summary>
        /// Thực thi một chuỗi SQL có dùng Transaction
        /// </summary>
        ///<returns>Trả về true nếu thực thi chuỗi SQL thành công, ngược lại trả về false</returns>
        //[DebuggerStepThrough()]
        public static void Ovr_ExecuteSQL(string strSQL)
        {
            //            SqlConnection conn = new SqlConnection(gsConnectionString);
            connect();
            SqlCommand cmd = new SqlCommand(strSQL, gConn);
            SqlTransaction trans = null;
            if (strSQL.Trim() == "")
            {
                return ;
            }
            try
            {
                //conn.Open();
                trans = gConn.BeginTransaction();
                cmd.CommandTimeout = 0;
                cmd.Transaction = trans;
                cmd.ExecuteNonQuery();
                trans.Commit();
                //conn.Close();
                disconnect();
            }
            catch
            {
                trans.Rollback();
                //conn.Close();
                disconnect();
                Clipboard.Clear();
                Clipboard.SetText(strSQL);
                MsgErr("Error when execute SQL in function ExecuteSQL(). Paste your SQL code from Clipboard");
                WriteLogFile(strSQL);
            }

        }

        /// <summary>
        /// Thực thi một chuỗi SQL không dùng Transaction
        /// </summary>
        /// <param name="strSQL">Chuỗi SQL cần thực thi</param>
        ///<returns>Trả về true nếu thực thi chuỗi SQL thành công, ngược lại trả về false</returns>
        [DebuggerStepThrough()]
        public static bool ExecuteSQLNoTransaction(string strSQL)
        {
            //SqlConnection conn = new SqlConnection(gsConnectionString);
            connect();
            SqlCommand cmd = new SqlCommand(strSQL, gConn);
            try
            {
                //conn.Open();
                cmd.CommandTimeout = 0;
                cmd.ExecuteNonQuery();
                //conn.Close();
                disconnect();
                return true;
            }
            catch
            {
                //conn.Close();
                disconnect();
                Clipboard.Clear();
                Clipboard.SetText(strSQL);
                MsgErr("Error when execute SQL in function ExecuteSQLNoTransaction(). Paste your SQL code from Clipboard");
                WriteLogFile(strSQL);
                return false;
            }
        }
        #endregion

        #region WriteLogFile

        [DebuggerStepThrough()]
        private static void WriteLogFile(string Text)
        {
            try
            {
                string sLog = "";
                string sFileName = Application.StartupPath + "\\Log.log";
                FileInfo fno = new FileInfo(sFileName);
                StreamWriter fwno = fno.AppendText();
                sLog += new String(' ', 20) + System.DateTime.Now + System.Environment.NewLine;
                sLog += Text + System.Environment.NewLine;
                sLog += "--------------------------------------------------------------------------" + System.Environment.NewLine;
                fwno.Write(sLog);
                fwno.Close();
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi WriteLogFile: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error WriteLogFile: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        #region Check DLL khi chay Debug

#if DEBUG

        public static void CheckDLL()
        {
            string sLocalDLL = null;
            string sServerDLL = null;
            //----- Check Electric Scale Components.dll
            sLocalDLL = "C:\\Program Files\\Electric Scale\\Electric Scale Components.dll";
            sServerDLL = "\\\\\\ssv03\\\\Aji_Soft\\\\Electric Scale\\\\LIB\\\\Electric Scale Components.dll";
            if (CheckDLL(sLocalDLL, sServerDLL))
            {
                System.Environment.Exit(1);
            }
            ////----- Check D99D0041.dll
            //sLocalDLL = "C:\\Program Files\\Electric Scale\\Temp.dll"; //dat lai ten thu vien Temp cho hop ly
            //sServerDLL = "\\\\\\ssv03\\\\Aji_Soft\\\\Electric Scale\\\\LIB\\\\Temp.dll";
            //if (CheckDLL(sLocalDLL, sServerDLL))
            //{
            //    System.Environment.Exit(1);
            //}
            //string sfuncsPath = "";
            //sfuncsPath = Application.StartupPath;
            //if (sfuncsPath.EndsWith("\\bin\\Debug"))
            //{
            //    string sfunc = "";
            //    sfunc = sfuncsPath.Substring(0, sfuncsPath.Length - "\\bin\\Debug".Length);
            //    string sLocalfunc = "";
            //    string sServerfunc = null;
            //    sLocalfunc = sfunc + "\\func\\" + "cls_GlobalUtil.cs";
            //    sServerfunc = "\\\\\\ssv03\\\\Aji_Soft\\\\Electric Scale\\\\LIB\\\\cls_GlobalUtil.cs";
            //    System.IO.FileInfo fInfoLocal = null;
            //    System.IO.FileInfo fInfoServer = null;
            //    long lLengthLoccal = 0;
            //    long lLengthServer = 0;
            //    System.DateTime dLastWriteTimeLocal = DateTime.MinValue;
            //    System.DateTime dLastWriteTimeServer = DateTime.MinValue;
            //    //-----------------------------------------------------------------
            //    fInfoLocal = new System.IO.FileInfo(sLocalfunc);
            //    lLengthLoccal = fInfoLocal.Length;
            //    dLastWriteTimeLocal = fInfoLocal.LastWriteTime.Date;
            //    //-----------------------------------------------------------------
            //    fInfoServer = new System.IO.FileInfo(sServerfunc);
            //    lLengthServer = fInfoServer.Length;
            //    dLastWriteTimeServer = fInfoServer.LastWriteTime.Date;
            //    //-----------------------------------------------------------------
            //    if (lLengthLoccal != lLengthServer || dLastWriteTimeLocal != dLastWriteTimeServer)
            //    {
            //        if (cls_GlobalUtil.OptSys.Language == 0)
            //            MessageBox.Show("Bạn phải cập nhật lại file: " + sLocalfunc + " tại đường dẫn " + sServerfunc, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //        else
            //            MessageBox.Show("You must update file: " + sLocalfunc + " at path: " + sServerfunc, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            //        System.Environment.Exit(1);
            //    }
            //}
        }

        private static bool CheckDLL(string DLLLocal, string DLLServer)
        {
            if (!(System.IO.File.Exists(DLLLocal)))
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Không tìm thấy DLL tại đường dẫn: " + DLLLocal, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Not found DLL at path: " + DLLLocal, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                System.Environment.Exit(1);
            }
            if (!(System.IO.File.Exists(DLLServer)))
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Không tìm thấy DLL tại đường dẫn: " + DLLServer, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Not found DLL at path: " + DLLServer, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                System.Environment.Exit(1);
            }
            System.Reflection.AssemblyName assemblyNameLocal = System.Reflection.AssemblyName.GetAssemblyName(DLLLocal);
            System.Reflection.AssemblyName assemblyNameServer = System.Reflection.AssemblyName.GetAssemblyName(DLLServer);
            string sLocalVersion = assemblyNameLocal.Version.ToString();
            string sServerVersion = assemblyNameServer.Version.ToString();
            if (sLocalVersion != sServerVersion)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Bạn phải update lại toàn bộ DLL trên thư mục quy định", cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("You must update all DLL", cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
                System.Environment.Exit(1);
            }
            return false;
        }

#endif
        #endregion

        #region Doc va ghi file
        /// <summary>
        /// Hàm đọc nội dung một text file bất kỳ
        /// </summary>
        /// <param name="path">Đường dẫn file cần đọc</param>
        /// <returns>Nội dung file</returns>
        public static string ReadFile(string path)
        {
            try
            {
                string fileContent = string.Empty;

                FileInfo fni = new FileInfo(path.Trim());
                StreamReader frni = fni.OpenText();

                fileContent = frni.ReadToEnd();

                frni.Close();
                return fileContent;
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi ReadFile: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error ReadFile: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return null;
            }
        }

        /// <summary>
        /// Hàm ghi một nội dung bất kỳ ra file text
        /// </summary>
        /// <param name="path">Đường dẫn file cần lưu</param>
        /// <param name="content">Nội dung cần lưu</param>
        public static void WriteFile(string path, string content)
        {
            try
            {
                FileInfo fno = new FileInfo(path.Trim());
                StreamWriter fwno = fno.CreateText();

                fwno.Write(content);

                fwno.Close();
            }
            catch (Exception ex)
            {
                if (cls_GlobalUtil.OptSys.Language == 0)
                    MessageBox.Show("Lỗi WriteFile: " + ex.Message, cls_MessageBox.sThongBao, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                else
                    MessageBox.Show("Error WriteFile: " + ex.Message, cls_MessageBox.sAnnouncement, MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        #endregion

        #region Mã hóa password
        /// <summary>
        /// Hàm hỗ trợ mã hóa password theo MD5
        /// </summary>
        /// <param name="sPassword">chuỗi password cần mã hóa</param>
        /// <returns>Chuỗi password đã được mã hóa</returns>
        public static string Encoder(string sPassword)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedDataBytes = md5Hasher.ComputeHash(System.Text.UTF8Encoding.UTF8.GetBytes(sPassword));
            string sEncryptPass = Convert.ToBase64String(hashedDataBytes);
            return sEncryptPass;
        }
        #endregion

        #endregion
    }
}