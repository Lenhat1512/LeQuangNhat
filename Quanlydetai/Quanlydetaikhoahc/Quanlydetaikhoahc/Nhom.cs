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
    public partial class Nhom : Form
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
        DataView dv_dgv = new DataView();
        public Nhom()
        {
            InitializeComponent();
        }

        private void LoadDataToGridView(string filter = " ")
        {
            string querySelect = "select * from Nhom";
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
                            using (DataTable dt = new DataTable())
                            {
                                adapter.Fill(dt);
                                if (dt.Rows.Count > 0)
                                {
                                    //dgv_dssv.DataSource = SinhVien;
                                    // dgv_dssv.AutoGenerateColumns = false;
                                    dv_dgv = dt.DefaultView;
                                    if (filter != null)
                                    {
                                        dv_dgv.RowFilter = filter;
                                    }
                                    dgv_nhomSV.AutoGenerateColumns = false;
                                    dgv_nhomSV.DataSource = dv_dgv;
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



        private void btn_them_Click(object sender, EventArgs e)
        {

        }

        private void Nhom_Load(object sender, EventArgs e)
        {
            LoadDataToGridView();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu n = new Menu();
            n.Show();
        }
    }
}
