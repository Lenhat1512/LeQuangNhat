using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydetaikhoahc
{

    public partial class SinhVien : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
        DataView dv_dgv = new DataView();
        public SinhVien()
        {
            InitializeComponent();
        }

        private void LoadDataToGridViewsv(string filter = " ")
        {
            string querySelect = "select * from SinhVien";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select sMaN from Nhom", sqlConnection))
                    {

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            cbMan.ValueMember = "sMaN";

                            cbMan.DataSource = dt;
                            cbMan.Text = string.Empty;
                        }

                    }

                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = sqlCommand;
                            using (DataTable lichSV = new DataTable())
                            {
                                adapter.Fill(lichSV);
                                if (lichSV.Rows.Count > 0)
                                {
                                    //dgv_dssv.DataSource = SinhVien;
                                    // dgv_dssv.AutoGenerateColumns = false;
                                    dv_dgv = lichSV.DefaultView;
                                    if (filter != null)
                                    {
                                        dv_dgv.RowFilter = filter;
                                    }
                                    dgv_dssv.AutoGenerateColumns = false;
                                    dgv_dssv.DataSource = dv_dgv;
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

        private void SinhVien_Load(object sender, EventArgs e)
        {
            LoadDataToGridViewsv();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {


                    cmd.CommandText = "themsv";
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Masv", tbMasv.Text);
                    cmd.Parameters.AddWithValue("@Tensv", tbTensv.Text);
                    cmd.Parameters.AddWithValue("@Man", cbMan.Text);
                    cmd.Parameters.AddWithValue("@Email", tbEmail.Text);
                    
                    cmd.Parameters.AddWithValue("@lophc", tbLopHC.Text);
                    cmd.Parameters.AddWithValue("@sdt", tbSdt.Text);
                    if(rbNam.Checked == true)
                    {
                        cmd.Parameters.AddWithValue("@Gt", "Nam");
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Gt", "Nu");
                    }
                    cnn.Open();
                    int row_af = cmd.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Thêm thành công đề tài " + tbTensv.Text + "!");
                    }
                }
                LoadDataToGridViewsv();
            }
        }

        private void dgv_dssv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tbMasv.Text = dgv_dssv.CurrentRow.Cells["MaSV"].Value.ToString();

            tbTensv.Text = dgv_dssv.CurrentRow.Cells["TenSV"].Value.ToString();

            tbLopHC.Text = dgv_dssv.CurrentRow.Cells["LopHC"].Value.ToString();
             tbSdt.Text = dgv_dssv.CurrentRow.Cells["SDT"].Value.ToString();
            cbMan.Text = dgv_dssv.CurrentRow.Cells["MaN"].Value.ToString();

            tbEmail.Text = dgv_dssv.CurrentRow.Cells["Email"].Value.ToString();
            if(dgv_dssv.CurrentRow.Cells["GioiTinh"].Value.ToString() == "Nam")
            {
                rbNam.Checked = true;
            }
            else
            {
                rbNu.Checked = true;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand("UPDATE_SV"  , con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@Masv", tbMasv.Text);
                    cm.Parameters.AddWithValue("@Tensv", tbTensv.Text);

                    if (rbNam.Checked == true)
                        cm.Parameters.AddWithValue("@Gt", "Nam");
                    else
                        cm.Parameters.AddWithValue("@Gt", "Nữ");
                    cm.Parameters.AddWithValue("@Man", cbMan.Text);
                    cm.Parameters.AddWithValue("@email", tbEmail.Text.Trim());
                    cm.Parameters.AddWithValue("@sdt", tbSdt.Text.Trim());
                    cm.Parameters.AddWithValue("@Lophc", tbLopHC.Text.Trim());
                    
                    con.Open();
                    int row_af = cm.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Sửa thành công sinh vien "+tbTensv.Text+" !");
                    }
                }
            }
            LoadDataToGridViewsv();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Bạn có muốn xóa mã " + tbTensv.Text + " này khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cm = new SqlCommand(
                        "Delete from dbo.SinhVien where sMaSV=@Masv"
                        , con))
                    {

                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@Masv", tbMasv.Text);
                        con.Open();
                        int row_af = cm.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Xóa thành công sinh vien "+tbTensv.Text+ " !");
                        }
                    }

                }

            }
            LoadDataToGridViewsv();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string fillter = "sMaSVS is not null";
            if (tbMasv.Text != null)
            {
                fillter += string.Format(" and sMaSV like '%{0}%'", tbMasv.Text);
            }
            
            //if (rdNam.Checked == true)
            //{
            //    fillter += string.Format(" and sGioiTinh like 'Nam'");

            //}


            
            LoadDataToGridViewsv(fillter);
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
            string reportFilter = "NOT(ISNULL({baocaosinhvien.sMaSV}))";
            if (tbMasv.Text != null)
            {
                reportFilter += string.Format(" AND {1} LIKE '*{0}*'", tbMasv.Text, "{baocaosinhvien.sMaSV}");
            }
            //if (!string.IsNullOrEmpty(tb_tensv.Text))
            //{
            //    reportFilter += string.Format(" AND {1} LIKE '*{0}*'", tb_tensv.Text, "{Select_TongHop.sHoTen}");
            //}
            //.. cac truong du lieu khac tuong ung voi cac control



            baocaodetai dt = new baocaodetai();
            dt.Show();
            dt.ShowReport(reportFilter, "RpSinhVien", "baocaosinhvien");
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Menu n = new Menu();
            n.Show();
            this.Hide();
        }
    }
}
