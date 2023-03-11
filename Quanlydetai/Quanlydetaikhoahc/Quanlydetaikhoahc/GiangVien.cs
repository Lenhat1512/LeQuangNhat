using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydetaikhoahc
{
    public partial class GiangVien : Form
    {
        private ErrorProvider errorProvider = new ErrorProvider();
        private string connectionString =
      ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
        DataView dv_dgv = new DataView();
        public GiangVien()
        {
            InitializeComponent();
        }

        private void tb_chucvu_TextChanged(object sender, EventArgs e)
        {

        }
        private void loadgv(string filter = "")
        {
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {

                    using (SqlCommand sqlCommand = new SqlCommand("select * from GiangVien", sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = sqlCommand;
                            using (DataTable dsGV = new DataTable())
                            {
                                adapter.Fill(dsGV);
                                if (dsGV.Rows.Count > 0)
                                {


                                    //dgv_dssv.DataSource = SinhVien;
                                    // dgv_dssv.AutoGenerateColumns = false;
                                    dv_dgv = dsGV.DefaultView;
                                    if (filter != null)
                                    {
                                        dv_dgv.RowFilter = filter;
                                    }
                                    dgv_dsgv.AutoGenerateColumns = false;
                                    dgv_dsgv.DataSource = dv_dgv;
                                }
                                else
                                {
                                    MessageBox.Show("khong co du lieu !");
                                }
                            }
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool IsNumber(string strValue)
        {
            foreach (Char ch in strValue)
            {
                if (!Char.IsDigit(ch))
                    return false;
            }
            return true;
        }
        //!IsNumber(tb_sdt.Text)



        private void GiangVien_Load(object sender, EventArgs e)
        {
            loadgv();
        }

        private void dgv_dsgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = dgv_dsgv.CurrentRow.Index;
            tbMagv.Text = dgv_dsgv.Rows[index].Cells["MaGV"].Value.ToString();
            tbTengv.Text = dgv_dsgv.Rows[index].Cells["TenGV"].Value.ToString();
            tbSdt.Text = dgv_dsgv.Rows[index].Cells["SDT"].Value.ToString();
            tbEmail.Text = dgv_dsgv.Rows[index].Cells["Email"].Value.ToString();
            tbChucvu.Text = dgv_dsgv.Rows[index].Cells["Chucvu"].Value.ToString();
            mtb_ngaysinh.Text = dgv_dsgv.Rows[index].Cells["Ngaysinh"].Value.ToString();
            if (dgv_dsgv.Rows[index].Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                rdNam.Checked = true;
            }
            else
            {
                rdNu.Checked = true;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DateTime dateTim = Convert.ToDateTime(mtb_ngaysinh.Text);
            TimeSpan timeSpan = DateTime.Now - dateTim;
            double tuoi = Convert.ToInt32(timeSpan.TotalDays / 365);

            if (tuoi < 18)
            {
                MessageBox.Show("Chua du tuoi");
            }
            else
            {
                using (SqlConnection cnn = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("", cnn))
                    {


                        cmd.CommandText = "THEM_GIANGVIEN";
                        cmd.CommandType = CommandType.StoredProcedure;


                        cmd.Parameters.AddWithValue("@Magv", tbMagv.Text);
                        cmd.Parameters.AddWithValue("@Tengv", tbTengv.Text);
                        cmd.Parameters.AddWithValue("@sdt", tbSdt.Text);
                        cmd.Parameters.AddWithValue("@Ngaysinh", Convert.ToDateTime(mtb_ngaysinh.Text));
                        cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                        cmd.Parameters.AddWithValue("@chucvu", tbChucvu.Text);
                        cmd.Parameters.AddWithValue("@cmt", textBox1.Text);

                        if (rdNam.Checked == true)
                        {
                            cmd.Parameters.AddWithValue("@gt", "Nam");
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@gt", "Nu");
                        }
                        cnn.Open();
                        int row_af = cmd.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Thêm thành công gang vien " + tbTengv.Text + "!");
                        }
                    }
                    loadgv();
                }

            }


        }
        private void btnSua_Click(object sender, EventArgs e)
        {

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand(
                    "update dbo.GiangVien" +
                    " set sTenGV=@Tengv," +
                    "sGioiTinh =@Gioitinh," +
                    "sNgaysinh=@Ngaysinh," +
                    "sEmail=@email," +
                    "sSDT=@Sdt," +
                    "sChucvu=@Chucvu," +
                    "cmt=@cmt" +
                    " where sMaGV=@Magv"
                    , con))
                {
                    cm.CommandType = CommandType.Text;
                    cm.Parameters.AddWithValue("@Magv", tbMagv.Text.Trim());
                    cm.Parameters.AddWithValue("@Tengv", tbTengv.Text.Trim());

                    if (rdNam.Checked == true)
                        cm.Parameters.AddWithValue("@Gioitinh", "Nam");
                    else
                        cm.Parameters.AddWithValue("@Gioitinh", "Nữ");
                    cm.Parameters.AddWithValue("@Ngaysinh", Convert.ToDateTime(mtb_ngaysinh.Text));
                    cm.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                    cm.Parameters.AddWithValue("@Sdt", tbSdt.Text.Trim());
                    cm.Parameters.AddWithValue("@Chucvu", tbChucvu.Text.Trim());
                    cm.Parameters.AddWithValue("@cmt", textBox1.Text);
                    con.Open();
                    int row_af = cm.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                }
            }
            loadgv();
        }



        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mã " + tbTengv.Text + " này khng", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cm = new SqlCommand(
                        "Delete from dbo.GiangVien where sMaGV=@Magv"
                        , con))
                    {

                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@Magv", tbMagv.Text);
                        con.Open();
                        int row_af = cm.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                    }

                }

            }
            loadgv();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string fillter = "sMaGV is not null";
            if (tbMagv.Text != null)
            {
                fillter += string.Format(" and sMaGV like '%{0}%'", tbMagv.Text);
            }
            if (rdNam.Checked == true)
            {
                fillter += string.Format(" and sGioiTinh like 'Nam'");


            }
            //if (mtb_ngaysinh.Text != null)
            //{
            //    fillter += string.Format(" and sNgaysinh like '%{0}%' ",Convert.ToDateTime(mtb_ngaysinh.Text));
            //}


            loadgv(fillter);
        }

        private void reset() {
            tbTengv.Text = "";
            tbMagv.Text = "";
            tbSdt.Text = "";
            tbEmail.Text = "";
            tbChucvu.Text = "";
            mtb_ngaysinh.Text = "";
            rdNam.Checked = false;
            rdNu.Checked = false;

            tbMagv.Focus();
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void btnThem_Validating(object sender, CancelEventArgs e)
        {
           
        }

        private void btnThem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMagv_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btnThem_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void tbMagv_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btn_inds_Click(object sender, EventArgs e)
        {
            string reportFilter = "NOT(ISNULL({giangvienquanlymax.sMaGV}))";
            if (tbMagv.Text != null)
            {
                reportFilter += string.Format(" AND {1} LIKE '*{0}*'", tbMagv.Text, "{giangvienquanlymax.sMaGV}");

            }
                baocaodetai dt = new baocaodetai();
                dt.Show();
                dt.ShowReport(reportFilter, "baithi", "giangvienquanlymax");
            




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!IsNumber(textBox1.Text))
            {
                btnThem.Enabled = false;
            }
            else
            {
                btnThem.Enabled = true;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Menu n = new Menu();
            n.Show();
            this.Hide();
        }
    }
}
    
