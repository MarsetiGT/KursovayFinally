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
    public partial class Form2 : Form
    {
        Form4 Profile;
        SqlConnection Conn = new SqlConnection("Data Source=LAPTOP-FV45K32J;Initial Catalog=ShopOnline;Integrated Security=True");
        string das = Form1.Value1;

        public Form2()
        {
            InitializeComponent();
            int codesec = 0;
            Conn.Open();
            string query2 = "SELECT Sec FROM AccountUsers WHERE Login = @Login";
            SqlCommand command2 = new SqlCommand(query2, Conn);
            command2.Parameters.Add("@Login", DbType.String).Value = das;
            codesec = ((int)command2.ExecuteScalar());
            Conn.Close();
            if (codesec == 1)
            {
                label4.Visible = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void label3_Click(object sender, EventArgs e) // Выход из профиля
        {
            this.Hide();
            Form1 form1 = (Form1)Application.OpenForms["Form1"]; // Где Form1 это имя формы содежащаяся в переменной Name.
            if (form1 != null) // Если форма не существует, то создаём
            {
                Form1 Auth = new Form1(); // Создание нового экземпляра формы
                form1.Show(); // Отображаем форму
            }
            else form1.Activate();
        }

        private void label1_Click(object sender, EventArgs e) // Профиль
        {
            Profile = new Form4();
            Profile.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e) // Комплектующие для ПК
        {
            MessageBox.Show($"Проверка: {das}");
        }

        private void pictureBox3_Click(object sender, EventArgs e) // Мониторы
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e) // Устройства ввода
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Form5 Admin = new Form5();
            Admin.StartPosition = FormStartPosition.WindowsDefaultLocation;
            Admin.Location = new Point (150,100);
            Admin.Show();
        }
    }
}
