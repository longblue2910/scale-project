using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.cls;
using Electric_Scale.func;

namespace Electric_Scale.info
{
    class info_Department
    {
        public DataTable GetAllDepartment()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetAllDepartment ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetInfoDepartment()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoDepartment ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetDepartmentByID(string sDepartmentID)
        {
            string sSQL = "";
            sSQL += "Exec sp_GetDepartmentByID ";
            sSQL += cls_GlobalUtil.SQLString(sDepartmentID);
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public string SQLInsertDepartment(cls_Department department)
        {
            string sSQL = "";
            sSQL += "Exec sp_Insertdepartment ";
            sSQL += cls_GlobalUtil.SQLString(department.DepartmentID) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(department.DepartmentName) + cls_GlobalUtil.COMMA;            
            sSQL += cls_GlobalUtil.SQLString(department.Phone) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(department.Description) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(department.Disabled);

            return sSQL;
        }

        public string SQLEditDepartment(string sDepartmentID_Old, cls_Department department)
        {
            string sSQL = "";
            sSQL += "Exec sp_Editdepartment ";
            sSQL += cls_GlobalUtil.SQLString(sDepartmentID_Old) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(department.DepartmentID) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(department.DepartmentName) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(department.Phone) + cls_GlobalUtil.COMMA;
            sSQL += "N";
            sSQL += cls_GlobalUtil.SQLString(department.Description) + cls_GlobalUtil.COMMA;
            sSQL += cls_GlobalUtil.SQLString(department.Disabled);

            return sSQL;
        }

        public string SQLDeleteDepartmentByID(string sDepartmentID)
        {
            string sSQL = "";
            sSQL += "Exec sp_DeleteDepartmentByID ";
            sSQL += cls_GlobalUtil.SQLString(sDepartmentID);

            return sSQL;
        }
    }
}
