using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 麥當勞訂購系統
{
    public partial class CustomerInFo : Form
    {
        public CustomerInFo()
        {
            InitializeComponent();
        }
        int intID = 0;
        private void CustomerInFo_Load(object sender, EventArgs e)
        {

            try
            {
                SqlConnectionStringBuilder Mcd = new SqlConnectionStringBuilder();
                Mcd.DataSource = @"."; // 連接本機資料庫
                Mcd.InitialCatalog = "McdonaldsOrderSystem";
                Mcd.IntegratedSecurity = true; // 資料庫驗證
                GlobalVar.strMyMcdonaldsString = Mcd.ConnectionString;

                if (GlobalVar.註冊 == 1)
                {
                    btn確認顧客資訊.Hide();
                    GlobalVar.註冊 = 0;
                    lbl優惠碼.Hide();
                    txtBox優惠碼.Hide();
                }
                else
                {
                    btn確認顧客資訊.Show();
                    btn註冊.Hide();
                    lbl密碼.Hide();
                    lbl再次輸入密碼.Hide();

                    txtBox密碼.Hide();
                    txtBox再次輸入密碼.Hide();
                }
                if (GlobalVar.顧客已登入 == 1)
                {
                    lbl客戶ID.Hide();
                    txtBox顧客姓名.Text = GlobalVar.顧客資訊[0][0].ToString();
                    txtBox外送地址.Text = GlobalVar.顧客資訊[0][1].ToString();
                    txtBox電話號碼.Text = GlobalVar.顧客資訊[0][2].ToString();
                    txtBox電子郵件.Text = GlobalVar.顧客資訊[0][3].ToString();
                    lbl客戶ID.Text = GlobalVar.顧客資訊[0][4].ToString();
                    Int32.TryParse(GlobalVar.顧客資訊[0][4].ToString(), out intID);


                    btn確認顧客資訊.Text = "修改顧客資訊";
                }

                txtBox顧客姓名.Tag = "請輸入中文姓名";
                txtBox電話號碼.Tag = "請輸入電話號碼(10碼)";
                txtBox電子郵件.Tag = "請輸入電子郵件";
                txtBox外送地址.Tag = "請輸入外送地址";
                txtBox密碼.Tag = "請輸入英文數字10 ~ 16位密碼";
                txtBox再次輸入密碼.Tag = "請再次輸入英文數字10 ~ 16位密碼";
                txtBox優惠碼.Tag = "請輸入優惠碼";
            }
            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
            
        }

        private void btn確認顧客資訊_Click(object sender, EventArgs e)
        {

            try
            {
                bool isChinese姓名 = Regex.IsMatch(txtBox顧客姓名.Text, @"[\u4e00-\u9fa5]+");
                bool isEnglishEmail = Regex.IsMatch(txtBox電子郵件.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");
                bool isEnglish = Regex.IsMatch(txtBox優惠碼.Text, @"^(?=.*[0-9])(?=.*[a-zA-Z])[0-9a-zA-Z]+$");
                if (GlobalVar.顧客已登入 == 1)
                {
                    if (txtBox顧客姓名.Text != "" && txtBox電話號碼.Text != "" && txtBox外送地址.Text != "" && txtBox電子郵件.Text != "" && txtBox電話號碼.Text.Length == 10 && (isEnglish == true || isEnglish == false) && isChinese姓名 == true && isEnglishEmail == true)
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "UPDATE Customers set  CustomerName = @NewName, PhoneNumber = @NewPhone, address = @NewAddress,Email = @NewEmail where id = @SearchID;";
                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txtBox顧客姓名.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewAddress", txtBox外送地址.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPhone", txtBox電話號碼.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewEmail", txtBox電子郵件.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();

                        MessageBox.Show("修改成功");
                        
                        Close();

                    }
                }
                if (GlobalVar.顧客已登入 == 0)
                {
                    if (txtBox顧客姓名.Text != "" && txtBox電話號碼.Text != "" && txtBox外送地址.Text != "" && txtBox電子郵件.Text != "" && txtBox電話號碼.Text.Length == 10 && (isEnglish == true || isEnglish == false) && isChinese姓名 == true && isEnglishEmail == true)
                    {
                        GlobalVar.顧客已登入 = 0;
                        ArrayList 顧客資料 = new ArrayList();
                        顧客資料.Add(lbl客戶ID.Text);
                        顧客資料.Add(txtBox顧客姓名.Text);
                        顧客資料.Add(txtBox電話號碼.Text);
                        顧客資料.Add(txtBox電子郵件.Text);
                        顧客資料.Add(txtBox外送地址.Text);
                        顧客資料.Add(txtBox優惠碼.Text);
                        GlobalVar.顧客資訊.Add(顧客資料);

                        GlobalVar.顧客資訊已填寫 += 1;
                        MessageBox.Show("填寫成功");
                        Close();

                    }


                    else
                    {
                        MessageBox.Show("填寫資料有誤 !! \n請重新輸入 !");
                    }
                }
            }
            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
       
        }

        private void btn返回_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn註冊_Click(object sender, EventArgs e)
        {
            try
            {
                string ismyPassword = "";
            bool isChinese地址 = Regex.IsMatch(txtBox外送地址.Text, @"[\u4e00-\u9fa5]+[0-9]+$");
            bool isChinese姓名 = Regex.IsMatch(txtBox顧客姓名.Text, @"[\u4e00-\u9fa5]+");
            bool isEnglishEmail = Regex.IsMatch(txtBox電子郵件.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");
            bool isPassword = Regex.IsMatch(txtBox密碼.Text, @"^[a-z0-9]+[a-zA-Z0-9]+$");
            //bool isAgainpassword = Regex.IsMatch(txtBox再次輸入密碼.Text, @"^[a-z0-9]+[a-zA-Z0-9]+$");

            
                if (txtBox顧客姓名.Text != "" && txtBox電話號碼.Text != "" && txtBox外送地址.Text != "" && txtBox電子郵件.Text != "" && txtBox電話號碼.Text.Length == 10 && txtBox密碼.Text != "" && txtBox再次輸入密碼.Text != "" && (isChinese姓名 == true && isEnglishEmail == true && isPassword == true))
                {


                    SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                    con.Open();
                    string strSQL = "INSERT INTO Customers VALUES (@NewName, @NewAddress,@NewPhoneNumber, NULL, @NewEmail, @Password,1000);";
                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    ArrayList 顧客資料 = new ArrayList();
                    顧客資料.Add(cmd.Parameters.AddWithValue("@NewName", txtBox顧客姓名.Text));
                    顧客資料.Add(cmd.Parameters.AddWithValue("@NewAddress", txtBox外送地址.Text));
                    顧客資料.Add(cmd.Parameters.AddWithValue("@NewEmail", txtBox電子郵件.Text));
                    顧客資料.Add(cmd.Parameters.AddWithValue("@Password", txtBox密碼.Text));
                    顧客資料.Add(cmd.Parameters.AddWithValue("@NewPhoneNumber", txtBox電話號碼.Text));
                    顧客資料.Add(ismyPassword = txtBox再次輸入密碼.Text);
                    cmd.ExecuteNonQuery();
                    if (txtBox密碼.Text.Length >= 10 && txtBox密碼.Text.Length <= 16)
                    {
                        if (txtBox再次輸入密碼.Text == ismyPassword)
                        {

                            GlobalVar.顧客資訊.Add(顧客資料);
                            GlobalVar.顧客已登入 += 1;
                            con.Close();
                            MessageBox.Show("填寫成功");
                            Close();
                        }
                        else
                        {
                            MessageBox.Show("密碼不一致 ! 請重新輸入");
                        }
                    }

                    else
                    {
                        MessageBox.Show("密碼長度有誤 ! 請重新輸入");
                    }
                }
                else
                {
                    MessageBox.Show("填寫資料有誤 !! \n請重新輸入 !");
                }
            }
            catch 
            {
                MessageBox.Show("此電話號碼已被註冊過");
            }

        }

        private void txtBox密碼_Click(object sender, EventArgs e)
        {
          
            
        }

       

        private void txtBox顧客姓名_MouseHover(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ToolTip tp = new ToolTip();

            tp.AutoPopDelay = 10000;
            tp.InitialDelay = 100;
            tp.ReshowDelay = 100;
            tp.ShowAlways = true;
            tp.SetToolTip(tb, tb.Tag.ToString());
        }
    }
}
