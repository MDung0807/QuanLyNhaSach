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
    public partial class Form_Find_Book : Form
    {
        Find_Book find_book = new Find_Book();

        void Load_Data ()
        {
            try
            {
                // Đưa dữ liệu lên DataGridView
                dgvFindBook.DataSource = find_book.Lay_TT_Sach();
                // Thay đổi độ rộng cột
                dgvFindBook.AutoResizeColumns();
                // Xóa trống các đối tượng trong Panel
                this.txt_BookName.ResetText();
                // Không cho thao tác trên các nút Lưu / Hủy
                //this.btnLuu.Enabled = false;
                //this.btnHuy.Enabled = false;
                //this.panel.Enabled = false;
                // Cho thao tác trên các nút Thêm / Sửa / Xóa /Thoát
                //this.btnThem.Enabled = true;
                //this.btnSua.Enabled = true;
                //this.btnXoa.Enabled = true;
                //
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu");
            }
        }

        void Find_book()
        {
            string tua_sach = txt_BookName.Text.Trim();
            try
            {
                dgvFindBook.DataSource = find_book.Tim_Sach(tua_sach);
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu");
            }
        }
        public Form_Find_Book()
        {
            InitializeComponent();
            Load_Data();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find_book();
        }

        private void btnReLoad_Click(object sender, EventArgs e)
        {
            Load_Data();
        }
    }
}
