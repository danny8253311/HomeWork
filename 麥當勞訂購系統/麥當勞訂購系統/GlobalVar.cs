using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 麥當勞訂購系統
{
    internal class GlobalVar
    {
        public static List<ArrayList> 顧客資訊 = new List<ArrayList>();
        public static List<ArrayList> list訂購商品資訊 = new List<ArrayList>();
        public static List<ArrayList> 顧客帳號 = new List<ArrayList>();
        public static List<ArrayList> 會員管理資料修改 = new List<ArrayList>();
        public static List<ArrayList> 員工管理資料修改 = new List<ArrayList>();
        public static List<ArrayList> 商品管理資料修改 = new List<ArrayList>();
        public static List<ArrayList> 訂單管理資料修改 = new List<ArrayList>();
        public static string strMyMcdonaldsString = "";
        public static string image_dir = "";
        public static int 顧客已登入 = 0;
        public static int 註冊 = 0;
        public static int 權限 = 1000;
        public static int 會員管理 = 0;
        public static int 商品管理 = 0;
        public static int 員工管理 = 0;
        public static int 訂單管理 = 0;
        public static int 顧客資訊已填寫 = 0;



    }
}
