using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongXuLy
{
    class SachBUS
    {
        public static bool ThemSach(SachDTO s)
        {
            if (SachDAO.SelectTLByName(s.TenSach) == null)
            {
                SachDAO.Insert(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool CapNhatSach(SachDTO s)
        {
            if (SachDAO.SelectSachTheoMa(s.MaSach) != null)
            {
                SachDAO.Insert(s);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool XoaSach(SachDTO s)
        {
            if (SachDAO.SelectSachTheoMa(s.MaSach) != null)
            {
                SachDAO.Delete(s);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
