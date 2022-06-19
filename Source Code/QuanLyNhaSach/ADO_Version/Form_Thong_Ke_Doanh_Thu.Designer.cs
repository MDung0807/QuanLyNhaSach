
namespace ADO_Version
{
    partial class Form_Thong_Ke_Doanh_Thu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgv_ThongKeDauSach = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.txt_ThongKe_Phat = new System.Windows.Forms.TextBox();
            this.txtThongKe_Muon = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.txtThongKe_Ban = new System.Windows.Forms.TextBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TuaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeDauSach)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_ThongKeDauSach
            // 
            this.dgv_ThongKeDauSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ThongKeDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeDauSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TuaSach,
            this.SoLuong});
            this.dgv_ThongKeDauSach.Location = new System.Drawing.Point(16, 233);
            this.dgv_ThongKeDauSach.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_ThongKeDauSach.Name = "dgv_ThongKeDauSach";
            this.dgv_ThongKeDauSach.ReadOnly = true;
            this.dgv_ThongKeDauSach.RowHeadersWidth = 51;
            this.dgv_ThongKeDauSach.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_ThongKeDauSach.Size = new System.Drawing.Size(432, 277);
            this.dgv_ThongKeDauSach.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 196);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(344, 23);
            this.label6.TabIndex = 36;
            this.label6.Text = "Số Lượng sách còn lại trên mỗi đầu sách";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(916, 380);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(132, 22);
            this.txtTongTien.TabIndex = 35;
            // 
            // txt_ThongKe_Phat
            // 
            this.txt_ThongKe_Phat.Location = new System.Drawing.Point(916, 315);
            this.txt_ThongKe_Phat.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ThongKe_Phat.Name = "txt_ThongKe_Phat";
            this.txt_ThongKe_Phat.Size = new System.Drawing.Size(132, 22);
            this.txt_ThongKe_Phat.TabIndex = 34;
            // 
            // txtThongKe_Muon
            // 
            this.txtThongKe_Muon.Location = new System.Drawing.Point(916, 254);
            this.txtThongKe_Muon.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongKe_Muon.Name = "txtThongKe_Muon";
            this.txtThongKe_Muon.Size = new System.Drawing.Size(132, 22);
            this.txtThongKe_Muon.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(653, 379);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Tổng số tiền thu được";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(528, 253);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(352, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Số tiền nhận được từ việc cho mượn sách";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(569, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(300, 23);
            this.label2.TabIndex = 29;
            this.label2.Text = "Số tiền nhận được từ việc bán sách";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(533, 423);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(100, 28);
            this.btnThongKe.TabIndex = 28;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            // 
            // txtThongKe_Ban
            // 
            this.txtThongKe_Ban.Location = new System.Drawing.Point(916, 207);
            this.txtThongKe_Ban.Margin = new System.Windows.Forms.Padding(4);
            this.txtThongKe_Ban.Name = "txtThongKe_Ban";
            this.txtThongKe_Ban.Size = new System.Drawing.Size(132, 22);
            this.txtThongKe_Ban.TabIndex = 27;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(951, 15);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(569, 313);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 23);
            this.label4.TabIndex = 31;
            this.label4.Text = "Số tiền nhận được từ việc nộp phạt";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 123);
            this.panel1.TabIndex = 26;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.ReadOnly = true;
            // 
            // TuaSach
            // 
            this.TuaSach.DataPropertyName = "TuaSach";
            this.TuaSach.HeaderText = "Tựa Sách";
            this.TuaSach.MinimumWidth = 6;
            this.TuaSach.Name = "TuaSach";
            this.TuaSach.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // Form_Thong_Ke_Doanh_Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.dgv_ThongKeDauSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txt_ThongKe_Phat);
            this.Controls.Add(this.txtThongKe_Muon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtThongKe_Ban);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Thong_Ke_Doanh_Thu";
            this.Text = "Form_Thong_Ke_Doanh_Thu";
            this.Load += new System.EventHandler(this.Form_Thong_Ke_Doanh_Thu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeDauSach)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgv_ThongKeDauSach;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.TextBox txt_ThongKe_Phat;
        private System.Windows.Forms.TextBox txtThongKe_Muon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.TextBox txtThongKe_Ban;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TuaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}