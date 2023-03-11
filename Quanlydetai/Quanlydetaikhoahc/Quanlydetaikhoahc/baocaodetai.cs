using CrystalDecisions.CrystalReports.Engine;
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
    public partial class baocaodetai : Form
    {

        private string connectionString =
                   ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
        public baocaodetai()
        {
            InitializeComponent();
        }

        private void baocaodetai_Load(object sender, EventArgs e)
        {
        }
            public void ShowReport(string reportFilter, string fileName, string tableName)
            {
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                {
                    try
                    {
                        using (SqlCommand sqlCommand = sqlConnection.CreateCommand())
                        {
                            sqlCommand.CommandText = tableName;
                            sqlCommand.CommandType = CommandType.StoredProcedure;
                            using (SqlDataAdapter adapter = new SqlDataAdapter())
                            {
                                adapter.SelectCommand = sqlCommand;
                                using (DataTable dt = new DataTable())
                                {
                                    adapter.Fill(dt);

                                    //Load report
                                    ReportDocument report = new ReportDocument();
                                    string path = string.Format("{0}\\BaoCao\\{1}.rpt",
                                        Application.StartupPath, fileName);
                                    report.Load(path);
                                    report.Database.Tables[tableName].SetDataSource(dt);
                                    report.SetParameterValue("Nguoilapbieu", "Bùi Chung Thành");

                                if (reportFilter != null)
                                    {
                                        report.RecordSelectionFormula = reportFilter;
                                    }

                                    crystalReportViewer1.ReportSource = report;
                                    crystalReportViewer1.Refresh();
                                }
                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }
    
}
