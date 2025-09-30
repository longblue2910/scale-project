using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Employees
    {
        private int _OrderNum;
        private string _EmployeeID;
        private string _EmployeeName;
        private string _DepartmentID;
        private string _Address;
        private string _Phone;
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
     
        public string EmployeeID
        {
            get
            {
                return _EmployeeID;
            }
            set
            {
                _EmployeeID = value;
            }
        }
    
        public string EmployeeName
        {
            get
            {
                return _EmployeeName;
            }
            set
            {
                _EmployeeName = value;
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
     
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
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

        public void Employees()
        {
            _OrderNum = 1;
            _EmployeeID = "";
            _EmployeeName = "";
            _DepartmentID = "";
            _Address = "";
            _Phone = "";
            _Disabled = false;
        }

        public void Employees(int orderNum, string employeeID, string employeeName, string departmentID, string address, string phone, bool disabled)
        {
            _OrderNum = orderNum;
            _EmployeeID = employeeID;
            _EmployeeName = employeeName;
            _DepartmentID = departmentID;
            _Address = address;
            _Phone = phone;
            _Disabled = disabled;
        }

    }
}
