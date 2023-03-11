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
    public partial class Form1 : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
        DataView dt = new DataView();
        public Form1()
        {
            InitializeComponent();
        }

        private void LoadToDataGridView(string filter = "")
        {
            string querySelect = "select_detai";
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    using (SqlCommand sqlCommand = new SqlCommand(querySelect, sqlConnection))
                    {
                        sqlCommand.CommandType = CommandType.Text;
                        using (SqlDataAdapter adapter = new SqlDataAdapter())
                        {
                            adapter.SelectCommand = sqlCommand;
                            using (DataTable QLDT = new DataTable())
                            {
                                adapter.Fill(QLDT);
                                if (QLDT.Rows.Count > 0)
                                {
                                    dt = QLDT.DefaultView;
                                    if (filter != null)
                                    {
                                        dt.RowFilter = filter;
                                    }
                                    dgvDeTai.AutoGenerateColumns = false;
                                    dgvDeTai.DataSource = dt;
                                }
                                else
                                {
                                    MessageBox.Show("Khong ton tai ban ghi nao");
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

        private void Loadcombobox()
        {
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                LoadToDataGridView();
                using (SqlCommand cmd = new SqlCommand("select sTenGV,sMaGV from GiangVien", sqlConnection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        CbTengv.ValueMember = "sMaGV";
                        CbTengv.DisplayMember = "sTenGV";
                        CbTengv.DataSource = dt;
                        CbTengv.Text = string.Empty;
                    }

                }

                using (SqlCommand cmd = new SqlCommand("select sTenLV,sMaLV from Linhvuc", sqlConnection))
                {

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        cbLinhvuc.ValueMember = "sMaLV";
                        cbLinhvuc.DisplayMember = "sTenLV";
                        cbLinhvuc.DataSource = dt;
                        cbLinhvuc.Text = string.Empty;
                    }



                }

                //using (SqlCommand cmd = new SqlCommand("select sNamTH from Detai", sqlConnection))
                //{

                //    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                //    {
                //        DataTable dt = new DataTable();
                //        adapter.Fill(dt);

                //        cbNamTH.ValueMember = "sNamTH";
                //        cbNamTH.DataSource = dt;
                //        cbNamTH.Text = string.Empty;
                //    }

                //}

                using (SqlCommand cmd = new SqlCommand("Nhomchuadt", sqlConnection))
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


            }
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dgvDeTai.CurrentRow.Index;
            tbMadt.Text = dgvDeTai.Rows[index].Cells["MaDT"].Value.ToString();
            tbTendt.Text = dgvDeTai.Rows[index].Cells["TenDT"].Value.ToString();
            tbDiem.Text = dgvDeTai.Rows[index].Cells["Diem"].Value.ToString();
            cbMan.Text = dgvDeTai.Rows[index].Cells["MaN"].Value.ToString();
            cbNamTH.Text = dgvDeTai.Rows[index].Cells["NamTh"].Value.ToString();
            CbTengv.Text = dgvDeTai.Rows[index].Cells["TenGV"].Value.ToString();
            cbLinhvuc.Text = dgvDeTai.Rows[index].Cells["TenLV"].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loadcombobox();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            using (SqlConnection cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("", cnn))
                {


                    cmd.CommandText = "themLichday";
                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Madt", tbMadt.Text);
                    cmd.Parameters.AddWithValue("@Tendt", tbTendt.Text);
                    cmd.Parameters.AddWithValue("@Malv", cbLinhvuc.SelectedValue);
                    cmd.Parameters.AddWithValue("@Man", cbMan.Text);
                    cmd.Parameters.AddWithValue("@Magv", CbTengv.SelectedValue);
                    cmd.Parameters.AddWithValue("@Diem", tbDiem.Text);
                    cmd.Parameters.AddWithValue("@NamTH", cbNamTH.Text);
                    cnn.Open();
                    int row_af = cmd.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Thêm thành công đề tài " + tbMadt.Text + "!");
                    }
                }
                Loadcombobox();
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                using (SqlCommand cm = new SqlCommand(
                    "UPDATE_DT"
                    , con))
                {
                    cm.CommandType = CommandType.StoredProcedure;
                    cm.Parameters.AddWithValue("@Madt", tbMadt.Text);
                    cm.Parameters.AddWithValue("@Tendt", tbTendt.Text);



                    cm.Parameters.AddWithValue("@Malv", cbLinhvuc.SelectedValue);
                    cm.Parameters.AddWithValue("@Man", cbMan.Text);
                    cm.Parameters.AddWithValue("@Magv", CbTengv.SelectedValue);

                    cm.Parameters.AddWithValue("@Diem", tbDiem.Text);
                    cm.Parameters.AddWithValue("@NamTH", cbNamTH.Text);

                    con.Open();
                    int row_af = cm.ExecuteNonQuery();
                    if (row_af > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                    }
                }
            }
            Loadcombobox();

        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa mã " + tbMadt.Text + " này khong", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    using (SqlCommand cm = new SqlCommand(
                        "Delete from dbo.Detai where sMaDT=@Madt"
                        , con))
                    {

                        cm.CommandType = CommandType.Text;
                        cm.Parameters.AddWithValue("@Madt", tbMadt.Text);
                        con.Open();
                        int row_af = cm.ExecuteNonQuery();
                        if (row_af > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                        }
                    }

                }

            }
            Loadcombobox();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            string fillter = "sMaDT is not null";
            if (tbMadt.Text != null)
            {
                fillter += string.Format(" and sMaDT like '%{0}%'", tbMadt.Text);
            }
            //if (rdNam.Checked == true)
            //{
            //    fillter += string.Format(" and sGioiTinh like 'Nam'");

            //}
            if (cbLinhvuc.Text != null)
            {
                fillter += string.Format(" and sTenLV like '%{0}%'", cbLinhvuc.Text);
            }


            Loadcombobox();
            LoadToDataGridView(fillter);
        }

        private void ResetFormLoad()
        {
            tbMadt.Text = "";
            tbTendt.Text = "";
            cbLinhvuc.Text = "";
            CbTengv.Text = "";
            cbMan.Text = "";
            cbNamTH.Text = "";
            tbDiem.Text = "";

            tbMadt.Focus();
        }

        private void btn_boqua_Click(object sender, EventArgs e)
        {
            ResetFormLoad();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoat khong ", "Thong bao", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            {
                if (dg == DialogResult.OK)
                {
                    Form1 f1 = new Form1();
                   this.Hide();
                    Menu n = new Menu();
                    n.Show();

                }
            }
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {

            string reportFilter = "NOT(ISNULL({pr_detai.sMaDT}))";
            if (tbMadt.Text != null)
            {
                reportFilter += string.Format(" AND {1} LIKE '*{0}*'", tbMadt.Text, "{pr_detai.sMaDT}");
            }
            //if (!string.IsNullOrEmpty(tb_tensv.Text))
            //{
            //    reportFilter += string.Format(" AND {1} LIKE '*{0}*'", tb_tensv.Text, "{Select_TongHop.sHoTen}");
            //}
            //.. cac truong du lieu khac tuong ung voi cac control



            baocaodetai dt = new baocaodetai();
            dt.Show();
            dt.ShowReport(reportFilter, "RpGiangVien", "pr_detai");
        }

        private void tbDiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMadt_Validating(object sender, CancelEventArgs e)
        {
        }

        private void tbMadt_TextChanged(object sender, EventArgs e)
        {
           
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    int diem1 = Convert.ToInt32(textBox1.Text);
        //    int diem2 = Convert.ToInt32(textBox2.Text);
        //    using (SqlConnection con = new SqlConnection(connectionString))
        //    {
        //        using (SqlCommand cm = new SqlCommand(" select * from Detai where sDiem > " + diem1 + " and sDiem < " + diem2

        //            , con))
        //        {
        //            using (SqlDataAdapter adapter = new SqlDataAdapter(cm))
        //            {
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);

        //                dgvDeTai.DataSource = dt;

        //                dgvDeTai.AutoGenerateColumns = false;

        //            }

        //        }

        //    }
        //}
    }
}