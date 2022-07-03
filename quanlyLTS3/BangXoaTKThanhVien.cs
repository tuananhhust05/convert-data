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
    public partial class BangXoaTKThanhVien : Form
    {
        public BangXoaTKThanhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text;
            string query = "EXEC dbo.USP_DeleteAccountbyID @id ='"+id+"'";
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = result;

            string query2 = "SELECT * FROM dbo.code";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);
            dataGridView2.DataSource = result2;
        }
    }
}
