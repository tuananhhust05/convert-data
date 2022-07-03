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
    public partial class menuCapNhatDiem : Form
    {
        public menuCapNhatDiem()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CapNhatDiemDanh f = new CapNhatDiemDanh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
