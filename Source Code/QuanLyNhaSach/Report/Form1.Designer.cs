namespace Report
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.thongKeMuaBanBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dtYear = new System.Windows.Forms.DateTimePicker();
            this.btnFinish = new System.Windows.Forms.Button();
            this.qLNhaSachDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLNhaSachDataSet = new Report.QLNhaSachDataSet();
            this.thongKeMuaBanTableAdapter = new Report.QLNhaSachDataSetTableAdapters.ThongKeMuaBanTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.thongKeMuaBanBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaSachDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaSachDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "DataSet1";
            reportDataSource2.Value = this.thongKeMuaBanBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Report.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1219, 391);
            this.reportViewer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập Năm Bắt Đầu Thống Kê";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(417, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(380, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Thống Kê Theo Tháng Trong 1 Năm";
            // 
            // thongKeMuaBanBindingSource
            // 
            this.thongKeMuaBanBindingSource.DataMember = "ThongKeMuaBan";
            this.thongKeMuaBanBindingSource.DataSource = this.qLNhaSachDataSetBindingSource;
            // 
            // dtYear
            // 
            this.dtYear.Location = new System.Drawing.Point(254, 72);
            this.dtYear.Name = "dtYear";
            this.dtYear.Size = new System.Drawing.Size(200, 20);
            this.dtYear.TabIndex = 3;
            this.dtYear.ValueChanged += new System.EventHandler(this.dtYear_ValueChanged);
            // 
            // btnFinish
            // 
            this.btnFinish.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinish.Location = new System.Drawing.Point(585, 69);
            this.btnFinish.Name = "btnFinish";
            this.btnFinish.Size = new System.Drawing.Size(75, 23);
            this.btnFinish.TabIndex = 4;
            this.btnFinish.Text = "Xong";
            this.btnFinish.UseVisualStyleBackColor = true;
            this.btnFinish.Click += new System.EventHandler(this.btnFinish_Click);
            // 
            // qLNhaSachDataSetBindingSource
            // 
            this.qLNhaSachDataSetBindingSource.DataSource = this.qLNhaSachDataSet;
            this.qLNhaSachDataSetBindingSource.Position = 0;
            // 
            // qLNhaSachDataSet
            // 
            this.qLNhaSachDataSet.DataSetName = "QLNhaSachDataSet";
            this.qLNhaSachDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // thongKeMuaBanTableAdapter
            // 
            this.thongKeMuaBanTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1248, 513);
            this.Controls.Add(this.btnFinish);
            this.Controls.Add(this.dtYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.thongKeMuaBanBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaSachDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLNhaSachDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource qLNhaSachDataSetBindingSource;
        private QLNhaSachDataSet qLNhaSachDataSet;
        private System.Windows.Forms.BindingSource thongKeMuaBanBindingSource;
        private QLNhaSachDataSetTableAdapters.ThongKeMuaBanTableAdapter thongKeMuaBanTableAdapter;
        private System.Windows.Forms.DateTimePicker dtYear;
        private System.Windows.Forms.Button btnFinish;
    }
}