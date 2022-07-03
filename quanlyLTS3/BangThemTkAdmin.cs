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
    public partial class BangThemTkAdmin : Form
    {
        public BangThemTkAdmin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(TxbPassWord.Text== textBox2.Text)
            {
                string query = " INSERT INTO LISTACCOUNT VALUES( '" + textBox1.Text+"', '" + TxbPassWord.Text + "')";
                DataTable result = dataprovider.Instance.ExecuteQuery(query);
                // show danh sách tk admin 
                string query2 = "SELECT *FROM dbo.LISTACCOUNT";
                DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);
                dataGridView1.DataSource = result2;
            }
        }
    }
}
