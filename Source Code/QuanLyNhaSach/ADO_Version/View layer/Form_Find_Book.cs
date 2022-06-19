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

namespace ADO_Version.View_layer
{
    public partial class Form_Find_Book : Form
    {
        DataTable dtFindBook = null;
        public Form_Find_Book()
        {
            InitializeComponent();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                BLFindBook blFB = new BLFindBook();
                dtFindBook = new DataTable();
                dtFindBook.Clear();

                DataSet ds = blFB.TimKiemSach(this.txtBookName.Text);
                dtFindBook = ds.Tables[0];

                dgvFINDBOOK.DataSource = dtFindBook;
                dgvFINDBOOK.AutoResizeColumns();

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void Form_Find_Book_Load(object sender, EventArgs e)
        {

        }
    }
}
