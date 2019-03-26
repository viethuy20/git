using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongLuuTru;
using quanlynhasach.HeThongXuLy;
using quanlynhasach.HeThongBaoCao;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmphieuthutien : Form
    {

        public Int64 luusotienthu;
        public static string makh;
        public frmphieuthutien()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnkh_Click(object sender, EventArgs e)
        {
            frmdanhsachkhachhang f = new frmdanhsachkhachhang();
            f.ShowDialog();
            hienthimakhachhang();
        }

        private void frmphieuthutien_Load(object sender, EventArgs e)
        {
            colcmbkh.DataSource = KhachHangDAO.GetKhachHangAll();
            colcmbkh.ValueMember = "MaKhachHang";
            colcmbkh.DisplayMember = "HoTenKhachHang";
            hienthiphieuthu();
        }
        public void hienthimakhachhang()
        {
            txtmakh.Text = makh;
        }
        public void hienthiphieuthu()
        {
            dgvphieuthutien.DataSource = PhieuThuDAO.GetPhieuThuAll();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            PhieuThuDTO pt = new PhieuThuDTO();
            try
            {
                pt.MaKhachHang = int.Parse(txtmakh.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống");
                btnkh_Click(sender, e);
                return;
            }            
            pt.NgayThu = dtngaythutien.Value;

            DataTable dt = ThamSoDAO.GetThamSoAll();
            int ktchophep = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            DataTable dt2 = ThamSoDAO.SlectTienNoKH(int.Parse(txtmakh.Text));
            int tienno = int.Parse(dt2.Rows[0].ItemArray[5].ToString());
            Int64 tienthu = Int64.Parse(txtsotien.Text);
            
            try
            {
                pt.SoTienThu = UInt64.Parse(txtsotien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thu chưa nhập đúng quy định");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiền thu không được âm");
                return;
            }
            if (ktchophep == 1)
            {
                if (tienno < tienthu)
                {
                    MessageBox.Show("Tiền thu đã lớn hơn tiền khách hàng đang nợ");
                    return;
                }
            }
            Int64 tiennonew = tienno - tienthu;
            
            if (PhieuThuBUS.ThemPhieuThu(pt) == false)
            {
                MessageBox.Show("Thêm thất bại", "Thông báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = int.Parse(txtmakh.Text);
                kh.TienNo = tiennonew;
                KhachHangDAO.UpdateTienNo(kh);
                BaoCaoCongNoDTO cn = new BaoCaoCongNoDTO();
                cn.MaKhachHang = kh.MaKhachHang;
                cn.NgayPhatSinh = pt.NgayThu;
                cn.NoDau = tienno;
                cn.NoCuoi = tiennonew;
                cn.PhatSinh = "Phiếu thu tiền";
                BaoCaoCongNoDAO.Insert(cn);
                MessageBox.Show("Thành công");
                hienthiphieuthu();
            }
            
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {

            PhieuThuDTO pt = new PhieuThuDTO();
            pt.MaPhieuThu = int.Parse(txtmaphieuthu.Text);
            if (PhieuThuBUS.XoaPhieuThu(pt) == false)
            {
                MessageBox.Show("Xóa thất bại", "Thông báo");
            }
            hienthiphieuthu();
        }

        private void dgvphieuthutien_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvphieuthutien.SelectedRows.Count > 0)
            {
                txtmaphieuthu.Text = dgvphieuthutien.SelectedRows[0].Cells[0].Value.ToString();
                dtngaythutien.Text = dgvphieuthutien.SelectedRows[0].Cells[1].Value.ToString();
                txtsotien.Text = dgvphieuthutien.SelectedRows[0].Cells[2].Value.ToString();
                luusotienthu = Int64.Parse(dgvphieuthutien.SelectedRows[0].Cells[2].Value.ToString());
                txtmakh.Text = dgvphieuthutien.SelectedRows[0].Cells[3].Value.ToString();
                
            }
        }

        private void btncapnhat_Click(object sender, EventArgs e)
        {
            PhieuThuDTO pt = new PhieuThuDTO();           
            pt.MaPhieuThu = int.Parse(txtmaphieuthu.Text);
            pt.NgayThu = dtngaythutien.Value;
            try
            {
                int kh = int.Parse(txtmakh.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Mã khách hàng không được bỏ trống");
                btnkh_Click(sender, e);
                return;
            }
            DataTable dt = ThamSoDAO.GetThamSoAll();
            int ktchophep = int.Parse(dt.Rows[0].ItemArray[5].ToString());
            DataTable dt2 = ThamSoDAO.SlectTienNoKH(int.Parse(txtmakh.Text));
            int tienno = int.Parse(dt2.Rows[0].ItemArray[5].ToString());
            Int64 tienthu = Int64.Parse(txtsotien.Text);
           
            
            try
            {
                pt.SoTienThu = UInt64.Parse(txtsotien.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Số tiền thu chưa nhập đúng quy định");
                return;
            }
            catch (OverflowException)
            {
                MessageBox.Show("Số tiền thu không được âm");
                return;
            }
            if (ktchophep == 1)
            {
                if (tienno < tienthu)
                {
                    MessageBox.Show("Tiền thu đã lớn hơn tiền khách hàng đang nợ");
                    return;
                }
            }
            Int64 tienthunew = tienthu - luusotienthu;
            Int64 tiennonew = tienno - tienthunew;
            

            if (PhieuThuBUS.SuaPhieuThu(pt) == false)
            {
                MessageBox.Show("Sửa thất bại", "Thông báo");
            }
            else
            {
                KhachHangDTO kh = new KhachHangDTO();
                kh.MaKhachHang = int.Parse(txtmakh.Text);
                kh.TienNo = tiennonew;
                KhachHangDAO.UpdateTienNo(kh);
                BaoCaoCongNoDTO cn = new BaoCaoCongNoDTO();
                cn.MaKhachHang = kh.MaKhachHang;
                cn.NgayPhatSinh = pt.NgayThu;
                cn.NoDau = tienno;
                cn.NoCuoi = tiennonew;
                cn.PhatSinh = "Cập nhật phiếu thu tiền";
                BaoCaoCongNoDAO.Insert(cn);
                MessageBox.Show("Thành công");

                hienthiphieuthu();
            }
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtsotien.Clear();
            txtmakh.Clear();
        }

        private void btnprint_Click(object sender, EventArgs e)
        {
            frminphieuthu f = new frminphieuthu();
            rptphieuthutien rpt = new rptphieuthutien();
            rpt.SetDataSource(PhieuThuDAO.GetPhieuThuCondition(int.Parse(txtmaphieuthu.Text)));
            f.viewinphieuthu.ReportSource = rpt;
            f.Show();
        }
    }
}