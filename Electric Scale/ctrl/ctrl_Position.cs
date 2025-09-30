using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Electric_Scale.info;

namespace Electric_Scale.ctrl
{
    class ctrl_Position
    {
        private readonly info_Position infoPos = new info_Position();

        public DataTable GetInfoPosition()
        {
            return infoPos.GetInfoPosition();
        }
    }
}
