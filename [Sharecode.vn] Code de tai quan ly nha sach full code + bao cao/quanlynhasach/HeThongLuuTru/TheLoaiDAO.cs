using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;
using System.Data;

namespace quanlynhasach.HeThongLuuTru
{
    class TheLoaiDAO
    {
        public static void Insert (TheLoaiDTO tl)
        {
            string sql= "insert into THELOAI(TenTheLoai) values('"+tl.TenTheLoai+"')";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(TheLoaiDTO tl)
        {
            string sql = "Update  THELOAI set TenTheLoai ='" + tl.TenTheLoai+ "'where MaTheLoai="+tl.MaTheLoai+"" ;
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(TheLoaiDTO tl)
        {
            try
            {
                string sql = "delete from THELOAI where TenTheLoai= '"+ tl.TenTheLoai+"'";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static TheLoaiDTO GetTheLoaiByName(string Name)
        {
            string sql = "select * from THELOAI where TenTheLoai='" + Name + "'";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count== 0)
            {
                return null;
            }
            else
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl.MaTheLoai = (int)dt.Rows[0].ItemArray[0];
                tl.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static TheLoaiDTO GetTheLoaiByMa(int Ma)
        {
            string sql = "select * from THELOAI where MaTheLoai="+Ma+"";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                TheLoaiDTO tl = new TheLoaiDTO();
                tl.MaTheLoai = (int)dt.Rows[0].ItemArray[0];
                tl.TenTheLoai = dt.Rows[0].ItemArray[1].ToString();
                return tl;
            }

        }
        public static DataTable GetTheLoaiAll()
        {
            string sql = "select * from THELOAI";
            return DataAccess.ExcuQuery(sql);            
        }
        
    }
   
}
