using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;

namespace quanlynhasach.HeThongLuuTru
{
    class SachDAO
    {
        static public DataTable SelectSachLikeName(SachDTO s)
        {
            string sql = "select * from SACH where TenSach like '%" + s.TenSach + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectSachLikeMaTheLoai(SachDTO s)
        {
            string sql = "select * from SACH where MaTheLoai like '%" + s.MaTheLoai + "%'";
            return DataAccess.ExcuQuery(sql);
        }
       
        static public DataTable SelectSachLikeTacGia(SachDTO s)
        {
            string sql = "select * from SACH where TacGia like '%" + s.TacGia + "%'";
            return DataAccess.ExcuQuery(sql);
        }
        static public DataTable SelectSachAll()
        {
            string sql = "select* from SACH";
            DataTable dt = DataAccess.ExcuQuery(sql);
            return dt;
        }
        static public void Insert(SachDTO s)
        {
            string sql = "insert into SACH(TenSach,TacGia,MaTheLoai,GiaBan,SoLuongTon) values('" + s.TenSach + "','" + s.TacGia + "'," + s.MaTheLoai + "," + s.GiaBan + "," + s.SoLuongTon + ")";
            DataAccess.ExcuNonQuery(sql);
           
        }
        public static bool Delete(SachDTO s)
        {
            try
            {
                string sql = "delete from SACH where MaSach= " + s.MaSach + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        static public void Update(SachDTO s)
        {
            string sql = "update  SACH set TenSach=('" + s.TenSach + "'),TacGia=('" + s.TacGia + "'),MaTheLoai=(" + s.MaTheLoai + "),GiaBan=(" + s.GiaBan + "),SoLuongTon=("+ s.SoLuongTon +") where MaSach = "+s.MaSach+"";
            DataAccess.ExcuNonQuery(sql);
        }
        static public void UpdateSoLuongTon(SachDTO s)
        {
            string sql = "update SACH set SoLuongTon=(" + s.SoLuongTon + ") where MaSach = "+s.MaSach+"";
            DataAccess.ExcuNonQuery(sql);
        }
        static public SachDTO SelectTLByName(string name)
        {
            string sql = "select * from SACH where TenSach='" + name + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else 
            {
                SachDTO s = new SachDTO();
                s.TenSach = dt.Rows[0].ItemArray[0].ToString();
                return s;
            }
        }
        static public SachDTO SelectSachTheoMa(int ma)
        {
            string sql = "select * from SACH where MaSach=" + ma + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                SachDTO s = new SachDTO();
                s.MaSach = int.Parse(dt.Rows[0].ItemArray[0].ToString());
                return s;
            }
        }
        public static DataTable GetSachCondition(int SoLuongTon)
        {
            string sql = "select * from SACH where SoLuongTon < " + SoLuongTon;
            return DataAccess.ExcuQuery(sql);
        }

        internal static object SelectPNByName(object p)
        {
            throw new Exception("The method or operation is not implemented.");
        }
        
    }
}
