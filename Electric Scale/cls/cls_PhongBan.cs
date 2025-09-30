using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_PhongBan
    {
        private string _MaPB;
        private string _TenPB;
        private string _DienThoai;
        private string _MoTa;
        private bool _KSD;
    
        public string MaPB
        {
            get
            {
                return _MaPB;
            }
            set
            {
                _MaPB = value;
            }
        }
    
        public string TenPB
        {
            get
            {
                return _TenPB;
            }
            set
            {
                _TenPB = value;
            }
        }
    
        public string DienThoai
        {
            get
            {
                return _DienThoai;
            }
            set
            {
                _DienThoai = value;
            }
        }
     
        public string MoTa
        {
            get
            {
                return _MoTa;
            }
            set
            {
                _MoTa = value;
            }
        }
     
        public bool KSD
        {
            get
            {
                return _KSD;
            }
            set
            {
                _KSD = value;
            }
        }

        public void PhongBan()
        {
            _MaPB = "";
            _TenPB = "";
            _DienThoai = "";
            _MoTa = "";
            _KSD = false;
        }

        public void PhongBan(string maPB, string tenPB, string dienThoai, string moTa, bool ksd)
        {
            _MaPB = maPB;
            _TenPB = tenPB;
            _DienThoai = dienThoai;
            _MoTa = moTa;
            _KSD = ksd;
        }
    }
}
