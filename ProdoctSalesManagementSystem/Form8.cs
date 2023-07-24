using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProdoctSalesManagementSystem
{
    public partial class Trade_Form : Form
    {
        public Trade_Form()
        {
            InitializeComponent();
        }

        private void Buy_button_Click(object sender, EventArgs e)
        {
            string dtime = DateTime.Now.ToString();
            string Uid = UidBox.Text.Trim();
            string Gid = GidBox.Text.Trim();
            string Smount = SmountBox.Text.Trim();
            string GOnidstr;
            int num = Main_Prodoct.Querycount("update Sales set GOnid = GOnid ");
            if (num == 0)
            {
                GOnidstr = "1";
            }
            else
                GOnidstr = (num + 1).ToString();
            string sql = "insert into Sales values("+num+","+dtime+","+Gid+","+Smount+","+Uid+")";
            string sqlcheck = "update GoodsSelling set Gid = Gid where Gid =" + Gid + " and GSelling >= " + Smount + "";
            if(Main_Prodoct.Querycount(sqlcheck) == 0)
            {
                MessageBox.Show("商品数量不足，无法购买");
                return;
            }
            if (Main_Prodoct.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("购买成功");
            }
        }
    }
}
