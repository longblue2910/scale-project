using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.info;

namespace Electric_Scale.ctrl
{
    class ctrl_Permission
    {
        private readonly info_Permission infoPer = new info_Permission();

        public DataTable GetAllPermission()
        {
            return infoPer.GetAllPermission();
        }
    }
}
