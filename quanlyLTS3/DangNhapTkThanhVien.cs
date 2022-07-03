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
    public partial class DangNhapTkThanhVien : Form
    {
        public DangNhapTkThanhVien()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = TxbPassWord.Text;
            if (LoginTV(username, password))
            {
                ThongTinThanhVien f = new ThongTinThanhVien();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }


            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }
        bool LoginTV(string username, string password)
        { // nếu đúng thì true sai thì trả về false 
            return AccountDAO.Instance.LoginTV(username, password);// lỗi xử lý sau, khả năng bên kia sai 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BangSuaMatKhau f = new BangSuaMatKhau();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
