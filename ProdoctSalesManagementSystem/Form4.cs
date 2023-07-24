using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace ProdoctSalesManagementSystem
{
    public partial class Goods_Info_Form : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Goods_Info_Form()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Search_Click(object sender, EventArgs e)
        {
            string Gid = GidBox.Text.Trim(); 
            string sql = "select [Gid],[Gname],[Garea],[Gicid],[Price],[Category] from Goods where Gid = " + Gid + "";
            if (Main_Prodoct.Querycount("update Goods set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                MessageBox.Show("无对于Gid值的商品");
                this.Close();
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlComm = new SqlCommand(sql, con);
            SqlDataReader reader = sqlComm.ExecuteReader();
            reader.Read();
            GidBox.Text = reader["Gid"].ToString();
            Gnamebox.Text = reader["Gname"].ToString();
            Gareabox.Text = reader["Garea"].ToString();
            Pricebox.Text = reader["Price"].ToString();
            Categroybox.Text = reader["Category"].ToString();
            con.Close();
        }

        private void Goodsin_Click(object sender, EventArgs e)
        {
            string Gid = GidBox.Text.Trim();
            string count = countBox.Text.Trim();
            if (Main_Prodoct.Querycount("update Goods set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                MessageBox.Show("无对于Gid值的商品");
                this.Close();
                return;
            }
            if (Main_Prodoct.Querycount("update Storeage set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                string sql ="insert into Storeage values("+Gid+","+count+")";
                Main_Prodoct.ExecuteSql(sql);
                MessageBox.Show("进货成功！");
            }
            else
            {
                string sql = "update Storeage set Gcount = Gcount + "+count+" where Gid = "+Gid+"";
                Main_Prodoct.ExecuteSql(sql);
                MessageBox.Show("进货成功！");
            }
        }
    }
}
