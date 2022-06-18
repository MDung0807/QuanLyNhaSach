namespace QuanLyNhaSach.View_Layer
{
    partial class Form_Pay
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
            this.btnReload = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBill = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaCuon = new System.Windows.Forms.ComboBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPay = new System.Windows.Forms.DataGridView();
            this.txtMaCuon = new System.Windows.Forms.TextBox();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.btnReload);
            this.panel1.Controls.Add(this.btnBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 7;
            // 
            // btnReload
            // 
            this.btnReload.Location = new System.Drawing.Point(713, 62);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(75, 23);
            this.btnReload.TabIndex = 2;
            this.btnReload.Text = "Reload";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.label1.Size = new System.Drawing.Size(160, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thanh Toán";
            // 
            // btnBill
            // 
            this.btnBill.Location = new System.Drawing.Point(399, 291);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(137, 23);
            this.btnBill.TabIndex = 10;
            this.btnBill.Text = "Xuât Hóa Đơn";
            this.btnBill.UseVisualStyleBackColor = true;
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(251, 291);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 8;
            this.btnFind.Text = "Tìm Kiếm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mã Cuốn";
            // 
            // cbMaCuon
            // 
            this.cbMaCuon.FormattingEnabled = true;
            this.cbMaCuon.Location = new System.Drawing.Point(486, 161);
            this.cbMaCuon.Name = "cbMaCuon";
            this.cbMaCuon.Size = new System.Drawing.Size(121, 21);
            this.cbMaCuon.TabIndex = 12;
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(486, 225);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(121, 21);
            this.cbMaKH.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(147, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mã Khách Hàng";
            // 
            // dgvPay
            // 
            this.dgvPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPay.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvPay.Location = new System.Drawing.Point(0, 354);
            this.dgvPay.Name = "dgvPay";
            this.dgvPay.Size = new System.Drawing.Size(800, 96);
            this.dgvPay.TabIndex = 15;
            this.dgvPay.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPay_CellClick);
            // 
            // txtMaCuon
            // 
            this.txtMaCuon.Location = new System.Drawing.Point(273, 166);
            this.txtMaCuon.Name = "txtMaCuon";
            this.txtMaCuon.Size = new System.Drawing.Size(100, 20);
            this.txtMaCuon.TabIndex = 16;
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(273, 230);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(100, 20);
            this.txtMaKH.TabIndex = 17;
            // 
            // Form_Pay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.txtMaCuon);
            this.Controls.Add(this.dgvPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.cbMaCuon);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnFind);
            this.Name = "Form_Pay";
            this.Text = "Form_Pay";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBill;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaCuon;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPay;
        private System.Windows.Forms.TextBox txtMaCuon;
        private System.Windows.Forms.TextBox txtMaKH;
    }
}