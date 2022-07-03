using OfficeOpenXml;
using quanlyLTS3.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quanlyLTS3
{
    public partial class CapNhatDiemDanh : Form
    {
        public CapNhatDiemDanh()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fdlg = new OpenFileDialog();
            fdlg.Title = "Get tool.xlsx file";
            fdlg.Filter = "xlsx files (*.xlsx)|*.xlsx";
            fdlg.FilterIndex = 2;
            fdlg.RestoreDirectory = true;
            if (fdlg.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = fdlg.FileName;   // textBox1 là text box
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {  // đọc 
            string path = textBox1.Text;
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();


            // get number of rows and columns in the sheet
            int rows = worksheet.Dimension.Rows; // 20
            int columns = worksheet.Dimension.Columns; // 7

            for (int i = 1; i <= rows; i++)
            {
                // lấy dữ liệu lên từ id, id lấy từ file excel , dữ liệu lấy ra là DataTable 
                string id = worksheet.Cells[i, 1].Value.ToString();
                DataTable diemdanh = new DataTable();
                diemdanh=loadDiemDanhLab(id);

                // ép kiểu dữ liệu lấy ra từ table rồi cộng 
                string a = textBox2.Text;   // số điểm muốn cộng 
                float b;
                b = float.Parse(a);
                float y = float.Parse((string)diemdanh.Rows[0]["DIEMDANHLAB"]);


                y = y + b;
                //xoa hàng có masv=id 
                string query = "EXEC dbo.USP_DeleteDIEMDANHByID @id= '" + id + " ' "; // tìm kiếm 
                DataTable result = dataprovider.Instance.ExecuteQuery(query);  // result không đóng vai trò nhiều 

                // thêm lại với giá trị điểm mới 
                string content = y.ToString();
                string query2 = "dbo.USP_InsertToDiemDanhLab1 @masv= '" + id + " ',@diem='" + content + "' ";
                DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);
            };
            string query3 = "SELECT *FROM dbo.DiemDanhLAB";
            DataTable result3 = dataprovider.Instance.ExecuteQuery(query3);
            dataGridView1.DataSource = result3;



        }
        DataTable loadDiemDanhLab(string masv)
        {

            string query = "EXEC dbo.USP_GetDIEMDANHLABByMASV @masv = N'" + masv + " ' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query);
            
            return result;

        }
    }
}
