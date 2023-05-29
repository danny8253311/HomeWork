using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace 麥當勞訂購系統
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int 防止使用者關閉視窗 = 0;
        private void btn超值全餐_Click(object sender, EventArgs e)
        {
            Great_Value_Full_Meal MyGVM = new Great_Value_Full_Meal();
            MyGVM.ShowDialog();
        }

        private void btn漢堡_Click(object sender, EventArgs e)
        {
            
            Burger MyBurger = new Burger();
            MyBurger.ShowDialog();
            
        }

        private void btn點心小品_Click(object sender, EventArgs e)
        {
            
            Dessert MyDessert = new Dessert();
            MyDessert.ShowDialog();
            
        }

        private void btn飲料_Click(object sender, EventArgs e)
        {
            
            Drink MyDrink = new Drink();
            MyDrink.ShowDialog();
            
        }

        private void btn快樂分享餐_Click(object sender, EventArgs e)
        {
            
            Happy_Meal MyHappy = new Happy_Meal();
            MyHappy.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btn您的訂單_Click(object sender, EventArgs e)
        {
            FormOrderList MyOrderList = new FormOrderList();
            MyOrderList.ShowDialog();

        }

       

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
