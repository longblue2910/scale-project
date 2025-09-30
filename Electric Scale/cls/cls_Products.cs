using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Products
    {
        private int _OrderNum;
        private string _ProductID;
        private string _ProductName;
        private string _Note;
        private bool _Disabled;

        public int  OrderNum
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
            _OrderNum = 1;
            _ProductID = "";
            _ProductName = "";
            _Note = "";
            _Disabled = false;
        }

        public void Products(int orderNum, string productID, string productName, string note, bool disabled)
        {
            _OrderNum = orderNum;
            _ProductID = productID;
            _ProductName = productName;
            _Note = note;
            _Disabled = disabled;
        }
    }
}
