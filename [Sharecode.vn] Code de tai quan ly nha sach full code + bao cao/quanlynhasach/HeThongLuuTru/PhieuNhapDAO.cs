using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongXuLy;
using quanlynhasach.HeThongLuuTru;
using System.Data;

namespace quanlynhasach.HeThongLuuTru
{
    class PhieuNhapDAO
    {
        static public DataTable SelectPhieuNhapAll()
        {
            string sql = "select* from PHIEUNHAP";
            DataTable dt = DataAccess.ExcuQuery(sql);
            return dt;
        }
        static public DataTable SelectPhieuNhapChiTietAll()
        {
            string sql = "select * from CHITIETPHIEU";
            DataTable dt = DataAccess.ExcuQuery(sql);
            return dt;
        }
        static public void Insert(PhieuNhapDTO p)
        {
            string sql = "insert into CHITIETPHIEU(MaPhieuNhap,MaSach,SoLuongNhap) values(" + p.MaPhieuNhap + "," + p.MaSach + "," + p.SoLuong + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        static public void Insertphieunhap(PhieuNhapDTO p)
        {
            string sql = "insert into PHIEUNHAP(NgayNhap) values('" + p.NgayNhap + "')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static PhieuNhapDTO GetPhieuNhapByName(int maphieunhap, int masach)
        {
            string sql = "select * from CHITIETPHIEU where ((MaPhieuNhap=" + maphieunhap + ")AND(MaSach = "+masach+"))";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PhieuNhapDTO pn = new PhieuNhapDTO();
                pn.MaPhieuNhap = (int)dt.Rows[0].ItemArray[0];                
                return pn;
            }

        }
        
    }
}
