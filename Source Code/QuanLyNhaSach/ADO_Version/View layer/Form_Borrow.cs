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
    public partial class Form_Borrow : Form
    {
        DataTable dtBorrow = null;
        string err;
        BLBorrow dbBr = new BLBorrow();
        public Form_Borrow()
        {
            InitializeComponent();
        }

        void LoadData()
        {
            try
            {
                dtBorrow = new DataTable();
                dtBorrow.Clear();

                DataSet ds = dbBr.LayDuLieu();
                dtBorrow = ds.Tables[0];

                dgvBORROW.DataSource = dtBorrow;
                dgvBORROW.AutoResizeColumns();

                dgvBORROW_CellClick(null, null);

            }
            catch (SqlException)
            {
                MessageBox.Show("Không lấy được nội dung trong table BORROW. Lỗi!!!");
            }
        }
        void LoadcmbCustomerID()
        {
            dtBorrow = new DataTable();
            dtBorrow.Clear();

            DataSet ds = dbBr.LayMaKhachHang();
            dtBorrow = ds.Tables[0];

            cmbCustomerID.ValueMember = "MaKH";
            cmbCustomerID.DataSource = dtBorrow;
        }
        void LoadcmbBookID()
        {
            dtBorrow = new DataTable();
            dtBorrow.Clear();

            DataSet ds = dbBr.LayMaCuon();
            dtBorrow = ds.Tables[0];

            cmbBookID.ValueMember = "MaCuon";
            cmbBookID.DataSource = dtBorrow;
        }
        private void Form_Borrow_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadcmbCustomerID();
            LoadcmbBookID();

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void dgvBORROW_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r = dgvBORROW.CurrentCell.RowIndex;

            cmbBookID.SelectedValue = dgvBORROW.Rows[r].Cells[0].Value.ToString();
            cmbCustomerID.SelectedValue = dgvBORROW.Rows[r].Cells[1].Value.ToString();
            
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (this.cmbBookID.SelectedValue == null)
            {
                MessageBox.Show("Đang có người mượn!");
                return;
            }    
            try
            {
                BLBorrow blBr = new BLBorrow();
                bool DangMuon = true;
                DateTime ngaymuon = DateTime.Today;
                DateTime hantra = new DateTime(ngaymuon.Year, ngaymuon.Month + 1, ngaymuon.Day);
                int r = dgvBORROW.CurrentCell.RowIndex;

                if (dgvBORROW.Rows[r].Cells[0].Value.ToString().Equals(cmbBookID.SelectedValue) &&
                    dgvBORROW.Rows[r].Cells[1].Value.ToString().Equals(cmbCustomerID.SelectedValue) &&
                    (bool)dgvBORROW.Rows[r].Cells[6].Value == false)
                {
                    blBr.CapNhatMuonSach(this.cmbBookID.SelectedValue.ToString(), this.cmbCustomerID.SelectedValue.ToString(), ngaymuon.ToString(), hantra.ToString(), DangMuon.ToString(), ref err);
                    blBr.CapNhatCuonSach(this.cmbBookID.SelectedValue.ToString(), DangMuon.ToString(), ref err);
                    LoadData();
                    MessageBox.Show("Đã mượn xong!");
                }
                else if (dgvBORROW.Rows[r].Cells[0].Value.ToString().Equals(cmbBookID.SelectedValue) &&
                    dgvBORROW.Rows[r].Cells[1].Value.ToString().Equals(cmbCustomerID.SelectedValue) &&
                    (bool)dgvBORROW.Rows[r].Cells[6].Value == true)
                {
                    LoadData();
                    MessageBox.Show("Đang có người mượn!");
                }
                else
                {
                    blBr.MuonSach(this.cmbBookID.SelectedValue.ToString(), this.cmbCustomerID.SelectedValue.ToString(), ngaymuon.ToString(), hantra.ToString(), DangMuon.ToString(), ref err);
                    blBr.CapNhatCuonSach(this.cmbBookID.SelectedValue.ToString(), DangMuon.ToString(), ref err);
                    LoadData();
                    MessageBox.Show("Đã mượn xong!");
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            try
            {
                BLBorrow blBr = new BLBorrow();
                bool DangMuon = false;
                int r = dgvBORROW.CurrentCell.RowIndex;
                DateTime ngaytra = DateTime.Today;
                int tienphat = 0;
                DateTime hantra = (DateTime)dgvBORROW.Rows[r].Cells[4].Value;
                double day = ngaytra.Subtract(hantra).TotalDays;
                if (this.cmbBookID.SelectedValue == null && (bool)dgvBORROW.Rows[r].Cells[6].Value == true)
                {
                    MessageBox.Show("Không thực hiện được!");
                    return;
                }    
                if (day > 0)
                {
                    tienphat = (int)day*5000;
                }    
                
                blBr.CapNhatTraSach(this.cmbBookID.SelectedValue.ToString(), this.cmbCustomerID.SelectedValue.ToString(), ngaytra.ToString(), tienphat.ToString(), DangMuon.ToString(), ref err);
                blBr.CapNhatCuonSach(this.cmbBookID.SelectedValue.ToString(), DangMuon.ToString(), ref err);
                LoadData();
                MessageBox.Show("Đã trả xong!");
            }
            catch (SqlException)
            {
                MessageBox.Show("Không tìm thấy thông tin!");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}