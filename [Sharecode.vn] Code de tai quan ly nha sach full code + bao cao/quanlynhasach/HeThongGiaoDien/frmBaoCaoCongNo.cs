using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using quanlynhasach.HeThongBaoCao;
using quanlynhasach.HeThongLuuTru;

namespace quanlynhasach.HeThongGiaoDien
{
    public partial class frmBaoCaoCongNo : Form
    {
        public frmBaoCaoCongNo()
        {
            InitializeComponent();
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {

            try
            {
                int thang = int.Parse(txtthang.Text);
                if (thang > 12)
                {
                    MessageBox.Show("Không có tháng nào lớn hơn 12");
                    return;

                }
                if (thang < 1)
                {
                    MessageBox.Show("Không có tháng nhỏ hơn tháng 1");
                    return;
                }
                frmrptcongno f = new frmrptcongno();
                rptBaoCaoCongNo rpt = new rptBaoCaoCongNo();
                rpt.SetDataSource(BaoCaoCongNoDAO.BaoCaoThang(thang));
                f.xembaocaocongno.ReportSource = rpt;
                f.Show();
            }
            catch (FormatException)
            {
                MessageBox.Show("Tháng không được bỏ trống và phải điền bằng số");
                return;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}