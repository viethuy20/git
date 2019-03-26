using System;
using System.Collections.Generic;
using System.Text;

namespace quanlynhasach.HeThongXuLy
{
    class ThamSoDTO
    {
        private int iMaThamSo;

        public int MaThamSo
        {
            get { return iMaThamSo; }
            set { iMaThamSo = value; }
        }
        private UInt64 uSoLuongNhapMin;

        public UInt64 SoLuongNhapMin
        {
            get { return uSoLuongNhapMin; }
            set { uSoLuongNhapMin = value; }
        }
        private UInt64 uLuongTonMin;

        public UInt64 LuongTonMin
        {
            get { return uLuongTonMin; }
            set { uLuongTonMin = value; }
        }
        private UInt64 uNoMin;

        public UInt64 NoMin
        {
            get { return uNoMin; }
            set { uNoMin = value; }
        }
        private UInt64 uTonSauKhiBan;

        public UInt64 TonSauKhiBan
        {
            get { return uTonSauKhiBan; }
            set { uTonSauKhiBan = value; }
        }
        private int iDieuKienThu;

        public int DieuKienThu
        {
            get { return iDieuKienThu; }
            set { iDieuKienThu = value; }
        }


    }
}
