using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongXuLy
{
    class PhieuThuBUS
    {
        public static bool ThemPhieuThu(PhieuThuDTO pt)
        {
            if (PhieuThuDAO.GetPhieuThuByMa(pt.MaPhieuThu) == null)
            {
                PhieuThuDAO.Insert(pt);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool XoaPhieuThu(PhieuThuDTO pt)
        {
            if (PhieuThuDAO.GetPhieuThuByMa(pt.MaPhieuThu) != null)
            {
                PhieuThuDAO.Delete(pt);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SuaPhieuThu(PhieuThuDTO pt)
        {
            if (PhieuThuDAO.GetPhieuThuByMa(pt.MaPhieuThu) != null)
            {
                PhieuThuDAO.Update(pt);
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
