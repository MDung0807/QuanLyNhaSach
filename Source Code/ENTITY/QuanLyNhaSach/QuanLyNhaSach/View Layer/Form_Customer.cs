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
    public partial class Form_Customer : Form
    {
        string option = null;
        QLKhachHang dpKhachHang = new QLKhachHang();
        public Form_Customer()
        {
            InitializeComponent();
            Load_Data();
        }

        void Load_Data()
        {
            try
            {
                dgvQLKhachHang.DataSource = dpKhachHang.Lay_TT_Khach();
            }
            catch
            {
                MessageBox.Show("Không thể load dữ liệu");
            }
        }

        void Clear ()
        {
            txtAddress.ResetText();
            DateOfBirth.ResetText();
            txtHoTen.ResetText();
            txtMaKH.ResetText();
            txtSDT.ResetText();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.option = "Them";
            btnSearch.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.option = "Xoa";
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.option = "Sua";
            btnAdd.Enabled = false;
            btnSearch.Enabled = false;
            btnUpdate.Enabled = false;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.option = "Tim Kiem";
            btnAdd.Enabled = false;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            ReLoad();
        }
        void ReLoad ()
        {
            Load_Data();
            Clear();
            btnAdd.Enabled = true;
            btnDelete.Enabled = true;
            btnUpdate.Enabled = true;
            btnSearch.Enabled = true;
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (option == "Them")
            {
                try
                {
                    string MaKH, TenKH, DiaChi, SDT;
                    MaKH = txtMaKH.Text.Trim();
                    TenKH = txtHoTen.Text.Trim();
                    DiaChi = txtAddress.Text.Trim();
                    DateTime NgSinh = Convert.ToDateTime(DateOfBirth.Text);
                    SDT = txtSDT.Text.Trim();

                    dpKhachHang.Them_Khach_Hang(MaKH, TenKH, NgSinh, DiaChi, SDT);

                    MessageBox.Show("Bạn đã thêm thành công");
                    ReLoad();
                }
                catch
                {
                    MessageBox.Show("Không thể thêm dữ liệu");
                }
            }
            else if (option == "Xoa")
            {
                try
                {
                    string MaKH;
                    MaKH = txtMaKH.Text.Trim();
                    dpKhachHang.Xoa_KH(MaKH);

                    MessageBox.Show("Bạn đã xóa thành công");
                    ReLoad();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa dữ liệu");
                }
            }
            else if (option == "Sua")
            {
                try
                {
                    string MaKH, TenKH, DiaChi, SDT;
                    MaKH = txtMaKH.Text.Trim();
                    TenKH = txtHoTen.Text.Trim();
                    DiaChi = txtAddress.Text.Trim();
                    DateTime NgSinh = DateOfBirth.Value;
                    SDT = txtSDT.Text.Trim();

                    dpKhachHang.Cap_Nhat_TT_Khach_Hang(MaKH, TenKH, NgSinh, DiaChi, SDT);
                    MessageBox.Show("Cập nhật thành công");
                    ReLoad();
                }
                catch
                {
                    MessageBox.Show("Không thể cập nhật dữ liệu");
                }
            }
            else if (option == "Tim Kiem")
            {
                try
                {
                    string MaKH, TenKH;
                    MaKH = txtMaKH.Text.Trim();
                    TenKH = txtHoTen.Text.Trim();

                    dgvQLKhachHang.DataSource = dpKhachHang.Tim_Khach_Hang(MaKH, TenKH);
                }
                catch
                {
                    MessageBox.Show("Không thể cập nhật dữ liệu");
                }
            }

            else MessageBox.Show("Chưa chọn chức năng");
        }

        private void dgvQLKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvQLKhachHang.CurrentCell.RowIndex;

            txtMaKH.Text = dgvQLKhachHang.Rows[r].Cells[0].Value.ToString().Trim();
            txtHoTen.Text = dgvQLKhachHang.Rows[r].Cells[1].Value.ToString().Trim();
            txtAddress.Text = dgvQLKhachHang.Rows[r].Cells[2].Value.ToString().Trim();
            DateOfBirth.Value = Convert.ToDateTime(dgvQLKhachHang.Rows[r].Cells[3].Value.ToString());
            txtSDT.Text = dgvQLKhachHang.Rows[r].Cells[4].Value.ToString().Trim();
        }
    }
}
