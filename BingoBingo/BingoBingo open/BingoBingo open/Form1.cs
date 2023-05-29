using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace BingoBingo_open
{

    public partial class Form1 : Form
    {

        List<Label> listnumber = new List<Label>();
        List<string> listNumberout = new List<string>();
        List<string> list星星 = new List<string>();
        List<int> list星星數值 = new List<int>();
        public static List<int> listNum = new List<int>();
        public static List<string> listNum2 = new List<string>();
        //public static 
        public Label LabelOne;
        public List<Button> listPGButtons = new List<Button>();
        int time電腦選號;
        int star = 0;
        
        
        string 所選星星;
        public bool is快選 = false;






        public Form1()
        {
            InitializeComponent();

        }
        // 建立List連續資料型態到Label

        private void Form1_Load(object sender, EventArgs e)
        {
            
            倒數計時();
            選擇號碼LabelOne();
            產生號碼按鈕(10, 8);

            // 選擇星星key
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            list星星.Add("");
            // 星星數值value
            list星星數值.Add(0);
            list星星數值.Add(1);
            list星星數值.Add(2);
            list星星數值.Add(3);
            list星星數值.Add(4);
            list星星數值.Add(5);
            list星星數值.Add(6);
            list星星數值.Add(7);
            list星星數值.Add(8);
            list星星數值.Add(9);
            list星星數值.Add(10);

            
            


            listnumber.Add(number1);
            listnumber.Add(number2);
            listnumber.Add(number3);
            listnumber.Add(number4);
            listnumber.Add(number5);
            listnumber.Add(number6);
            listnumber.Add(number7);
            listnumber.Add(number8);
            listnumber.Add(number9);
            listnumber.Add(number10);
            listnumber.Add(number11);
            listnumber.Add(number12);
            listnumber.Add(number13);
            listnumber.Add(number14);
            listnumber.Add(number15);
            listnumber.Add(number16);
            listnumber.Add(number17);
            listnumber.Add(number18);
            listnumber.Add(number19);
            listnumber.Add(number20);
            listnumber.Add(spnumber);

            // 請選擇星星
            for (int i = 0; i < list星星.Count; i += 1)
            {
                string strItem = string.Format("{0}{1}星",list星星[i], list星星數值[i]);
                comboBox星.Items.Add(strItem);
                
            }



        }
        
        
        // ======================選擇號碼======================
        void 選擇號碼LabelOne()
        {
            LabelOne = new Label();
            //LabelOne.BackColor = Color.Gray;
            LabelOne.ForeColor = Color.Red;
            LabelOne.Font = new Font("微軟正黑體", 18);
            //LabelOne.Text = "程式化語法產生的標籤One";
            //LabelOne.Name = "lblPGOne";
            LabelOne.TextAlign = ContentAlignment.MiddleCenter;
            LabelOne.Location = new Point(30, 10);
            LabelOne.Size = new Size(400, 36);

        }
        void 快選號碼()
        {
            try
            {
                Random random = new Random();
                int[] rannumber = new int[star];
                string OBOB = "";
                int[] sta = new int[10];

                for (int i = 0; i < star; i += 1)
                {
                    rannumber[i] = random.Next(0, 80);

                    for (int j = 0; j < i; j += 1)
                    {
                        while (rannumber[j] == rannumber[i])
                        {
                            j = 0;
                            rannumber[i] = random.Next(0, 80);
                            
                        }
                    }

                    sta[i] = rannumber[i];
                    sta[i] += 1;
                    
                    OBOB += sta[i].ToString(string.Format("00")) + ",";

                    listPGButtons[rannumber[i]].BackColor = Color.Red;
                    listPGButtons[rannumber[i]].ForeColor = Color.White;

                    //Console.WriteLine(list顯示號碼值);
                }

                list選擇號碼顯示.Text = OBOB;
                
            }
            catch
            {
                MessageBox.Show("偵測到異常選號");
                清除號碼();
                comboBox星.SelectedIndex = 0;
            }


        }
        
        // ======================產生號碼按鈕======================
        public void 產生號碼按鈕(int intColumn, int intRow)
        {
            int 編號 = 0;
            
            for (int i = 0; i < intRow; i += 1)
            {                
                for (int j = 0; j < intColumn; j += 1)
                {
                    編號 += 1;
                    Button dButton = new Button();
                    dButton.BackColor = Color.Pink;
                    dButton.ForeColor = Color.Red;
                    dButton.Font = new Font("微軟正黑體", 18);
                    dButton.Text = 編號.ToString();
                    dButton.Location = new Point(520 + 65 * j, 430 + 55 * i);
                    dButton.Size = new Size(50, 40);
                    dButton.Click += new EventHandler(dButton_Click);
                    Controls.Add(dButton);
                    listPGButtons.Add(dButton);
                    



                }
            }
            
        }
        // ======================按鈕點擊事件======================
        int myBtn2 = 0;        
        private void dButton_Click(object sender, EventArgs e)
        {
            Button myBtn = (Button)sender;
            
            
            if (myBtn.BackColor == Color.Pink)
            {
                
                myBtn2 += 1;
                myBtn.BackColor = Color.Red;
                myBtn.ForeColor = Color.White;
                
                
            }
            else
            {
                
                myBtn2 -= 1;
                myBtn.BackColor = Color.Pink;
                myBtn.ForeColor = Color.Red;

            }
            if (myBtn2 >= 11)
            {
                
                MessageBox.Show("請勿點選超過十個數字，請重新選擇");
                清除號碼();
                myBtn2 -= 11;


            } 
           
            
        }
        // ======================清除號碼======================
        void 清除號碼()
        {
            for (int i = 0; i < listPGButtons.Count; i += 1)
            {
                listPGButtons[i].BackColor= Color.Pink;
                listPGButtons[i].ForeColor = Color.Red;
            }
        }
        // ======================倒數計時======================
        void 倒數計時()
        {
            
            timer倒數.Enabled = true;
            time電腦選號 = 30;
            
            timer倒數.Interval = 1000;
           // timer倒數.Tick += new EventHandler(timer_Tick);
            
        }
        // ======================亂數產生======================
        private void bytOpen_Click(object sender, EventArgs e)
        {


            Random myRandom = new Random();
            int[] number123 = new int[20];
            int[] number456 = new int[20];
            int[] number789 = new int[20];

            string strNumSet = "";
            string strNum = "";
            string strNum2 = "";

            listBox大.Items.Clear();
            listBox小.Items.Clear();
            listBox顯示開獎號碼.Items.Clear();

            for (int i = 0; i < 20; i += 1)
            {

                number123[i] = myRandom.Next(1, 80);


                for (int j = 0; j < i; j += 1)
                {
                    while (number123[j] == number123[i])
                    {
                        j = 0;
                        number123[i] = myRandom.Next(1, 80);

                    }
                }
                number456[i] = number123[i];                
                number789[i] = number456[i];
                

                strNumSet += number123[i].ToString(string.Format("00")) + ",";
                


                if (number456[i] <= 40)
                {
                    
                    number789[i] = number456[i];
                    

                    if (number789[i] <= 40)
                    {
                        strNum2 += number789[i].ToString(string.Format("00")) + ",";
                    }
                    continue;
                    

                }
                
                strNum += number456[i].ToString(string.Format("")) + ",";
                
               
            }
            
            //Numset += RandNum + ", ";                                                                     
            //string Num = string.Format("{0:00}",(RandNum)); //listnumber[i].Text = RandNum.ToString();
            //listnumber[i].Text = RandNum.ToString();
            //Array.Sort(strNum2);

            // ======================亂數印出並排列順序======================
            spnumber.Text = number123[19].ToString(String.Format("00"));
            
            Array.Sort(number123);

            number1.Text = number123[0].ToString(String.Format("00"));
            number2.Text = number123[1].ToString(String.Format("00"));
            number3.Text = number123[2].ToString(String.Format("00"));
            number4.Text = number123[3].ToString(String.Format("00"));
            number5.Text = number123[4].ToString(String.Format("00"));
            number6.Text = number123[5].ToString(String.Format("00"));
            number7.Text = number123[6].ToString(String.Format("00"));
            number8.Text = number123[7].ToString(String.Format("00"));
            number9.Text = number123[8].ToString(String.Format("00"));
            number10.Text = number123[9].ToString(String.Format("00"));
            number11.Text = number123[10].ToString(String.Format("00"));
            number12.Text = number123[11].ToString(String.Format("00"));
            number13.Text = number123[12].ToString(String.Format("00"));
            number14.Text = number123[13].ToString(String.Format("00"));
            number15.Text = number123[14].ToString(String.Format("00"));
            number16.Text = number123[15].ToString(String.Format("00"));
            number17.Text = number123[16].ToString(String.Format("00"));
            number18.Text = number123[17].ToString(String.Format("00"));
            number19.Text = number123[18].ToString(String.Format("00"));
            number20.Text = number123[19].ToString(String.Format("00"));
            listBox顯示開獎號碼.Items.Add(strNumSet);
            //Form1.listNum2.Add(strNumSet);
           
            listBox大.Items.Add(strNum);
            listBox小.Items.Add(strNum2);
            //listNumberout.Add(Numset);
        }
        


        void 亂數產生()
        {
            
            Random myRandom = new Random();
            int[] number123 = new int[20];
            int[] number456 = new int[20];
            int[] number789 = new int[20];
            string strNumSet = "";
            string strNum = "";
            string strNum2 = "";
            listBox大.Items.Clear();
            listBox小.Items.Clear();
            listBox顯示開獎號碼.Items.Clear();

            for (int i = 0; i < 20; i += 1)
            {

                number123[i] = myRandom.Next(1, 80);


                for (int j = 0; j < i; j += 1)
                {
                    while (number123[j] == number123[i])
                    {
                        j = 0;
                        number123[i] = myRandom.Next(1, 80);

                    }
                }

                number456[i] = number123[i];
                number789[i] = number456[i];


                strNumSet += number123[i].ToString(string.Format("00")) + ",";


                if (number456[i] <= 40)
                {
                    number789[i] = number456[i];
                    if (number789[i] <= 40)
                    {
                        strNum2 += number789[i].ToString(string.Format("00")) + ",";
                    }
                    continue;
                }

                strNum += number456[i].ToString(string.Format("")) + ",";
                
                
            }

            

            // ======================亂數印出並排列順序======================
            spnumber.Text = number123[19].ToString(String.Format("00"));

            Array.Sort(number123);

            number1.Text = number123[0].ToString(String.Format("00"));
            number2.Text = number123[1].ToString(String.Format("00"));
            number3.Text = number123[2].ToString(String.Format("00"));
            number4.Text = number123[3].ToString(String.Format("00"));
            number5.Text = number123[4].ToString(String.Format("00"));
            number6.Text = number123[5].ToString(String.Format("00"));
            number7.Text = number123[6].ToString(String.Format("00"));
            number8.Text = number123[7].ToString(String.Format("00"));
            number9.Text = number123[8].ToString(String.Format("00"));
            number10.Text = number123[9].ToString(String.Format("00"));
            number11.Text = number123[10].ToString(String.Format("00"));
            number12.Text = number123[11].ToString(String.Format("00"));
            number13.Text = number123[12].ToString(String.Format("00"));
            number14.Text = number123[13].ToString(String.Format("00"));
            number15.Text = number123[14].ToString(String.Format("00"));
            number16.Text = number123[15].ToString(String.Format("00"));
            number17.Text = number123[16].ToString(String.Format("00"));
            number18.Text = number123[17].ToString(String.Format("00"));
            number19.Text = number123[18].ToString(String.Format("00"));
            number20.Text = number123[19].ToString(String.Format("00"));
            listBox顯示開獎號碼.Items.Add(strNumSet);
            listBox大.Items.Add(strNum);
            listBox小.Items.Add(strNum2);
        }


        // ======================倒數計時======================
        private void timer_Tick(object sender, EventArgs e)
        {

            
            if (time電腦選號 > 0)
            {
                
                time電腦選號 -= 1;
                time倒數.Text = time電腦選號.ToString();
                
            }
            else
            {
                time電腦選號 = 30;
                time倒數.Text = "30";
                亂數產生();


            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void comboBox星_SelectedIndexChanged(object sender, EventArgs e)
        {
            star = list星星數值[comboBox星.SelectedIndex];
            
            





        }

        private void btn快選_Click(object sender, EventArgs e)
        {
            
            
            if (btn快選.Created == true)
            {
                清除號碼();
                快選號碼();
                is快選 = true;
            }
            
        }

        private void listBox顯示開獎號碼_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("對獎功能未開放\n如有需要請洽臨櫃，謝謝 ! ");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("輸出功能未開放\n如有需要請洽臨櫃，謝謝 ! ");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            清除號碼();
            myBtn2 = 0;
            
        }
    }
}
