
namespace Quanlydetaikhoahc
{
    partial class SinhVien
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_dssv = new System.Windows.Forms.DataGridView();
            this.MaSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopHC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMan = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.rbNu = new System.Windows.Forms.RadioButton();
            this.rbNam = new System.Windows.Forms.RadioButton();
            this.tbLopHC = new System.Windows.Forms.TextBox();
            this.tbSdt = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbTensv = new System.Windows.Forms.TextBox();
            this.tbMasv = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_sdt = new System.Windows.Forms.Label();
            this.lb_lopHC = new System.Windows.Forms.Label();
            this.lb_gioitinh = new System.Windows.Forms.Label();
            this.lb_tensv = new System.Windows.Forms.Label();
            this.lb_masv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssv)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_dssv);
            this.groupBox2.Location = new System.Drawing.Point(34, 398);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1041, 239);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2.Thông tin sinh viên";
            // 
            // dgv_dssv
            // 
            this.dgv_dssv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_dssv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSV,
            this.TenSV,
            this.GioiTinh,
            this.LopHC,
            this.Email,
            this.SDT,
            this.MaN});
            this.dgv_dssv.Location = new System.Drawing.Point(17, 23);
            this.dgv_dssv.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_dssv.Name = "dgv_dssv";
            this.dgv_dssv.RowHeadersWidth = 51;
            this.dgv_dssv.Size = new System.Drawing.Size(1016, 207);
            this.dgv_dssv.TabIndex = 0;
            this.dgv_dssv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_dssv_CellClick);
            // 
            // MaSV
            // 
            this.MaSV.DataPropertyName = "sMaSV";
            this.MaSV.HeaderText = "Mã sinh viên";
            this.MaSV.MinimumWidth = 6;
            this.MaSV.Name = "MaSV";
            this.MaSV.Width = 125;
            // 
            // TenSV
            // 
            this.TenSV.DataPropertyName = "sTenSV";
            this.TenSV.HeaderText = "Tên sinh viên";
            this.TenSV.MinimumWidth = 6;
            this.TenSV.Name = "TenSV";
            this.TenSV.Width = 125;
            // 
            // GioiTinh
            // 
            this.GioiTinh.DataPropertyName = "sGioiTinh";
            this.GioiTinh.HeaderText = "Giới tính";
            this.GioiTinh.MinimumWidth = 6;
            this.GioiTinh.Name = "GioiTinh";
            this.GioiTinh.Width = 125;
            // 
            // LopHC
            // 
            this.LopHC.DataPropertyName = "sLopHC";
            this.LopHC.HeaderText = "Lớp hành chính";
            this.LopHC.MinimumWidth = 6;
            this.LopHC.Name = "LopHC";
            this.LopHC.Width = 125;
            // 
            // Email
            // 
            this.Email.DataPropertyName = "sEmail";
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "sSDT";
            this.SDT.HeaderText = "Số điện thoại";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 125;
            // 
            // MaN
            // 
            this.MaN.DataPropertyName = "sMaN";
            this.MaN.HeaderText = "Mã nhóm";
            this.MaN.MinimumWidth = 6;
            this.MaN.Name = "MaN";
            this.MaN.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTimKiem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbMan);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btnBaocao);
            this.groupBox1.Controls.Add(this.btnBoqua);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.rbNu);
            this.groupBox1.Controls.Add(this.rbNam);
            this.groupBox1.Controls.Add(this.tbLopHC);
            this.groupBox1.Controls.Add(this.tbSdt);
            this.groupBox1.Controls.Add(this.tbEmail);
            this.groupBox1.Controls.Add(this.tbTensv);
            this.groupBox1.Controls.Add(this.tbMasv);
            this.groupBox1.Controls.Add(this.lb_email);
            this.groupBox1.Controls.Add(this.lb_sdt);
            this.groupBox1.Controls.Add(this.lb_lopHC);
            this.groupBox1.Controls.Add(this.lb_gioitinh);
            this.groupBox1.Controls.Add(this.lb_tensv);
            this.groupBox1.Controls.Add(this.lb_masv);
            this.groupBox1.Location = new System.Drawing.Point(34, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1033, 281);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1.Quản lý nhóm sinh viên";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(444, 231);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(118, 27);
            this.btnTimKiem.TabIndex = 26;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(525, 183);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Mã nhóm";
            // 
            // cbMan
            // 
            this.cbMan.FormattingEnabled = true;
            this.cbMan.Location = new System.Drawing.Point(613, 174);
            this.cbMan.Margin = new System.Windows.Forms.Padding(4);
            this.cbMan.Name = "cbMan";
            this.cbMan.Size = new System.Drawing.Size(260, 24);
            this.cbMan.TabIndex = 24;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(925, 230);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 23;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Location = new System.Drawing.Point(775, 231);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(4);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(100, 28);
            this.btnBaocao.TabIndex = 22;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Location = new System.Drawing.Point(599, 231);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(4);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(127, 28);
            this.btnBoqua.TabIndex = 21;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(305, 231);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(115, 28);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(153, 231);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(125, 28);
            this.btnSua.TabIndex = 19;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(8, 231);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(124, 28);
            this.btnThem.TabIndex = 18;
            this.btnThem.Text = "Thêm SV";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // rbNu
            // 
            this.rbNu.AutoSize = true;
            this.rbNu.Location = new System.Drawing.Point(305, 155);
            this.rbNu.Margin = new System.Windows.Forms.Padding(4);
            this.rbNu.Name = "rbNu";
            this.rbNu.Size = new System.Drawing.Size(47, 21);
            this.rbNu.TabIndex = 16;
            this.rbNu.TabStop = true;
            this.rbNu.Text = "Nữ";
            this.rbNu.UseVisualStyleBackColor = true;
            // 
            // rbNam
            // 
            this.rbNam.AutoSize = true;
            this.rbNam.Location = new System.Drawing.Point(153, 155);
            this.rbNam.Margin = new System.Windows.Forms.Padding(4);
            this.rbNam.Name = "rbNam";
            this.rbNam.Size = new System.Drawing.Size(58, 21);
            this.rbNam.TabIndex = 15;
            this.rbNam.TabStop = true;
            this.rbNam.Text = "Nam";
            this.rbNam.UseVisualStyleBackColor = true;
            // 
            // tbLopHC
            // 
            this.tbLopHC.Location = new System.Drawing.Point(613, 26);
            this.tbLopHC.Margin = new System.Windows.Forms.Padding(4);
            this.tbLopHC.Name = "tbLopHC";
            this.tbLopHC.Size = new System.Drawing.Size(260, 22);
            this.tbLopHC.TabIndex = 12;
            // 
            // tbSdt
            // 
            this.tbSdt.Location = new System.Drawing.Point(613, 127);
            this.tbSdt.Margin = new System.Windows.Forms.Padding(4);
            this.tbSdt.Name = "tbSdt";
            this.tbSdt.Size = new System.Drawing.Size(260, 22);
            this.tbSdt.TabIndex = 11;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(613, 79);
            this.tbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(260, 22);
            this.tbEmail.TabIndex = 10;
            // 
            // tbTensv
            // 
            this.tbTensv.Location = new System.Drawing.Point(153, 87);
            this.tbTensv.Margin = new System.Windows.Forms.Padding(4);
            this.tbTensv.Name = "tbTensv";
            this.tbTensv.Size = new System.Drawing.Size(260, 22);
            this.tbTensv.TabIndex = 9;
            // 
            // tbMasv
            // 
            this.tbMasv.Location = new System.Drawing.Point(153, 28);
            this.tbMasv.Margin = new System.Windows.Forms.Padding(4);
            this.tbMasv.Name = "tbMasv";
            this.tbMasv.Size = new System.Drawing.Size(260, 22);
            this.tbMasv.TabIndex = 8;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Location = new System.Drawing.Point(540, 87);
            this.lb_email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(42, 17);
            this.lb_email.TabIndex = 7;
            this.lb_email.Text = "Email";
            // 
            // lb_sdt
            // 
            this.lb_sdt.AutoSize = true;
            this.lb_sdt.Location = new System.Drawing.Point(540, 135);
            this.lb_sdt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_sdt.Name = "lb_sdt";
            this.lb_sdt.Size = new System.Drawing.Size(36, 17);
            this.lb_sdt.TabIndex = 6;
            this.lb_sdt.Text = "SDT";
            // 
            // lb_lopHC
            // 
            this.lb_lopHC.AutoSize = true;
            this.lb_lopHC.Location = new System.Drawing.Point(525, 31);
            this.lb_lopHC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_lopHC.Name = "lb_lopHC";
            this.lb_lopHC.Size = new System.Drawing.Size(55, 17);
            this.lb_lopHC.TabIndex = 3;
            this.lb_lopHC.Text = "Lớp HC";
            // 
            // lb_gioitinh
            // 
            this.lb_gioitinh.AutoSize = true;
            this.lb_gioitinh.Location = new System.Drawing.Point(40, 155);
            this.lb_gioitinh.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_gioitinh.Name = "lb_gioitinh";
            this.lb_gioitinh.Size = new System.Drawing.Size(60, 17);
            this.lb_gioitinh.TabIndex = 2;
            this.lb_gioitinh.Text = "Giới tính";
            // 
            // lb_tensv
            // 
            this.lb_tensv.AutoSize = true;
            this.lb_tensv.Location = new System.Drawing.Point(40, 92);
            this.lb_tensv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_tensv.Name = "lb_tensv";
            this.lb_tensv.Size = new System.Drawing.Size(93, 17);
            this.lb_tensv.TabIndex = 1;
            this.lb_tensv.Text = "Tên sinh viên";
            // 
            // lb_masv
            // 
            this.lb_masv.AutoSize = true;
            this.lb_masv.Location = new System.Drawing.Point(40, 36);
            this.lb_masv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_masv.Name = "lb_masv";
            this.lb_masv.Size = new System.Drawing.Size(87, 17);
            this.lb_masv.TabIndex = 0;
            this.lb_masv.Text = "Mã sinh viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(145, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(680, 52);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ SINH VIÊN THAM GIA NGHIÊN CỨU KHOA HỌC\r\n                                K" +
    "hoa Điện - Điện Tử";
            // 
            // SinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SinhVien";
            this.Text = "SinhVien";
            this.Load += new System.EventHandler(this.SinhVien_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_dssv)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_dssv;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMan;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.RadioButton rbNu;
        private System.Windows.Forms.RadioButton rbNam;
        private System.Windows.Forms.TextBox tbSdt;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbTensv;
        private System.Windows.Forms.TextBox tbMasv;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_sdt;
        private System.Windows.Forms.Label lb_lopHC;
        private System.Windows.Forms.Label lb_gioitinh;
        private System.Windows.Forms.Label lb_tensv;
        private System.Windows.Forms.Label lb_masv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbLopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopHC;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaN;
        private System.Windows.Forms.Button btnTimKiem;
    }
}