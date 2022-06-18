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
    public partial class Form_Internal : Form
    {
        string quyen = null;


        Login Login = new Login();

        public Form_Internal()
        {
            InitializeComponent();
        }

        private void radioNhanVien_CheckedChanged(object sender, EventArgs e)
        {
            this.quyen = "Nhanvien";
        }

        private void radioQuanLy_CheckedChanged(object sender, EventArgs e)
        {
            this.quyen = "Quanli";
        }

        private void btnLeader_Click(object sender, EventArgs e)
        {
            //Form fmLeader = new Form_Leader();
            //fmLeader.ShowDialog();
        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            Form fmFindPass = new Form_Forget_Password();
            fmFindPass.ShowDialog();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text.Trim();
            string pass = txtPassword.Text.Trim();
            if (quyen == "Nhanvien")
            {
                if (Login.Check_Login_IsTrue(user, pass, quyen))
                {

                    Form fmEmployee = new Form_Employee("Nhân Viên " + user);
                    fmEmployee.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Nhập sai tên người dùng hoặc mật khẩu");
                }
            }    
            else if (quyen == "Quanli")
            {
                if (Login.Check_Login_IsTrue(user, pass, quyen))
                {
                    Form fmManager = new Form_Manager();
                    fmManager.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Nhập sai tên người dùng hoặc mật khẩu");
                }
            }
        }

       
    }
}
