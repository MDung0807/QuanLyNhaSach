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
    public partial class Form_SignUp : Form
    {
        string err;
        public Form_SignUp()
        {
            InitializeComponent();
        }
        
        private void Form_SignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            try
            {
                BLSignUp blSingUp = new BLSignUp();
                // thêm thông tin vào table NhanVien
                blSingUp.ThemNhanVien(this.txtStaffID.Text, this.txtFullName.Text, this.txtJob.Text, this.txtIncome.Text, this.txtAddress.Text, this.dtpDayOfBirth.Value.ToString(), this.cbSex.Checked.ToString(), this.txtPhone.Text, ref err);
                
                // thêm thông tin vào table TaiKhoan
                string quyen = "Nhanvien";
                blSingUp.ThemTaiKhoan(this.txtStaffID.Text, quyen, this.txtUsername.Text, this.txtPassword.Text, ref err);
                
                if (this.txtConfirmPass.Text == this.txtPassword.Text)
                    MessageBox.Show("Đã thêm xong!");
                else
                {
                    MessageBox.Show("Vui lòng xác nhận lại mật khẩu!");
                    this.txtPassword.ResetText();
                    this.txtConfirmPass.ResetText();
                    this.txtPassword.Focus();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Không thêm được. Lỗi rồi!");
            }
        }
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtPassword.PasswordChar = '✽';
        }

        private void txtConfirmPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.txtConfirmPass.PasswordChar = '✽';
        }

        private void ptbPassinvisible1_Click(object sender, EventArgs e)
        {
            if (this.ptbPassinvisible1.Visible == false)
            {
                this.ptbPassvisible1.Visible = false;
                this.ptbPassinvisible1.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible1.Visible = true;
                this.ptbPassinvisible1.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void ptbPassvisible1_Click(object sender, EventArgs e)
        {
            if (this.ptbPassvisible1.Visible == true)
            {
                this.ptbPassvisible1.Visible = false;
                this.ptbPassinvisible1.Visible = true;
                this.txtPassword.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible1.Visible = true;
                this.ptbPassinvisible1.Visible = false;
                txtPassword.PasswordChar = '✽';
            }
        }

        private void ptbPassinvisible2_Click(object sender, EventArgs e)
        {
            if (this.ptbPassinvisible2.Visible == false)
            {
                this.ptbPassvisible2.Visible = false;
                this.ptbPassinvisible2.Visible = true;
                this.txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible2.Visible = true;
                this.ptbPassinvisible2.Visible = false;
                this.txtConfirmPass.PasswordChar = '✽';
            }
        }

        private void ptbPassvisible2_Click(object sender, EventArgs e)
        {
            if (this.ptbPassvisible2.Visible == true)
            {
                this.ptbPassvisible2.Visible = false;
                this.ptbPassinvisible2.Visible = true;
                this.txtConfirmPass.PasswordChar = '\0';
            }
            else
            {
                this.ptbPassvisible2.Visible = true;
                this.ptbPassinvisible2.Visible = false;
                this.txtConfirmPass.PasswordChar = '✽';
            }
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
