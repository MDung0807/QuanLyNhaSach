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
    public partial class Form_Borrow : Form
    {

        Muon_Sach muon_sach = new Muon_Sach();
        string option = null;
        string result;

        public Form_Borrow()
        {
            InitializeComponent();
            Load_Data();
        }

        void Load_Data () // Update data to the form
        {
            try
            {
                dgvMuon.DataSource = muon_sach.Lay_TT();
                Clear();
            }
            catch
            {
                MessageBox.Show("Không thể load data, lỗi rồi!!!");
            }
        }

        void Clear () // Delete data for txt
        {
            txtMaKH.ResetText();
            txtMaSach.ResetText();
        }

        private void btnBack_Click(object sender, EventArgs e) // back the form
        {
            this.Close();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
            btnBorrow.Enabled = true;
            btnReturn.Enabled = true;
            this.option = null;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            this.option = "Tra Sach";
            btnBorrow.Enabled = false;
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            this.option = "Muon Sach";
            btnReturn.Enabled = false;
        }

        private void dgvMuon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvMuon.CurrentCell.RowIndex;

            txtMaKH.Text = dgvMuon.Rows[r].Cells[0].Value.ToString().Trim(); 
            txtMaSach.Text = dgvMuon.Rows[r].Cells[2].Value.ToString().Trim();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {

            if (option == "Tra Sach")
            {
                try
                {
                    string MaKH = txtMaKH.Text.Trim();
                    string MaCuon = txtMaSach.Text.Trim();
                    muon_sach.KH_Tra_Sach(MaKH, MaCuon);
                    MessageBox.Show("Đã trả thành công");
                    Load_Data();
                    Clear();
                }
                catch
                {
                    MessageBox.Show("Trả không thành công, vui lòng kiểm tra lại mã khách hàng và mã cuốn");
                }
            }
            else if (option == "Muon Sach")
            {
                try
                {
                    string MaKH = txtMaKH.Text.Trim();
                    string MaCuon = txtMaSach.Text.Trim();
                    DateTime NgMuon = DateTime.Now;
                    muon_sach.KH_Muon_Sach(MaKH, MaCuon, NgMuon, ref result);
                    MessageBox.Show(result);
                    Load_Data();
                    Clear();
                }
                catch
                {
                    MessageBox.Show("Thêm không thành công, vui lòng kiểm tra lại mã khách hàng và mã cuốn");
                }
            }
            else
                MessageBox.Show("Chưa chọn chức năng");
        }
    }
}
