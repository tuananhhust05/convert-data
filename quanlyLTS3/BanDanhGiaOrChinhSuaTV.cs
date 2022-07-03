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
    public partial class BanDanhGiaOrChinhSuaTV : Form
    {
        public BanDanhGiaOrChinhSuaTV()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BanDanhGiaTV f = new BanDanhGiaTV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menuChinhSua f = new menuChinhSua();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
