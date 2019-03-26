using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class PhieuNhapDTO
    {
        private int iMaPhieuNhap;

        public int MaPhieuNhap
        {
            get { return iMaPhieuNhap; }
            set { iMaPhieuNhap = value; }
        }
        private DateTime daNgayNhap;

        public DateTime NgayNhap
        {
            get { return daNgayNhap; }
            set { daNgayNhap = value; }
        }
        private int iMaSach;

        public int MaSach
        {
            get { return iMaSach; }
            set { iMaSach = value; }
        }
        private int ISoLuong;

        public int SoLuong
        {
            get { return ISoLuong; }
            set { ISoLuong = value; }
        }


    }
}
