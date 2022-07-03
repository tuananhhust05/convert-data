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
    public partial class BangThemTkThanhVien : Form
    {
        public BangThemTkThanhVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   /// click vào mở file 
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
        {   // excel là mảng 2 chiều tình từ 1 
            string path = textBox1.Text;
            FileInfo fileInfo = new FileInfo(path);
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
            ExcelPackage package = new ExcelPackage(fileInfo);
            ExcelWorksheet worksheet = package.Workbook.Worksheets.FirstOrDefault();

            // get number of rows and columns in the sheet
            int rows = worksheet.Dimension.Rows; // 20
            int columns = worksheet.Dimension.Columns; // 7


            // thử thêm vào 1 thằng trước 

            int j = 1;
            for (int i = 1; i < rows + 1; i++)
            { 
                    string content2 = worksheet.Cells[i, j + 1].Value.ToString();
                    string content1 = worksheet.Cells[i, j].Value.ToString();
                    string query = "EXEC dbo.USP_InsertID @id='" + content2 + "', @ten='" + content1 + "' "; // chèn 2 ẩn vào 3 database
                    DataTable result = dataprovider.Instance.ExecuteQuery(query);
                    dataGridView1.DataSource = result;
            }

            // chiếu tất cả lên 
            string query1= "SELECT *FROM dbo.DiemDanhLAB";
            string query2= "SELECT *FROM dbo.DiemPhatTrienBanThan";
            string query3= "SELECT * FROM dbo.code";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);
            dataGridView2.DataSource = result1;
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);
            dataGridView3.DataSource = result2;
            DataTable result3 = dataprovider.Instance.ExecuteQuery(query3);
            dataGridView4.DataSource = result3;

        }
    }
}
