using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyLTS3
{
    public partial class menuChinhSua : Form
    {
        public menuChinhSua()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BangThemTkThanhVien f = new BangThemTkThanhVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BangXoaTKThanhVien f = new BangXoaTKThanhVien();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            menuCapNhatDiem f = new menuCapNhatDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            menuSuaDiem f = new menuSuaDiem();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BangThemTkAdmin f = new BangThemTkAdmin();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
