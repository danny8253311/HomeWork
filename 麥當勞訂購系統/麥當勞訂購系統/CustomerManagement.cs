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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        List<string> list商品分類 = new List<string>();
        int 漢堡 = 0;
        int 超值全餐 = 0;
        int 點心小品 = 0;
        int 飲料 = 0;
        int 快樂分享餐 = 0;
        DialogResult A;

        string 所選商品分類;
        private void CustomerManagement_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'mcDonaldsOrderSystemDataSet.Customers' 資料表。您可以視需要進行移動或移除。
            this.customersTableAdapter.Fill(this.mcDonaldsOrderSystemDataSet.Customers);

            SqlConnectionStringBuilder Mcd = new SqlConnectionStringBuilder();
            Mcd.DataSource = @"."; // 連接本機資料庫
            Mcd.InitialCatalog = "McdonaldsOrderSystem";
            Mcd.IntegratedSecurity = true; // 資料庫驗證
            GlobalVar.strMyMcdonaldsString = Mcd.ConnectionString;
            
            list商品分類.Add("超值全餐");
            list商品分類.Add("漢堡");            
            list商品分類.Add("點心小品");
            list商品分類.Add("飲料");
            list商品分類.Add("快樂分享餐");
            

            進入商品管理();            
            進入會員管理();         
            進入員工管理();
            進入訂單管理();
            foreach (string item in list商品分類)
            {
                cbB商品總類.Items.Add(item);                
            }

        }

        void 導入資料庫(string SQL)
        {
            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
            con.Open();                      
            SqlCommand cmd = new SqlCommand(SQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.HasRows) // HasRoWs 是布林值只能get
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView讀取資料庫.DataSource = dt;
            }
            reader.Close();
            con.Close();
        }
        void 進入商品管理()
        {
            
            if (GlobalVar.商品管理 == 1)
            {
                lblID.Visible = false;

                if (漢堡 == 1)
                {
                    
                    lbl標題.Text = "商品與庫存管理";
                    lbl任意內容1.Text = "餐點名稱";
                    lbl任意內容1.Location = new Point(904, 129);
                    lbl任意內容2.Text = "價格";
                    lbl任意內容3.Text = "庫存數量";
                    lbl任意內容3.Location = new Point(904, 365);
                    lbl任意內容4.Text = "image";
                    lbl任意內容4.Location = new Point(927, 483);
                    lbl任意內容5.Hide();                    
                    txt任意內容1.Text = "";
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;

                    txt任意內容3.Text = "";
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;

                    txt任意內容5.Visible = false;
                    string SQL = "select id,漢堡名稱,價格,庫存,image from Burger ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 150;
                    dataGridView讀取資料庫.Columns[2].Width = 150;
                    dataGridView讀取資料庫.Columns[3].Width = 150;
                    dataGridView讀取資料庫.Columns[4].Width = 150;
                }
                if (超值全餐 == 1)
                {

                    lbl標題.Text = "商品與庫存管理";
                    lbl任意內容1.Text = "漢堡";
                    lbl任意內容1.Location = new Point(930, 129);
                    lbl任意內容2.Text = "薯條";
                    lbl任意內容3.Text = "飲料";
                    lbl任意內容3.Location = new Point(929, 365);
                    lbl任意內容4.Text = "價格";
                    lbl任意內容5.Visible = true;
                    lbl任意內容5.Text = "image";
                    lbl任意內容5.Location = new Point(916, 597);
                    txt任意內容1.Text = "";

                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;

                    txt任意內容3.Text = "";
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;
                    txt任意內容5.Visible = true;
                    txt任意內容5.Text = "";
                    txt任意內容5.TextAlign = HorizontalAlignment.Center;
                    string SQL = "select id,漢堡名稱,薯條,飲料,價格,image from GreatValueFullMeal ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 150;
                    dataGridView讀取資料庫.Columns[2].Width = 150;
                    dataGridView讀取資料庫.Columns[3].Width = 150;
                    dataGridView讀取資料庫.Columns[4].Width = 150;
                    dataGridView讀取資料庫.Columns[5].Width = 150;
                }
                if (點心小品 == 1)
                {
                    
                    lbl標題.Text = "商品與庫存管理";
                    lbl任意內容1.Text = "餐點名稱";
                    lbl任意內容1.Location = new Point(904, 129);
                    lbl任意內容2.Text = "價格";
                    lbl任意內容3.Text = "庫存數量";
                    lbl任意內容3.Location = new Point(904, 365); 
                    lbl任意內容4.Text = "image";
                    lbl任意內容4.Location = new Point(927, 483);
                    lbl任意內容5.Visible = false;
                    txt任意內容1.Text = "";
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;

                    txt任意內容3.Text = "";
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;

                    txt任意內容5.Visible = false;
                    string SQL = "select id,點心小品名稱,價格,庫存,image from Dessert ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 150;
                    dataGridView讀取資料庫.Columns[2].Width = 150;
                    dataGridView讀取資料庫.Columns[3].Width = 150;
                    dataGridView讀取資料庫.Columns[4].Width = 150;
                }
                if (飲料 == 1)
                {
                    
                    lbl標題.Text = "商品與庫存管理";
                    lbl任意內容1.Text = "餐點名稱";
                    lbl任意內容1.Location = new Point(904, 129);
                    lbl任意內容2.Text = "價格";
                    lbl任意內容3.Text = "庫存數量";
                    lbl任意內容3.Location = new Point(904, 365);
                    lbl任意內容4.Text = "image";
                    lbl任意內容4.Location = new Point(927, 483);
                    lbl任意內容5.Visible = false;
                    txt任意內容1.Text = "";
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;

                    txt任意內容3.Text = "";
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;

                    txt任意內容5.Visible = false;
                    string SQL = "select id,飲料名稱,價格,庫存,image from Drink1 ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 150;
                    dataGridView讀取資料庫.Columns[2].Width = 150;
                    dataGridView讀取資料庫.Columns[3].Width = 150;
                    dataGridView讀取資料庫.Columns[4].Width = 150;
                }
                if (快樂分享餐 == 1)
                {
                    
                    lbl標題.Text = "商品與庫存管理";
                    lbl任意內容1.Text = "餐點名稱";
                    lbl任意內容2.Text = "價格";
                    lbl任意內容3.Text = "庫存數量";
                    lbl任意內容4.Text = "image";
                    lbl任意內容5.Hide();
                    txt任意內容1.Text = "";
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;

                    txt任意內容3.Text = "";
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;

                    txt任意內容5.Hide();
                    string SQL = "select id,快樂分享餐名稱,價格,庫存,image from HappyMeal ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 150;
                    dataGridView讀取資料庫.Columns[2].Width = 150;
                    dataGridView讀取資料庫.Columns[3].Width = 150;
                    dataGridView讀取資料庫.Columns[4].Width = 150;
                }
            }
        }

        void 進入會員管理()
        {
            if (GlobalVar.會員管理 == 1)
            {

                try
                {
                    cbB商品總類.Visible = false;
                    lbl標題.Text = "會員管理";
                    txt任意內容2.Width = 150;
                    lbl任意內容1.Text = "顧客姓名";
                    lbl任意內容2.Text = "地址";
                    lbl任意內容3.Text = "電話號碼";
                    lbl任意內容4.Text = "Email";
                    lbl任意內容5.Text = "密碼";
                    lblID.Visible = false;

                    txt任意內容1.Text = "";
                    txt任意內容1.Font = new Font("微軟正黑體", 16);
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.Font = new Font("微軟正黑體", 12);
                    txt任意內容2.Width = 250;
                    txt任意內容2.Location = new Point(850, 293);
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;


                    txt任意內容3.Text = "";
                    txt任意內容3.Font = new Font("微軟正黑體", 16);
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.Font = new Font("微軟正黑體", 12);
                    txt任意內容4.Width = 250;
                    txt任意內容4.Location = new Point(856, 546);
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;

                    txt任意內容5.Text = "";
                    txt任意內容5.Font = new Font("微軟正黑體", 12);
                    txt任意內容5.TextAlign = HorizontalAlignment.Center;

                    string SQL = "select id,CustomerName as 顧客姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Customers ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 90;
                    dataGridView讀取資料庫.Columns[2].Width = 210;
                    dataGridView讀取資料庫.Columns[3].Width = 100;
                    dataGridView讀取資料庫.Columns[4].Width = 180;
                    dataGridView讀取資料庫.Columns[5].Width = 80;
                }
                catch
                {
                    MessageBox.Show("目前沒有會員資料");
                }
                

                
            }
        }
        void 進入員工管理()
        {
            if (GlobalVar.員工管理 == 1)
            {
                try
                {
                    cbB商品總類.Visible = false;
                    lbl標題.Text = "員工管理";
                    lbl任意內容1.Text = "員工姓名";
                    lbl任意內容2.Text = "地址";
                    lbl任意內容3.Text = "電話號碼";
                    lbl任意內容4.Text = "Email";
                    lbl任意內容5.Text = "密碼";
                    lblID.Visible = false;
                    txt任意內容1.Text = "";
                    txt任意內容1.Font = new Font("微軟正黑體", 16);
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;

                    txt任意內容2.Text = "";
                    txt任意內容2.Font = new Font("微軟正黑體", 12);
                    txt任意內容2.Width = 250;
                    txt任意內容2.Location = new Point(850, 293);
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;

                    txt任意內容3.Text = "";
                    txt任意內容3.Font = new Font("微軟正黑體", 16);
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;

                    txt任意內容4.Text = "";
                    txt任意內容4.Font = new Font("微軟正黑體", 12);
                    txt任意內容4.Width = 250;
                    txt任意內容4.Location = new Point(846, 546);
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;

                    txt任意內容5.Text = "";
                    txt任意內容5.Font = new Font("微軟正黑體", 12);
                    txt任意內容5.TextAlign = HorizontalAlignment.Center;


                    string SQL = "select id,EmployeeName as 員工姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Employees ;";
                    導入資料庫(SQL);

                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Visible = false;
                    dataGridView讀取資料庫.Columns[1].Width = 90;
                    dataGridView讀取資料庫.Columns[2].Width = 210;
                    dataGridView讀取資料庫.Columns[3].Width = 100;
                    dataGridView讀取資料庫.Columns[4].Width = 180;
                    dataGridView讀取資料庫.Columns[5].Width = 80;
                }
                catch
                {
                    MessageBox.Show("目前沒有員工資料");
                }
                
            }
        }
        void 進入訂單管理()
        {
            try
            {
                if (GlobalVar.訂單管理 == 1)
                {

                    lbl標題.Text = "訂單管理";
                    lbl任意內容1.Text = "訂單編號";
                    lbl任意內容1.Location = new Point(904, 129);
                    lbl任意內容2.Text = "客戶姓名";
                    lbl任意內容2.Location = new Point(907, 237);
                    lbl任意內容3.Text = "客戶電話";
                    lbl任意內容4.Text = "地址";
                    lbl任意內容5.Text = "訂單成立時間";
                    lbl任意內容5.Location = new Point(866, 597);
                    txt任意內容1.Text = "";
                    txt任意內容1.TextAlign = HorizontalAlignment.Center;
                    txt任意內容2.Text = "";
                    txt任意內容2.TextAlign = HorizontalAlignment.Center;
                    txt任意內容3.Text = "";
                    txt任意內容3.TextAlign = HorizontalAlignment.Center;
                    txt任意內容4.Text = "";
                    txt任意內容4.Location = new Point(838, 546);
                    txt任意內容4.Width = 270;
                    txt任意內容4.TextAlign = HorizontalAlignment.Center;
                    txt任意內容5.Text = "";
                    txt任意內容5.TextAlign = HorizontalAlignment.Center;
                    txt任意內容5.Width = 220;
                    txt任意內容5.Location = new Point(856, 650);

                    button2.Hide();
                    cbB商品總類.Hide();
                    lblID.Hide();

                    string SQL = "select 訂單編號,客戶ID,客戶姓名,客戶電話,地址,商品ID,商品名稱,訂單金額,訂單成立時間 from OderTime ;";
                    導入資料庫(SQL);
                    foreach (DataGridViewColumn column in dataGridView讀取資料庫.Columns)
                    {
                        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    }
                    dataGridView讀取資料庫.Columns[0].Width = 80;
                    dataGridView讀取資料庫.Columns[1].Width = 70;
                    dataGridView讀取資料庫.Columns[2].Width = 80;
                    dataGridView讀取資料庫.Columns[3].Width = 100;
                    dataGridView讀取資料庫.Columns[4].Width = 100;
                    dataGridView讀取資料庫.Columns[5].Width = 70;
                    dataGridView讀取資料庫.Columns[6].Width = 80;
                    dataGridView讀取資料庫.Columns[7].Width = 80;
                    dataGridView讀取資料庫.Columns[8].Width = 100;


                }
            }
            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
            
        }
        private void btn儲存變更_Click(object sender, EventArgs e)
        {
            try
            {
            if(GlobalVar.會員管理 == 1)
            {
                int intID = 0;
                Int32.TryParse(lblID.Text, out intID);
                bool isChinese姓名 = Regex.IsMatch(txt任意內容1.Text, @"[\u4e00-\u9fa5]+");
                bool isEnglishEmail = Regex.IsMatch(txt任意內容4.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");


                if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != ""  && txt任意內容3.Text.Length == 10 && isChinese姓名 == true && isEnglishEmail == true)
                {
                    
                    SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                    con.Open();

                    string strSQL = "UPDATE Customers set  CustomerName = @NewName, PhoneNumber = @NewPhone, password = @NewPassword, address = @NewAddress,Email = @NewEmail where id = @SearchID;";

                    SqlCommand cmd = new SqlCommand(strSQL, con);
                    cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewAddress", txt任意內容2.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewPhone", txt任意內容3.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewEmail", txt任意內容4.Text.Trim());
                    cmd.Parameters.AddWithValue("@NewPassword", txt任意內容5.Text.Trim());
                    cmd.Parameters.AddWithValue("@SearchID", intID);                   
                    int rows = cmd.ExecuteNonQuery();   
                    
                                              
                    MessageBox.Show("儲存變更成功");

                    con.Close();
                }
                else
                {
                    MessageBox.Show("填寫資料有誤 !! \n請重新輸入 !");
                }
                string SQL = "select id,CustomerName as 顧客姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Customers ;";
                導入資料庫(SQL);
            }
            if (GlobalVar.商品管理 == 1)
            {
                int intID = 0;
                Int32.TryParse(lblID.Text, out intID);
                
                if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "")
                {
                    if (漢堡 == 1)
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "UPDATE Burger set  漢堡名稱 = @NewName, 價格 = @NewPrice, 庫存 = @NewInventory,image = @NewImage where id = @SearchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("儲存變更成功");

                        con.Close();
                        string SQL = "select id,漢堡名稱,價格,庫存,image from Burger ;";
                        導入資料庫(SQL);
                    }

                    if (點心小品 == 1)
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "UPDATE Dessert set  點心小品名稱 = @NewName, 價格 = @NewPrice, 庫存 = @NewInventory,image = @NewImage where id = @SearchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("儲存變更成功");

                        con.Close();
                        string SQL = "select id,點心小品名稱,價格,庫存,image from Dessert ;";
                        導入資料庫(SQL);
                    }

                    if (飲料 == 1)
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "UPDATE Drink1 set  飲料名稱 = @NewName, 價格 = @NewPrice, 庫存 = @NewInventory,image = @NewImage where id = @SearchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("儲存變更成功");

                        con.Close();
                        string SQL = "select id,飲料名稱,價格,庫存,image from Drink1 ;";
                        導入資料庫(SQL);
                    }

                    if (超值全餐 == 1)
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();
                        string strSQL = "UPDATE GreatValueFullMeal set  超值全餐 = @NewName, 薯條 = @NewFries, 飲料 = @NewDrink,價格 = @NewPrice, image = @NewImage where id = @SearchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewFries", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewDrink", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPrice", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("儲存變更成功");

                        con.Close();
                        string SQL = "select id, 超值全餐, 薯條, 飲料, 價格, image from GreatValueFullMeal ;";
                        導入資料庫(SQL);
                    }

                    if (快樂分享餐 == 1)
                    {
                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "UPDATE HappyMeal set  快樂分享餐名稱 = @NewName, 價格 = @NewPrice, 庫存 = @NewInventory,image = @NewImage where id = @SearchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("儲存變更成功");

                        con.Close();
                        string SQL = "select id, 快樂分享餐名稱, 價格, 庫存, image from HappyMeal ;";
                        導入資料庫(SQL);
                    }
                }
                else
                {
                    MessageBox.Show(" 請輸入資料 ! ");
                }
                
            }
            if (GlobalVar.員工管理 == 1)
            {
                try
                {
                    int intID = 0;
                    Int32.TryParse(lblID.Text, out intID);
                    bool isChinese姓名 = Regex.IsMatch(txt任意內容1.Text, @"[\u4e00-\u9fa5]+");
                    bool isEnglishEmail = Regex.IsMatch(txt任意內容4.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");


                    if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != "" && txt任意內容3.Text.Length == 10 && isChinese姓名 == true && isEnglishEmail == true)
                    {

                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "UPDATE Employees set  EmployeeName = @NewName, PhoneNumber = @NewPhone, password = @NewPassword, address = @NewAddress,Email = @NewEmail where id = @SearchID;";

                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewAddress", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPhone", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewEmail", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPassword", txt任意內容5.Text.Trim());
                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("儲存變更成功");

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("填寫資料有誤 !! \n請重新輸入 !");
                    }
                    string SQL = "select id,EmployeesName as 員工姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Customers ;";
                    導入資料庫(SQL);
                }
                catch
                {
                    MessageBox.Show("資料重複 !");
                }
                
            }
            }

            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
        }

        private void lbl標題_Click(object sender, EventArgs e)
        {

        }

        private void btn返回菜單_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView自定義表格_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView讀取資料庫_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {


                if (e.RowIndex >= 0)
                {
                    string strselectedID = dataGridView讀取資料庫.Rows[e.RowIndex].Cells[0].Value.ToString();
                    int selectedID = 0; // Rows 代表列 選取到的列都會存在Rows裡面
                    Int32.TryParse(strselectedID, out selectedID);

                    if (GlobalVar.商品管理 == 1)
                    {
                        if (漢堡 == 1)
                        {
                            if (selectedID > 0)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();
                                string strSQL = "select * from Burger where id = @SelectID;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@SelectID", selectedID);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read() == true)
                                {
                                    lblID.Text = reader["id"].ToString();
                                    txt任意內容1.Text = reader["漢堡名稱"].ToString();
                                    txt任意內容2.Text = reader["價格"].ToString();
                                    txt任意內容3.Text = reader["庫存"].ToString();
                                    txt任意內容4.Text = reader["image"].ToString();
                                }
                                reader.Close();
                                con.Close();
                            }

                        }
                        if (飲料 == 1)
                        {
                            if (selectedID > 0)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();
                                string strSQL = "select * from Drink1 where id = @SelectID;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@SelectID", selectedID);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read() == true)
                                {
                                    lblID.Text = reader["id"].ToString();
                                    txt任意內容1.Text = reader["飲料名稱"].ToString();
                                    txt任意內容2.Text = reader["價格"].ToString();
                                    txt任意內容3.Text = reader["庫存"].ToString();
                                    txt任意內容4.Text = reader["image"].ToString();
                                }
                                reader.Close();
                                con.Close();
                            }
                        }
                        if (點心小品 == 1)
                        {
                            if (selectedID > 0)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();
                                string strSQL = "select * from Dessert where id = @SelectID;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@SelectID", selectedID);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read() == true)
                                {
                                    lblID.Text = reader["id"].ToString();
                                    txt任意內容1.Text = reader["點心小品名稱"].ToString();
                                    txt任意內容2.Text = reader["價格"].ToString();
                                    txt任意內容3.Text = reader["庫存"].ToString();
                                    txt任意內容4.Text = reader["image"].ToString();
                                }
                                reader.Close();
                                con.Close();
                            }

                        }
                        if (超值全餐 == 1)
                        {
                            if (selectedID > 0)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();
                                string strSQL = "select * from GreatValueFullMeal where id = @SelectID;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@SelectID", selectedID);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read() == true)
                                {
                                    lblID.Text = reader["id"].ToString();
                                    txt任意內容1.Text = reader["漢堡名稱"].ToString();
                                    txt任意內容2.Text = reader["薯條"].ToString();
                                    txt任意內容3.Text = reader["飲料"].ToString();
                                    txt任意內容4.Text = reader["價格"].ToString();
                                    txt任意內容5.Text = reader["image"].ToString();
                                }
                                reader.Close();
                                con.Close();
                            }

                        }
                        if (快樂分享餐 == 1)
                        {
                            if (selectedID > 0)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();
                                string strSQL = "select * from HappyMeal where id = @SelectID;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@SelectID", selectedID);
                                SqlDataReader reader = cmd.ExecuteReader();
                                if (reader.Read() == true)
                                {
                                    lblID.Text = reader["id"].ToString();
                                    txt任意內容1.Text = reader["快樂分享餐名稱"].ToString();
                                    txt任意內容2.Text = reader["價格"].ToString();
                                    txt任意內容3.Text = reader["庫存"].ToString();
                                    txt任意內容4.Text = reader["image"].ToString();
                                    txt任意內容5.Visible = false;
                                }
                                reader.Close();
                                con.Close();
                            }
                        }


                    }
                    if (GlobalVar.會員管理 == 1)
                    {
                        if (selectedID > 0)
                        {
                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();
                            string strSQL = "select * from Customers where id = @SelectID;";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@SelectID", selectedID);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read() == true)
                            {
                                lblID.Text = reader["id"].ToString();
                                txt任意內容1.Text = reader["CustomerName"].ToString();
                                txt任意內容2.Text = reader["address"].ToString();
                                txt任意內容3.Text = reader["PhoneNumber"].ToString();
                                txt任意內容4.Text = reader["Email"].ToString();
                                txt任意內容5.Text = reader["password"].ToString();
                            }
                            reader.Close();
                            con.Close();
                        }
                    }
                    if (GlobalVar.員工管理 == 1)
                    {
                        if (selectedID > 0)
                        {

                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();
                            string strSQL = "select * from Employees where id = @SelectID;";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@SelectID", selectedID);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read() == true)
                            {
                                lblID.Text = reader["id"].ToString();
                                txt任意內容1.Text = reader["EmployeeName"].ToString();
                                txt任意內容2.Text = reader["address"].ToString();
                                txt任意內容3.Text = reader["PhoneNumber"].ToString();
                                txt任意內容4.Text = reader["Email"].ToString();
                                txt任意內容5.Text = reader["password"].ToString();
                            }
                            reader.Close();
                            con.Close();
                        }

                    }
                    if (GlobalVar.訂單管理 == 1)
                    {
                        if (selectedID > 0)
                        {

                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();
                            string strSQL = "select * from OderTime where 訂單編號 = @SelectID;";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@SelectID", selectedID);
                            SqlDataReader reader = cmd.ExecuteReader();
                            if (reader.Read() == true)
                            {
                                lblID.Visible = false;
                                txt任意內容1.Text = reader["訂單編號"].ToString();
                                txt任意內容2.Text = reader["客戶姓名"].ToString();
                                txt任意內容3.Text = reader["客戶電話"].ToString();
                                txt任意內容4.Text = reader["地址"].ToString();
                                txt任意內容5.Text = reader["訂單成立時間"].ToString();
                            }
                            reader.Close();
                            con.Close();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
        }

        private void cbB商品總類_SelectedIndexChanged(object sender, EventArgs e)
        {
            所選商品分類 = list商品分類[cbB商品總類.SelectedIndex];
            if (所選商品分類 == "漢堡")
            {
                快樂分享餐 = 0;
                超值全餐 = 0;
                點心小品 = 0;
                飲料 = 0;
                漢堡 += 1;
                進入商品管理();
            }
            if (所選商品分類 == "快樂分享餐")
            {
                快樂分享餐 += 1;
                超值全餐 = 0;
                點心小品 = 0;
                飲料 = 0;
                漢堡 = 0;
                進入商品管理();
            }
            if (所選商品分類 == "超值全餐")
            {
                快樂分享餐 = 0;
                超值全餐 += 1;
                點心小品 = 0;
                飲料 = 0;
                漢堡 = 0;
                進入商品管理();
            }
            if (所選商品分類 == "飲料")
            {
                快樂分享餐 = 0;
                超值全餐 = 0;
                點心小品 = 0;
                飲料 += 1;
                漢堡 = 0;
                進入商品管理();
            }
            if (所選商品分類 == "點心小品")
            {
                快樂分享餐 = 0;
                超值全餐 = 0;
                點心小品 += 1;
                飲料 = 0;
                漢堡 = 0;
                進入商品管理();
            }
        }

        private void btn新增_Click(object sender, EventArgs e)
        {
            try
            {

                if (GlobalVar.商品管理 == 1)
                {
                    int intID = 0;
                    Int32.TryParse(lblID.Text, out intID);

                    if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "")
                    {
                        if (漢堡 == 1)
                        {
                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "INSERT INTO Burger VALUES (@NewName, @NewPrice,@NewInventory, @NewImage);";


                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            MessageBox.Show("新增成功");

                            con.Close();
                            string SQL = "select id,漢堡名稱,價格,庫存,image from Burger ;";
                            導入資料庫(SQL);
                        }

                        if (點心小品 == 1)
                        {
                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "INSERT INTO Dessert VALUES (@NewName, @NewPrice,@NewInventory, @NewImage);";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            MessageBox.Show("新增成功");

                            con.Close();
                            string SQL = "select id,點心小品名稱,價格,庫存,image from Dessert ;";
                            導入資料庫(SQL);
                        }

                        if (飲料 == 1)
                        {
                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "INSERT INTO Drink1 VALUES (@NewName, @NewPrice,@NewInventory, @NewImage);";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            MessageBox.Show("新增成功");

                            con.Close();
                            string SQL = "select id,飲料名稱,價格,庫存,image from Drink1 ;";
                            導入資料庫(SQL);
                        }

                        if (超值全餐 == 1)
                        {
                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();
                            string strSQL = "INSERT INTO GreatValueFullMeal VALUES (@NewName, @NewFries, @NewDrink, @NewPrice, @NewImage);";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewFries", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewDrink", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPrice", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            MessageBox.Show("新增成功");

                            con.Close();
                            string SQL = "select id, 超值全餐, 薯條, 飲料, 價格, image from GreatValueFullMeal ;";
                            導入資料庫(SQL);
                        }

                        if (快樂分享餐 == 1)
                        {
                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();
                            string strSQL = "INSERT INTO HappyMeal VALUES (@NewName,@NewContent,@NewPrice,@NewInventory, @NewImage);";

                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            MessageBox.Show("新增成功");

                            con.Close();
                            string SQL = "select id, 快樂分享餐名稱, 價格, 庫存, image from HappyMeal ;";
                            導入資料庫(SQL);
                        }
                    }
                    else
                    {
                        MessageBox.Show(" 請輸入資料 ! ");
                    }
                }
                if (GlobalVar.會員管理 == 1)
                {
                    int intID = 0;
                    Int32.TryParse(lblID.Text, out intID);
                    bool isChinese姓名 = Regex.IsMatch(txt任意內容1.Text, @"[\u4e00-\u9fa5]+");
                    bool isEnglishEmail = Regex.IsMatch(txt任意內容4.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");


                    if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != "" && txt任意內容3.Text.Length == 10 && isChinese姓名 == true && isEnglishEmail == true)
                    {

                        SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                        con.Open();

                        string strSQL = "INSERT INTO Customers  VALUES (@NewName, @NewAddress, @NewPhone, NULL,@NewEmail, @NewPassword, 1000);";


                        SqlCommand cmd = new SqlCommand(strSQL, con);
                        cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewAddress", txt任意內容2.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPhone", txt任意內容3.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewEmail", txt任意內容4.Text.Trim());
                        cmd.Parameters.AddWithValue("@NewPassword", txt任意內容5.Text.Trim());

                        cmd.Parameters.AddWithValue("@SearchID", intID);
                        int rows = cmd.ExecuteNonQuery();


                        MessageBox.Show("新增成功");

                        con.Close();
                    }
                    else
                    {
                        MessageBox.Show("填寫資料有誤 !! \n請重新輸入 !");
                    }
                    string SQL = "select id,CustomerName as 顧客姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Customers ;";
                    導入資料庫(SQL);
                }
                if (GlobalVar.員工管理 == 1)
                {
                    try
                    {
                        int intID = 0;
                        Int32.TryParse(lblID.Text, out intID);
                        bool isChinese姓名 = Regex.IsMatch(txt任意內容1.Text, @"[\u4e00-\u9fa5]+");
                        bool isEnglishEmail = Regex.IsMatch(txt任意內容4.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");


                        if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != "" && txt任意內容3.Text.Length == 10 && isChinese姓名 == true && isEnglishEmail == true)
                        {

                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "INSERT INTO Employees  VALUES (@NewName, @NewAddress, @NewPhone, NULL,@NewEmail, @NewPassword, 100);";


                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewAddress", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPhone", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewEmail", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPassword", txt任意內容5.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            MessageBox.Show("新增成功");

                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show("填寫資料有誤 !! \n請重新輸入 !");
                        }
                        string SQL = "select id,EmployeeName as 顧客姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Employees ;";
                        導入資料庫(SQL);
                    }
                    catch
                    {
                        MessageBox.Show("電話號碼已被註冊 ! ");
                    }

                }
            }
            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
            

        }




        private void btn刪除_Click(object sender, EventArgs e)
        {
            try
            {
                if (GlobalVar.商品管理 == 1)
                {
                    try
                    {
                        int intID = 0;
                        Int32.TryParse(lblID.Text, out intID);

                        if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "")
                        {
                            if (漢堡 == 1)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();

                                string strSQL = "DELETE FROM Burger where 漢堡名稱 = @NewName ;";


                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                                cmd.Parameters.AddWithValue("@SearchID", intID);
                                int rows = cmd.ExecuteNonQuery();

                                A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (A == DialogResult.Yes)
                                {
                                    MessageBox.Show("刪除成功");
                                }


                                con.Close();
                                string SQL = "select id,漢堡名稱,價格,庫存,image from Burger ;";
                                導入資料庫(SQL);
                            }

                            if (點心小品 == 1)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();

                                string strSQL = "DELETE FROM Dessert where 點心小品名稱 = @NewName;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                                cmd.Parameters.AddWithValue("@SearchID", intID);
                                int rows = cmd.ExecuteNonQuery();


                                A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (A == DialogResult.Yes)
                                {
                                    MessageBox.Show("刪除成功");
                                }

                                con.Close();
                                string SQL = "select id,點心小品名稱,價格,庫存,image from Dessert ;";
                                導入資料庫(SQL);
                            }

                            if (飲料 == 1)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();

                                string strSQL = "DELETE FROM Drink1 where 飲料名稱 = @NewName;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                                cmd.Parameters.AddWithValue("@SearchID", intID);
                                int rows = cmd.ExecuteNonQuery();


                                A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (A == DialogResult.Yes)
                                {
                                    MessageBox.Show("刪除成功");
                                }

                                con.Close();
                                string SQL = "select id,飲料名稱,價格,庫存,image from Drink1 ;";
                                導入資料庫(SQL);
                            }

                            if (超值全餐 == 1)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();
                                string strSQL = "DELETE FROM GreatValueFullMeal where 超值全餐 = @NewName;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewFries", txt任意內容2.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewDrink", txt任意內容3.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewPrice", txt任意內容4.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                                cmd.Parameters.AddWithValue("@SearchID", intID);
                                int rows = cmd.ExecuteNonQuery();


                                A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (A == DialogResult.Yes)
                                {
                                    MessageBox.Show("刪除成功");
                                }

                                con.Close();
                                string SQL = "select id, 超值全餐, 薯條, 飲料, 價格, image from GreatValueFullMeal ;";
                                導入資料庫(SQL);
                            }

                            if (快樂分享餐 == 1)
                            {
                                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                                con.Open();

                                string strSQL = "DELETE FROM HappyMeal where 快樂分享餐名稱 = @NewName;";

                                SqlCommand cmd = new SqlCommand(strSQL, con);
                                cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewPrice", txt任意內容2.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewInventory", txt任意內容3.Text.Trim());
                                cmd.Parameters.AddWithValue("@NewImage", txt任意內容4.Text.Trim());
                                cmd.Parameters.AddWithValue("@SearchID", intID);
                                int rows = cmd.ExecuteNonQuery();


                                A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (A == DialogResult.Yes)
                                {
                                    MessageBox.Show("刪除成功");
                                }

                                con.Close();
                                string SQL = "select id, 快樂分享餐名稱, 價格, 庫存, image from HappyMeal ;";
                                導入資料庫(SQL);
                            }
                        }
                    }
                    catch
                    {
                        MessageBox.Show(" 請選擇需要刪除的資料 !　");
                    }

                }
                if (GlobalVar.會員管理 == 1)
                {
                    try
                    {
                        int intID = 0;
                        Int32.TryParse(lblID.Text, out intID);
                        bool isChinese姓名 = Regex.IsMatch(txt任意內容1.Text, @"[\u4e00-\u9fa5]+");
                        bool isEnglishEmail = Regex.IsMatch(txt任意內容4.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");


                        if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != "" && txt任意內容3.Text.Length == 10 && isChinese姓名 == true && isEnglishEmail == true)
                        {

                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "DELETE FROM Customers where CustomerName = @NewName ;";


                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewAddress", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPhone", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewEmail", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPassword", txt任意內容5.Text.Trim());

                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (A == DialogResult.Yes)
                            {
                                MessageBox.Show("刪除成功");
                            }

                            con.Close();
                        }
                        else
                        {
                            MessageBox.Show(" 請選擇需要刪除的資料 !　");
                        }
                        string SQL = "select id,CustomerName as 顧客姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Customers ;";
                        導入資料庫(SQL);
                    }
                    catch
                    {
                        MessageBox.Show(" 請選擇需要刪除的資料 !　");
                    }

                }
                if (GlobalVar.員工管理 == 1)
                {
                    try
                    {
                        int intID = 0;
                        Int32.TryParse(lblID.Text, out intID);
                        bool isChinese姓名 = Regex.IsMatch(txt任意內容1.Text, @"[\u4e00-\u9fa5]+");
                        bool isEnglishEmail = Regex.IsMatch(txt任意內容4.Text, @"^[a-z0-9]+@[a-zA-Z0-9]+.[a-zA-Z]+$");


                        if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != "" && txt任意內容3.Text.Length == 10 && isChinese姓名 == true && isEnglishEmail == true)
                        {

                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "DELETE FROM Employees where EmployeeName = @NewName ";


                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewAddress", txt任意內容2.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPhone", txt任意內容3.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewEmail", txt任意內容4.Text.Trim());
                            cmd.Parameters.AddWithValue("@NewPassword", txt任意內容5.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (A == DialogResult.Yes)
                            {
                                MessageBox.Show("刪除成功");
                            }

                            con.Close();
                        }

                        string SQL = "select id,EmployeeName as 員工姓名,address as 地址,PhoneNumber as 電話號碼, Email, password as 密碼, permission as 權限 from Employees ;";
                        導入資料庫(SQL);
                    }
                    catch
                    {
                        MessageBox.Show("請選擇需要刪除的資料 !　");
                    }

                }
                if (GlobalVar.訂單管理 == 1)
                {
                    try
                    {
                        int intID = 0;
                        Int32.TryParse(lblID.Text, out intID);


                        if (txt任意內容1.Text != "" && txt任意內容2.Text != "" && txt任意內容3.Text != "" && txt任意內容4.Text != "" && txt任意內容5.Text != "")
                        {

                            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                            con.Open();

                            string strSQL = "DELETE FROM OderTime where 訂單編號 = @NewName ";


                            SqlCommand cmd = new SqlCommand(strSQL, con);
                            cmd.Parameters.AddWithValue("@NewName", txt任意內容1.Text.Trim());
                            cmd.Parameters.AddWithValue("@SearchID", intID);
                            int rows = cmd.ExecuteNonQuery();


                            A = MessageBox.Show("您確定要刪除嗎 ? ", "刪除確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                            if (A == DialogResult.Yes)
                            {
                                MessageBox.Show("刪除成功");
                            }

                            con.Close();
                        }

                        string SQL = "select 訂單編號,客戶ID,客戶姓名,客戶電話,地址,商品ID,商品名稱,訂單金額,訂單成立時間 from OderTime ;";
                        導入資料庫(SQL);
                    }
                    catch
                    {
                        MessageBox.Show("請選擇需要刪除的資料 !　");
                    }
                }
            }
            catch
            {
                MessageBox.Show("發生錯誤 ! 請洽後台人員");
            }
        }

        private void dataGridView讀取資料庫_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
