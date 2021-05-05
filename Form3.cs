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
    public partial class Form3 : Form
    {
        SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-FV45K32J;Initial Catalog=ShopOnline;Integrated Security=True");
        Form2 ListP;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма не существует, то создаём
            {
                Form1 Auth = new Form1(); // Создание нового экземпляра формы
                form1.Show(); // Отображаем форму
                textBox1.Text = "";
                textBox2.Text = "";
                radioButton1.Checked = false;
            }
            else
            {
                form1.Activate();
                textBox1.Text = "";
                textBox2.Text = "";
                radioButton1.Checked = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length != 0) && (textBox2.Text.Length != 0))
            {
                if (radioButton1.Checked == true)
                {
                    Conn.Open();
                    string query1 = "SELECT Login FROM AccountUsers WHERE Login = @Login";
                    SqlCommand command = new SqlCommand(query1, Conn);
                    command.Parameters.Add("@Login", DbType.String).Value = textBox1.Text;
                    string main = ((string)command.ExecuteScalar());
                    MessageBox.Show($"проверка {main}");
                    if (main == textBox1.Text)
                    {
                        /*string query2 = "INSERT INTO AccountUsers (Login, Pass, Sec) VALUES (@Login, @Pass, 1)";
                        SqlCommand command2 = new SqlCommand(query2, Conn);
                        command2.Parameters.AddWithValue("@Login", textBox1.Text); 
                        command2.Parameters.AddWithValue("@Pass", textBox2.Text);
                        command2.ExecuteNonQuery();
                        
                        textBox1.Text = "";
                        textBox2.Text = "";
                        radioButton1.Checked = false;

                        this.Hide();
                        ListP = new Form2();
                        ListP.Show();*/
                        MessageBox.Show("Лол работает");
                    }
                    else
                    {
                        MessageBox.Show("Лол не работает");
                    }
                    Conn.Close();
                }
                else
                {
                    MessageBox.Show("Подтвердите, что Вы не робот");
                }
            }
            else
            {
                MessageBox.Show("Введите логин и пароль");
            }
        }
    }
}
