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
//static string connectionString = System.Configuration.ConfigurationManager.["connectionString"];
namespace ProdoctSalesManagementSystem
{
    public partial class Main_Prodoct : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public Main_Prodoct()
        {
            InitializeComponent();
        }
        public static int Querycount(string sql)
        {
            int cnt = ExecuteSql(sql);
            return cnt;
        }
        public static DataSet Query(string sql)
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
            catch(SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                sda.Dispose();
                con.Close();
            }
        }
        public static int ExecuteSql(string sql)
        {
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            try
            {
                con.Open();
                int rows = cmd.ExecuteNonQuery();
                return rows;
            }
            catch (SqlException e)
            {
                throw new Exception(e.Message);
            }
            finally
            {
                cmd.Dispose();
                con.Close ();
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AddGoods_Button_Click(object sender, EventArgs e)
        {
            GoodsAdd_Form form2 = new GoodsAdd_Form();
            form2.ShowDialog();
        }

        private void GoodsInfo_Button_Click(object sender, EventArgs e)
        {
            Goods_Info_Form form4 = new Goods_Info_Form();
            form4.ShowDialog();
        }

        private void UserManage_Button_Click(object sender, EventArgs e)
        {
            User_Manage_Form form3 = new User_Manage_Form();
            form3.ShowDialog();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            string Gid = SearchText.Text.Trim();
            this.dataGridView1.DataSource = Query("select * from Goods where Gid like '%" + Gid + "%'").Tables["dataGridView1"];
        }


        private void GoodsManage_Click(object sender, EventArgs e)
        {
            Goods_Manage_Form form7 = new Goods_Manage_Form();
            form7.ShowDialog();
        }
    }
}
