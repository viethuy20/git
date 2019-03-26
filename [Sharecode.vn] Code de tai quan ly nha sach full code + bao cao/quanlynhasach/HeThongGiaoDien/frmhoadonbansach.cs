using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongXuLy;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmhoadonbansach : Form
    {
        public static string makh;
        public static string ms;
        public static string dongia;

        public frmhoadonbansach()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnmakh_Click(object sender, EventArgs e)
        {
            frmdanhsachkhachhang f = new frmdanhsachkhachhang();
            f.ShowDialog();
            hienthimakhachhang();
            
        }

        private void frmhoadonbansach_Load(object sender, EventArgs e)
        {
            txtdongia.Text = "0";
            thunho();
            dtngaylaphoadon.Value = DateTime.Now;
          
            colcbmkh.DataSource = KhachHangDAO.GetKhachHangAll();
            colcbmkh.ValueMember = "MaKhachHang";
            colcbmkh.DisplayMember = "HoTenKhachHang";
            colcmbmasach.DataSource = SachDAO.SelectSachAll();
            colcmbmasach.ValueMember = "MaSach";
            colcmbmasach.DisplayMember = "TenSach";
            coldongia.DataSource = SachDAO.SelectSachAll();
            coldongia.ValueMember = "MaSach";
            coldongia.DisplayMember = "GiaBan";
           
            hienthidshoadon();
            hienthidscthoadon();
        }
        public void hienthimakhachhang()
        {
            txtmakh.Text = makh;
        }
        public void hienthimasach()
        {
            txtmasach.Text = ms;
            txtdongia.Text = dongia;
        }
        public void hienthidshoadon()
        {
            dshoadon.DataSource = HoaDonDAO.SelectallHoaDon();
        }
        public void hienthidscthoadon()
        {
            dshoadonchitiet.DataSource = HoaDonDAO.SelectallHoaDonChiTiet();
        }

        private void btnmasach_Click(object sender, EventArgs e)
        {
            frmdanhsachsach f = new frmdanhsachsach();
            f.ShowDialog();
            hienthimasach();            
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int dem = dshoadon.Rows.Count;
            HoaDonDTO hd = new HoaDonDTO();
            try
            {
                hd.MaKhachHang = int.Parse(txtmakh.Text);
            }
            catch(FormatException)
            {
                MessageBox.Show("Phải chọn Khách Hàng từ danh sách");
                btnmakh_Click(sender, e);
                return;
            }
            hd.NgayLapHoaDon = dtngaylaphoadon.Value;
            if (HoaDonBUS.ThemHoaDon(hd) == false)
            {
                MessageBox.Show("Thêm thất bại");
                return;
            }
            hienthidshoadon();
            txtmahdct.Text = dshoadon.Rows[dem].Cells[0].Value.ToString();
            txtmakhct.Text = dshoadon.Rows[dem].Cells[2].Value.ToString();
            phongto();

        }

        private void dshoadon_SelectionChanged(object sender, EventArgs e)
        {
            if (dshoadon.SelectedRows.Count > 0)
            {
                txtmahd.Text = dshoadon.SelectedRows[0].Cells[0].Value.ToString();
                txtmahdct.Text = dshoadon.SelectedRows[0].Cells[0].Value.ToString();
                txtmakhct.Text = dshoadon.SelectedRows[0].Cells[2].Value.ToString();
                txtmakh.Text = dshoadon.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void dshoadonchitiet_SelectionChanged(object sender, EventArgs e)
        {
            if (dshoadonchitiet.SelectedRows.Count > 0)
            {

                txtmahdct.Text = dshoadonchitiet.SelectedRows[0].Cells[0].Value.ToString();
                txtmasach.Text = dshoadonchitiet.SelectedRows[0].Cells[1].Value.ToString();
                txtsoluongmua.Text = dshoadonchitiet.SelectedRows[0].Cells[2].Value.ToString();

            }
        }

        private void btnbosung_Click(object sender, EventArgs e)
        {
            DataTable dt = ThamSoDAO.GetThamSoAll();
            int nomax = int.Parse(dt.Rows[0].ItemArray[3].ToString());
            int luongtonaftersell= int.Parse(dt.Rows[0].ItemArray[4].ToString());
            DataTable dt2 = ThamSoDAO.SlectTienNoKH(int.Parse(txtmakhct.Text));
            int tienno = int.Parse(dt2.Rows[0].ItemArray[5].ToString()); 
    
            HoaDonDTO hd = new HoaDonDTO();
            try
            {
                hd.MaHoaDon = int.Parse(txtmahdct.Text);      
            }
            catch (FormatException)
            {
                MessageBox.Show("Không được để trống");
                return;
            }
            try 
            {
                hd.MaSach = int.Parse(txtmasach.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã sách phải được chọn từ danh sách");
                btnmasach_Click(sender, e);
                return;
            }
            try
            {
                hd.SoLuongMua = uint.Parse(txtsoluongmua.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số lượng mua phải là số và không được để trống");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số lượng không được âm");
            }
            if (tienno <= nomax)
            {
                DataTable dt3 = ThamSoDAO.SlectSoLuongTon(hd.MaSach);
                int luongton = int.Parse(dt3.Rows[0].ItemArray[3].ToString());
                int luongmua = int.Parse(txtsoluongmua.Text);
                int tongtien = tienno + ( luongmua * int.Parse(txtdongia.Text));
                if ((luongton - luongmua) < luongtonaftersell)
                {
                    MessageBox.Show("Số lượng tồn của sách này sau khi bán đã nhỏ hơn quy định");
                    return;
                }
                if (HoaDonBUS.ThemHoaDonChiTiet(hd) == false)
                {
                    MessageBox.Show("Sách này đã có rồi");
                }
                else
                {   
                    int soluongtonnew = luongton - luongmua;
                    SachDTO s = new SachDTO();
                    s.MaSach = int.Parse(txtmasach.Text);
                    s.SoLuongTon = soluongtonnew;
                    SachDAO.UpdateSoLuongTon(s);
                    KhachHangDTO kh = new KhachHangDTO();
                    kh.MaKhachHang = int.Parse(txtmakhct.Text);
                    kh.TienNo = tongtien;
                    KhachHangDAO.UpdateTienNo(kh);
                    BaoCaoTonDTO bc = new BaoCaoTonDTO();
                    bc.MaSach = s.MaSach;
                    bc.NgayPhatSinh = dtngaylaphoadon.Value;
                    bc.PhatSinh = "Bán sách";
                    bc.TonDau = luongton;
                    bc.TonCuoi = soluongtonnew;
                    BaoCaoTonDAO.Insert(bc);
                    BaoCaoCongNoDTO cn = new BaoCaoCongNoDTO();
                    cn.MaKhachHang = kh.MaKhachHang;
                    cn.NgayPhatSinh = bc.NgayPhatSinh;
                    cn.NoDau = tienno;
                    cn.NoCuoi = tongtien;
                    cn.PhatSinh = "Hóa đơn bán sách";
                    BaoCaoCongNoDAO.Insert(cn);
                    MessageBox.Show("Thành công");
                    hienthidscthoadon();
                }
            }
            else
            {
                MessageBox.Show("Tiền nợ quý khách đã quá quy định để mua sách");
            }
            
        }

        private void btndong_Click(object sender, EventArgs e)
        {
            thunho();
        }

        private void btnbsct_Click(object sender, EventArgs e)
        {
            phongto();
        }
        public void phongto()
        {
            this.Size = new Size(804, 451);
        }
        public void thunho()
        {
            this.Size = new Size(384, 451);
        }
        public void thanhtien()
        {
            
            if (int.Parse(txtdongia.Text) >0)
            {

                UInt64 thanhtien = UInt64.Parse(txtsoluongmua.Text) * UInt64.Parse(txtdongia.Text);

                txtthanhtien.Text = thanhtien.ToString();
            }
            else
            {
                MessageBox.Show("Bạn phải chọn sách để lấy đơn giá");
                return;
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtsoluongmua.Clear();
        }

        private void txtsoluongmua_Leave(object sender, EventArgs e)
        {
            thanhtien();
        }
    }
}