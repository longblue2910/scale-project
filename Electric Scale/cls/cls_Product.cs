using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Product
    {
        private string _ProductID;
        private string _ProductName;
        private string _Description;
        private bool _Disabled;

        public string ProductID
        {
            get
            {
                return _ProductID;
            }
            set
            {
                _ProductID = value;
            }
        }

        public string ProductName
        {
            get
            {
                return _ProductName;
            }
            set
            {
                _ProductName = value;
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
      
        public  bool Disabled
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

        public void Products()
        {
            _ProductID = "";
            _ProductName = "";
            _Description = "";
            _Disabled = false;
        }

        public void Products(string productID, string productName, string description, bool disabled)
        {
            _ProductID = productID;
            _ProductName = productName;
            _Description = description;
            _Disabled = disabled;
        }
    }
}
