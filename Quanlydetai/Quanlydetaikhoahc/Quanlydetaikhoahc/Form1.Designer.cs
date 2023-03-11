
namespace Quanlydetaikhoahc
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
            this.cb_gv = new System.Windows.Forms.GroupBox();
            this.CbTengv = new System.Windows.Forms.ComboBox();
            this.cbNamTH = new System.Windows.Forms.ComboBox();
            this.cbMan = new System.Windows.Forms.ComboBox();
            this.cbLinhvuc = new System.Windows.Forms.ComboBox();
            this.tbDiem = new System.Windows.Forms.TextBox();
            this.tbTendt = new System.Windows.Forms.TextBox();
            this.tbMadt = new System.Windows.Forms.TextBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_baocao = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_timkiem = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.lb_namTH = new System.Windows.Forms.Label();
            this.lb_man = new System.Windows.Forms.Label();
            this.lb_gv = new System.Windows.Forms.Label();
            this.lb_diem = new System.Windows.Forms.Label();
            this.lb_linhvuc = new System.Windows.Forms.Label();
            this.lb_tendt = new System.Windows.Forms.Label();
            this.lb_madt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDeTai = new System.Windows.Forms.DataGridView();
            this.MaDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NamTH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Diem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cb_gv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).BeginInit();
            this.SuspendLayout();
            // 
            // cb_gv
            // 
            this.cb_gv.Controls.Add(this.CbTengv);
            this.cb_gv.Controls.Add(this.cbNamTH);
            this.cb_gv.Controls.Add(this.cbMan);
            this.cb_gv.Controls.Add(this.cbLinhvuc);
            this.cb_gv.Controls.Add(this.tbDiem);
            this.cb_gv.Controls.Add(this.tbTendt);
            this.cb_gv.Controls.Add(this.tbMadt);
            this.cb_gv.Controls.Add(this.btn_thoat);
            this.cb_gv.Controls.Add(this.btn_baocao);
            this.cb_gv.Controls.Add(this.btn_boqua);
            this.cb_gv.Controls.Add(this.btn_timkiem);
            this.cb_gv.Controls.Add(this.btn_xoa);
            this.cb_gv.Controls.Add(this.btn_sua);
            this.cb_gv.Controls.Add(this.btn_them);
            this.cb_gv.Controls.Add(this.lb_namTH);
            this.cb_gv.Controls.Add(this.lb_man);
            this.cb_gv.Controls.Add(this.lb_gv);
            this.cb_gv.Controls.Add(this.lb_diem);
            this.cb_gv.Controls.Add(this.lb_linhvuc);
            this.cb_gv.Controls.Add(this.lb_tendt);
            this.cb_gv.Controls.Add(this.lb_madt);
            this.cb_gv.Location = new System.Drawing.Point(13, 45);
            this.cb_gv.Margin = new System.Windows.Forms.Padding(4);
            this.cb_gv.Name = "cb_gv";
            this.cb_gv.Padding = new System.Windows.Forms.Padding(4);
            this.cb_gv.Size = new System.Drawing.Size(1001, 318);
            this.cb_gv.TabIndex = 3;
            this.cb_gv.TabStop = false;
            this.cb_gv.Text = "Thông tin đề tài";
            // 
            // CbTengv
            // 
            this.CbTengv.FormattingEnabled = true;
            this.CbTengv.Location = new System.Drawing.Point(644, 39);
            this.CbTengv.Margin = new System.Windows.Forms.Padding(4);
            this.CbTengv.Name = "CbTengv";
            this.CbTengv.Size = new System.Drawing.Size(280, 24);
            this.CbTengv.TabIndex = 22;
            // 
            // cbNamTH
            // 
            this.cbNamTH.FormattingEnabled = true;
            this.cbNamTH.Items.AddRange(new object[] {
            "2015-2016",
            "2016-2017",
            "2018-2019",
            "2019-2020",
            "2020-2021",
            "2021-2022",
            "2022-2023"});
            this.cbNamTH.Location = new System.Drawing.Point(644, 123);
            this.cbNamTH.Margin = new System.Windows.Forms.Padding(4);
            this.cbNamTH.Name = "cbNamTH";
            this.cbNamTH.Size = new System.Drawing.Size(280, 24);
            this.cbNamTH.TabIndex = 21;
            // 
            // cbMan
            // 
            this.cbMan.FormattingEnabled = true;
            this.cbMan.Location = new System.Drawing.Point(644, 82);
            this.cbMan.Margin = new System.Windows.Forms.Padding(4);
            this.cbMan.Name = "cbMan";
            this.cbMan.Size = new System.Drawing.Size(280, 24);
            this.cbMan.TabIndex = 20;
            // 
            // cbLinhvuc
            // 
            this.cbLinhvuc.FormattingEnabled = true;
            this.cbLinhvuc.Location = new System.Drawing.Point(120, 191);
            this.cbLinhvuc.Margin = new System.Windows.Forms.Padding(4);
            this.cbLinhvuc.Name = "cbLinhvuc";
            this.cbLinhvuc.Size = new System.Drawing.Size(280, 24);
            this.cbLinhvuc.TabIndex = 18;
            // 
            // tbDiem
            // 
            this.tbDiem.Location = new System.Drawing.Point(644, 155);
            this.tbDiem.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiem.Name = "tbDiem";
            this.tbDiem.Size = new System.Drawing.Size(280, 22);
            this.tbDiem.TabIndex = 17;
            this.tbDiem.TextChanged += new System.EventHandler(this.tbDiem_TextChanged);
            // 
            // tbTendt
            // 
            this.tbTendt.Location = new System.Drawing.Point(120, 82);
            this.tbTendt.Margin = new System.Windows.Forms.Padding(4);
            this.tbTendt.Multiline = true;
            this.tbTendt.Name = "tbTendt";
            this.tbTendt.Size = new System.Drawing.Size(280, 93);
            this.tbTendt.TabIndex = 16;
            // 
            // tbMadt
            // 
            this.tbMadt.Location = new System.Drawing.Point(120, 31);
            this.tbMadt.Margin = new System.Windows.Forms.Padding(4);
            this.tbMadt.Name = "tbMadt";
            this.tbMadt.Size = new System.Drawing.Size(280, 22);
            this.tbMadt.TabIndex = 15;
            this.tbMadt.TextChanged += new System.EventHandler(this.tbMadt_TextChanged);
            this.tbMadt.Validating += new System.ComponentModel.CancelEventHandler(this.tbMadt_Validating);
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(851, 261);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 14;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_baocao
            // 
            this.btn_baocao.Location = new System.Drawing.Point(693, 261);
            this.btn_baocao.Margin = new System.Windows.Forms.Padding(4);
            this.btn_baocao.Name = "btn_baocao";
            this.btn_baocao.Size = new System.Drawing.Size(100, 28);
            this.btn_baocao.TabIndex = 13;
            this.btn_baocao.Text = "Báo cáo";
            this.btn_baocao.UseVisualStyleBackColor = true;
            this.btn_baocao.Click += new System.EventHandler(this.btn_baocao_Click);
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(527, 261);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(100, 28);
            this.btn_boqua.TabIndex = 11;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            this.btn_boqua.Click += new System.EventHandler(this.btn_boqua_Click);
            // 
            // btn_timkiem
            // 
            this.btn_timkiem.Location = new System.Drawing.Point(391, 261);
            this.btn_timkiem.Margin = new System.Windows.Forms.Padding(4);
            this.btn_timkiem.Name = "btn_timkiem";
            this.btn_timkiem.Size = new System.Drawing.Size(100, 28);
            this.btn_timkiem.TabIndex = 10;
            this.btn_timkiem.Text = "Tìm kiếm";
            this.btn_timkiem.UseVisualStyleBackColor = true;
            this.btn_timkiem.Click += new System.EventHandler(this.btn_timkiem_Click);
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(264, 261);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 9;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            this.btn_xoa.Click += new System.EventHandler(this.btn_xoa_Click);
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(137, 261);
            this.btn_sua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(100, 28);
            this.btn_sua.TabIndex = 8;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_them
            // 
            this.btn_them.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_them.Location = new System.Drawing.Point(8, 261);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 7;
            this.btn_them.Text = "Thêm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // lb_namTH
            // 
            this.lb_namTH.AutoSize = true;
            this.lb_namTH.Location = new System.Drawing.Point(477, 133);
            this.lb_namTH.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_namTH.Name = "lb_namTH";
            this.lb_namTH.Size = new System.Drawing.Size(99, 17);
            this.lb_namTH.TabIndex = 6;
            this.lb_namTH.Text = "Năm thực hiện";
            // 
            // lb_man
            // 
            this.lb_man.AutoSize = true;
            this.lb_man.Location = new System.Drawing.Point(477, 86);
            this.lb_man.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_man.Name = "lb_man";
            this.lb_man.Size = new System.Drawing.Size(66, 17);
            this.lb_man.TabIndex = 5;
            this.lb_man.Text = "Mã nhóm";
            // 
            // lb_gv
            // 
            this.lb_gv.AutoSize = true;
            this.lb_gv.Location = new System.Drawing.Point(477, 39);
            this.lb_gv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gv.Name = "lb_gv";
            this.lb_gv.Size = new System.Drawing.Size(148, 17);
            this.lb_gv.TabIndex = 4;
            this.lb_gv.Text = "Giảng viên hướng dẫn";
            // 
            // lb_diem
            // 
            this.lb_diem.AutoSize = true;
            this.lb_diem.Location = new System.Drawing.Point(477, 158);
            this.lb_diem.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_diem.Name = "lb_diem";
            this.lb_diem.Size = new System.Drawing.Size(40, 17);
            this.lb_diem.TabIndex = 3;
            this.lb_diem.Text = "Điểm";
            // 
            // lb_linhvuc
            // 
            this.lb_linhvuc.AutoSize = true;
            this.lb_linhvuc.Location = new System.Drawing.Point(31, 191);
            this.lb_linhvuc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_linhvuc.Name = "lb_linhvuc";
            this.lb_linhvuc.Size = new System.Drawing.Size(61, 17);
            this.lb_linhvuc.TabIndex = 2;
            this.lb_linhvuc.Text = "Lĩnh vực";
            // 
            // lb_tendt
            // 
            this.lb_tendt.AutoSize = true;
            this.lb_tendt.Location = new System.Drawing.Point(25, 92);
            this.lb_tendt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tendt.Name = "lb_tendt";
            this.lb_tendt.Size = new System.Drawing.Size(72, 17);
            this.lb_tendt.TabIndex = 1;
            this.lb_tendt.Text = "Tên đề tài";
            // 
            // lb_madt
            // 
            this.lb_madt.AutoSize = true;
            this.lb_madt.Location = new System.Drawing.Point(31, 39);
            this.lb_madt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_madt.Name = "lb_madt";
            this.lb_madt.Size = new System.Drawing.Size(66, 17);
            this.lb_madt.TabIndex = 0;
            this.lb_madt.Text = "Mã đề tài";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "QUẢN LÝ ĐỀ TÀI NGHIÊN CỨU KHOA HỌC - KHOA ĐIỆN - ĐIỆN TỬ";
            // 
            // dgvDeTai
            // 
            this.dgvDeTai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeTai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDT,
            this.TenDT,
            this.TenLV,
            this.TenGV,
            this.MaN,
            this.NamTH,
            this.Diem});
            this.dgvDeTai.Location = new System.Drawing.Point(21, 370);
            this.dgvDeTai.Name = "dgvDeTai";
            this.dgvDeTai.RowHeadersWidth = 51;
            this.dgvDeTai.RowTemplate.Height = 24;
            this.dgvDeTai.Size = new System.Drawing.Size(1001, 250);
            this.dgvDeTai.TabIndex = 4;
            this.dgvDeTai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // MaDT
            // 
            this.MaDT.DataPropertyName = "sMaDT";
            this.MaDT.HeaderText = "Mã Đề Tài";
            this.MaDT.MinimumWidth = 6;
            this.MaDT.Name = "MaDT";
            this.MaDT.Width = 125;
            // 
            // TenDT
            // 
            this.TenDT.DataPropertyName = "sTenDT";
            this.TenDT.HeaderText = "Tên Đề Tài";
            this.TenDT.MinimumWidth = 6;
            this.TenDT.Name = "TenDT";
            this.TenDT.Width = 125;
            // 
            // TenLV
            // 
            this.TenLV.DataPropertyName = "sTenLV";
            this.TenLV.HeaderText = "Tên Lĩnh Vực";
            this.TenLV.MinimumWidth = 6;
            this.TenLV.Name = "TenLV";
            this.TenLV.Width = 125;
            // 
            // TenGV
            // 
            this.TenGV.DataPropertyName = "sTenGV";
            this.TenGV.HeaderText = "Tên Giảng Viên";
            this.TenGV.MinimumWidth = 6;
            this.TenGV.Name = "TenGV";
            this.TenGV.Width = 125;
            // 
            // MaN
            // 
            this.MaN.DataPropertyName = "sMaN";
            this.MaN.HeaderText = "Mã Nhóm";
            this.MaN.MinimumWidth = 6;
            this.MaN.Name = "MaN";
            this.MaN.Width = 125;
            // 
            // NamTH
            // 
            this.NamTH.DataPropertyName = "sNamTH";
            this.NamTH.HeaderText = "Năm Thực Hành";
            this.NamTH.MinimumWidth = 6;
            this.NamTH.Name = "NamTH";
            this.NamTH.Width = 125;
            // 
            // Diem
            // 
            this.Diem.DataPropertyName = "sDiem";
            this.Diem.HeaderText = "Điểm";
            this.Diem.MinimumWidth = 6;
            this.Diem.Name = "Diem";
            this.Diem.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 649);
            this.Controls.Add(this.dgvDeTai);
            this.Controls.Add(this.cb_gv);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "DETAI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.cb_gv.ResumeLayout(false);
            this.cb_gv.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeTai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox cb_gv;
        private System.Windows.Forms.ComboBox CbTengv;
        private System.Windows.Forms.ComboBox cbNamTH;
        private System.Windows.Forms.ComboBox cbMan;
        private System.Windows.Forms.ComboBox cbLinhvuc;
        private System.Windows.Forms.TextBox tbDiem;
        private System.Windows.Forms.TextBox tbTendt;
        private System.Windows.Forms.TextBox tbMadt;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_baocao;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_timkiem;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.Label lb_namTH;
        private System.Windows.Forms.Label lb_man;
        private System.Windows.Forms.Label lb_gv;
        private System.Windows.Forms.Label lb_diem;
        private System.Windows.Forms.Label lb_linhvuc;
        private System.Windows.Forms.Label lb_tendt;
        private System.Windows.Forms.Label lb_madt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDeTai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NamTH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diem;
    }
}

