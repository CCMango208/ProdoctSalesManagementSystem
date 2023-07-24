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
    public partial class User_Add_Form : Form
    {
        public User_Add_Form()
        {
            InitializeComponent();
        }

        private void User_add_button_Click(object sender, EventArgs e)
        {
            string Uid = UidBox.Text.Trim();
            string Uname = UnameBox.Text.Trim();
            string Ucall = UcallBox.Text.Trim();
            string Uaddr = UaddrBox.Text.Trim();
            string sql = "insert into Users values(" + Uid + ",'" + Uname + "','" + Ucall + "','" + Uaddr + "')";
            if (Main_Prodoct.ExecuteSql(sql) > 0)
            {
                MessageBox.Show("用户添加成功");
            }
            this.Close();
        }
    }
}
