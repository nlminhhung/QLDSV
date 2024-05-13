namespace QLDSV
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_xeploai = new System.Windows.Forms.TextBox();
            this.label_xeploai = new System.Windows.Forms.Label();
            this.label_ngaysinh = new System.Windows.Forms.Label();
            this.date_ngaysinh = new System.Windows.Forms.DateTimePicker();
            this.tb_diemso = new System.Windows.Forms.TextBox();
            this.label_diemso = new System.Windows.Forms.Label();
            this.tb_tsv = new System.Windows.Forms.TextBox();
            this.label_tensv = new System.Windows.Forms.Label();
            this.tb_mssv = new System.Windows.Forms.TextBox();
            this.label_mssv = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bangSinhVien = new System.Windows.Forms.DataGridView();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tENSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIEMSODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nGAYSINHDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xEPLOAIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.sinhVienBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.firstDBDataSet1 = new QLDSV.firstDBDataSet1();
            this.button_them = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_thoat = new System.Windows.Forms.Button();
            this.firstDBDataSet = new QLDSV.firstDBDataSet1();
            this.sinhVienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sinhVienTableAdapter = new QLDSV.firstDBDataSet1TableAdapters.SinhVienTableAdapter();
            this.sinhVienTableAdapter1 = new QLDSV.firstDBDataSet1TableAdapters.SinhVienTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bangSinhVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.groupBox1.Controls.Add(this.tb_xeploai);
            this.groupBox1.Controls.Add(this.label_xeploai);
            this.groupBox1.Controls.Add(this.label_ngaysinh);
            this.groupBox1.Controls.Add(this.date_ngaysinh);
            this.groupBox1.Controls.Add(this.tb_diemso);
            this.groupBox1.Controls.Add(this.label_diemso);
            this.groupBox1.Controls.Add(this.tb_tsv);
            this.groupBox1.Controls.Add(this.label_tensv);
            this.groupBox1.Controls.Add(this.tb_mssv);
            this.groupBox1.Controls.Add(this.label_mssv);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 179);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhap thong tin";
            // 
            // tb_xeploai
            // 
            this.tb_xeploai.Location = new System.Drawing.Point(363, 130);
            this.tb_xeploai.Name = "tb_xeploai";
            this.tb_xeploai.Size = new System.Drawing.Size(141, 29);
            this.tb_xeploai.TabIndex = 7;
            // 
            // label_xeploai
            // 
            this.label_xeploai.AutoSize = true;
            this.label_xeploai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xeploai.Location = new System.Drawing.Point(290, 139);
            this.label_xeploai.Name = "label_xeploai";
            this.label_xeploai.Size = new System.Drawing.Size(60, 16);
            this.label_xeploai.TabIndex = 8;
            this.label_xeploai.Text = "Xep Loai";
            // 
            // label_ngaysinh
            // 
            this.label_ngaysinh.AutoSize = true;
            this.label_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngaysinh.Location = new System.Drawing.Point(290, 92);
            this.label_ngaysinh.Name = "label_ngaysinh";
            this.label_ngaysinh.Size = new System.Drawing.Size(67, 16);
            this.label_ngaysinh.TabIndex = 6;
            this.label_ngaysinh.Text = "Ngay sinh";
            // 
            // date_ngaysinh
            // 
            this.date_ngaysinh.CustomFormat = "";
            this.date_ngaysinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_ngaysinh.Location = new System.Drawing.Point(363, 87);
            this.date_ngaysinh.Name = "date_ngaysinh";
            this.date_ngaysinh.Size = new System.Drawing.Size(252, 22);
            this.date_ngaysinh.TabIndex = 1;
            // 
            // tb_diemso
            // 
            this.tb_diemso.Location = new System.Drawing.Point(363, 36);
            this.tb_diemso.Name = "tb_diemso";
            this.tb_diemso.Size = new System.Drawing.Size(141, 29);
            this.tb_diemso.TabIndex = 4;
            // 
            // label_diemso
            // 
            this.label_diemso.AutoSize = true;
            this.label_diemso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_diemso.Location = new System.Drawing.Point(290, 45);
            this.label_diemso.Name = "label_diemso";
            this.label_diemso.Size = new System.Drawing.Size(57, 16);
            this.label_diemso.TabIndex = 5;
            this.label_diemso.Text = "Diem so";
            // 
            // tb_tsv
            // 
            this.tb_tsv.Location = new System.Drawing.Point(109, 83);
            this.tb_tsv.Name = "tb_tsv";
            this.tb_tsv.Size = new System.Drawing.Size(141, 29);
            this.tb_tsv.TabIndex = 2;
            // 
            // label_tensv
            // 
            this.label_tensv.AutoSize = true;
            this.label_tensv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tensv.Location = new System.Drawing.Point(6, 90);
            this.label_tensv.Name = "label_tensv";
            this.label_tensv.Size = new System.Drawing.Size(90, 16);
            this.label_tensv.TabIndex = 3;
            this.label_tensv.Text = "Ten Sinh Vien";
            // 
            // tb_mssv
            // 
            this.tb_mssv.Location = new System.Drawing.Point(109, 36);
            this.tb_mssv.Name = "tb_mssv";
            this.tb_mssv.Size = new System.Drawing.Size(141, 29);
            this.tb_mssv.TabIndex = 1;
            // 
            // label_mssv
            // 
            this.label_mssv.AutoSize = true;
            this.label_mssv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mssv.Location = new System.Drawing.Point(17, 45);
            this.label_mssv.Name = "label_mssv";
            this.label_mssv.Size = new System.Drawing.Size(45, 16);
            this.label_mssv.TabIndex = 1;
            this.label_mssv.Text = "MSSV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bangSinhVien);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(9, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(899, 226);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sach sinh vien";
            // 
            // bangSinhVien
            // 
            this.bangSinhVien.AllowUserToAddRows = false;
            this.bangSinhVien.AutoGenerateColumns = false;
            this.bangSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bangSinhVien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSSVDataGridViewTextBoxColumn,
            this.tENSVDataGridViewTextBoxColumn,
            this.dIEMSODataGridViewTextBoxColumn,
            this.nGAYSINHDataGridViewTextBoxColumn,
            this.xEPLOAIDataGridViewTextBoxColumn,
            this.checkedbox});
            this.bangSinhVien.DataSource = this.sinhVienBindingSource1;
            this.bangSinhVien.Location = new System.Drawing.Point(20, 28);
            this.bangSinhVien.Name = "bangSinhVien";
            this.bangSinhVien.Size = new System.Drawing.Size(856, 192);
            this.bangSinhVien.TabIndex = 6;
            this.bangSinhVien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bangSinhVien_CellClick);
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            this.mSSVDataGridViewTextBoxColumn.Width = 150;
            // 
            // tENSVDataGridViewTextBoxColumn
            // 
            this.tENSVDataGridViewTextBoxColumn.DataPropertyName = "TENSV";
            this.tENSVDataGridViewTextBoxColumn.HeaderText = "TEN SINH VIEN";
            this.tENSVDataGridViewTextBoxColumn.Name = "tENSVDataGridViewTextBoxColumn";
            this.tENSVDataGridViewTextBoxColumn.Width = 150;
            // 
            // dIEMSODataGridViewTextBoxColumn
            // 
            this.dIEMSODataGridViewTextBoxColumn.DataPropertyName = "DIEMSO";
            this.dIEMSODataGridViewTextBoxColumn.HeaderText = "DIEM SO";
            this.dIEMSODataGridViewTextBoxColumn.Name = "dIEMSODataGridViewTextBoxColumn";
            // 
            // nGAYSINHDataGridViewTextBoxColumn
            // 
            this.nGAYSINHDataGridViewTextBoxColumn.DataPropertyName = "NGAYSINH";
            this.nGAYSINHDataGridViewTextBoxColumn.HeaderText = "NGAY SINH";
            this.nGAYSINHDataGridViewTextBoxColumn.Name = "nGAYSINHDataGridViewTextBoxColumn";
            this.nGAYSINHDataGridViewTextBoxColumn.Width = 150;
            // 
            // xEPLOAIDataGridViewTextBoxColumn
            // 
            this.xEPLOAIDataGridViewTextBoxColumn.DataPropertyName = "XEPLOAI";
            this.xEPLOAIDataGridViewTextBoxColumn.HeaderText = "XEP LOAI";
            this.xEPLOAIDataGridViewTextBoxColumn.Name = "xEPLOAIDataGridViewTextBoxColumn";
            this.xEPLOAIDataGridViewTextBoxColumn.Width = 150;
            // 
            // checkedbox
            // 
            this.checkedbox.FalseValue = "false";
            this.checkedbox.HeaderText = "Checked";
            this.checkedbox.Name = "checkedbox";
            this.checkedbox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkedbox.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.checkedbox.TrueValue = "true";
            // 
            // sinhVienBindingSource1
            // 
            this.sinhVienBindingSource1.DataMember = "SinhVien";
            this.sinhVienBindingSource1.DataSource = this.firstDBDataSet1;
            // 
            // firstDBDataSet1
            // 
            this.firstDBDataSet1.DataSetName = "firstDBDataSet1";
            this.firstDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button_them
            // 
            this.button_them.Location = new System.Drawing.Point(9, 483);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(152, 37);
            this.button_them.TabIndex = 2;
            this.button_them.Text = "Them";
            this.button_them.UseVisualStyleBackColor = true;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Location = new System.Drawing.Point(207, 483);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(152, 37);
            this.button_xoa.TabIndex = 3;
            this.button_xoa.Text = "Xoa";
            this.button_xoa.UseVisualStyleBackColor = true;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Location = new System.Drawing.Point(415, 483);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(152, 37);
            this.button_sua.TabIndex = 4;
            this.button_sua.Text = "Sua";
            this.button_sua.UseVisualStyleBackColor = true;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_thoat
            // 
            this.button_thoat.Location = new System.Drawing.Point(660, 483);
            this.button_thoat.Name = "button_thoat";
            this.button_thoat.Size = new System.Drawing.Size(152, 37);
            this.button_thoat.TabIndex = 5;
            this.button_thoat.Text = "Thoat chuong trinh";
            this.button_thoat.UseVisualStyleBackColor = true;
            this.button_thoat.Click += new System.EventHandler(this.button_thoat_Click);
            // 
            // firstDBDataSet
            // 
            this.firstDBDataSet.DataSetName = "firstDBDataSet";
            this.firstDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sinhVienBindingSource
            // 
            this.sinhVienBindingSource.DataMember = "SinhVien";
            this.sinhVienBindingSource.DataSource = this.firstDBDataSet;
            // 
            // sinhVienTableAdapter
            // 
            this.sinhVienTableAdapter.ClearBeforeFill = true;
            // 
            // sinhVienTableAdapter1
            // 
            this.sinhVienTableAdapter1.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(610, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "CHUONG TRINH QUAN LY DIEM SINH VIEN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 549);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_thoat);
            this.Controls.Add(this.button_sua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bangSinhVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sinhVienBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label_mssv;
        private System.Windows.Forms.TextBox tb_diemso;
        private System.Windows.Forms.Label label_diemso;
        private System.Windows.Forms.TextBox tb_tsv;
        private System.Windows.Forms.Label label_tensv;
        private System.Windows.Forms.TextBox tb_mssv;
        private System.Windows.Forms.TextBox tb_xeploai;
        private System.Windows.Forms.Label label_xeploai;
        private System.Windows.Forms.Label label_ngaysinh;
        private System.Windows.Forms.DateTimePicker date_ngaysinh;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_thoat;
        private System.Windows.Forms.DataGridView bangSinhVien;
        private firstDBDataSet1 firstDBDataSet;
        private System.Windows.Forms.BindingSource sinhVienBindingSource;
        private firstDBDataSet1TableAdapters.SinhVienTableAdapter sinhVienTableAdapter;
        private firstDBDataSet1 firstDBDataSet1;
        private System.Windows.Forms.BindingSource sinhVienBindingSource1;
        private firstDBDataSet1TableAdapters.SinhVienTableAdapter sinhVienTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tENSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIEMSODataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nGAYSINHDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xEPLOAIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedbox;
    }
}

