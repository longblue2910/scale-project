using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.info;
using Electric_Scale.cls;

namespace Electric_Scale.ctrl
{
    class ctrl_Department
    {
        private readonly info_Department infoDep = new info_Department();

        public DataTable GetAllDepartment()
        {
            return infoDep.GetAllDepartment();
        }

        public DataTable GetInfoDepartment()
        {
            return infoDep.GetInfoDepartment();
        }

        public DataTable GetDepartmentByID(string sDepartmentID)
        {
            return infoDep.GetDepartmentByID(sDepartmentID);    
        }

        public string SQLInsertDepartment(cls_Department department)
        {
            return infoDep.SQLInsertDepartment(department);
        }

        public string SQLEditDepartment(string sDepartmentID_Old, cls_Department department)
        {
            return infoDep.SQLEditDepartment(sDepartmentID_Old, department);
        }

        public string SQLDeleteDepartmentByID(string sDepartmentID)
        {
            return infoDep.SQLDeleteDepartmentByID(sDepartmentID);
        }
    }
}
