using System;
using System.Collections.Generic;
using System.Text;
using C1.C1Excel;
using System.Drawing;
using Microsoft.VisualBasic;

namespace Electric_Scale.func
{
    class cls_Excel
    {
        public C1XLBook book;
        string bookName;
        XLStyle m_Tahoma_9;
        XLStyle m_Tahoma_18; // tieu de 
        XLStyle m_DataNormal;
        XLStyle m_DataSpecial;
        XLStyle m_DateNormal;
        XLStyle m_NumberNormal;
        XLStyle m_CustomFormat;
        XLStyle m_SubTotalFormat;
        XLStyle m_GrandTotalFormat;
        XLStyle  m_TitleColumn;
        //int m_NoCol;

        public cls_Excel()
        {
           book = new C1XLBook();
        }

        public cls_Excel(string fileName)
        {
            book = new C1XLBook();    
            bookName = fileName;
        }

        public void Show()
        {
            if (bookName == "") bookName = "default.xls";
            book.Save(bookName);
            System.Diagnostics.Process.Start(bookName);

        }

        public XLStyle Tahoma_9
        {
            get
            {
                m_Tahoma_9 = new XLStyle(book);
                m_Tahoma_9.Font = new Font("Tahoma", 9, FontStyle.Bold);
                m_Tahoma_9.ForeColor = Color.Blue;
                return m_Tahoma_9;
            }
            set
            {
                m_Tahoma_9 = value;
            }
        }

        public XLStyle Tahoma_18 // tieu de 
        {
            get
            {
                m_Tahoma_18 = new XLStyle(book);
                m_Tahoma_18.Font = new Font("Tahoma", 18, FontStyle.Bold);
                m_Tahoma_18.ForeColor = Color.Red;
                m_Tahoma_18.AlignHorz = XLAlignHorzEnum.Center;
                m_Tahoma_18.AlignVert = XLAlignVertEnum.Center;
                return m_Tahoma_18;
            }
            set
            {
                m_Tahoma_18 = value;
            }
        }

        public XLStyle DateNormal
        {
            get
            {
                m_DateNormal = new XLStyle(book);
                m_DateNormal = new XLStyle(book);
                m_DateNormal.Font = new Font("Tahoma", 9, FontStyle.Regular);
                m_DateNormal.BorderBottom = XLLineStyleEnum.Thin;
                m_DateNormal.BorderTop = XLLineStyleEnum.Thin;
                m_DateNormal.BorderLeft = XLLineStyleEnum.Medium;
                m_DateNormal.BorderRight = XLLineStyleEnum.Medium;
                m_DateNormal.Format = "dd/MM/yyyy";

                return m_DateNormal;
            }
            set
            {
                m_DateNormal = value;
            }

        }

        public XLStyle DataNormal
        {
            get
            {
                m_DataNormal = new XLStyle(book);
                m_DataNormal= new XLStyle(book);
                m_DataNormal.Font = new Font("Tahoma", 9, FontStyle.Regular);
                m_DataNormal.BorderBottom = XLLineStyleEnum.Thin;
                m_DataNormal.BorderTop = XLLineStyleEnum.Thin;
                m_DataNormal.BorderLeft = XLLineStyleEnum.Medium;
                m_DataNormal.BorderRight = XLLineStyleEnum.Medium;
                return m_DataNormal;
            }
            set
            {
                m_DataNormal = value;
            }

        }
        
        public XLStyle DataSpecial
        {
            get
            {
                m_DataSpecial = new XLStyle(book);
                m_DataSpecial = new XLStyle(book);
                m_DataSpecial.Font = new Font("Tahoma", 9, FontStyle.Regular);
                m_DataSpecial.BorderBottom = XLLineStyleEnum.Thin;
                m_DataSpecial.BorderTop = XLLineStyleEnum.Thin;
                m_DataSpecial.BorderLeft = XLLineStyleEnum.Medium;
                m_DataSpecial.BorderRight = XLLineStyleEnum.Medium;
                m_DataSpecial.BackColor = Color.Red;
                 
                return m_DataSpecial;
            }
            set
            {
                m_DataSpecial = value;
            }
        }

