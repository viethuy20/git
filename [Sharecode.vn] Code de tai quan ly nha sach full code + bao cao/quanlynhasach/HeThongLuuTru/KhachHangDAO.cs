using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongXuLy;
using quanlynhasach.HeThongLuuTru;
using System.Data;

namespace quanlynhasach.HeThongLuuTru
{
    class KhachHangDAO
    {
        static public DataTable SelectKhachHangLikeTen(KhachHangDTO kh)
        {
            string sql = "select * from KHACHHANG where HoTenKhachHang like '%" + kh.HoTenKhachHang + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeDiaChi(KhachHangDTO kh)
        {
            string sql = "select * from KHACHHANG where DiaChi like '%" + kh.DiaChi+ "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeDienThoai(KhachHangDTO kh)
        {
            string sql = "select * from KHACHHANG where DienThoai like '%" + kh.DienThoai + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectKhachHangLikeEmail(KhachHangDTO kh)
        {
            string sql = "select * from KHACHHANG where Email like '%" + kh.Email + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        public static DataTable GetKhachHangAll()
        {
            string sql = "select * from KHACHHANG";
            return DataAccess.ExcuQuery(sql);
        }
        public static void Insert(KhachHangDTO kh)
        {
            string sql = "insert into KHACHHANG(HoTenKhachHang,DienThoai,DiaChi,Email) values('" + kh.HoTenKhachHang + "',"+kh.DienThoai+",'"+kh.DiaChi+"','"+kh.Email+"')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(KhachHangDTO kh)
        {
            string sql = "Update  KHACHHANG set HoTenKhachHang =('" + kh.HoTenKhachHang + "'),DienThoai=(" + kh.DienThoai + "), DiaChi=('" + kh.DiaChi + "'),Email=('" + kh.Email + "') where MaKhachHang=" + kh.MaKhachHang + "";
            

            DataAccess.ExcuNonQuery(sql);
        }
        public static void UpdateTienNo(KhachHangDTO kh)
        {
            string sql = "Update  KHACHHANG set TienNo=(" + kh.TienNo + ") where MaKhachHang=" + kh.MaKhachHang + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(KhachHangDTO kh)
        {
            try
            {
                string sql = "delete from KHACHHANG where MaKhachHang= "+ kh.MaKhachHang+"";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static KhachHangDTO GetTheLoaiByMa(int Ma)
        {
            string sql = "select * from KHACHHANG where MaKhachHang=" + Ma + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = (int)dt.Rows[0].ItemArray[0];
                kh.HoTenKhachHang = dt.Rows[0].ItemArray[1].ToString();
                kh.DienThoai = (int)dt.Rows[0].ItemArray[2];
                kh.DiaChi = dt.Rows[0].ItemArray[3].ToString();
                kh.Email = dt.Rows[0].ItemArray[4].ToString();
                return kh;
            }

        }
    }
}
