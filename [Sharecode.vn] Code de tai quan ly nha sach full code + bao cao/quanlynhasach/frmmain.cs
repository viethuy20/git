using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongGiaoDien;
using System.Diagnostics;

namespace quanlynhasach
{
    public partial class frmmain : Form
    {
        public frmmain()
        {
            InitializeComponent();
        }

        private void phiếuNhậpSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmphieunhapsach f = new frmphieunhapsach();
            f.MdiParent = this;
            f.Show();
        }

        private void hóaĐơnBánSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmhoadonbansach f = new frmhoadonbansach();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchSáchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmdanhsachsach f = new frmdanhsachsach();
            f.MdiParent = this;
            f.Show();

        }

        private void quảnLýSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlysach f = new frmquanlysach();
            f.MdiParent = this;
            f.Show();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlykhachhang f = new frmquanlykhachhang();
            f.MdiParent = this;
            f.Show();
        }

        private void lậpPhiếuThuTiềnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmphieuthutien f = new frmphieuthutien();
            f.MdiParent = this;
            f.Show();
        }

        private void frmmain_Load(object sender, EventArgs e)
        {

        }

        private void quảnLýThểLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmquanlytheloai f = new frmquanlytheloai();
            f.MdiParent = this;
            f.Show();
        }

        private void vềChươngTrìnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongtin f = new frmthongtin();
            f.MdiParent = this;
            f.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void danhSáchKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdanhsachkhachhang f = new frmdanhsachkhachhang();
            f.MdiParent = this;
            f.Show();
        }

        private void thayĐổiQuyĐịnhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthaydoiquydinh f = new frmthaydoiquydinh();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmdanhsachsach f = new frmdanhsachsach();
            f.MdiParent = this;
            f.Show();
        }

        private void danhSáchKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmdanhsachkhachhang f = new frmdanhsachkhachhang();
            f.MdiParent = this;
            f.Show();
        }

        private void lậpBáoCáoThángToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoTon f = new frmBaoCaoTon();
            f.MdiParent = this;
            f.Show();
        }

        private void báoCáoCôngNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBaoCaoCongNo f = new frmBaoCaoCongNo();
            f.MdiParent = this;
            f.Show();
        }

        private void trợGiúpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Process.Start("help.chm");
        }
        
    }
}