        public XLStyle NumberNormal
        {
            get
            {
                m_NumberNormal = new XLStyle(book);
                m_NumberNormal = new XLStyle(book);
                m_NumberNormal.Font = new Font("Tahoma", 9, FontStyle.Regular);
                m_NumberNormal.BorderBottom = XLLineStyleEnum.Thin;
                m_NumberNormal.BorderTop = XLLineStyleEnum.Thin;
                m_NumberNormal.BorderLeft = XLLineStyleEnum.Medium;
                m_NumberNormal.BorderRight = XLLineStyleEnum.Medium;
                m_NumberNormal.Format = "#,##0";

                return m_NumberNormal;
            }
            set
            {
                m_NumberNormal = value;
            }
        }

        public XLStyle CustomFormat
        {
            get
            {
                m_CustomFormat = new XLStyle(book);
                m_CustomFormat = new XLStyle(book);
                m_CustomFormat.Font = new Font("Tahoma", 9, FontStyle.Regular);
                m_CustomFormat.BorderBottom = XLLineStyleEnum.Thin;
                m_CustomFormat.BorderTop = XLLineStyleEnum.Thin;
                m_CustomFormat.BorderLeft = XLLineStyleEnum.Medium;
                m_CustomFormat.BorderRight = XLLineStyleEnum.Medium;
                m_CustomFormat.BackColor = Color.FromArgb(192, 255, 255);
                m_CustomFormat.ForeColor = Color.FromArgb(192,0,192);
                return m_CustomFormat;
            }
            set
            {
                m_CustomFormat = value;
            }
        }

        public XLStyle SubTotalFormat
        {
            get
            {
                m_SubTotalFormat = new XLStyle(book);
                m_SubTotalFormat.Font = new Font("Tahoma", 9, FontStyle.Bold);
                m_SubTotalFormat.ForeColor = Color.Blue;
                m_SubTotalFormat.BorderBottom = XLLineStyleEnum.Medium;
                m_SubTotalFormat.BorderTop = XLLineStyleEnum.Medium;
                m_SubTotalFormat.BorderLeft = XLLineStyleEnum.Medium;
                m_SubTotalFormat.BorderRight = XLLineStyleEnum.Medium;
                m_SubTotalFormat.BackColor = Color.Silver;
                return m_SubTotalFormat;
            }
            set
            {
                m_SubTotalFormat = value;
            }
        }

        public XLStyle GrandTotalFormat
        {
            get
            {
                m_GrandTotalFormat = new XLStyle(book);
                m_GrandTotalFormat.Font = new Font("Tahoma", 9, FontStyle.Bold);
                m_GrandTotalFormat.ForeColor = Color.Blue;
                m_GrandTotalFormat.BorderBottom = XLLineStyleEnum.Medium;
                m_GrandTotalFormat.BorderTop = XLLineStyleEnum.Medium;
                m_GrandTotalFormat.BorderLeft = XLLineStyleEnum.Medium;
                m_GrandTotalFormat.BorderRight = XLLineStyleEnum.Medium;
                m_GrandTotalFormat.BackColor = Color.LemonChiffon;
                m_GrandTotalFormat.Format = "###,###";
                return m_GrandTotalFormat;
            }
            set
            {
                m_GrandTotalFormat = value;
            }
        }

        public void mergeCell(int NoSheet,int rowFrom, int rowTo, int colFrom, int colTo, string value)
        {
            XLCellRange cr = new XLCellRange(rowFrom, rowTo, colFrom, colTo);
            book.Sheets[NoSheet].MergedCells.Add(cr);
            book.Sheets[NoSheet][rowFrom, colFrom].Value = value;
        }
        
