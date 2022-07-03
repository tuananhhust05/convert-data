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
    public partial class ThongTinThanhVien : Form
    {
        public ThongTinThanhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            string mk= textBox2.Text;
            string query = "SELECT *FROM DanhSachTkThanhVien WHERE TEN= '"+ten+ "' AND MATKHAU='" +mk+"' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query);  // result không đóng vai trò nhiều 

            string y;
            y = (string)result.Rows[0]["id"];// cách lôi dữ liệu từ datatable ra 
            textBox3.Text = y;

            // load điêm điểm danh bằng id 
            DataTable diemdanh = new DataTable();
            diemdanh = loadDiemDanhLab(y);
            textBox5.Text = (string)diemdanh.Rows[0]["DIEMDANHLAB"];

            // load điểm phát triển bản thân 
            DataTable diemptbt = new DataTable();
             diemptbt = loadDiemPhatTrienBanThan(y);
            textBox4.Text= (string)diemptbt.Rows[0]["DIEM"];   // gán là nó hiện lên thôi 
        }
        DataTable loadDiemDanhLab(string masv)
        {

            string query = "EXEC dbo.USP_GetDIEMDANHLABByMASV @masv = N'" + masv + " ' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
           
            return result;

        }
        DataTable loadDiemPhatTrienBanThan(string masv) // bắt nó trả về 1 datatable để tính 
        {

            string query = "EXEC dbo.USP_GetDiemPhatTrienBanThanByMASV @masv = N'" + masv + " ' ";
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
           
            return result;

        }
    }
}
