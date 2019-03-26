using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class SachDTO
    {
        int iMaSach;

        public int MaSach
        {
            get { return iMaSach; }
            set { iMaSach = value; }
        }
        string strTenSach;

        public string TenSach
        {
            get { return strTenSach; }
            set { strTenSach = value; }
        }
        int iSoLuongTon;

        public int SoLuongTon
        {
            get { return iSoLuongTon; }
            set { iSoLuongTon = value; }
        }

        
        string strTacGia;

        public string TacGia
        {
            get { return strTacGia; }
            set { strTacGia = value; }
        }
        int iMaTheLoai;

        public int MaTheLoai
        {
            get { return iMaTheLoai; }
            set { iMaTheLoai = value; }
        }
        int iGiaBan;

        public int GiaBan
        {
            get { return iGiaBan; }
            set { iGiaBan = value; }
        }

    }
}
