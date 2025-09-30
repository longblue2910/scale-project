/// <summary>
/// Cac van de cua C1
/// </summary>
/// <remarks></remarks>
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Web;
using System.Windows.Forms;

namespace Electric_Scale.func
{
	internal static class cls_C1LoadData
	{

	#region Đổ nguồn cho C1Combo

		/// <summary>
		/// Đổ nguồn cho C1Combo
		/// </summary>
		/// <param name="C1Combo">Tên C1Combo cần đổ nguồn</param>
		/// <param name="sSQL">Lệnh SQL đổ nguồn</param>
		/// <param name="Width">Mảng chiều rộng các cột tương ứng của C1Combo</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1List.C1Combo C1Combo, string sSQL, int[] Width)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1Combo, dt, Width);
		}

		/// <summary>
		/// Đổ nguồn cho C1Combo
		/// </summary>
		/// <param name="C1Combo">Ten C1Combo can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		/// <param name="Width">Mảng chiều rộng các cột tương ứng của C1Combo</param>
		public static void LoadDataSource(C1.Win.C1List.C1Combo C1Combo, DataTable dt, int[] Width)
		{
			LoadDataSource(C1Combo, dt);
			for (int i = 0; i < C1Combo.Splits[0].DisplayColumns.Count; i++)
			{
				C1Combo.Splits[0].DisplayColumns[i].Width = Width[i];
			}
		}

