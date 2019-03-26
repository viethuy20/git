using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongXuLy;
using System.Data;

namespace quanlynhasach.HeThongLuuTru
{
    class BaoCaoTonDAO
    {
        public static void Insert(BaoCaoTonDTO bc)
        {
            string sql = "insert into BAOCAOTON(MaSach,NgayPhatSinh,TonDau,PhatSinh,TonCuoi) values(" + bc.MaSach + ",'" + bc.NgayPhatSinh + "'," + bc.TonDau+ ",'"+bc.PhatSinh+"',"+bc.TonCuoi+")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static DataTable BaoCaoThang(int thang)
        {
            string sql = "select * from BAOCAOTON where Month(NgayPhatSinh) like '%" + thang + "%' ";
            return DataAccess.ExcuQuery(sql);
        } 
    }
}
