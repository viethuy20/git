using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongXuLy
{
    class TheLoaiBUS
    {
        public static bool ThemTheLoai(TheLoaiDTO tl)
        {
            if (TheLoaiDAO.GetTheLoaiByName(tl.TenTheLoai) == null)
            {
                TheLoaiDAO.Insert(tl);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool XoaTheLoai(TheLoaiDTO tl)
        {
            if (TheLoaiDAO.GetTheLoaiByName(tl.TenTheLoai) != null)
            {
                TheLoaiDAO.Delete(tl);
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool SuaTheLoai(TheLoaiDTO tl)
        {
            if (TheLoaiDAO.GetTheLoaiByMa(tl.MaTheLoai) != null)
            {
                TheLoaiDAO.Update(tl);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
