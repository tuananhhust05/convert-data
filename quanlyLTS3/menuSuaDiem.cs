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
    public partial class menuSuaDiem : Form
    {
        public menuSuaDiem()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BangSuaDiemDiemDanh f = new BangSuaDiemDiemDanh();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
