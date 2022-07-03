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
    public partial class BanDanhGiaTV : Form
    {
        public BanDanhGiaTV()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BanDanhGiaNhanSu f = new BanDanhGiaNhanSu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BangLocNhanSu f = new BangLocNhanSu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
