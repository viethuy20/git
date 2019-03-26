using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using quanlynhasach.HeThongXuLy;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongLuuTru
{
    class ThamSoDAO
    {
        public static DataTable GetThamSoAll()
        {
            string sql = "select * from THAMSO";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SlectSoLuongTon(int masach)
        {
            string sql = "select * from SACH where MaSach=" +masach + "";
            return DataAccess.ExcuQuery(sql);          
        }
        static public DataTable SlectTienNoKH(int makh)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + makh + "";
            return DataAccess.ExcuQuery(sql);
        }
        static public void Update(ThamSoDTO ts)
        {
            string sql = "update THAMSO set SoLuongNhapItNhat=(" + ts.SoLuongNhapMin + "),LuongTonItNhat=(" + ts.LuongTonMin + "),NoKhongQua=(" + ts.NoMin + "),LuongTonSauKhiBan=(" + ts.TonSauKhiBan + "),DieuKienThu=(" + ts.DieuKienThu+ ") where MaThamSo = " + ts.MaThamSo + "";
            DataAccess.ExcuNonQuery(sql);
        }
    }
}
