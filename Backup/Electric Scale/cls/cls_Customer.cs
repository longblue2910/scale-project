using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Customer
    {
        private string _CustomerID;
        private string _CustomerName;
        private string _Address;
        private string _Email;
        private string _Phone;
        private string _Fax;
        private bool _Disabled;
     
        public string CustomerID
        {
            get
            {
                return _CustomerID;
            }
            set
            {
                _CustomerID = value;
            }
        }
     
        public string CustomerName
        {
            get
            {
                return _CustomerName;
            }
            set
            {
                _CustomerName = value;
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
        
        public string Email
        {
            get
            {
                return _Email;
            }
            set
            {
                _Email = value;
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
     
        public string Fax
        {
            get
            {
                return _Fax;
            }
            set
            {
                _Fax = value;
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

        public void Customer()
        {
            _CustomerID = "";
            _CustomerName = "";
            _Address = "";
            _Phone = "";
            _Fax = "";
            _Disabled = false;
        }

        public void Customer(string customerID, string cusomerName, string address, string phone, string fax, bool disbled)
        {
            _CustomerID = customerID;
            _CustomerName = cusomerName;
            _Address = address;
            _Phone = phone;
            _Fax = fax;
            _Disabled = disbled;
        }
    }
}
