using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class KhachHangDTO
    {
        private int iMaKhachHang;

        public int MaKhachHang
        {
            get { return iMaKhachHang; }
            set { iMaKhachHang = value; }
        }
        private string strHoTenKhachHang;

        public string HoTenKhachHang
        {
            get { return strHoTenKhachHang; }
            set { strHoTenKhachHang = value; }
        }
        private Int64 iDienThoai;

        public Int64 DienThoai
        {
            get { return iDienThoai; }
            set { iDienThoai = value; }
        }
        private string strDiaChi;

        public string DiaChi
        {
            get { return strDiaChi; }
            set { strDiaChi = value; }
        }
        private string strEmail;

        public string Email
        {
            get { return strEmail; }
            set { strEmail = value; }
        }
        private int iMaHoaDon;

        public int MaHoaDon
        {
            get { return iMaHoaDon; }
            set { iMaHoaDon = value; }
        }
        private Int64 iTienNo;

        public Int64 TienNo
        {
            get { return iTienNo; }
            set { iTienNo = value; }
        }

    }
}
