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
    public partial class BangLocNhanSu : Form
    {
        public BangLocNhanSu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TimMaxNhanSu f = new TimMaxNhanSu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TimMinNhanSu f = new TimMinNhanSu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TimIdThuocKhoangNhanSu f = new TimIdThuocKhoangNhanSu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SapXepTheoDiemNhanSu f = new SapXepTheoDiemNhanSu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
