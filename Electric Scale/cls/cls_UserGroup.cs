using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_UserGroup
    {
        private string _GroupID;
        private string _FormID;
        private string _PermissionID;     
        private string _GroupName;
        private string _DepartmentID;
        private string _PositionID;
        //private string _Description;
        private bool _Disabled;

        public string GroupID
        {
            get
            {
                return _GroupID;
            }
            set
            {
                _GroupID = value;
            }
        }

        public string FormID
        {
            get
            {
                return _FormID;
            }
            set
            {
                _FormID = value;
            }
        }

        public string PermissionID
        {
            get
            {
                return _PermissionID;
            }
            set
            {
                _PermissionID = value;
            }
        }

        public string GroupName
        {
            get
            {
                return _GroupName;
            }
            set
            {
                _GroupName = value;
            }
        }

        public string DepartmentID
        {
            get
            {
                return _DepartmentID;
            }
            set
            {
                _DepartmentID = value;
            }
        }

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

//        public string Description
//        {
//            get
//            {
//                return _Description;
//            }
//            set
//            {
//                _Description = value;
//            }
//        }
     
        public bool Disabled
        {
            get
            {
                return _Disabled;
            }
            set
            {
                _Disabled = value;
            }
        }

        public void UserGroups()
        {
            _GroupID = "";
            _FormID = "";
            _PermissionID = "None"; //Chua co quyen
            _GroupName = "";
            _DepartmentID = "";
            _PositionID = "";
            //_Description = "";
            _Disabled = false;
        }

        public void UserGroups(string groupID, string formID, string permissionID, string groupName, string departmentID, string positionID, bool disabled)
        {
            _GroupID = groupID;
            _FormID = formID;
            _PermissionID = permissionID;
            _GroupName = groupName;
            _DepartmentID = departmentID;
            _PositionID = positionID;
            //_Description = description;
            _Disabled = disabled;
        }
    }
}
