using System;
using System.Collections.Generic;
using System.Text;

namespace Electric_Scale.cls
{
    class cls_NhanVien
    {
        private int _STT;
        private string _MaNV;
        private string _TenNV;
        private string _MaPB;
        private string _DiaChi;
        private string _DienThoai;
        private bool _KSD;

        public int STT
        {
            get
            {
                return _STT;
            }
            set
            {
                _STT = value;
            }
        }
    
        public string MaNV
        {
            get
            {
                return _MaNV;
            }
            set
            {
                _MaNV = value;
            }
        }
   
        public string TenNV
        {
            get
            {
                return _TenNV;
            }
            set
            {
                _TenNV = value;
            }
        }
     
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
    
        public string DiaChi
        {
            get
            {
                return _DiaChi;
            }
            set
            {
                _DiaChi = value;
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

        public void NhanVien()
        {
            _STT = 1;
            _MaNV = "";
            _TenNV = "";
            _MaPB = "";
            _DiaChi = "";
            _DienThoai = "";
            _KSD = false;
        }

        public void NhanVien(int stt, string maNV, string tenNV, string maPB, string diaChi, string dienThoai, bool ksd)
        {
            _STT = stt;
            _MaNV = maNV;
            _TenNV = tenNV;
            _MaPB = maPB;
            _DiaChi = diaChi;
            _DienThoai = dienThoai;
            _KSD = ksd;
        }
    }
}
