using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;
using QuanLyNhaSach;
using System.IO;
using System.Diagnostics;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmquanlykhachhang : Form
    {
        public frmquanlykhachhang()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            try
            {
                if (txttenkh.Text != "")
                {
                    kh.HoTenKhachHang = txttenkh.Text;
                }
                else
                {
                    MessageBox.Show("Tên khách hàng không được để trống", "Thông báo");
                    return;
                }
                if (txtdienthoai.Text != "")
                {
                    kh.DienThoai = int.Parse(txtdienthoai.Text);
                }
                else
                {
                    MessageBox.Show("Điện thoại không được để trống", "Thông báo");
                    return;
                }
                if (txtdiachi.Text != "")
                {
                    kh.DiaChi = txtdiachi.Text;
                }
                else
                {
                    MessageBox.Show("Địa chỉ không được để trống", "Thông báo");
                    return;
                }
                if (txtemail.Text != "")
                {
                    kh.Email = txtemail.Text;
                }
                else
                {
                    MessageBox.Show("Email không được để trống", "Thông báo");
                    return;
                }            
                              
                
            }
            catch(FormatException)
            {
                MessageBox.Show("Điện thoại phải là số", "Thông báo");
                return;
            }
            
            if (KhachHangBUS.ThemKhachHang(kh) == false)
            {
                MessageBox.Show("Dữ liệu nhập đã có trong cơ sở dữ liệu", "Thông báo");
                return;
            }
            HienThiDanhSach();
        }

        private void frmquanlykhachhang_Load(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public void HienThiDanhSach()
        {
            dskhachhang.DataSource = KhachHangDAO.GetKhachHangAll();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            
            kh.MaKhachHang = int.Parse(txtmakh.Text);
            if (KhachHangBUS.XoaKhachHang(kh) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            HienThiDanhSach();
        }

        private void dskhachhang_SelectionChanged(object sender, EventArgs e)
        {
            if (dskhachhang.SelectedRows.Count > 0)
            {
                txtmakh.Text = dskhachhang.SelectedRows[0].Cells[0].Value.ToString();
                txttenkh.Text = dskhachhang.SelectedRows[0].Cells[1].Value.ToString();
                txtdienthoai.Text = dskhachhang.SelectedRows[0].Cells[2].Value.ToString();
                txtdiachi.Text = dskhachhang.SelectedRows[0].Cells[3].Value.ToString();
                txtemail.Text = dskhachhang.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            KhachHangDTO kh = new KhachHangDTO();
            kh.MaKhachHang = int.Parse(txtmakh.Text);
            kh.HoTenKhachHang = txttenkh.Text;
            kh.DienThoai = int.Parse(txtdienthoai.Text);
            kh.DiaChi = txtdiachi.Text;
            kh.Email = txtemail.Text;
            if (KhachHangBUS.SuaKhachHang(kh) == false)
            {
                MessageBox.Show("Cập nhật thất bại", "Thông báo");
            }
            HienThiDanhSach();
        }

        private void txttimkiem_TextChanged(object sender, EventArgs e)
        {
            if (radtenkh.Checked == true)
            {
                timkiemtenkh();
            }
            if (raddiachi.Checked == true)
            {
                timkiemdiachi();
            }
            if (raddienthoai.Checked == true)
            {
                timkiemdienthoai();
            }
            if (rademail.Checked == true)
            {
                timkiememail();
            }
        }

        private void radtenkh_CheckedChanged(object sender, EventArgs e)
        {
            timkiemtenkh();
        }
        

        private void raddiachi_CheckedChanged(object sender, EventArgs e)
        {
            timkiemdiachi();
        }

        private void raddienthoai_CheckedChanged(object sender, EventArgs e)
        {
            txttimkiem.Text = "0";
            timkiemdienthoai();

        }

        private void rademail_CheckedChanged(object sender, EventArgs e)
        {
            timkiememail();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmakh.Clear();
            txtdienthoai.Clear();
            txttenkh.Clear();
            txtemail.Clear();
            txtdiachi.Clear();
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            HienThiDanhSach();
        }
        public void timkiemtenkh()
        {

            KhachHangDTO kh = new KhachHangDTO();
            kh.HoTenKhachHang = txttimkiem.Text;
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeTen(kh);
        }
        public void timkiemdiachi()
        {

            KhachHangDTO kh = new KhachHangDTO();
            kh.DiaChi = txttimkiem.Text;
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeDiaChi(kh);
        }
        public void timkiememail()
        {

            KhachHangDTO kh = new KhachHangDTO();
            kh.Email = txttimkiem.Text;
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeEmail(kh);
        }
        public void timkiemdienthoai()
        {

            KhachHangDTO kh = new KhachHangDTO();
            try
            {
                kh.DienThoai = Int64.Parse(txttimkiem.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Điện thoại phải điền vào số", "Thông báo");
                return;
            }
            dskhachhang.DataSource = KhachHangDAO.SelectKhachHangLikeDienThoai(kh);
        }

        private void btnimport_Click(object sender, EventArgs e)
        {
            string oldPath = Directory.GetCurrentDirectory();
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();
            string strPathName = of.FileName;
            Directory.SetCurrentDirectory(oldPath);
            DataTable dt = ExcelRead.getSheet(strPathName, "sheet1");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.HoTenKhachHang = dt.Rows[i].ItemArray[1].ToString();
                kh.DienThoai = int.Parse(dt.Rows[i].ItemArray[2].ToString());
                kh.DiaChi = dt.Rows[i].ItemArray[3].ToString();
                kh.Email = dt.Rows[i].ItemArray[4].ToString();
                KhachHangDAO.Insert(kh);
            }
            MessageBox.Show("Import dữ liệu thành công ...", "Thông báo");
            HienThiDanhSach();
        }

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

            string oldPath = Directory.GetCurrentDirectory();
            SaveFileDialog sf = new SaveFileDialog();
            sf.ShowDialog();
            string strFileName = sf.FileName;
            Directory.SetCurrentDirectory(oldPath);
            ExcelWrite myExcel = new ExcelWrite();
            List<String> list = myExcel.DGVToExcel(dskhachhang);
            String filePath = Directory.GetCurrentDirectory() + strFileName;
            myExcel.WriteDateToExcel(strFileName, list, "A1", "E1", "A2");
            MessageBox.Show("Export dữ liệu thành công...", "Thông báo");
            Process.Start(strFileName);
        }
       
    }
}