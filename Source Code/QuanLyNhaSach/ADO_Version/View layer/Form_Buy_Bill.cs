﻿using System;
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
    public partial class Form_Buy_Bill : Form
    {
        public Form_Buy_Bill()
        {
            InitializeComponent();
        }

        private void Form_Bill_Load(object sender, EventArgs e)
        {
            this.txtCustomerID.Text = Form_Buy_Pay.maKH;
            this.txtDayOfBuy.Text = Form_Buy_Pay.ngaymua;
            this.txtQuantity.Text = Form_Buy_Pay.soluong;
            this.txtTotalPrice.Text = Form_Buy_Pay.thanhtien;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}