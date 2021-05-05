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
    public partial class Form1 : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-FV45K32J;Initial Catalog=ShopOnline;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
        }

        public static string Value1 = "";
        Form2 Main;
        Form3 Reg;

        private void label3_Click(object sender, EventArgs e) // Регистрация 
        {
            this.Hide();

            Reg= new Form3();
            Reg.Show();
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                button1.Focus();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.PasswordChar = new char();
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e) // Кнопка входа
        {
            if ((textBox1.Text.Length != 0) && (textBox2.Text.Length != 0))
            {
                Conn.Open();
                string query2 = "Select * From AccountUsers WHERE Login = @Login and Pass = @Pass";
                SqlCommand command2 = new SqlCommand(query2, Conn);
                SqlParameter sd41 = new SqlParameter("@Login", SqlDbType.Char, 100);
                sd41.Value = textBox1.Text;
                command2.Parameters.Add(sd41);
                SqlParameter sd415 = new SqlParameter("@Pass", SqlDbType.Char, 100);
                sd415.Value = textBox2.Text;
                command2.Parameters.Add(sd415);
                command2.Prepare();
                SqlDataReader reader2 = command2.ExecuteReader();
                if (reader2.Read() == true)
                {
                    Value1 = textBox1.Text;

                    this.Hide();
                    Main = new Form2();
                    Main.Show();
                    textBox2.Text = "";
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                    textBox2.Text = "";
                    textBox1.Focus();
                    Conn.Close();
                }
            }
            else MessageBox.Show("Введите логин и пароль");
        }
    }
}
