using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale
{
    class cls_Position
    {
        private string _PositionID;
        private string _Description;

        public string PositionID
        {
            get
            {
                return _PositionID;
            }
            set
            {
                _PositionID = value;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
            set
            {
                _Description = value;
            }
        }

        public void Position()
        {
            _PositionID = "";
            _Description = "";
        }

        public void Position(string positionID, string description)
        {
            _PositionID = positionID;
            _Description = description;
        }
    }
}
