using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class NguoiDungDTO
    {
        string m_strTenNguoiDung;

        public string TenNguoiDung
        {
            get { return m_strTenNguoiDung; }
            set { m_strTenNguoiDung = value; }
        }
        string m_strMatKhau;

        public string MatKhau
        {
            get { return m_strMatKhau; }
            set { m_strMatKhau = value; }
        }
        string m_strPhanQuyen;

        public string PhanQuyen
        {
            get { return m_strPhanQuyen; }
            set { m_strPhanQuyen = value; }
        }
    }
}
