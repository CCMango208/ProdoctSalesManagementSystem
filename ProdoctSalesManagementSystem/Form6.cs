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
    public partial class ErrorForm : Form
    {
        public ErrorForm(string errorMes)
        {
            InitializeComponent();
            Error_Message.Text = errorMes;
        }
    }
}
