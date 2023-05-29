using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 麥當勞訂購系統
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        List<string> list_Customers_account = new List<string>();
        List<string> list_Customers_password = new List<string>();        
        List<int> listID = new List<int>();
        int click = 0;

        private void Login_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder Mcd = new SqlConnectionStringBuilder();
            Mcd.DataSource = @"."; // 連接本機資料庫
            Mcd.InitialCatalog = "McdonaldsOrderSystem";
            Mcd.IntegratedSecurity = true; // 資料庫驗證
            GlobalVar.strMyMcdonaldsString = Mcd.ConnectionString;
            SQLLoading();
            chB管理登入.Visible = false;
        }

        void SQLLoading()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
            con.Open();
            string strSQL = "select * from Customers ;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();           
            int count = 0;
            while (reader.Read() == true)
            {
                listID.Add((int)reader["id"]);
                list_Customers_account.Add((string)reader["Email"]);
                list_Customers_password.Add((string)reader["password"]);  
                count += 1;
            }
            //Console.WriteLine($"讀取{count}資料");
            reader.Close();
            con.Close();

        }

        private void btn註冊會員_Click(object sender, EventArgs e)
        {
            GlobalVar.註冊 += 1;
            GlobalVar.顧客已登入 = 0;
            CustomerInFo myCustomerInFo = new CustomerInFo();
            myCustomerInFo.ShowDialog();
        }

        private void txtBox帳號_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox密碼_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btn登入_Click(object sender, EventArgs e)
        {
            
            bool isEnglishphone = Regex.IsMatch(txtBox帳號.Text, @"^[0-9]+$");
            bool isEnglishpassword = Regex.IsMatch(txtBox密碼.Text, @"^[a-zA-Z0-9]+$");
            
            if (txtBox帳號.Text != "" && txtBox密碼.Text != "" && isEnglishphone == true && isEnglishpassword == true)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                string strSQL = "select * from Employees where PhoneNumber = @NewPhone and password = @NewPassword ;";
                string strSQL2 = "select* from Customers where PhoneNumber = @NewPhone and password = @NewPassword ;";

                
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@NewPhone", txtBox帳號.Text);
                cmd.Parameters.AddWithValue("@NewPassword", txtBox密碼.Text);
                SqlDataReader reader = cmd.ExecuteReader();
                
                              
                if (chB管理登入.Checked == true)
                {
                    if (reader.Read())
                    {
                        if ((int)reader["permission"] <= 100)
                        {
                            string strname = reader["EmployeeName"].ToString();
                            MessageBox.Show($"您好 ! {strname}");
                            OrderHome myorderhone = new OrderHome();
                            myorderhone.ShowDialog();
                            CustomerInFo mycustomerinfo = new CustomerInFo();
                            con.Close();
                            Close();
                            myorderhone.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show(" 例外錯誤 : 賦予權限錯誤 !");
                        }
                        
                    }
                    else
                    {
                        MessageBox.Show(" 登入失敗 ! 帳號或密碼錯誤  ");
                    }                                                                            
                }

                else
                {
                    con.Close();
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand(strSQL2, con);
                    cmd2.Parameters.AddWithValue("@NewPhone", txtBox帳號.Text);
                    cmd2.Parameters.AddWithValue("@NewPassword", txtBox密碼.Text);
                    SqlDataReader reader2 = cmd2.ExecuteReader();
                    if (reader2.Read())
                    {
                        if ((int)reader2["permission"] >= 1000)
                        {
                            
                            MessageBox.Show("登入成功");
                            OrderHome myorderhone = new OrderHome();
                            myorderhone.Controls["btn商品管理"].Hide();
                            myorderhone.Controls["btn員工管理"].Hide();
                            myorderhone.Controls["btn訂單管理"].Hide();
                            myorderhone.Controls["btn會員管理"].Hide();
                            GlobalVar.顧客已登入 += 1;
                            ArrayList 顧客登入資訊 = new ArrayList();
                            顧客登入資訊.Add((string)reader2["CustomerName"]);
                            顧客登入資訊.Add((string)reader2["Address"]);
                            顧客登入資訊.Add((string)reader2["PhoneNumber"]);
                            顧客登入資訊.Add((string)reader2["Email"]);
                            顧客登入資訊.Add((int)reader2["id"]);
                            GlobalVar.顧客資訊.Add(顧客登入資訊);                            
                            con.Close();                            
                            myorderhone.ShowDialog();                            
                        }
                        else
                        {
                            MessageBox.Show(" 例外錯誤 : 賦予權限錯誤 !");
                        }
                    }
                    else
                    {
                        MessageBox.Show(" 登入失敗 ! 帳號或密碼錯誤  ");
                    }

                }
                
            }
            else
            {
                
                MessageBox.Show(" 無此帳號及密碼 ! ");
            }
        }

        private void btn免註冊訂餐_Click(object sender, EventArgs e)
        {
            GlobalVar.顧客已登入 = 0;
            GlobalVar.顧客資訊.Clear();
            GlobalVar.list訂購商品資訊.Clear();
            Form1 myform = new Form1();
            myform.ShowDialog();
        }

        private void Login_MouseClick(object sender, MouseEventArgs e)
        {
            click += 1;
            if(click == 3)
            {
                chB管理登入.Visible = true;
            }

        }
    }
}
