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
using System.Data.SqlClient;

namespace 麥當勞訂購系統
{
    public partial class Burger : Form
    {
        List<string> list_Burger_Name = new List<string>();
        List<int> list_Burger_Price = new List<int>();
        List<int> listID = new List<int>();

        public Burger()
        {
            InitializeComponent();
        }

        private void Burger_Load(object sender, EventArgs e)
        {
            SqlConnectionStringBuilder Mcd = new SqlConnectionStringBuilder();
            Mcd.DataSource = @"."; // 連接本機資料庫
            Mcd.InitialCatalog = "McdonaldsOrderSystem";
            Mcd.IntegratedSecurity = true; // 資料庫驗證
            GlobalVar.strMyMcdonaldsString = Mcd.ConnectionString;
            GlobalVar.image_dir = @"C:\Users\iSpan\source\repos\元件開發\麥當勞訂購系統\麥當勞圖片\漢堡\"; // 照片來源路徑
            SQLLoading();
            DisplayListViewImageMode();
        }

        void SQLLoading()
        {
            SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
            con.Open();
            string strSQL = "select * from Burger;";
            SqlCommand cmd = new SqlCommand(strSQL, con);
            SqlDataReader reader = cmd.ExecuteReader();

            string image_name = ""; // 圖檔名稱
            int count = 0;
            while (reader.Read() == true)
            {
                listID.Add((int)reader["id"]);
                list_Burger_Name.Add((string)reader["漢堡名稱"]);
                list_Burger_Price.Add((int)reader["價格"]);
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
            imageListCommodity.ImageSize = new Size(95, 95); // 
            listCommodityView.LargeImageList = imageListCommodity;


            for (int i = 0; i < imageListCommodity.Images.Count; i += 1)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = i;
                item.Font = new Font("微軟正黑體", 11, FontStyle.Bold);
                item.ForeColor = Color.Black;
                item.BackColor = Color.White;
                item.Text = $"{list_Burger_Name[i]}";
                item.Tag = listID[i];
                listCommodityView.Items.Add(item);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            Close();
        }

        private void Burger_FormClosing(object sender, FormClosingEventArgs e)
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

        private void listCommodityView_ItemActivate(object sender, EventArgs e)
        {
            ProductDetailsItems MyProductDetailsItems = new ProductDetailsItems();
            MyProductDetailsItems.OrderBurgerID = (int)listCommodityView.SelectedItems[0].Tag;
            MyProductDetailsItems.ShowDialog();
        }
    }
}
