using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Department
    {
        private string _DepartmentID;
        private string _DepartmentName;
        private string _Phone;
        private string _Desciption;
        private bool _Disabled;
          
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
     
        public string DepartmentName
        {
            get
            {
                return _DepartmentName;
            }
            set
            {
                _DepartmentName = value;
            }
        }
     
        public string Phone
        {
            get
            {
                return _Phone;
            }
            set
            {
                _Phone = value;
            }
        }
     
        public string Description
        {
            get
            {
                return _Desciption;
            }
            set
            {
                _Desciption = value;
            }
        }
      
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

        public void Department()
        {
            _DepartmentID = "";
            _DepartmentName = "";
            _Phone = "";
            _Desciption = "";
            _Disabled = false;
        }

        public void Department(string departmentID, string departmentName, string phone, string description, bool disabled)
        {
            _DepartmentID = departmentID;
            _DepartmentName = departmentName;
            _Phone = phone;
            _Desciption = description;
            _Disabled = disabled;
        }
    }
}
