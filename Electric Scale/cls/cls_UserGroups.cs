using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_UserGroups
    {
        private int _OrderNum;
        private string _GroupID;
        private string _GroupName;
        private string _DepartmentID;
        private string _PositionID;
        private int _Permission;

        public int OrderNum
        {
            get
            {
                return _OrderNum;
            }
            set
            {
                _OrderNum = value;
            }
        }

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

        public int Permission
        {
            get
            {
                return _Permission;
            }
            set
            {
                _Permission = value;
            }
        }

        public void UserGroups()
        {
            _OrderNum = 1;
            _GroupID = "";
            _GroupName = "";
            _DepartmentID = "";
            _PositionID = "";
            _Permission = 0; //Chua co quyen
        }

        public void UserGroups(int orderNum, string groupID, string groupName, string departmentID, string positionID, int permission)
        {
            _OrderNum = orderNum;
            _GroupID = groupID;
            _GroupName = groupName;
            _DepartmentID = departmentID;
            _PositionID = positionID;
            _Permission = permission;
        }
    }
}
