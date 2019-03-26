using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class BaoCaoCongNoDTO
    {
        private int iMaKhachHang;

        public int MaKhachHang
        {
            get { return iMaKhachHang; }
            set { iMaKhachHang = value; }
        }
        private int iNoDau;

        public int NoDau
        {
            get { return iNoDau; }
            set { iNoDau = value; }
        }
        private string strPhatSinh;

        public string PhatSinh
        {
            get { return strPhatSinh; }
            set { strPhatSinh = value; }
        }
        private Int64 iNoCuoi;

        public Int64 NoCuoi
        {
            get { return iNoCuoi; }
            set { iNoCuoi = value; }
        }
        private DateTime dNgayPhatSinh;

        public DateTime NgayPhatSinh
        {
            get { return dNgayPhatSinh; }
            set { dNgayPhatSinh = value; }
        }

    }
}