        public void mergeCell(int NoSheet, int rowFrom, int rowTo, int colFrom, int colTo, string value,XLStyle style)
        {
            XLCellRange cr = new XLCellRange(rowFrom, rowTo, colFrom, colTo);
            book.Sheets[NoSheet].MergedCells.Add(cr);
            book.Sheets[NoSheet][rowFrom, colFrom].Value = value;
            for (int i = rowFrom; i <= rowTo; i++)
                for (int j = colFrom; j <= colTo; j++)
                    book.Sheets[NoSheet][i, j].Style = style;
        }
        
        public void mergeCell(XLSheet sheet,int rowFrom, int rowTo, int colFrom, int colTo, string value)
        {
            XLCellRange cr = new XLCellRange(rowFrom, rowTo, colFrom, colTo);
            sheet.MergedCells.Add(cr);
            sheet[rowFrom, colFrom].Value = value;
        }

        public void mergeCell(XLSheet sheet, int rowFrom, int rowTo, int colFrom, int colTo, string value,XLStyle style)
        {
            XLCellRange cr = new XLCellRange(rowFrom, rowTo, colFrom, colTo);
           
            for (int i = rowFrom; i <= rowTo; i++)
                for (int j = colFrom; j <= colTo; j++)
                    sheet[i, j].Style = style;
            sheet.MergedCells.Add(cr);
            sheet[rowFrom, colFrom].Value = value;
        }
        
        public void WriteTitle(string company, string section, string title)
        {
            book.Sheets[0][0, 0].Value = company;
            book.Sheets[0][0, 0].Style = Tahoma_9;
            book.Sheets[0][1, 1].Value = section;
            book.Sheets[0][1, 1].Style = Tahoma_9;
            book.Sheets[0][3, 0].Value = title;
            book.Sheets[0][3, 0].Style = Tahoma_18;

            book.Sheets[0][4, 0].Value = "Date create: " + Strings.Format(DateAndTime.Now.Date, "dd/MM/yyyy").ToString().Trim();

        }
        
        public void WriteTitle(string company, string section, string title, int FromCol, int ToCol)
        {
            book.Sheets[0][0, 0].Value = company;
            book.Sheets[0][0, 0].Style = Tahoma_9;
            book.Sheets[0][1, 1].Value = section;
            book.Sheets[0][1, 1].Style = Tahoma_9;
            //  book.Sheets[0][3, 0].Value = title;
            mergeCell(0, 3, 3, FromCol, ToCol, title, Tahoma_18);
            //  book.Sheets[0][3, 0].Style = Tahoma_18;

            //book.Sheets[0][4, 0].Value = "Ngày tạo : " + Strings.Format(DateAndTime.Now.Date, "dd/MM/yyyy").ToString().Trim();

        }
        
        public XLStyle TitleColumn
        {
            get
            {
                m_TitleColumn = new XLStyle(book);
                m_TitleColumn.Font = new Font("Tahoma", 9, FontStyle.Bold);
                m_TitleColumn.ForeColor = Color.Blue;
                m_TitleColumn.AlignHorz = XLAlignHorzEnum.Center;
                m_TitleColumn.AlignVert = XLAlignVertEnum.Center;
                m_TitleColumn.BorderBottom = XLLineStyleEnum.Medium;
                m_TitleColumn.BorderTop = XLLineStyleEnum.Medium;
                m_TitleColumn.BorderLeft = XLLineStyleEnum.Medium;
                m_TitleColumn.BorderRight = XLLineStyleEnum.Medium;
                m_TitleColumn.BackColor = Color.FromArgb(192, 192, 255);
                return m_TitleColumn;

            }
            set
            {
                m_TitleColumn = value;
            }
        }
        
        public XLStyle BackColor(XLStyle style, Color color)
        {
            style.BackColor = color;
            return style;
        }
    }
}
