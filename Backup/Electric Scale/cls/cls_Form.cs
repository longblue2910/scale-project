using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_Form
    {
        private string _FormID;
        private string _Description;

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

        public void Form()
        {
            _FormID = "";
            _Description = "";
        }

        public void Form(string formID, string description)
        {
            _FormID = formID;
            _Description = description;
        }
    }
}
