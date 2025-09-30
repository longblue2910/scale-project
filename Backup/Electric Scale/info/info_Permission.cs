using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.func;

namespace Electric_Scale.info
{
    class info_Permission
    {
        public DataTable GetAllPermission()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetAllPermission ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }
    }
}
