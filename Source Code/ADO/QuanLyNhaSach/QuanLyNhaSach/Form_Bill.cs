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
using QuanLyNhaSach.BS_layer;

namespace QuanLyNhaSach
{
    public partial class Form_Bill : Form
    {
        public Form_Bill()
        {
            InitializeComponent();
        }

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            this.txtCustomerID.Text = Form_Pay.maKH;
            this.txtDayOfBuy.Text = Form_Pay.ngaymua;
            this.txtQuantity.Text = Form_Pay.soluong;
            this.txtTotalPrice.Text = Form_Pay.thanhtien;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
