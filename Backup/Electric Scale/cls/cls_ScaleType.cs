using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_ScaleType
    {
        private int _ScaleTypeID;
        private string _ScaleTypeName;

        public int ScaleTypeID
        {
            get
            {
                return _ScaleTypeID;
            }
            set
            {
                _ScaleTypeID = value;
            }
        }

        public string ScaleTypeName
        {
            get
            {
                return _ScaleTypeName;
            }
            set
            {
                _ScaleTypeName = value;
            }
        }

        public void ScaleTypes()
        {
            _ScaleTypeID = 1;
            _ScaleTypeName = "";
        }

        public void ScaleTypes(int scaleTypeID, string scaleTypeName)
        {
            _ScaleTypeID = scaleTypeID;
            _ScaleTypeName = scaleTypeName;
        }
    }
}
