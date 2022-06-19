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
    public partial class Form_Pay : Form
    {

        Pay pay = new Pay();
        string option = null;
        public Form_Pay()
        {
            InitializeComponent();
            Load_Data();
        }

        void Load_Data ()
        {
            try
            {
                dgvPay.DataSource = pay.Lay_TT_Pay();
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu");
            }

            dgvPay.AutoResizeColumns();
            this.option = null;
            this.btnBill.Enabled = false;
        }
        private void btnBill_Click(object sender, EventArgs e)
        {
           

            string MaKH = txtMaKH.Text.Trim();

            Form_Bill fmBill = new Form_Bill(MaKH);
            fmBill.ShowDialog();

            try
            {
                pay.DaThanhToan(MaKH);
            }
            catch
            {
                MessageBox.Show("khong thanh cong");
            }


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string MaKH = txtMaKH.Text.Trim();
            dgvPay.DataSource = pay.Tim_KH(MaKH);
            btnBill.Enabled = true;
        }

        private void dgvPay_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPay.CurrentCell.RowIndex;

            txtMaCuon.Text = dgvPay.Rows[r].Cells[0].Value.ToString().Trim();
            txtMaKH.Text = dgvPay.Rows[r].Cells[1].Value.ToString().Trim();
        }
    }
}
