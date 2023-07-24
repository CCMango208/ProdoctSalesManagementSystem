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
    public partial class Goods_Manage_Form : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Goods_Manage_Form()
        {
            InitializeComponent();
        }

        public static DataSet QueryGoodsOn(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "dataGridView1");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }
        public static DataSet QueryGoodsOff(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                sda.Fill(ds, "dataGridView2");
                return ds;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }
        private void Search_Button_Click(object sender, EventArgs e)
        {
            string Gid = GidBox.Text.Trim();
            if (Main_Prodoct.Querycount("update Storeage set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                MessageBox.Show("无对于Gid值的商品");
                this.Close();
                return;
            }
            string sql = "select [Gid],[Gcount] from Storeage where Gid = " + Gid + "";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            SqlCommand sqlComm = new SqlCommand(sql, con);
            SqlDataReader reader = sqlComm.ExecuteReader();
            reader.Read();
            Gcountbox.Text = reader["Gcount"].ToString();
            con.Close();

            if (Main_Prodoct.Querycount("update GoodsSelling set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                Sellingbox.Text = "0";
            }
            else {
                string sql2 = "select [Gid],[GSelling] from GoodsSelling where Gid = " + Gid + "";
                SqlConnection con2 = new SqlConnection(connectionString);
                con2.Open();
                SqlCommand sqlComm2 = new SqlCommand(sql2, con2);
                SqlDataReader reader2 = sqlComm2.ExecuteReader();
                reader2.Read();
                Sellingbox.Text = reader2["GSelling"].ToString();
                con2.Close();
            }
            
        }

        private void NewForSale_Button_Click(object sender, EventArgs e)
        {
            string Count = NewSalebox.Text.Trim();
            string Gid = GidBox.Text.Trim();
            string dtime = DateTime.Now.ToString();
            if (Main_Prodoct.Querycount("update Storeage set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                MessageBox.Show("无对应Gid值的商品在库");
                this.Close();
                return;
            }
            if (Main_Prodoct.Querycount("update Storeage set Gid = Gid where Gid = " + Gid + " and Gcount >= " + Count + " ") == 0)
            {
                MessageBox.Show("没有足够数量的商品上架");
                this.Close();
                return;
            }
            string GOnidstr;
            int num = Main_Prodoct.Querycount("update GoodsOn set GOnid = GOnid ");
            if (num == 0)
            {
                GOnidstr = "1";
            }
            else
                GOnidstr = (num+1).ToString();
            MessageBox.Show(GOnidstr);
            string sql = "insert into GoodsOn values("+GOnidstr+","+Gid+","+Count+", '"+dtime+"' )";
            if (Main_Prodoct.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("上架成功");
            }
        }

        private void OffSale_Button_Click(object sender, EventArgs e)
        {
            string Count = OffSalebox.Text.Trim();
            string Gid = GidBox.Text.Trim();
            string dtime = DateTime.Now.ToString();
            if (Main_Prodoct.Querycount("update GoodsSelling set Gid = Gid where Gid = " + Gid + " ") == 0)
            {
                MessageBox.Show("无对应Gid值的商品在售");
                this.Close();
                return;
            }
            if (Main_Prodoct.Querycount("update GoodsSelling set Gid = Gid where Gid = " + Gid + " and GSelling >= " + Count + "") == 0)
            {
                MessageBox.Show("没有足够数量的商品下架");
                this.Close();
                return;
            }
            string sql = "insert into GoodsOff values(GOffnid,Gid,GOffmount,GOffdate) select MAX(GOffid)+1," + Gid + "," + Count + "," + dtime + "";
            if (Main_Prodoct.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("下架成功");
            }
        }

        private void Search_On_Button_Click(object sender, EventArgs e)
        {
            string Gid = GidBox.Text.Trim();
            this.dataGridView1.DataSource = QueryGoodsOn("select * from GoodsOn where Gid like '%" + Gid + "%'").Tables["dataGridView1"];
        }

        private void Search_Off_Button_Click(object sender, EventArgs e)
        {
            string Gid = GidBox.Text.Trim();
            this.dataGridView2.DataSource = QueryGoodsOff("select * from GoodsOff where Gid like '%" + Gid + "%'").Tables["dataGridView2"];
        }
    }
}
