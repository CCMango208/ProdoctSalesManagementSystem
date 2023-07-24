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
    public partial class GoodsAdd_Form : Form
    {
        public GoodsAdd_Form()
        {
            InitializeComponent();
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            //SqlConnection con = new SqlConnection(connectionString);
            string Gid = Gidbox.Text.Trim();
            string Gname = Gnamebox.Text.Trim();
            string Garea = Gareabox.Text.Trim();
            string Gicid = Gicidbox.Text.Trim();
            string Price = Pricebox.Text.Trim();
            string Inventory = Inventorybox.Text.Trim();
            string Categoty = CategoryBox.Text.Trim();
            if (Main_Prodoct.Querycount("update Goods set Gid = Gid where Gid = "+ Gid+ " ") > 0)
            {
                MessageBox.Show("Gid重复，添加失败");
                this.Close();
                return;
            }
            string sql = "insert into Goods values(" + Gid + ",'" + Gname + "','" + Garea + "','" + Gicid + "'," + Price + "," + Inventory + ",'" + Categoty + "')";
            if(Main_Prodoct.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("添加成功");
            }
            this.Close(); 
        }
    }
}
