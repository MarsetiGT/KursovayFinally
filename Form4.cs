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
using Microsoft.SqlServer.Server;
using System.Linq.Expressions;

namespace Kyrs
{
    public partial class Form4 : Form
    {

        SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-FV45K32J;Initial Catalog=ShopOnline;Integrated Security=True");

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
