using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.cls;
using Electric_Scale.func;

namespace Electric_Scale.info
{
    class info_GroupAndUser
    {
        public DataTable GetAllGroup()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetAllGroup ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetInfoGroupByID(int iGroupID)
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoGroupByID ";
            sSQL += cls_GlobalUtil.SQLString(iGroupID);
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetInfoGroupAvailable()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoGroupAvailable ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetFormPermissionByGroupID(int iGroupID)
        {
            string sSQL = "";
            sSQL += "Exec sp_GetFormPermissionByGroupID ";
            sSQL += cls_GlobalUtil.SQLString(iGroupID);
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public DataTable GetFormPermissionDefault()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetFormPermissionDefault ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }

        public string SQLDeleteUserGroupByID(int sGroupID)
        {
            string sSQL = "";
            sSQL += "Exec sp_DeleteUserGroupByGroupID ";
            sSQL += cls_GlobalUtil.SQLString(sGroupID);

            return sSQL;
        }
    }
}
