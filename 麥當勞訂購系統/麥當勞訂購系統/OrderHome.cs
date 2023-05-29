using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 麥當勞訂購系統
{
    public partial class OrderHome : Form
    {
        public OrderHome()
        {
            InitializeComponent();
        }
        int 防止使用者關閉視窗 = 0;
        public int permission = 0;
        private void OrderHome_Load(object sender, EventArgs e)
        {

            //while (reader.Read())
            //{
            //    permission = (int)reader["permission"];
            //}

            //cmd.Parameters.AddWithValue("@Newpermission", permission);

            //if (permission == 1000)
            //{
            //    GlobalVar.權限 = 1000;
            //    btn員工管理.Hide();
            //    btn商品管理.Hide();
            //    btn訂單管理.Hide();
            //    btn會員管理.Hide();
            //}

        }



        private void OrderHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (防止使用者關閉視窗 == 1)
            {
                e.Cancel = false;

            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btn點餐_Click(object sender, EventArgs e)
        {
            Form1 myform1 = new Form1();
            myform1.ShowDialog();
            防止使用者關閉視窗 = 0;
            防止使用者關閉視窗 += 1;
            
            
        }

        private void btn會員登入_Click(object sender, EventArgs e)
        {
            //防止使用者關閉視窗 = 0;
            //防止使用者關閉視窗 += 1;
            CustomerInFo myCustomerInFo = new CustomerInFo();
            myCustomerInFo.ShowDialog();

        }

        private void btn會員管理_Click(object sender, EventArgs e)
        {
            GlobalVar.會員管理 = 0;
            GlobalVar.商品管理 = 0;
            GlobalVar.員工管理 = 0;
            GlobalVar.訂單管理 = 0;
            GlobalVar.會員管理 += 1;
            
            CustomerManagement mycm = new CustomerManagement();
            mycm.ShowDialog();
        }

        private void btn商品管理_Click(object sender, EventArgs e)
        {
            GlobalVar.會員管理 = 0;
            GlobalVar.商品管理 = 0;
            GlobalVar.員工管理 = 0;
            GlobalVar.訂單管理 = 0;
            GlobalVar.商品管理 += 1;
            
            CustomerManagement mycm = new CustomerManagement();
            mycm.ShowDialog();
            
        }

        private void btn員工管理_Click(object sender, EventArgs e)
        {
            GlobalVar.會員管理 = 0;
            GlobalVar.商品管理 = 0;
            GlobalVar.員工管理 = 0;
            GlobalVar.訂單管理 = 0;
            GlobalVar.員工管理 += 1;
            
            CustomerManagement mycm = new CustomerManagement();
            mycm.ShowDialog();
            //mycm.Controls.["dataGridView自定義表格"]
        }

        private void btn訂單管理_Click(object sender, EventArgs e)
        {
            GlobalVar.會員管理 = 0;
            GlobalVar.商品管理 = 0;
            GlobalVar.員工管理 = 0;
            GlobalVar.訂單管理 = 0;
            GlobalVar.訂單管理 += 1;
            CustomerManagement mycm = new CustomerManagement();
            mycm.ShowDialog();
        }
    }
}
