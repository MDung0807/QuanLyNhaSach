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
using ADO_Version.BS_layer;

namespace ADO_Version
{
    public partial class Form_Thong_Ke_Doanh_Thu : Form
    {
        DataTable dtThongKe = null;
        string err;
        BLThongKe dbTK = new BLThongKe();
        public Form_Thong_Ke_Doanh_Thu()
        {
            InitializeComponent();
        }
        void LoadData()
        {
            try
            {
                dtThongKe = new DataTable();
                dtThongKe.Clear();

                DataSet ds = dbTK.LayDuLieu();
                dtThongKe = ds.Tables[0];

                dgv_ThongKeDauSach.DataSource = dtThongKe;
                dgv_ThongKeDauSach.AutoResizeColumns();
            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung . Lỗi!!!");
            }
        }
        private void Form_Thong_Ke_Doanh_Thu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
