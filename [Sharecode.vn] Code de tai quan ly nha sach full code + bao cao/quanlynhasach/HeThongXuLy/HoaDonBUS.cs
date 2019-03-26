using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongXuLy
{
    class HoaDonBUS
    {
        public static bool ThemHoaDon(HoaDonDTO hd)
        {
            HoaDonDAO.Insert(hd);
            return true;
        }
        public static bool ThemHoaDonChiTiet(HoaDonDTO hd)
        {
            if (HoaDonDAO.SelectSachLikeMaSach(hd.MaHoaDon,hd.MaSach) == null)
            {
                HoaDonDAO.InsertChitiet(hd);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
