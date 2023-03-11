
namespace Quanlydetaikhoahc
{
    partial class Nhom
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
            this.dgv_nhomSV = new System.Windows.Forms.DataGridView();
            this.maN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_man = new System.Windows.Forms.ComboBox();
            this.btn_thoat = new System.Windows.Forms.Button();
            this.btn_tim = new System.Windows.Forms.Button();
            this.btn_boqua = new System.Windows.Forms.Button();
            this.btn_xoa = new System.Windows.Forms.Button();
            this.btn_them = new System.Windows.Forms.Button();
            this.tb_soSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhomSV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgv_nhomSV);
            this.groupBox2.Location = new System.Drawing.Point(583, 76);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(448, 402);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách nhóm ";
            // 
            // dgv_nhomSV
            // 
            this.dgv_nhomSV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhomSV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maN,
            this.soSV});
            this.dgv_nhomSV.Location = new System.Drawing.Point(24, 23);
            this.dgv_nhomSV.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_nhomSV.Name = "dgv_nhomSV";
            this.dgv_nhomSV.RowHeadersWidth = 51;
            this.dgv_nhomSV.Size = new System.Drawing.Size(397, 372);
            this.dgv_nhomSV.TabIndex = 0;
            // 
            // maN
            // 
            this.maN.DataPropertyName = "sMaN";
            this.maN.HeaderText = "sMaN";
            this.maN.MinimumWidth = 6;
            this.maN.Name = "maN";
            this.maN.Width = 125;
            // 
            // soSV
            // 
            this.soSV.DataPropertyName = "iSoSV";
            this.soSV.HeaderText = "Số sinh viên";
            this.soSV.MinimumWidth = 6;
            this.soSV.Name = "soSV";
            this.soSV.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cb_man);
            this.groupBox1.Controls.Add(this.btn_thoat);
            this.groupBox1.Controls.Add(this.btn_tim);
            this.groupBox1.Controls.Add(this.btn_boqua);
            this.groupBox1.Controls.Add(this.btn_xoa);
            this.groupBox1.Controls.Add(this.btn_them);
            this.groupBox1.Controls.Add(this.tb_soSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(76, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(465, 402);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhóm sinh viên";
            // 
            // cb_man
            // 
            this.cb_man.FormattingEnabled = true;
            this.cb_man.Location = new System.Drawing.Point(177, 46);
            this.cb_man.Margin = new System.Windows.Forms.Padding(4);
            this.cb_man.Name = "cb_man";
            this.cb_man.Size = new System.Drawing.Size(151, 24);
            this.cb_man.TabIndex = 9;
            // 
            // btn_thoat
            // 
            this.btn_thoat.Location = new System.Drawing.Point(231, 316);
            this.btn_thoat.Margin = new System.Windows.Forms.Padding(4);
            this.btn_thoat.Name = "btn_thoat";
            this.btn_thoat.Size = new System.Drawing.Size(100, 28);
            this.btn_thoat.TabIndex = 8;
            this.btn_thoat.Text = "Thoát";
            this.btn_thoat.UseVisualStyleBackColor = true;
            this.btn_thoat.Click += new System.EventHandler(this.btn_thoat_Click);
            // 
            // btn_tim
            // 
            this.btn_tim.Location = new System.Drawing.Point(229, 174);
            this.btn_tim.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim.Name = "btn_tim";
            this.btn_tim.Size = new System.Drawing.Size(100, 28);
            this.btn_tim.TabIndex = 7;
            this.btn_tim.Text = "Tìm";
            this.btn_tim.UseVisualStyleBackColor = true;
            // 
            // btn_boqua
            // 
            this.btn_boqua.Location = new System.Drawing.Point(229, 241);
            this.btn_boqua.Margin = new System.Windows.Forms.Padding(4);
            this.btn_boqua.Name = "btn_boqua";
            this.btn_boqua.Size = new System.Drawing.Size(100, 28);
            this.btn_boqua.TabIndex = 6;
            this.btn_boqua.Text = "Bỏ qua";
            this.btn_boqua.UseVisualStyleBackColor = true;
            // 
            // btn_xoa
            // 
            this.btn_xoa.Location = new System.Drawing.Point(40, 241);
            this.btn_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.btn_xoa.Name = "btn_xoa";
            this.btn_xoa.Size = new System.Drawing.Size(100, 28);
            this.btn_xoa.TabIndex = 5;
            this.btn_xoa.Text = "Xóa";
            this.btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_them
            // 
            this.btn_them.Location = new System.Drawing.Point(40, 174);
            this.btn_them.Margin = new System.Windows.Forms.Padding(4);
            this.btn_them.Name = "btn_them";
            this.btn_them.Size = new System.Drawing.Size(100, 28);
            this.btn_them.TabIndex = 4;
            this.btn_them.Text = "Thêm nhóm";
            this.btn_them.UseVisualStyleBackColor = true;
            this.btn_them.Click += new System.EventHandler(this.btn_them_Click);
            // 
            // tb_soSV
            // 
            this.tb_soSV.Location = new System.Drawing.Point(177, 102);
            this.tb_soSV.Margin = new System.Windows.Forms.Padding(4);
            this.tb_soSV.Name = "tb_soSV";
            this.tb_soSV.ReadOnly = true;
            this.tb_soSV.Size = new System.Drawing.Size(151, 22);
            this.tb_soSV.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 106);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Số thành viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã nhóm ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 34);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ NHÓM SINH VIÊN THAM GIA NGHIÊN CỨU KHOA HỌC\r\n                            " +
    "          Khoa DDienj - Điện Tử ";
            // 
            // Nhom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Nhom";
            this.Text = "Nhom";
            this.Load += new System.EventHandler(this.Nhom_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhomSV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_nhomSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maN;
        private System.Windows.Forms.DataGridViewTextBoxColumn soSV;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_man;
        private System.Windows.Forms.Button btn_thoat;
        private System.Windows.Forms.Button btn_tim;
        private System.Windows.Forms.Button btn_boqua;
        private System.Windows.Forms.Button btn_xoa;
        private System.Windows.Forms.Button btn_them;
        private System.Windows.Forms.TextBox tb_soSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}