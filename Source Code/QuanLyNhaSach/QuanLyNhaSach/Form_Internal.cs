using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhaSach
{
    public partial class Form_Internal : Form
    {
        public Form_Internal()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            Form fmEmployee = new Form_Employee();
            fmEmployee.ShowDialog();
        }

        private void btnManager_Click(object sender, EventArgs e)
        {
            Form fmManager = new Form_Manager();
            fmManager.ShowDialog();
        }

        private void btnLeader_Click(object sender, EventArgs e)
        {
            Form fmLeader = new Form_Leader();
            fmLeader.ShowDialog();
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
    }
}
