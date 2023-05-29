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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace 麥當勞訂購系統
{
    public partial class Happy_Meal : Form
    {
        List<string> list_Happy_Meal_Name = new List<string>();
        List<string> list_Happy_Meal_Content = new List<string>();
        List<int> list_Happy_Meal_Price = new List<int>();
        List<int> listID = new List<int>();

        public Happy_Meal()
        {
            InitializeComponent();
        }

        private void Happy_Meal_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder Mcd = new SqlConnectionStringBuilder();
            Mcd.DataSource = @"."; // 連接本機資料庫
            Mcd.InitialCatalog = "McdonaldsOrderSystem";
            Mcd.IntegratedSecurity = true; // 資料庫驗證
            GlobalVar.strMyMcdonaldsString = Mcd.ConnectionString;
            GlobalVar.image_dir = @"C:\Users\iSpan\source\repos\元件開發\麥當勞訂購系統\麥當勞圖片\快樂分享餐\"; // 照片來源路徑
            SQLLoading();
            DisplayListViewImageMode();
            
        }


        void SQLLoading()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
            con.Open();
            string strSQL = "select * from HappyMeal;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_name = ""; // 圖檔名稱
            int count = 0;
            while (reader.Read() == true)
            {
                listID.Add((int)reader["id"]);
                list_Happy_Meal_Name.Add((string)reader["快樂分享餐名稱"]);
                list_Happy_Meal_Content.Add((string)reader["餐點內容"]);
                list_Happy_Meal_Price.Add((int)reader["價格"]);
                image_name = reader["image"].ToString();
                string image_address = GlobalVar.image_dir + image_name;
                Image imagCommodityImage = Image.FromFile(image_address);

                imageListCommodity.Images.Add(imagCommodityImage);
                count += 1;
            }
            //Console.WriteLine($"讀取{count}資料");
            reader.Close();
            con.Close();

        }

        void DisplayListViewImageMode()
        {
            listCommodityView.Clear(); // listCommodityView產品展示
            listCommodityView.View = View.LargeIcon;
            imageListCommodity.ImageSize = new Size(256, 100); // 
            listCommodityView.LargeImageList = imageListCommodity;
            
            


            for (int i = 0; i < imageListCommodity.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                item.ForeColor = Color.White;
                item.BackColor = Color.SandyBrown;                
                item.Text = $"{list_Happy_Meal_Name[i]}";
                
                item.Tag = listID[i];
                listCommodityView.Items.Add(item);
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Happy_Meal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult C = MessageBox.Show("您確定要離開嗎 ? ", "關閉菜單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (C == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void listCommodityView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
            
        }

        private void listCommodityView_ItemActivate(object sender, EventArgs e)
        {
            ProductDetailsItems MyProductDetailsItems = new ProductDetailsItems();
            MyProductDetailsItems.OrderHappyMealID = (int)listCommodityView.SelectedItems[0].Tag;
            MyProductDetailsItems.ShowDialog();
        }
    }
}
