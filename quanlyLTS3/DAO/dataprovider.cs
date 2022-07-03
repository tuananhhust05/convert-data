using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quanlyLTS3.DAO
{

    public class dataprovider
    {
        // tạo 1 cái singleton 
        private static dataprovider instance; // tất cả nhứng thằng tạo qua thắng này đều chỉ xuất hiện 1 lần 
        // đóng gói nó -> cú pháp Ctrl + R+ E ,đặt chuột ở ngay thằng instance 
        public static dataprovider Instance
        {
            get { if (instance == null) instance = new dataprovider(); return dataprovider.instance; } // phòng trường hợp thằng instance rỗng 
            private set { dataprovider.instance = value; } // chỉ nội bộ class sử dụng , không đc lấy ra 
        }
        private dataprovider() { }  // cái này để chắc chắn cái Singleton kia là private , lưu ý dấu ngoặc kép đằng sau 



        private string connectionSTR = "Data Source=.\\SQLEXPRESS01;Initial Catalog=quanlyLTS;Integrated Security=True";

        // dấu ... thế hiện là còn 1 đống ở đằng sau 
        // dưới đây là 3 phương thức cần thiết cho dataprovider 
        public DataTable ExecuteQuery(string query, object[] parameter = null)   // dùng phương thức này kèm câu lệnh muốn truy vấn, bằng null là thằng cuối cùng bằng null 
        // string id để truyền parameter 
        {
            DataTable data = new DataTable();   // tạo datatable => tìm hiểu về kiểu dữ liệu 
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // đỡ lỗi tự động giải phóng bộ nhớ 
            {
                connection.Open();   // mở kết nối 

                SqlCommand command = new SqlCommand(query, connection);  // tạo command

                if (parameter != null)   // điều kiện parameter 
                {
                    string[] listPara = query.Split(' '); // Split theo khoảng trắng của câu truy vấn 
                    int i = 0;
                    foreach (string item in listPara)  // cho item chạy
                    {
                        if (item.Contains('@'))  // @ là ký tự thể hiện đây là 1 thằng parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);  // thêm vào thằng parameter thỏa mãn 
                            i++;


                        }
                    }
                }



                SqlDataAdapter adapter = new SqlDataAdapter(command);// tạo adapter 
                adapter.Fill(data);  // điền đầy data
                connection.Close();
            }
            return data;  // quan trọng nhất là lệnh return này , đổ dữ liệu lên 1 thằng nào đó 
        }


        // trả về số dòng 
        public int ExecuteNonQuery(string query, object[] parameter = null)   // dùng phương thức này kèm câu lệnh muốn truy vấn, bằng null là thằng cuối cùng bằng null 
        // string id để truyền parameter 
        {
            int data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // đỡ lỗi tự động giải phóng bộ nhớ 
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' '); // Split theo khoảng trắng 
                    int i = 0;
                    foreach (string item in listPara)  // cho item chạy
                    {
                        if (item.Contains('@'))  // @ là ký tự thể hiện đây là 1 thằng parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);  // thêm vào thằng parameter thỏa mãn 
                            i++;


                        }
                    }
                }

                data = command.ExecuteNonQuery();  // đệ quy chăng => cuối cùng trả ra số dòng thành công 

                connection.Close();
            }
            return data;  // quan trọng nhất là lệnh return này , đổ dữ liệu lên 1 thằng nào đó 
        }

        public object ExecuteScalar(string query, object[] parameter = null)// trả về 1 trường thông tin phù hợp của đối tượng   
        // trả về số lượng trả ra  
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionSTR)) // đỡ lỗi tự động giải phóng bộ nhớ 
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                if (parameter != null)
                {
                    string[] listPara = query.Split(' '); // Split theo khoảng trắng 
                    int i = 0;
                    foreach (string item in listPara)  // cho item chạy
                    {
                        if (item.Contains('@'))  // @ là ký tự thể hiện đây là 1 thằng parameter
                        {
                            command.Parameters.AddWithValue(item, parameter[i]);  // thêm vào thằng parameter thỏa mãn 
                            i++;


                        }
                    }
                }

                data = command.ExecuteScalar();  // đệ quy chăng => cuối cùng trả ra số đối tượng  thành công 

                connection.Close();
            }
            return data;  // quan trọng nhất là lệnh return này , đổ dữ liệu lên 1 thằng nào đó 
        }
    }
}