		/// <summary>
		/// Do nguon cho C1Combo
		/// </summary>
		/// <param name="C1Combo">Ten C1Combo can do nguon</param>
		/// <param name="sSQL">Lenh SQL do nguon</param>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1List.C1Combo C1Combo, string sSQL)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1Combo, dt);
		}

		/// <summary>
		/// Do nguon cho C1Combo
		/// </summary>
		/// <param name="C1Combo">Ten C1Combo can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		/// <remarks></remarks>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1List.C1Combo C1Combo, DataTable dt)
		{
			int iMaxDropdownItems = 8;
			int iColumnsCount = dt.Columns.Count - 1;
			for (int i = iColumnsCount; i >= 0; i--)
			{
				if (IsExistDataField(C1Combo, dt.Columns[i].ColumnName) == false)
				{
					dt.Columns.RemoveAt(i);
				}
			}
			if (dt.Rows.Count < iMaxDropdownItems)
			{
				DataRow dr = null;
				for (int i = 0; i < iMaxDropdownItems - dt.Rows.Count; i++)
				{
					dr = dt.NewRow();
					dt.Rows.Add(dr);
				}
			}
			int[] arrWidth = new int[C1Combo.Splits[0].DisplayColumns.Count];
			bool[] arrVisible = new bool[C1Combo.Splits[0].DisplayColumns.Count];
			C1.Win.C1List.AlignHorzEnum[] arrHorizontalAlignment = new C1.Win.C1List.AlignHorzEnum[C1Combo.Splits[0].DisplayColumns.Count];
			for (int i = 0; i < C1Combo.Splits[0].DisplayColumns.Count; i++)
			{
				arrWidth[i] = C1Combo.Splits[0].DisplayColumns[i].Width;
				arrVisible[i] = C1Combo.Splits[0].DisplayColumns[i].Visible;
				arrHorizontalAlignment[i] = C1Combo.Splits[0].DisplayColumns[i].Style.HorizontalAlignment;
			}
			string[] arrCaption = new string[C1Combo.Columns.Count];
			for (int i = 0; i < C1Combo.Columns.Count; i++)
			{
				arrCaption[i] = C1Combo.Columns[i].Caption;
			}
			C1Combo.DataSource = dt;
			C1Combo.DisplayMember = C1Combo.DisplayMember;
			C1Combo.ValueMember = C1Combo.ValueMember;
			C1Combo.Font = new Font("Microsoft Sans Serif", 8.249999F);
			for (int i = 0; i < C1Combo.Columns.Count; i++)
			{
				C1Combo.Columns[i].Caption = arrCaption[i];
			}
			for (int i = 0; i < C1Combo.Splits[0].DisplayColumns.Count; i++)
			{
				//object tempWith1 = C1Combo.Splits[0].DisplayColumns[i];
                C1.Win.C1List.C1DisplayColumn tempWith1 = C1Combo.Splits[0].DisplayColumns[i];
				tempWith1.HeadingStyle.HorizontalAlignment = C1.Win.C1List.AlignHorzEnum.Center;
				tempWith1.Width = arrWidth[i];
				tempWith1.Visible = arrVisible[i];
				tempWith1.Style.HorizontalAlignment = arrHorizontalAlignment[i];
			}
			C1Combo.HeadingStyle.Font = new Font("Microsoft Sans Serif", 8.25F);
			C1Combo.HighLightRowStyle.BackColor = Color.Green;
			C1Combo.HighLightRowStyle.ForeColor = SystemColors.HighlightText;
			C1Combo.SelectedStyle.BackColor = Color.Green;
			C1Combo.SelectedStyle.ForeColor = SystemColors.HighlightText;
		}

	#endregion

	#region Do nguon cho C1DropDown


		/// <summary>
		/// Do nguon cho C1DropDown nhap Unicode
		/// </summary>
		/// <param name="C1DropDown">Ten C1DropDown can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, DataTable dt, string[] ArrColumnsName)
		{

			//Set Font nhap Unicode
			if (cls_GlobalUtil.gbInputbyUnicode)
			{
				C1DropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
				if (dt.Rows.Count > 0)
				{
					cls_ConvertFont.ConvertDataTable(ref dt, ArrColumnsName);
				}
			}
			LoadDataSource(C1DropDown, dt);

		}


		/// <summary>
		/// Do nguon cho C1DropDown nh?p Unicode
		/// </summary>
		/// <param name="C1DropDown">Ten C1DropDown can do nguon</param>
		/// <param name="sSQL">Lenh SQL do nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, string sSQL, string[] ArrColumnsName)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1DropDown, dt, ArrColumnsName);
		}

		/// <summary>
		/// Do nguon cho C1DropDown
		/// </summary>
		/// <param name="C1DropDown">Ten C1DropDown can do nguon</param>
		/// <param name="sSQL">Lenh SQL do nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, string sSQL)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1DropDown, dt);
		}

		/// <summary>
		/// Do nguon cho C1DropDown
		/// </summary>
		/// <param name="C1DropDown">Ten C1DropDown can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, DataTable dt)
		{
			int iMaxDropdownItems = 8;
			int iColumnsCount = dt.Columns.Count - 1;
			for (int i = iColumnsCount; i >= 0; i--)
			{
				if (IsExistDataField(C1DropDown, dt.Columns[i].ColumnName) == false)
				{
					dt.Columns.RemoveAt(i);
				}
			}
			if (dt.Rows.Count < iMaxDropdownItems)
			{
				DataRow dr = null;
				for (int i = 0; i < iMaxDropdownItems - dt.Rows.Count; i++)
				{
					dr = dt.NewRow();
					dt.Rows.Add(dr);
				}
			}
			//Set mau khi chen
			C1DropDown.Styles["Selected"].BackColor = Color.Green;
			C1DropDown.SetDataBinding(dt, "", true);
		}

		/// <summary>
		/// Do nguon cho C1DropDown
		/// </summary>
		/// <param name="C1DropDown">Ten C1DropDown can do nguon</param>
		/// <param name="sSQL">Lenh SQL do nguon</param>
		/// <param name="Width">Mang chieu rong cac cot tuong ung cua C1DropDown</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, string sSQL, int[] Width)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1DropDown, dt, Width);
		}

		/// <summary>
		/// Do nguon cho C1DropDown
		/// </summary>
		/// <param name="C1DropDown">Ten C1DropDown can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		/// <param name="Width">Mang chieu rong cac cot tuong ung cua C1DropDown</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, DataTable dt, int[] Width)
		{
			LoadDataSource(C1DropDown, dt);
			for (int i = 0; i < C1DropDown.DisplayColumns.Count; i++)
			{
				C1DropDown.DisplayColumns[i].Width = Width[i];
			}
		}

	#endregion

	#region Do nguon cho C1Grid

		/// <summary>
		/// Do nguon cho C1Grid nhap Unicode
		/// </summary>
		/// <param name="C1Grid">Ten C1Grid can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBGrid C1Grid, DataTable dt, string[] ArrColumnsName)
		{
			//Set Font nhap Unicode
			if (cls_GlobalUtil.gbInputbyUnicode)
			{
				C1Grid.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
				if (dt.Rows.Count > 0)
				{
					cls_ConvertFont.ConvertDataTable(ref dt, ArrColumnsName);
				}
			}
			LoadDataSource(C1Grid, dt);

		}

		/// <summary>
		/// Do nguon cho C1Grid nhap Unicode
		/// </summary>
		/// <param name="C1Grid">Ten C1Grid can do nguon</param>
		/// <param name="sSQL">Lenh SQL do nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBGrid C1Grid, string sSQL, string[] ArrColumnsName)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1Grid, dt, ArrColumnsName);
		}

		/// <summary>
		/// Do nguon cho C1Grid
		/// </summary>
		/// <param name="C1Grid">Ten C1Grid can do nguon</param>
		/// <param name="sSQL">Lenh SQL do nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBGrid C1Grid, string sSQL)
		{
			DataTable dt = cls_GlobalUtil.ReturnDataTable(sSQL);
			LoadDataSource(C1Grid, dt);
		}

		/// <summary>
		/// Do nguon cho C1Grid
		/// </summary>
		/// <param name="C1Grid">Ten C1Grid can do nguon</param>
		/// <param name="dt">DataTable nguon</param>
		[DebuggerStepThrough()]
		public static void LoadDataSource(C1.Win.C1TrueDBGrid.C1TrueDBGrid C1Grid, DataTable dt)
		{
			int iColumnsCount = dt.Columns.Count - 1;
			for (int i = iColumnsCount; i >= 0; i--)
			{
				if (IsExistDataField(C1Grid, dt.Columns[i].ColumnName) == false)
				{
					dt.Columns.RemoveAt(i);
				}
			}
			C1Grid.SetDataBinding(dt, "", true);
		}

	#endregion

    #region Check exist datafield
        [DebuggerStepThrough()]
		private static bool IsExistDataField(C1.Win.C1List.C1Combo C1Comobo, string DataField)
		{
			foreach (C1.Win.C1List.C1DataColumn dc in C1Comobo.Columns)
			{
				if (dc.DataField == DataField)
				{
					return true;
				}
			}
			return false;
		}

		[DebuggerStepThrough()]
		private static bool IsExistDataField(C1.Win.C1TrueDBGrid.C1TrueDBDropdown C1DropDown, string DataField)
		{
			foreach (C1.Win.C1TrueDBGrid.C1DataColumn dc in C1DropDown.Columns)
			{
				if (dc.DataField == DataField)
				{
					return true;
				}
			}
			return false;
		}

		[DebuggerStepThrough()]
		private static bool IsExistDataField(C1.Win.C1TrueDBGrid.C1TrueDBGrid C1Grid, string DataField)
		{
			foreach (C1.Win.C1TrueDBGrid.C1DataColumn dc in C1Grid.Columns)
			{
				if (dc.DataField == DataField)
				{
					return true;
				}
			}
			return false;
		}

	#endregion

	}

} //end of root namespace