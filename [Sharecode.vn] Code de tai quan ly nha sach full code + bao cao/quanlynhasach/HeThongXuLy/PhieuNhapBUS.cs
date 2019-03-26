using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongXuLy
{
    class PhieuNhapBUS
    {
        public static bool themphieunhap(PhieuNhapDTO p)
        {            
                PhieuNhapDAO.Insertphieunhap(p);
                return true;           
        }
        public static bool themchitietphieunhap(PhieuNhapDTO p)
        {
            if (PhieuNhapDAO.GetPhieuNhapByName(p.MaPhieuNhap,p.MaSach) == null)
            {
                PhieuNhapDAO.Insert(p);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
