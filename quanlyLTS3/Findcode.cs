using quanlyLTS3.DAO;
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
    public partial class Findcode : Form
    {
        public Findcode()
        {
            InitializeComponent();
            
        }
        void loadcode(string ten )
        {
           
            string query = "EXEC dbo.USP_GetCODEByTENTV @tentv= N'" + ten + " ' ";
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
            dtgvcode.DataSource = result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            loadcode(ten);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LTorTV f = new LTorTV();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
