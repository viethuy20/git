using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmdanhsachsach : Form
    {
        
        public static string laymasach;
        public static string laydongia;
        public frmdanhsachsach()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HienThiDanhSach()
        {
            dgvsach.DataSource = SachDAO.SelectSachAll();          

        }

        private void frmdanhsachsach_Load(object sender, EventArgs e)
        {
            
            colmatheloai.ValueMember = "MaTheLoai";
            colmatheloai.DisplayMember = "TenTheLoai";
            colmatheloai.DataSource = TheLoaiDAO.GetTheLoaiAll();
            HienThiDanhSach();
            cbTimTheLoai.ValueMember = "MaTheLoai";
            cbTimTheLoai.DisplayMember = "TenTheLoai";
            cbTimTheLoai.DataSource = TheLoaiDAO.GetTheLoaiAll();
        }

        private void dgvsach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsach.SelectedRows.Count > 0)
            {   
                laymasach = dgvsach.SelectedRows[0].Cells[0].Value.ToString();
                laydongia = dgvsach.SelectedRows[0].Cells[2].Value.ToString();

            }
        }       

        private void btnchon_Click(object sender, EventArgs e)
        {                   
            frmphieunhapsach.masach = laymasach;
            frmhoadonbansach.ms = laymasach;
            frmhoadonbansach.dongia = laydongia;
            this.Close();
        }

        private void radtatca_CheckedChanged(object sender, EventArgs e)
        {
            HienThiDanhSach();

        }

       
        private void radiotacgia_CheckedChanged(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            s.TacGia = txtthongtinsach.Text;
            dgvsach.DataSource = SachDAO.SelectSachLikeTacGia(s);
        }

        private void radtensach_CheckedChanged(object sender, EventArgs e)
        {
            SachDTO s = new SachDTO();
            s.TenSach = txtthongtinsach.Text;
            dgvsach.DataSource = SachDAO.SelectSachLikeName(s);
        }

        private void txtthongtinsach_TextChanged(object sender, EventArgs e)
        {
            if (radiotacgia.Checked == true)
            {
                SachDTO s = new SachDTO();
                s.TacGia = txtthongtinsach.Text;
                dgvsach.DataSource = SachDAO.SelectSachLikeTacGia(s);
            }
            if (radtatca.Checked == true)
            {
                HienThiDanhSach();
            }
            if (radtensach.Checked == true)
            {
                SachDTO s = new SachDTO();
                s.TenSach = txtthongtinsach.Text;
                dgvsach.DataSource = SachDAO.SelectSachLikeName(s);
            }
        }

        private void cbTimTheLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            string i = cbTimTheLoai.SelectedValue.ToString();
            HienThiDanhSach2(i);
        }
        public void HienThiDanhSach2(string ma)
        {
            SachDTO s = new SachDTO();
            s.MaTheLoai = int.Parse(ma);
            dgvsach.DataSource = SachDAO.SelectSachLikeMaTheLoai(s);
        }
        
    }
}