using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.info;

namespace Electric_Scale.ctrl
{
    class ctrl_ScaleType
    {
        private readonly info_ScaleType infoST = new info_ScaleType();
        
        /// <summary>
        /// Get info of all Scale type
        /// </summary>
        /// <returns></returns>
        public DataTable GetInfoScaleType()
        {
            return infoST.GetInfoScaleType();
        }
    }
}
