using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.func;

namespace Electric_Scale.info
{
    class info_ScaleType
    {
        public DataTable GetInfoScaleType()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoScaleType ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }
    }
}
