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
    
    
    public  partial class frmphieunhapsach : Form
    {
        public static string masach;
        
        public frmphieunhapsach()
        {
            InitializeComponent();
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void HienThiDanhSach()
        {
            dgvsach.DataSource = PhieuNhapDAO.SelectPhieuNhapChiTietAll();
            dsphieunhap.DataSource = PhieuNhapDAO.SelectPhieuNhapAll();
            
            
        }
        public void hienthimasach()
        {
            txtmasach.Text = masach;
        }
        private void frmphieunhapsach_Load(object sender, EventArgs e)
        {
            
            this.Size = new Size (369, 511);
            colcmbsach.DataSource = SachDAO.SelectSachAll();            
            colcmbsach.ValueMember = "MaSach";
            colcmbsach.DisplayMember = "TenSach";           
            colcbmtacgia.DataSource = SachDAO.SelectSachAll();
            colcbmtacgia.ValueMember = "MaSach";
            colcbmtacgia.DisplayMember = "TacGia";
            
            HienThiDanhSach();
           
            dtpick.Value = DateTime.Now;
            
            
        }

        private void dgvsach_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvsach.SelectedRows.Count > 0)
            {
                txtmaphieunhap.Text = dgvsach.SelectedRows[0].Cells[0].Value.ToString();
                txtmasach.Text = dgvsach.SelectedRows[0].Cells[1].Value.ToString();
                txtsoluong.Text = dgvsach.SelectedRows[0].Cells[2].Value.ToString(); 
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int dem = dsphieunhap.Rows.Count;
            this.Size = new Size(760, 511);
            PhieuNhapDTO p = new PhieuNhapDTO();
            p.NgayNhap = dtpick.Value;            

            if (PhieuNhapBUS.themphieunhap(p) == false)
            {
                MessageBox.Show("Tạo Phiếu Nhập thất bại");
                
            }
            HienThiDanhSach();
            txtmaphieunhap.Text = dsphieunhap.Rows[dem].Cells[0].Value.ToString();
        
        }

        private void dsphieunhap_SelectionChanged(object sender, EventArgs e)
        {
            if (dsphieunhap.SelectedRows.Count > 0)
            {
                txtmaphieunhap.Text = dsphieunhap.SelectedRows[0].Cells[0].Value.ToString();
                txtmasachauto.Text = dsphieunhap.SelectedRows[0].Cells[0].Value.ToString();
                
            }
        }

        private void btnbosungchitiet_Click(object sender, EventArgs e)
        {                        
            DataTable dt = ThamSoDAO.GetThamSoAll();
            int nhapmin = int.Parse(dt.Rows[0].ItemArray[1].ToString());            
            int luongtonmin = int.Parse(dt.Rows[0].ItemArray[2].ToString());
            
            PhieuNhapDTO p = new PhieuNhapDTO();
            try
            {

                if (txtmaphieunhap.Text != "")
                {
                    p.MaPhieuNhap = int.Parse(txtmaphieunhap.Text);
                    
                }
                else
                {
                    MessageBox.Show("Mã phiếu nhập không được để trống");
                    return;
                }
                if (txtmasach.Text != "")
                {
                    
                    p.MaSach = int.Parse(txtmasach.Text);
                    

                }
                else
                {
                    MessageBox.Show("Mã sách không được để trống");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Mã là số nguyên");
                return;
            }
            try
            {
                if (int.Parse(txtsoluong.Text) < nhapmin)
                {
                    MessageBox.Show("Số lượng phải lớn hơn số lượng quy định");
                    return;
                }
                else
                {
                    
                    p.SoLuong = int.Parse(txtsoluong.Text);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng phải là kiểu số");
                return;
            }
            DataTable dt2 = ThamSoDAO.SlectSoLuongTon(p.MaSach);
            int luongton = int.Parse(dt2.Rows[0].ItemArray[3].ToString());
            int soluongtonnew = luongton + int.Parse(txtsoluong.Text);
            if (luongton < luongtonmin)
            {
                if (PhieuNhapBUS.themchitietphieunhap(p) == false)
                {
                    MessageBox.Show("Sách này đã có trong phiếu!");
                }
                else
                {
                    
                    SachDTO s = new SachDTO();
                    s.MaSach = int.Parse(txtmasach.Text);
                    s.SoLuongTon = soluongtonnew;
                    SachDAO.UpdateSoLuongTon(s);                    
                    HienThiDanhSach();
                    BaoCaoTonDTO bc = new BaoCaoTonDTO();
                    bc.MaSach = s.MaSach;
                    bc.NgayPhatSinh = dtpick.Value;
                    bc.PhatSinh = "Phiếu nhập sách";
                    bc.TonDau = luongton;
                    bc.TonCuoi = soluongtonnew;
                    BaoCaoTonDAO.Insert(bc);
                    MessageBox.Show("Thành công");
                }
            }
            else
            {
                MessageBox.Show("Chỉ nhập các đầu sách có lượng tồn ít hơn theo quy định");
                
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmaphieunhap.Clear();
            txtmasach.Clear();
            txtsoluong.Clear();

        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            this.Size = new Size(760, 511);
        }

        private void btdong_Click(object sender, EventArgs e)
        {
            this.Size = new Size(369, 511);
        }

        private void btnmasach_Click(object sender, EventArgs e)
        {
            frmdanhsachsach f = new frmdanhsachsach();
            f.ShowDialog();
            hienthimasach();
        }

        

                              
         

        
        
    }
    
}