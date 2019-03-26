using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongXuLy;
using System.Data;

namespace quanlynhasach.HeThongLuuTru
{
    class BaoCaoCongNoDAO
    {
        public static void Insert(BaoCaoCongNoDTO bc)
        {
            string sql = "insert into BAOCAOCONGNO(MaKhachHang,NgayPhatSinh,NoDau,PhatSinh,NoCuoi) values(" + bc.MaKhachHang + ",'" + bc.NgayPhatSinh + "'," + bc.NoDau + ",'" + bc.PhatSinh + "'," + bc.NoCuoi + ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static DataTable BaoCaoThang(int thang)
        {
            string sql = "select * from BAOCAOCONGNO where Month(NgayPhatSinh) like '%" + thang + "%' ";
            return DataAccess.ExcuQuery(sql);
        } 
    }
}
