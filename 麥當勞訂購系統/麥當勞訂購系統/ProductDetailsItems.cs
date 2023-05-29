using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 麥當勞訂購系統
{
    public partial class ProductDetailsItems : Form
    {
        public int OrderID = 0;
        public int OrderDrinkID = 0;
        public int OrderBurgerID = 0;
        public int OrderDessertID = 0;
        public int OrderHappyMealID = 0;

        string image_Burger = "";
        string image_Drink = "";
        string image_Dessert = "";
        string image_GVM = "";
        string image_HappyMeal = "";

        public ProductDetailsItems()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProductDetailsItems_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder scsb = new SqlConnectionStringBuilder();
            scsb.DataSource = @".";
            scsb.InitialCatalog = "McDonaldsOrderSystem";
            scsb.IntegratedSecurity = true;
            GlobalVar.strMyMcdonaldsString = scsb.ConnectionString;
            ProductDetailItems();
            ProductDetailItemsDrink();
            ProductDetailItemsBurger();
            ProductDetailItemsDessert();
            ProductDetailItemsHappyMeal();
        }

        void ProductDetailItems()
        {
            if (OrderID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                string strSQL = "select * from GreatValueFullMeal where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", OrderID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    lbl餐點名稱.Text = reader["超值全餐"].ToString();
                    textBox餐點內容.Text = reader["餐點內容"].ToString();
                    lbl價格.Text = reader["價格"].ToString();
                    image_GVM = reader["image"].ToString();
                    string 圖檔完整路徑 = GlobalVar.image_dir + image_GVM;
                    pictureBox商品照片.Image = Image.FromFile(圖檔完整路徑);

                }

                reader.Close();
                con.Close();
            }
        }

        void ProductDetailItemsDrink()
        {
            if (OrderDrinkID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                string strSQL = "select * from Drink1 where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", OrderDrinkID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    lbl餐點名稱.Text = reader["飲料名稱"].ToString();
                    textBox餐點內容.Text = reader["飲料名稱"].ToString();
                    textBox餐點內容.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    lbl價格.Text = reader["價格"].ToString();
                    image_Drink = reader["image"].ToString();
                    string 圖檔完整路徑 = GlobalVar.image_dir + image_Drink;
                    pictureBox商品照片.Image = Image.FromFile(圖檔完整路徑);
                    

                }

                reader.Close();
                con.Close();
            }
        }
        void ProductDetailItemsBurger()
        {
            if (OrderBurgerID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                string strSQL = "select * from Burger where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", OrderBurgerID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    lbl餐點名稱.Text = reader["漢堡名稱"].ToString();
                    textBox餐點內容.Text = reader["漢堡名稱"].ToString();
                    //textBox餐點內容.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    lbl價格.Text = reader["價格"].ToString();
                    image_Burger = reader["image"].ToString();
                    string 圖檔完整路徑 = GlobalVar.image_dir + image_Burger;
                    pictureBox商品照片.Image = Image.FromFile(圖檔完整路徑);

                }

                reader.Close();
                con.Close();
            }
        }
        void ProductDetailItemsDessert()
        {
            if (OrderDessertID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                string strSQL = "select * from Dessert where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", OrderDessertID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    lbl餐點名稱.Text = reader["點心小品名稱"].ToString();
                    textBox餐點內容.Text = reader["點心小品名稱"].ToString();
                    textBox餐點內容.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    lbl價格.Text = reader["價格"].ToString();
                    image_Dessert = reader["image"].ToString();
                    string 圖檔完整路徑 = GlobalVar.image_dir + image_Dessert;
                    pictureBox商品照片.Image = Image.FromFile(圖檔完整路徑);

                }

                reader.Close();
                con.Close();
            }
        }

        void ProductDetailItemsHappyMeal()
        {
            if (OrderHappyMealID > 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                string strSQL = "select * from HappyMeal where id = @SearchID;";
                SqlCommand cmd = new SqlCommand(strSQL, con);
                cmd.Parameters.AddWithValue("@SearchID", OrderHappyMealID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read() == true)
                {
                    lblID.Text = reader["id"].ToString();
                    lbl餐點名稱.Text = reader["快樂分享餐名稱"].ToString();
                    textBox餐點內容.Text = reader["餐點內容"].ToString();
                    textBox餐點內容.Font = new Font("微軟正黑體", 12, FontStyle.Bold);
                    lbl價格.Text = reader["價格"].ToString();
                    image_HappyMeal = reader["image"].ToString();
                    string 圖檔完整路徑 = GlobalVar.image_dir + image_HappyMeal;
                    pictureBox商品照片.Image = Image.FromFile(圖檔完整路徑);

                }

                reader.Close();
                con.Close();
            }
        }
        private void btn加入清單_Click(object sender, EventArgs e)
        {
            if ((lblID.Text != "") && (lbl價格.Text != "") && (lbl餐點名稱.Text != "") && (pictureBox商品照片.Image != null))
            {
                ArrayList ListInformation = new ArrayList();
                int price = 0;
                ListInformation.Add(lblID.Text);
                ListInformation.Add(lbl餐點名稱.Text);
                ListInformation.Add(textBox餐點內容.Text);                
                Int32.TryParse(lbl價格.Text ,out price);
                ListInformation.Add(price);

                GlobalVar.list訂購商品資訊.Add(ListInformation);
                MessageBox.Show("加入成功");
                Close();
                

            }
            else
            {
                MessageBox.Show("請選擇商品");
            }
        }

       
        private void btn返回_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
