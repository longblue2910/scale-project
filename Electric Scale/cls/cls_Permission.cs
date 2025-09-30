using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Permission
    {
        private string _PermissionID;
        private string _Description;

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

        public void Permission()
        {
            _PermissionID = "";
            _Description = "";
        }

        public void Permission(string permissionID, string description)
        {
            _PermissionID = permissionID;
            _Description = description;
        }
    }
}
