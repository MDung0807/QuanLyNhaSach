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
    public partial class Form_Forget_Password : Form
    {
        Find_Pass find_pass = new Find_Pass();
        public Form_Forget_Password()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFindPass_Click(object sender, EventArgs e)
        {
            try
            {
                string MaNV = txtMaNV.Text.Trim();
                string TenNV = txtUsername.Text.Trim();
                string SDT = txtSDT.Text.Trim();

                dgvFindPass.DataSource = find_pass.Tim_MK(MaNV, TenNV, SDT);
                dgvFindPass.AutoResizeColumns();
                MessageBox.Show("Đã tìm được tên tài khoản và mật khẩu");

            }
            catch
            {
                MessageBox.Show("Không thể tìm tên tài khoản và mật khẩu");
            }
        }
    }
}
