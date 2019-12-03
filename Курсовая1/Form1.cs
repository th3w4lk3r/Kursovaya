using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form_main f = new Form_main();
            f.Show();
            /*
            bool flag = false;
            
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                ClassMagic.login = dataGridView1.Rows[i].Cells[1].Value.ToString();
                ClassMagic.password = dataGridView1.Rows[i].Cells[2].Value.ToString();
                ClassMagic.access = dataGridView1.Rows[i].Cells[3].Value.ToString();

                if (textBox_login.Text == ClassMagic.login && textBox_password.Text == ClassMagic.password)
                {
                    flag = !flag;
                    Form_main form = new Form_main();
                    form.Show();
                }
                else if (textBox_login.Text == "" || textBox_password.Text == "")
                {
                    MessageBox.Show("Заполните все поля!");
                    flag = !flag;
                }
                else if (flag != false)
                {
                    MessageBox.Show("Неправильный логин или пароль!");
                    flag = !flag;
                }
                if (flag)
                {
                    break;
                }
            }
            */
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Доступ". При необходимости она может быть перемещена или удалена.
            this.доступTableAdapter.Fill(this.учет_товаровDataSet.Доступ);
            dataGridView1.Visible = false;
            ClassMagic.data_grid_view_settings(dataGridView1);
        }
    }
}
