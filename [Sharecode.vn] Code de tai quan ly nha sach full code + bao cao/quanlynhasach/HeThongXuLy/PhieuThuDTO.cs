using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class PhieuThuDTO
    {
        private int iMaPhieuThu;

        public int MaPhieuThu
        {
            get { return iMaPhieuThu; }
            set { iMaPhieuThu = value; }
        }
        private DateTime daNgayThu;

        public DateTime NgayThu
        {
            get { return daNgayThu; }
            set { daNgayThu = value; }
        }
        private UInt64 iSoTienThu;

        public UInt64 SoTienThu
        {
            get { return iSoTienThu; }
            set { iSoTienThu = value; }
        }
        private int iMaKhachHang;

        public int MaKhachHang
        {
            get { return iMaKhachHang; }
            set { iMaKhachHang = value; }
        }
    }
}
