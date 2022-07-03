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
    public partial class TimIdThuocKhoangNhanSu : Form
    {
        public TimIdThuocKhoangNhanSu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemDanhLAB";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);
            float max = float.Parse(textBox1.Text);
            float min = float.Parse(textBox2.Text);

            // nếu như giá trị của bảng thuộc khoảng 
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MASV", typeof(string));
            ketqua.Columns.Add("DIEMDANHLAB", typeof(string));
            
            // thêm từng thằng vào 
            for(int i = 0; i < result1.Rows.Count; i++)
            {
                if ((float.Parse((string)result1.Rows[i]["DIEMDANHLAB"])>min)&&((float.Parse((string)result1.Rows[i]["DIEMDANHLAB"])<max)))
                {
                    ketqua.Rows.Add((string)result1.Rows[i]["MASV"], (string)result1.Rows[i]["DIEMDANHLAB"]);
                };
            };
            // show
            dataGridView1.DataSource = ketqua;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên
            string query1 = "SELECT *FROM dbo.DiemPhatTrienBanThan";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);
            float max = float.Parse(textBox3.Text); // lớn hơn min nhỏ hơn max 
            float min = float.Parse(textBox4.Text);

            // nếu như giá trị của bảng thuộc khoảng 
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MASV", typeof(string));
            ketqua.Columns.Add("DIEM", typeof(string));

            // thêm từng thằng vào 
            for (int i = 0; i < result1.Rows.Count; i++)
            {
                if ((float.Parse((string)result1.Rows[i]["DIEM"]) > min) && ((float.Parse((string)result1.Rows[i]["DIEM"]) < max)))
                {
                    ketqua.Rows.Add((string)result1.Rows[i]["MASV"], (string)result1.Rows[i]["DIEM"]);
                };
            };
            // show
            dataGridView2.DataSource = ketqua;
        }
    }
}
