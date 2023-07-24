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
    public partial class User_Manage_Form : Form
    {
        static string connectionString = System.Configuration.ConfigurationManager.AppSettings["connectionString"];
        public User_Manage_Form()
        {
            InitializeComponent();
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
        private void User_search_button_Click(object sender, EventArgs e)
        {
            string Uid = UidBox.Text.Trim();
            this.dataGridView1.DataSource = Query("select * from Users").Tables["dataGridView1"];
            MessageBox.Show("查询成功");
        }

        private void User_Add_button_Click(object sender, EventArgs e)
        {
            User_Add_Form form5 = new User_Add_Form();
            form5.ShowDialog();
        }

        private void Trade_Click(object sender, EventArgs e)
        {
            Trade_Form form8 = new Trade_Form();
            form8.ShowDialog();
        }
    }
}
