using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Design;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace 麥當勞訂購系統
{
    public partial class FormOrderList : Form
    {
        public FormOrderList()
        {
            InitializeComponent();
        }
        int c = 0;
        int 輸出訂單總金額 = 0;
        DialogResult A;
        string str建立訂單 = "INSERT INTO OderTime VALUES (@NewCustomerID, @NewCustomerName, @NewCustomerPhone, @NewCustomerAddress,@NewCommodityID,@NewCommodityName, @OderAmount, @OderTime);";
        private void FormOrderList_Load(object sender, EventArgs e)
        {
            
            foreach (ArrayList popo in GlobalVar.list訂購商品資訊)
            {
                string ID = popo[0].ToString();
                string pname = popo[1].ToString();
                string pdatail = popo[2].ToString();
                int price = (int)popo[3];

                //string 資訊 = string.Format("{0} {1} {2} {3}元", ID, pname, pdatail, price);
                string 資訊 = string.Format($"項目 : {ID}");
                string 資訊2 = string.Format($"餐點名稱 : {pname}");
                string 資訊3 = string.Format($"內容 : {pdatail}");
                string 資訊4 = string.Format($"價格 : {price}元");
                string 資訊5 = "";
                
                listBox品項列表.Items.Add(資訊);
                listBox品項列表.Items.Add(資訊2);
                listBox品項列表.Items.Add(資訊3);
                listBox品項列表.Items.Add(資訊4);
                listBox品項列表.Items.Add(資訊5);
                計算訂單總價();
            }
            
        }

        private void FormOrderList_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            if (c == 1)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }
        void 計算訂單總價()
        {
            int 訂單總價 = 0;
            int 多筆訂單數 = 0;

            foreach (ArrayList popo in GlobalVar.list訂購商品資訊)
            {
                int 訂單數 = 0;
                int 價格 = (int)popo[3];                
                訂單總價 += 價格;
                輸出訂單總金額 = 訂單總價;
                
                if (popo.Count == 4)
                {
                    訂單數 += 1;
                }
                多筆訂單數 += 訂單數;                
            }
            

            lbl總金額.Text = string.Format("總金額 : {0} 元", 訂單總價);
            lbl顯示多筆項目.Text = string.Format("項目 : {0} 筆", 多筆訂單數);
            
        }
        private void btn取消訂單_Click(object sender, EventArgs e)
        {
            c += 1;
            MessageBox.Show("您確定要取消訂單嗎 ? ", "取消訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            GlobalVar.list訂購商品資訊.Clear();
            Close();

        }

        private void btn顧客資訊_Click(object sender, EventArgs e)
        {
            if (GlobalVar.顧客已登入 != 1)
            {

                CustomerInFo MycustomerInFo = new CustomerInFo();
                MycustomerInFo.ShowDialog();
            }
            else
            {
                A = MessageBox.Show("您已輸入顧客資料 !! 是否需要重新修改 ? ", "資料更改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (A == DialogResult.Yes)
                {                                      
                    CustomerInFo MycustomerInFo = new CustomerInFo();
                    MycustomerInFo.ShowDialog();
                    
                }                              
            }
            //if (GlobalVar.顧客資訊已填寫 != 1)
            //{

            //    CustomerInFo MycustomerInFo = new CustomerInFo();
            //    MycustomerInFo.ShowDialog();
            //}
            //else
            //{
            //    A = MessageBox.Show("您已輸入顧客資料 !! 是否需要重新修改 ? ", "資料更改確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if (A == DialogResult.Yes)
            //    {
            //        CustomerInFo MycustomerInFo = new CustomerInFo();
            //        MycustomerInFo.ShowDialog();

            //    }


            //}
            if (GlobalVar.註冊 == 1)
            {
                GlobalVar.註冊 = 0;
                
            }
            
        }

        private void listBox品項列表_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                
            }
            reader.Close();
            con.Close();
        }
        private void btn送出訂單_Click(object sender, EventArgs e)
        {
            if (GlobalVar.list訂購商品資訊.Count != 0)
            {
                SqlConnection con = new SqlConnection(GlobalVar.strMyMcdonaldsString);
                con.Open();
                

                SqlCommand cmd = new SqlCommand(str建立訂單, con);
                if (GlobalVar.顧客資訊.Count != 0)
                {
                    A = MessageBox.Show("請確認餐點後再送出 !  ", "送出訂單確認", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (A == DialogResult.Yes)
                    {                        
                        
                        string str檔案路徑 = @"C:\Users\Public\Documents";
                        Random myrandom = new Random();
                        int rndNum = myrandom.Next(1000, 10000);
                        string str檔名 = DateTime.Now.ToString("yyyyMMdd") + rndNum + ".txt";
                        string str完整檔案路徑 = str檔案路徑 + @"\" + str檔名;
                        

                        SaveFileDialog sfd = new SaveFileDialog();
                        sfd.InitialDirectory = str檔案路徑;
                        sfd.FileName = str檔名;
                        sfd.Filter = "Text File | *.txt";

                        DialogResult R = sfd.ShowDialog();
                        if (R == DialogResult.OK)
                        {
                            str完整檔案路徑 = sfd.FileName;
                        }
                        else
                        {
                            return;
                        }

                        List<string> list訂單資訊 = new List<string>();
                        list訂單資訊.Add("---------------------- 您的訂單 ----------------------");
                        list訂單資訊.Add("");
                        list訂單資訊.Add("");
                        list訂單資訊.Add($"訂餐時間 : {DateTime.Now.ToString()}");
                        list訂單資訊.Add("");
                        if(GlobalVar.顧客資訊已填寫 == 1)
                        {
                            foreach (ArrayList 顧客顯示 in GlobalVar.顧客資訊)
                            {

                                string 顧客ID = 顧客顯示[0].ToString();
                                string 顧客姓名 = 顧客顯示[1].ToString();
                                string 顧客電話 = 顧客顯示[2].ToString();
                                string 顧客地址 = 顧客顯示[4].ToString();
                                string 顧客郵件 = 顧客顯示[3].ToString();

                                string 顧客 = string.Format($"顧客姓名 : {顧客姓名} ");
                                string 顧客2 = string.Format($"顧客電話 : {顧客電話} ");
                                string 顧客3 = string.Format($"顧客電子郵件 : {顧客郵件} ");
                                string 顧客4 = string.Format($"外送地址 : {顧客地址} ");
                                list訂單資訊.Add(顧客 + 顧客2 + 顧客3 + 顧客4);

                            }
                        }
                        if(GlobalVar.顧客已登入 == 1)
                        {
                            foreach (ArrayList 顧客顯示 in GlobalVar.顧客資訊)
                            {

                                string 顧客ID = 顧客顯示[4].ToString();
                                string 顧客姓名 = 顧客顯示[0].ToString();
                                string 顧客電話 = 顧客顯示[2].ToString();
                                string 顧客地址 = 顧客顯示[1].ToString();
                                string 顧客郵件 = 顧客顯示[3].ToString();

                                string 顧客 = string.Format($"顧客姓名 : {顧客姓名} ");
                                string 顧客2 = string.Format($"顧客電話 : {顧客電話} ");
                                string 顧客3 = string.Format($"顧客電子郵件 : {顧客郵件} ");
                                string 顧客4 = string.Format($"外送地址 : {顧客地址} ");
                                list訂單資訊.Add(顧客 + 顧客2 + 顧客3 + 顧客4);

                            }
                        }
                       

                        list訂單資訊.Add("");
                        list訂單資訊.Add("---------------------- 訂單品項 ----------------------");
                        for (int i = 0; i < GlobalVar.list訂購商品資訊.Count; i += 1)
                        {
                            if(GlobalVar.顧客已登入 == 1)
                            {
                                cmd = new SqlCommand(str建立訂單, con);
                                //ArrayList ord = new ArrayList();
                                //ord.Add("@NewCustomerID", GlobalVar.顧客資訊[0][4])
                                cmd.Parameters.AddWithValue("@NewCustomerID", GlobalVar.顧客資訊[0][4]);
                                cmd.Parameters.AddWithValue("@NewCustomerName", GlobalVar.顧客資訊[0][0]);
                                cmd.Parameters.AddWithValue("@NewCustomerPhone", GlobalVar.顧客資訊[0][2]);
                                cmd.Parameters.AddWithValue("@NewCustomerAddress", GlobalVar.顧客資訊[0][1]);
                                cmd.Parameters.AddWithValue("@NewCommodityID", GlobalVar.list訂購商品資訊[i][0]);
                                cmd.Parameters.AddWithValue("@NewCommodityName", GlobalVar.list訂購商品資訊[i][1].ToString());
                                cmd.Parameters.AddWithValue("@OderAmount", GlobalVar.list訂購商品資訊[i][3]);
                                cmd.Parameters.AddWithValue("@OderTime", DateTime.Now);
                                int rows = cmd.ExecuteNonQuery();
                                cmd.Cancel();
                            }
                            
                        }
                       
                        foreach (ArrayList popo in GlobalVar.list訂購商品資訊)
                        {
                                                
                            string ID = popo[0].ToString();
                            string pname = popo[1].ToString();
                            string pdatail = popo[2].ToString();
                            int price = (int)popo[3];
                           
                            list訂單資訊.Add("");
                            list訂單資訊.Add("");
                            string 資訊 = string.Format($"項目 : {ID} ");
                            string 資訊2 = string.Format($"餐點名稱 : {pname}  ");
                            string 資訊3 = string.Format($"內容 : {pdatail}   ");
                            string 資訊4 = string.Format($"價格 : {price}元");                                                                                                      
                            list訂單資訊.Add("");
                            list訂單資訊.Add(資訊 + 資訊2 + 資訊3 + 資訊4);

                            


                        }
                        list訂單資訊.Add("");
                        list訂單資訊.Add("優惠碼 : 未使用 ");
                        list訂單資訊.Add("");
                        list訂單資訊.Add($"您的訂單總金額為 : {輸出訂單總金額} 元");
                        list訂單資訊.Add("");
                        list訂單資訊.Add("訂單已完成 餐點正在準備中 感謝您的訂購");
                        
                        string SQL = "select  訂單編號, 客戶ID, 客戶姓名, 客戶電話, 地址, 商品ID, 商品名稱, 訂單金額, 訂單成立時間 from OderTime ;";
                        導入資料庫(SQL);
                        System.IO.File.WriteAllLines(str完整檔案路徑, list訂單資訊, Encoding.UTF8);
                        con.Close();
                        MessageBox.Show("存檔成功");
                        c += 1;
                        GlobalVar.list訂購商品資訊.Clear();
                        GlobalVar.顧客資訊.Clear();
                        OrderHome myOH = new OrderHome();
                        Form1 myform1 = new Form1();
                        
                        Close();
                        myform1.Close();
                        myOH.Close();
                    }
                }
                else
                {
                    MessageBox.Show("顧客資訊未填寫 ! ");
                }
                
                
                
            }
            else
            {                
                MessageBox.Show("請選擇餐點");
            }

           
        }

        private void btn返回菜單_Click(object sender, EventArgs e)
        {
            c += 1;
            Close();

        }

        private void btn清除所有商品_Click(object sender, EventArgs e)
        {
            listBox品項列表.Items.Clear();
            GlobalVar.list訂購商品資訊.Clear();
            計算訂單總價();
        }

        
        
    }
}
