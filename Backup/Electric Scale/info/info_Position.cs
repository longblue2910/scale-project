using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.func;

namespace Electric_Scale.info
{
    class info_Position
    {
        public DataTable GetInfoPosition()
        {
            string sSQL = "";
            sSQL += "Exec sp_GetInfoPosition ";
            return cls_GlobalUtil.ReturnDataTable(sSQL);
        }
    }
}
