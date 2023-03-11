using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlydetaikhoahc
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void quảnLýSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            SinhVien sv = new SinhVien();
            sv.Show();
            this.Hide();

        }

        private void quảnLýĐềTàiKhoaHọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            Form1 dt = new Form1();
            dt.Show();
            this.Hide();
        }

        private void quảnLýGiảngVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GiangVien gv = new GiangVien();
            gv.Show();
            this.Hide();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void quảnLýChungToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhómToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nhom n = new Nhom();
            n.Show();

            this.Hide();
        }
    }
}
