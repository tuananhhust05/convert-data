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
    public partial class SapXepTheoDiemNhanSu : Form
    {
        public SapXepTheoDiemNhanSu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemDanhLAB";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);

            // lưu điểm điểm danh vào một mảng 
            float[] Kteam = new float[result1.Rows.Count];
            for(int a=0;a< result1.Rows.Count;a=a+1)
            {
                Kteam[a] = float.Parse((string)result1.Rows[a]["DIEMDANHLAB"]);
            }
            
            // sắp xếp lại mảng tăng dần 
            for (int i = 0; i < result1.Rows.Count; i++)
            {
                for (int j = i + 1; j < result1.Rows.Count; j++)
                {
                    if (Kteam[i] > Kteam[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = Kteam[i];
                        Kteam[i] = Kteam[j];
                        Kteam[j] = temp;
                    }
                }
            };
           

            // lần lượt xét từng điểm => xuống sql lấy ra 1 dataTable 
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MASV", typeof(string));
            ketqua.Columns.Add("DIEMDANHLAB", typeof(string));

            string query2 = "SELECT *FROM dbo.DiemDanhLAB WHERE DIEMDANHLAB='" + Kteam[0].ToString() + "'";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);  // dataTable tam
            for (int t = 0; t < result2.Rows.Count; t++)
            {
                ketqua.Rows.Add((string)result2.Rows[t]["MASV"], (string)result2.Rows[t]["DIEMDANHLAB"]);
            }

            int b = 1;
            while(b< result1.Rows.Count)
            {
                if(Kteam[b]!=Kteam[b-1])
                {
                    string query = "SELECT *FROM dbo.DiemDanhLAB WHERE DIEMDANHLAB='" + Kteam[b].ToString() + "'";
                    DataTable result = dataprovider.Instance.ExecuteQuery(query);  // dataTable tam
                    for(int z = 0; z < result.Rows.Count; z++)
                    {
                        ketqua.Rows.Add((string)result.Rows[z]["MASV"], (string)result.Rows[z]["DIEMDANHLAB"]);
                    }
                    
                }
                b++;
            }
            dataGridView1.DataSource = ketqua;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemDanhLAB";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);

            // lưu điểm điểm danh vào một mảng 
            float[] Kteam = new float[result1.Rows.Count];
            for (int a = 0; a < result1.Rows.Count; a = a + 1)
            {
                Kteam[a] = float.Parse((string)result1.Rows[a]["DIEMDANHLAB"]);
            }
            


            // sắp xếp lại mảng tăng dần 
            for (int i = 0; i < result1.Rows.Count; i++)
            {
                for (int j = i + 1; j < result1.Rows.Count; j++)
                {
                    if (Kteam[i] < Kteam[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = Kteam[i];
                        Kteam[i] = Kteam[j];
                        Kteam[j] = temp;
                    }
                }
            };
            

            // lần lượt xét từng điểm => xuống sql lấy ra 1 dataTable 
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MASV", typeof(string));
            ketqua.Columns.Add("DIEMDANHLAB", typeof(string));

            string query2 = "SELECT *FROM dbo.DiemDanhLAB WHERE DIEMDANHLAB='" + Kteam[0].ToString() + "'";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);  // dataTable tam
            for (int t = 0; t < result2.Rows.Count; t++)
            {
                ketqua.Rows.Add((string)result2.Rows[t]["MASV"], (string)result2.Rows[t]["DIEMDANHLAB"]);
            }

            int b = 1;
            while (b < result1.Rows.Count)
            {
                if (Kteam[b] != Kteam[b - 1])
                {
                    string query = "SELECT *FROM dbo.DiemDanhLAB WHERE DIEMDANHLAB='" + Kteam[b].ToString() + "'";
                    DataTable result = dataprovider.Instance.ExecuteQuery(query);  // dataTable tam
                    for (int z = 0; z < result.Rows.Count; z++)
                    {
                        ketqua.Rows.Add((string)result.Rows[z]["MASV"], (string)result.Rows[z]["DIEMDANHLAB"]);
                    }

                }
                b++;
            }
            dataGridView3.DataSource = ketqua;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemPhatTrienBanThan";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);

            // lưu điểm điểm danh vào một mảng 
            float[] Kteam = new float[result1.Rows.Count];
            for (int a = 0; a < result1.Rows.Count; a = a + 1)
            {
                Kteam[a] = float.Parse((string)result1.Rows[a]["DIEM"]);
            }
          

            // sắp xếp lại mảng tăng dần 
            for (int i = 0; i < result1.Rows.Count; i++)
            {
                for (int j = i + 1; j < result1.Rows.Count; j++)
                {
                    if (Kteam[i] > Kteam[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = Kteam[i];
                        Kteam[i] = Kteam[j];
                        Kteam[j] = temp;
                    }
                }
            };


            // lần lượt xét từng điểm => xuống sql lấy ra 1 dataTable 
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MASV", typeof(string));
            ketqua.Columns.Add("DIEM", typeof(string));

            string query2 = "SELECT *FROM dbo.DiemPhatTrienBanThan WHERE DIEM='" + Kteam[0].ToString() + "'";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);  // dataTable tam
            for (int t = 0; t < result2.Rows.Count; t++)
            {
                ketqua.Rows.Add((string)result2.Rows[t]["MASV"], (string)result2.Rows[t]["DIEM"]);
            }

            int b = 1;
            while (b < result1.Rows.Count)
            {
                if (Kteam[b] != Kteam[b - 1])
                {
                    string query = "SELECT *FROM dbo.DiemPhatTrienBanThan WHERE DIEM='" + Kteam[b].ToString() + "'";
                    DataTable result = dataprovider.Instance.ExecuteQuery(query);  // dataTable tam
                    for (int z = 0; z < result.Rows.Count; z++)
                    {
                        ketqua.Rows.Add((string)result.Rows[z]["MASV"], (string)result.Rows[z]["DIEM"]);
                    }

                }
                b++;
            }
            dataGridView4.DataSource = ketqua;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // lôi thằng bảng điểm danh lên 
            string query1 = "SELECT *FROM dbo.DiemPhatTrienBanThan";
            DataTable result1 = dataprovider.Instance.ExecuteQuery(query1);

            // lưu điểm điểm danh vào một mảng 
            float[] Kteam = new float[result1.Rows.Count];
            for (int a = 0; a < result1.Rows.Count; a = a + 1)
            {
                Kteam[a] = float.Parse((string)result1.Rows[a]["DIEM"]);
            }
           


            // sắp xếp lại mảng tăng dần 
            for (int i = 0; i < result1.Rows.Count; i++)
            {
                for (int j = i + 1; j < result1.Rows.Count; j++)
                {
                    if (Kteam[i] < Kteam[j])
                    {
                        // Nếu arr[i] > arr[j] thì hoán đổi giá trị của arr[i] và arr[j]
                        float temp = Kteam[i];
                        Kteam[i] = Kteam[j];
                        Kteam[j] = temp;
                    }
                }
            };


            // lần lượt xét từng điểm => xuống sql lấy ra 1 dataTable 
            DataTable ketqua = new DataTable();
            ketqua.Columns.Add("MASV", typeof(string));
            ketqua.Columns.Add("DIEM", typeof(string));

            string query2 = "SELECT *FROM dbo.DiemPhatTrienBanThan WHERE DIEM='" + Kteam[0].ToString() + "'";
            DataTable result2 = dataprovider.Instance.ExecuteQuery(query2);  // dataTable tam
            for (int t = 0; t < result2.Rows.Count; t++)
            {
                ketqua.Rows.Add((string)result2.Rows[t]["MASV"], (string)result2.Rows[t]["DIEM"]);
            }

            int b = 1;
            while (b < result1.Rows.Count)
            {
                if (Kteam[b] != Kteam[b - 1])
                {
                    string query = "SELECT *FROM dbo.DiemPhatTrienBanThan WHERE DIEM='" + Kteam[b].ToString() + "'";
                    DataTable result = dataprovider.Instance.ExecuteQuery(query);  // dataTable tam
                    for (int z = 0; z < result.Rows.Count; z++)
                    {
                        ketqua.Rows.Add((string)result.Rows[z]["MASV"], (string)result.Rows[z]["DIEM"]);
                    }

                }
                b++;
            }
            dataGridView2.DataSource = ketqua;
        }
    }
}
