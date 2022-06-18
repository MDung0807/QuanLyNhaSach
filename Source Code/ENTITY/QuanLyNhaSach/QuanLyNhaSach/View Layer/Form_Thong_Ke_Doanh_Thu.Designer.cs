namespace QuanLyNhaSach.View_Layer
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThongKe_Ban = new System.Windows.Forms.TextBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtThongKe_Muon = new System.Windows.Forms.TextBox();
            this.txt_ThongKe_Phat = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_ThongKeDauSach = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeDauSach)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 13;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(713, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(309, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống Kê Doanh Thu";
            // 
            // txtThongKe_Ban
            // 
            this.txtThongKe_Ban.Location = new System.Drawing.Point(482, 116);
            this.txtThongKe_Ban.Name = "txtThongKe_Ban";
            this.txtThongKe_Ban.Size = new System.Drawing.Size(100, 20);
            this.txtThongKe_Ban.TabIndex = 14;
            // 
            // btnThongKe
            // 
            this.btnThongKe.Location = new System.Drawing.Point(401, 291);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(75, 23);
            this.btnThongKe.TabIndex = 15;
            this.btnThongKe.Text = "Thống Kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(227, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Số tiền nhận được từ việc bán sách";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Số tiền nhận được từ việc cho mượn sách";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(227, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Số tiền nhận được từ việc nộp phạt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tổng số tiền thu được";
            // 
            // txtThongKe_Muon
            // 
            this.txtThongKe_Muon.Location = new System.Drawing.Point(482, 154);
            this.txtThongKe_Muon.Name = "txtThongKe_Muon";
            this.txtThongKe_Muon.Size = new System.Drawing.Size(100, 20);
            this.txtThongKe_Muon.TabIndex = 20;
            // 
            // txt_ThongKe_Phat
            // 
            this.txt_ThongKe_Phat.Location = new System.Drawing.Point(482, 203);
            this.txt_ThongKe_Phat.Name = "txt_ThongKe_Phat";
            this.txt_ThongKe_Phat.Size = new System.Drawing.Size(100, 20);
            this.txt_ThongKe_Phat.TabIndex = 21;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(482, 256);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(100, 20);
            this.txtTongTien.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(340, 329);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Số Lượng sách còn lại trên mỗi đầu sách";
            // 
            // dgv_ThongKeDauSach
            // 
            this.dgv_ThongKeDauSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ThongKeDauSach.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_ThongKeDauSach.Location = new System.Drawing.Point(0, 360);
            this.dgv_ThongKeDauSach.Name = "dgv_ThongKeDauSach";
            this.dgv_ThongKeDauSach.Size = new System.Drawing.Size(800, 90);
            this.dgv_ThongKeDauSach.TabIndex = 25;
            // 
            // Form_Thong_Ke_Doanh_Thu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgv_ThongKeDauSach);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txt_ThongKe_Phat);
            this.Controls.Add(this.txtThongKe_Muon);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.txtThongKe_Ban);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Thong_Ke_Doanh_Thu";
            this.Text = "Thong_Ke_Doanh_Thu";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ThongKeDauSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtThongKe_Ban;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtThongKe_Muon;
        private System.Windows.Forms.TextBox txt_ThongKe_Phat;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgv_ThongKeDauSach;
    }
}