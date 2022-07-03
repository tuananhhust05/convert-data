using quanlyLTS3.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyLTS3.DAO
{
    public class AccountDAO  // cấu hình singleton => chỉ cần 1 conection=> tiện và dễ quản lý hơn 
    {
        private static AccountDAO instance;
        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }

        private AccountDAO() { }

        // hàm login 
        //Bản chất: ta gõ thông tin-> chuyển thành câu truy vấn-> câu truy vấn chọn ra đối tượng phù hợp với đk sau where -> kiểm tra xem đối tượng đó có tồn tại không-> trả về 0 hoặc 1 để mở hay đóng fTableManager 
        public bool Login(string userName, string password)
        {
            string query = "SELECT *FROM dbo.LISTACCOUNT WHERE TEN =N'" + userName + "' AND MATKHAU =N'" + password + "'";// truyền vào userName và password vấn đề là ta lấy userName và passWord từ textBox
            DataTable result = dataprovider.Instance.ExecuteQuery(query);// trả về đối tượng phù hợp 
            return result.Rows.Count > 0; // cái này trả về 0 hoặc 1=> 0 thì sai,1 thì đúng 
        }
        public bool LoginTV(string userName, string password)
        {
            string query = "SELECT *FROM dbo.DanhSachTkThanhVien WHERE TEN =N'" + userName + "' AND MATKHAU =N'" + password + "'";// truyền vào userName và password vấn đề là ta lấy userName và passWord từ textBox
            DataTable result = dataprovider.Instance.ExecuteQuery(query);// trả về đối tượng phù hợp 
            return result.Rows.Count > 0; // cái này trả về 0 hoặc 1=> 0 thì sai,1 thì đúng 
        }
    }
}

