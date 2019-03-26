using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongXuLy
{
    class KhachHangBUS
    {
        public static bool ThemKhachHang(KhachHangDTO kh)
        {
            if (KhachHangDAO.GetTheLoaiByMa(kh.MaKhachHang) == null)
            {
                KhachHangDAO.Insert(kh);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool XoaKhachHang(KhachHangDTO kh)
        {
            if (KhachHangDAO.GetTheLoaiByMa(kh.MaKhachHang) != null)
            {
                KhachHangDAO.Delete(kh);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SuaKhachHang(KhachHangDTO kh)
        {
            if (KhachHangDAO.GetTheLoaiByMa(kh.MaKhachHang) != null)
            {
                KhachHangDAO.Update(kh);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
