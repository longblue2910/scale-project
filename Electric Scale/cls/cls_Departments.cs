using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Departments
    {
        private int _OrderNum;
        private string _DepartmentID;
        private string _DepartmentName;
        private string _Phone;
        private string _Note;
        private bool _Disabled;

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
     
        public string Note
        {
            get
            {
                return _Note;
            }
            set
            {
                _Note = value;
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

        public void Departments()
        {
            _OrderNum = 1;
            _DepartmentID = "";
            _DepartmentName = "";
            _Phone = "";
            _Note = "";
            _Disabled = false;
        }

        public void Departments(int orderNum, string departmentID, string departmentName, string phone, string note, bool disabled)
        {
            _OrderNum = orderNum;
            _DepartmentID = departmentID;
            _DepartmentName = departmentName;
            _Phone = phone;
            _Note = note;
            _Disabled = disabled;
        }
    }
}
