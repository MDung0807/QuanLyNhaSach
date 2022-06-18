using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyNhaSach.BS_Layer;

namespace QuanLyNhaSach.View_Layer
{
    public partial class Form_Thong_Ke_Doanh_Thu : Form
    {
        Thong_Ke thong_ke = new Thong_Ke();
        public Form_Thong_Ke_Doanh_Thu()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            var result = thong_ke.Thong_Ke_Tu_Viec_Mua_Va_Muon_Sach();
            txtThongKe_Ban.Text = Convert.ToString(result.Item2.ToString());
            txtThongKe_Muon.Text = Convert.ToString(result.Item1.ToString());
            txt_ThongKe_Phat.Text = Convert.ToString(result.Item3.ToString());
            txtTongTien.Text = Convert.ToString(result.Item1 + result.Item2 + result.Item3);
            dgv_ThongKeDauSach.DataSource = result.Item4;
        }
    }
}
