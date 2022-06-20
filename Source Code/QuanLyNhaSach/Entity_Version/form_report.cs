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

namespace EntityFramework_Version
{
    public partial class form_report : Form
    {
        Thong_Ke thong_ke = new Thong_Ke();
        public form_report()
        {
            InitializeComponent();
        }

        private void form_report_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime NG = Convert.ToDateTime("2022-1-1");
            var result = thong_ke.TK_Hoat_Dong_Mua_Ban("moth", NG);
            dataGridView1.DataSource = result.Item1;
        }
    }
}
