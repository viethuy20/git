using System;
using System.Collections.Generic;
using System.Text;
using quanlynhasach.HeThongXuLy;
using System.Data;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongLuuTru
{
    class PhieuThuDAO
    {
        public static DataTable GetPhieuThuAll()
        {
            string sql = "select * from PHIEUTHU";
            return DataAccess.ExcuQuery(sql);
        }
        public static void Insert(PhieuThuDTO pt)
        {
            string sql = "insert into PHIEUTHU(NgayThu,SoTienThu,MaKhachHang) values('" + pt.NgayThu + "'," + pt.SoTienThu + "," + pt.MaKhachHang+ ")";
            DataAccess.ExcuNonQuery(sql);
        }
        public static void Update(PhieuThuDTO  pt)
        {
            string sql = "Update  PHIEUTHU set NgayThu =('" + pt.NgayThu + "'),SoTienThu=(" + pt.SoTienThu + ") where MaPhieuThu=" + pt.MaPhieuThu + "";
            DataAccess.ExcuNonQuery(sql);
        }
        public static bool Delete(PhieuThuDTO pt)
        {
            try
            {
                string sql = "delete from PHIEUTHU where MaPhieuThu= " + pt.MaPhieuThu + "";
                DataAccess.ExcuNonQuery(sql);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static PhieuThuDTO GetPhieuThuByMa(int Ma)
        {
            string sql = "select * from PHIEUTHU where MaPhieuThu=" + Ma + "";
            DataTable dt = DataAccess.ExcuQuery(sql);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            else
            {
                PhieuThuDTO pt = new PhieuThuDTO();
                pt.MaPhieuThu = (int)dt.Rows[0].ItemArray[0];
                //pt.NgayThu = (DateTime)dt.Rows[0].ItemArray[1];
                //pt.SoTienThu = (int)dt.Rows[0].ItemArray[2];
                //pt.MaKhachHang = (int)dt.Rows[0].ItemArray[3];                
                return pt;
            }

        }
        public static DataTable GetPhieuThuCondition(int MaPhieuThu)
        {
            string sql = "select * from PHIEUTHU,KHACHHANG where MaPhieuThu = " + MaPhieuThu;
            return DataAccess.ExcuQuery(sql);
        }
    }
}
