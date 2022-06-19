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
