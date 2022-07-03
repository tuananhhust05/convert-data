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
    public partial class TimMaxNhanSu : Form
    {
        public TimMaxNhanSu()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemDanhLAB";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);

            // không dùng mảng nữa 

            int a = result1.Rows.Count; // a OK 

            float max = float.Parse((string)result1.Rows[0]["DIEMDANHLAB"]);
            int i = 1;
            while (i < a)
            {
                if (float.Parse((string)result1.Rows[i]["DIEMDANHLAB"]) > max)
                {
                    max = float.Parse((string)result1.Rows[i]["DIEMDANHLAB"]);
                }

                i = i + 1;
            }


            // tìm đối tượng dựa vào giá trị điểm và đổ lên datagv
            //string content = min.ToString();

            string content = max.ToString();

            string query2 = "SELECT *FROM dbo.DiemDanhLAB WHERE DIEMDANHLAB='" + content + "'";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);
            dataGridView2.DataSource = result2;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemPhatTrienBanThan";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);

            // không dùng mảng nữa 

            int a = result1.Rows.Count; // a OK 

            float max = float.Parse((string)result1.Rows[0]["DIEM"]);
            int i = 1;
            while (i < a)
            {
                if (float.Parse((string)result1.Rows[i]["DIEM"]) > max)
                {
                    max = float.Parse((string)result1.Rows[i]["DIEM"]);
                }

                i = i + 1;
            }


            // tìm đối tượng dựa vào giá trị điểm và đổ lên datagv
            //string content = min.ToString();

            string content = max.ToString();

            string query2 = "SELECT *FROM dbo.DiemPhatTrienBanThan WHERE DIEM='" + content + "'";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);
            dataGridView1.DataSource = result2;
        }
    }
}
