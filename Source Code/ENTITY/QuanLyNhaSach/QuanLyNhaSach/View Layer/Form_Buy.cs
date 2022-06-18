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
    public partial class Form_Buy : Form
    {
        string result;
        Mua_Sach buy = new Mua_Sach();

        public Form_Buy()
        {
            InitializeComponent();
            Load_Data();
        }

        void Load_Data()
        {
            try
            {
                dgvBuy.DataSource = buy.Lay_TT_Mua();
                Clear();
            }
            catch
            {
                MessageBox.Show("Không thể load data, lỗi rồi!!!");
            }
        }

        void Clear ()
        {
            this.txtMaCuon.ResetText();
            this.txtMaKH.ResetText();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                string MaKH = txtMaKH.Text.Trim();
                string MaCuon = txtMaCuon.Text.Trim();
                DateTime NgMuon = DateTime.Now;

                buy.Them_KH_Mua(MaKH, MaCuon, NgMuon, ref result);
                MessageBox.Show(result);
                Load_Data();
                Clear();
            }
            catch
            {
                MessageBox.Show("Thêm vào giỏ hàng không thành công, vui lòng kiểm tra lại tên và mã cuốn sách");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void dgvBuy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBuy.CurrentCell.RowIndex;

            txtMaKH.Text = dgvBuy.Rows[r].Cells[0].Value.ToString().Trim();
            txtMaCuon.Text = dgvBuy.Rows[r].Cells[2].Value.ToString().Trim();
        }
    }
}
