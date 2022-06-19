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
    public partial class Form_Borrow_Bill : Form
    {
        public Form_Borrow_Bill()
        {
            InitializeComponent();
        }

        private void Form_Borrow_Bill_Load(object sender, EventArgs e)
        {
            this.txtBookID.Text = Form_Borrow_Pay.maCuon;
            this.txtCustomerID.Text = Form_Borrow_Pay.maKH;
            this.txtDayOfBorrow.Text = Form_Borrow_Pay.ngaymuon;
            this.txtReturnDeadline.Text = Form_Borrow_Pay.hantra;
            this.txtPrice.Text = Form_Borrow_Pay.dongia;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
