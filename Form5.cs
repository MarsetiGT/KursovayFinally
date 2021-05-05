using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kyrs
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopOnlineDataSet.Brand". При необходимости она может быть перемещена или удалена.
            this.brandTableAdapter.Fill(this.shopOnlineDataSet.Brand);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopOnlineDataSet.categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.shopOnlineDataSet.categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopOnlineDataSet.InfoAccount". При необходимости она может быть перемещена или удалена.
            this.infoAccountTableAdapter.Fill(this.shopOnlineDataSet.InfoAccount);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopOnlineDataSet.Num_sec". При необходимости она может быть перемещена или удалена.
            this.num_secTableAdapter.Fill(this.shopOnlineDataSet.Num_sec);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopOnlineDataSet.product". При необходимости она может быть перемещена или удалена.
            this.productTableAdapter.Fill(this.shopOnlineDataSet.product);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "shopOnlineDataSet.AccountUsers". При необходимости она может быть перемещена или удалена.
            this.accountUsersTableAdapter.Fill(this.shopOnlineDataSet.AccountUsers);
            this.ControlBox = false;
        }

        private void accountUsersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountUsersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.shopOnlineDataSet);
        }

        private void button1_Click(object sender, EventArgs e) //Первая
        {
            accountUsersBindingSource.MoveFirst();
        }

        private void button2_Click(object sender, EventArgs e) //Последняя
        {
            accountUsersBindingSource.MovePrevious();
        }

        private void button3_Click(object sender, EventArgs e) //Следующая
        {
            accountUsersBindingSource.MoveNext();
        }

        private void button4_Click(object sender, EventArgs e) //Предыдущая
        {
            accountUsersBindingSource.MoveLast();
        }

        private void button5_Click(object sender, EventArgs e) //Добавить
        {
            accountUsersBindingSource.AddNew();
        }

        private void button6_Click(object sender, EventArgs e) //Удалить
        {
            accountUsersBindingSource.RemoveCurrent();
        }

        private void button7_Click(object sender, EventArgs e) //Сохранить
        {
            //проверяет введённые в поля данные на соответствие типам данных полей 
            this.Validate();
            //закрывает подключение с сервером 
            this.accountUsersBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.shopOnlineDataSet);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveFirst();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            productBindingSource.MovePrevious();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveNext();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            productBindingSource.MoveLast();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            productBindingSource.AddNew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            productBindingSource.RemoveCurrent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей 
            this.Validate();
            //закрывает подключение с сервером 
            this.productBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.shopOnlineDataSet);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MoveFirst();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MovePrevious();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MoveNext();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.MoveLast();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.AddNew();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            categoriesBindingSource.RemoveCurrent();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей 
            this.Validate();
            //закрывает подключение с сервером 
            this.categoriesBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.shopOnlineDataSet);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            brandBindingSource.MoveFirst();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            brandBindingSource.MovePrevious();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            brandBindingSource.MoveNext();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            brandBindingSource.MoveLast();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            brandBindingSource.AddNew();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            brandBindingSource.RemoveCurrent();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            //проверяет введённые в поля данные на соответствие типам данных полей 
            this.Validate();
            //закрывает подключение с сервером 
            this.brandBindingSource.EndEdit();
            //обновляет данные на сервере
            this.tableAdapterManager.UpdateAll(this.shopOnlineDataSet);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
