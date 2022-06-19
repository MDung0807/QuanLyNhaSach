using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using EntityFramework_Version.BS_Layer;

namespace EntityFramework_Version.View_Layer
{
    public partial class Form_Buy_Pay : Form
    {
        DataTable dtPay = null;


        public Form_Buy_Pay()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
     
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table PAY. Lỗi!!!");
            }
        }

        private void Form_Pay_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbCustomerID();
        }
        void LoadcmbCustomerID()
        {
          
        }

        private void dgvPAY_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvPAY.CurrentCell.RowIndex;

            cmbCustomerID.SelectedValue = dgvPAY.Rows[r].Cells[0].Value.ToString();
            dtpDayOfBuy.Value = (DateTime)dgvPAY.Rows[r].Cells[1].Value;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnOutputBill_Click(object sender, EventArgs e)
        {

            Form form = new Form_Buy_Bill();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
