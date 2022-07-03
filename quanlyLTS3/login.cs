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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text;
            string password = TxbPassWord.Text;
            if (Login(username, password))
            {
                Findcode f = new Findcode();
                this.Hide();
                f.ShowDialog();
                this.Show();
            }


            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }

        }
        bool Login(string username, string password)
        { // nếu đúng thì true sai thì trả về false 
            return AccountDAO.Instance.Login(username, password);// lỗi xử lý sau, khả năng bên kia sai 
        }
    }
}
