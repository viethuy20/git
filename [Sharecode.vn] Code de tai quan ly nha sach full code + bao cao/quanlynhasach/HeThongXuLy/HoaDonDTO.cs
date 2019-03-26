using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class HoaDonDTO
    {
        private int IMaHoaDon;

        public int MaHoaDon
        {
            get { return IMaHoaDon; }
            set { IMaHoaDon = value; }
        }
        private DateTime dtNgayLapHoaDon;

        public DateTime NgayLapHoaDon
        {
            get { return dtNgayLapHoaDon; }
            set { dtNgayLapHoaDon = value; }
        }
        private int iMaSach;

        public int MaSach
        {
            get { return iMaSach; }
            set { iMaSach = value; }
        }
        private int iMaKhachHang;

        public int MaKhachHang
        {
            get { return iMaKhachHang; }
            set { iMaKhachHang = value; }
        }
        private uint uiSoLuongMua;

        public uint SoLuongMua
        {
            get { return uiSoLuongMua; }
            set { uiSoLuongMua = value; }
        }


    }
}
