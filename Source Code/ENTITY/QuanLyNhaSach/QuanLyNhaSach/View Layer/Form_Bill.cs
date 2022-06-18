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
    public partial class Form_Bill : Form
    {
        Pay pay = new Pay();
        string MaKH;
        public Form_Bill()
        {
            InitializeComponent();
            Load_Data();
        }
        public Form_Bill(string MaKH)
        {
            InitializeComponent();
            this.MaKH = MaKH;  
            Load_Data();
        }
        public void Load_Data()
        {
            string TenKH = null, MaSach = null;
            int SoLuong, ThanhTien;

            try
            {
                var result = pay.Pay_Bill(MaKH);
                TenKH = result.Item1;
                MaSach = result.Item2;
                SoLuong = result.Item3;
                ThanhTien = result.Item4;

                txtMaKH.Text = MaKH;
                //txtMaSach.Text = MaSach;
                txtSoLuon.Text = Convert.ToString(SoLuong);
                txtTenKH.Text = TenKH;
                txtThanhTien.Text = Convert.ToString(ThanhTien);
                txtTongTien.Text = Convert.ToString(ThanhTien);
            }
            catch
            {
                MessageBox.Show("Không thể in hóa đơn, lỗi rồi!!!");
            } 
            

            txtMaKH.Enabled = false;
            txtTenKH.Enabled = false;
            //txtMaSach.Enabled = false;
            txtSoLuon.Enabled = false;
            txtThanhTien.Enabled = false;
            txtTongTien.Enabled = false;
        }
    }
}
