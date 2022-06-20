using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFramework_Version.BS_Layer;

namespace EntityFramework_Version.View_Layer
{
    public partial class Form_Thong_Ke_Doanh_Thu : Form
    {
        Thong_Ke thong_ke = new Thong_Ke();
        string option;
        public Form_Thong_Ke_Doanh_Thu()
        {
            InitializeComponent();
            txtThongKe_Ban.Enabled = false;
            txtThongKe_Muon.Enabled = false;
            txtTongTien.Enabled = false;
            txt_ThongKe_Phat.Enabled = false;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            try
            {
                var result = thong_ke.TK_Hoat_Dong_Mua_Ban(option, Convert.ToDateTime(dtNgayBatDau.Value));
                dgv_ThongKeLoiNhuan.DataSource = result.Item1;

                txtThongKe_Ban.Text = Convert.ToString(result.Item4.ToString());
                txtThongKe_Muon.Text = Convert.ToString(result.Item2.ToString());
                txt_ThongKe_Phat.Text = Convert.ToString(result.Item3.ToString());
                txtTongTien.Text = Convert.ToString(result.Item2 + result.Item3 + result.Item4);
                dgv_ThongKeDauSach.DataSource = thong_ke.Thong_Ke_SL_Sach_Tren_Moi_Dau_Sach();
            }
            catch
            {
                MessageBox.Show("Không thể thực hiện tác vụ, lỗi rồi!!!");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbThang_CheckedChanged(object sender, EventArgs e)
        {
            this.option = "Moth";
        }

        private void rbNam_CheckedChanged(object sender, EventArgs e)
        {
            this.option = "Year";
        }
    }
}
