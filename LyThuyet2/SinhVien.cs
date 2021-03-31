using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1 
{
    class SinhVien
    {
        private string _maSV;
        private string _tenSV;
        private string _diaChiSV;
        private int _tuoiSV;
        private float _diemTBSV;

        public SinhVien(string maSV, string tenSV)
        {
            _maSV = maSV;
            _tenSV = tenSV;
        }

        public SinhVien(string maSV, string tenSV, string diaChiSV) : this(maSV, tenSV)
        {
            _diaChiSV = diaChiSV;
            _maSV = "1811505310129";
            _tenSV = "No Name";
        }


        public SinhVien(string maSV, string tenSV,string diaChiSV, int tuoiSV, float diemTBSV) : this(maSV,tenSV)
        {
            _diaChiSV = diaChiSV;
            _tuoiSV = tuoiSV;
            _diemTBSV = diemTBSV;
        }

        public string MaSV
        {
            get => _maSV;

            set 
            {
                if (Int32.Parse(value) < 0)
                    _maSV = "-1";
                else
                    _maSV = value;
            }
        }
        public string TenSV
        {
            get => _tenSV;
            set
            {
                if (value.Length >= 10)
                    _tenSV = "Invalid Name";
                else
                    _tenSV = value;
            }
        }

        public string DiaChiSV
        {
            get => _diaChiSV;
            set => _diaChiSV = value;
        }
        public int TuoiSV
        {
            get => _tuoiSV;
            set => _tuoiSV = value;
        }

        public float DiemTBSV
        {
            get => _diemTBSV;
            set => _diemTBSV = value;
        }


        public override string ToString()
        {
            return MaSV + " " + TenSV + " " + DiaChiSV + " " + TuoiSV + " " + DiemTBSV;
        }

    }
}
