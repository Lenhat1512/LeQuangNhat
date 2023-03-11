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
    public partial class Dangnhap : Form
    {
        private int dem = 10;
        private System.Windows.Forms.Timer aTimer;
        private string connectionString =
      ConfigurationManager.ConnectionStrings["QLDT"].ConnectionString;
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void aTimer_Tick(object sender, EventArgs e)
        {
            dem--;
            if(dem == 0)
            {
                aTimer.Stop();
                label3.Visible = false;
                Dangnhap dn = new Dangnhap();
                dn.Show();
            }
            label3.Text = dem.ToString();
        }
            


        private void button1_Click(object sender, EventArgs e)
        {
            string admin = textBox1.Text;
            string pass = textBox2.Text;
            if(admin == "admin" && pass == "1"){
                Menu n = new Menu();
               
                n.Show();
                this.Hide();
                

            }else
            {
                MessageBox.Show("Sai ten dang nhap va mat  khau");
                label3.Visible = true;
                label1.Visible = false;
                label2.Visible = false;
                button1.Visible = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                var dem = 10;

                aTimer = new System.Windows.Forms.Timer();

                aTimer.Tick += new EventHandler(aTimer_Tick);
                aTimer.Interval = 1000;
                aTimer.Start();
                label3.Text = dem.ToString();


            }

        }

        private void Dangnhap_Load(object sender, EventArgs e)
        {
            label3.Visible = false;
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
