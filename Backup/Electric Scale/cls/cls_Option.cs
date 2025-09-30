using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Option
    {
        private int _OptID;
        private string _OptName;
        //private string _OptType;
        private string _OptValue;
        private bool _OptStatus;
        
        public int OptID
        {
            get
            {
                return _OptID;
            }
            set
            {
                _OptID = value;
            }
        }
    
        public string OptName
        {
            get
            {
                return _OptName;
            }
            set
            {
                _OptName = value;
            }
        }
   
        //public string OptType
        //{
        //    get
        //    {
        //        return _OptType;
        //    }
        //    set
        //    {
        //        _OptType = value;
        //    }
        //}
    
        public string OptValue
        {
            get
            {
                return _OptValue;
            }
            set
            {
                _OptValue = value;
            }
        }
    
        public bool OptStatus
        {
            get
            {
                return _OptStatus;
            }
            set
            {
                _OptStatus = value;
            }
        }

        public void Options()
        {
            _OptID = 1;
            _OptName = "";
            //_OptType = "";
            _OptValue = "";
            _OptStatus = true;
        }

        public void Options(int optID, string optName, string optValue, bool optStatus)
        {
            _OptID = optID;
            _OptName = optName;
            //_OptType = optType;
            _OptValue = optValue;
            _OptStatus = optStatus;
        }
    }
}
