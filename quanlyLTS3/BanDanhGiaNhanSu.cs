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
    public partial class BanDanhGiaNhanSu : Form
    {
        public BanDanhGiaNhanSu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)  // load dữ liệu lên 
        {
            string masv = textBox1.Text;
            DataTable tablePTBT = new DataTable();
            DataTable tableDiemDanh = new DataTable();
            tablePTBT=loadDiemPhatTrienBanThan(masv);
            tableDiemDanh=loadDiemDanhLab(masv);


            // lưu ý đọc dữ liệu từ dataTable ra 
            float x;
            x = float.Parse((string)tablePTBT.Rows[0]["DIEM"]); // phải ép ra kiểu string xong mới ép ra kiểu float 
            float y;
            y = float.Parse((string)tableDiemDanh.Rows[0]["DIEMDANHLAB"]);// cách lôi dữ liệu từ datatable ra 
            float z;
            z = tinhdiem(x, y);
            string str2;
            str2 = z.ToString();
            textBox2.Text = str2;
            // chỉ cần nhập mã nó tự lấy dữ liệu và tự tính 


        }
        DataTable loadDiemPhatTrienBanThan(string masv) // bắt nó trả về 1 datatable để tính 
        {

            string query = "EXEC dbo.USP_GetDiemPhatTrienBanThanByMASV @masv = N'" + masv + " ' ";
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
            dtgvPhatTrienBanThan.DataSource = result;
            return result;

        }
        DataTable loadDiemDanhLab(string masv)
        {

            string query = "EXEC dbo.USP_GetDIEMDANHLABByMASV @masv = N'" + masv + " ' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
            dtgvDiemDanhLab.DataSource = result;
            return result;

        }
        float tinhdiem(float a, float b)
        {
            
            return a+b;
        }
    }
}
