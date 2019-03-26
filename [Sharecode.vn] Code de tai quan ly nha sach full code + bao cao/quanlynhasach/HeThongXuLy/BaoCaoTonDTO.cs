using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class BaoCaoTonDTO
    {
        private int iMaBaoCao;

        public int MaBaoCao
        {
            get { return iMaBaoCao; }
            set { iMaBaoCao = value; }
        }
        private int iMaSach;

        public int MaSach
        {
            get { return iMaSach; }
            set { iMaSach = value; }
        }
        private DateTime dNgayPhatSinh;

        public DateTime NgayPhatSinh
        {
            get { return dNgayPhatSinh; }
            set { dNgayPhatSinh = value; }
        }
        private int iTonDau;

        public int TonDau
        {
            get { return iTonDau; }
            set { iTonDau = value; }
        }
        private string strPhatSinh;

        public string PhatSinh
        {
            get { return strPhatSinh; }
            set { strPhatSinh = value; }
        }
        private int iTonCuoi;

        public int TonCuoi
        {
            get { return iTonCuoi; }
            set { iTonCuoi = value; }
        }
    }
}
