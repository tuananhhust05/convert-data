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
    public partial class BangSuaDiemDiemDanh : Form
    {
        public BangSuaDiemDiemDanh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string masv = textBox1.Text;
            loadDiemDanhLab(masv);
        }
        void loadDiemDanhLab(string masv)
        {

            string query = "EXEC dbo.USP_GetDIEMDANHLABByMASV @masv = N'" + masv + " ' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
            dataGridView1.DataSource = result;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // xóa id cũ với điểm cũ => Dùng lại thủ tục cũ 
            string id = textBox1.Text;
            string query = "EXEC dbo.USP_DeleteDIEMDANHByID @id= '" + id + " ' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query); 
            // chèn id cũ với điểm mới 
            string diemmoi = textBox2.Text;
            string query2 = "dbo.USP_InsertToDiemDanhLab1 @masv= '" + id + " ',@diem='" + diemmoi + "' ";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);

            // show bảng điểm mới 
            string query1 = "SELECT *FROM dbo.DiemDanhLAB";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);
            dataGridView2.DataSource = result1;
        }
    }
}
