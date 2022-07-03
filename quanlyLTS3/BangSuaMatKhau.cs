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
    public partial class BangSuaMatKhau : Form
    {
        public BangSuaMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ten = textBox1.Text;
            string mk = textBox2.Text;
            string query = "SELECT *FROM DanhSachTkThanhVien WHERE TEN= '" + ten + "' AND MATKHAU='" + mk + "' "; // tìm kiếm 
            DataTable result = dataprovider.Instance.ExecuteQuery(query);  // result không đóng vai trò nhiều 

            // lấy id 
            string y=null;
            if (result.Rows.Count > 0)
            {
                
                y = (string)result.Rows[0]["id"];// cách lôi dữ liệu từ datatable ra 
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu ");
            };
            
            if (TxbPassWord.Text== textBox3.Text)
            {
                string query1 = "DELETE FROM DanhSachTkThanhVien WHERE id='" + y + "'";
                DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);
                // không được quên excute 
                string query2 = "INSERT INTO DanhSachTkThanhVien VALUES ('"+ textBox1.Text+ "','"+TxbPassWord.Text+"','"+y+"')";
                DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);


                // lôi lên cái thằng mật khẩu mới để đối chiếu với mật khẩu cũ => sửa thành công hay không 
                string query3 = "SELECT *FROM DanhSachTkThanhVien WHERE id='" + y + "' "; // tìm kiếm 
                DataTable result3 = dataprovider.Instance.ExecuteQuery(query3);
                string z = (string)result3.Rows[0]["MATKHAU"];
                if (z != textBox2.Text)
                {
                    MessageBox.Show("Sửa thành công");
                };
            };


            

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
