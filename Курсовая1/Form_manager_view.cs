using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_manager_view : Form
    {
        public Form_manager_view()
        {
            InitializeComponent();
        }

        private void Form_manager_view_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Доступ". При необходимости она может быть перемещена или удалена.
            this.доступTableAdapter.Fill(this.учет_товаровDataSet.Доступ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Менеджер". При необходимости она может быть перемещена или удалена.
            this.менеджерTableAdapter.Fill(this.учет_товаровDataSet.Менеджер);
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            ClassMagic.data_grid_view_settings(dataGridView1);
            ClassMagic.data_grid_view_settings(dataGridView2);
            if(ClassMagic.manager_edit_status == 1)
            {
                 label1.Visible = false;
                textBox1.Visible = false;
                label11.Visible = false;
                textBox11.Visible = false;
            }
            if (ClassMagic.manager_edit_status == 2)
            {
                ClassMagic.load_manager(ClassMagic.index_manager, dataGridView1, dataGridView2, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14);
                label13.Visible = false;
                textBox13.Visible = false;
                label14.Visible = false;
                textBox14.Visible = false;
            }
            if (ClassMagic.manager_edit_status == 3)
            {
                ClassMagic.load_manager(ClassMagic.index_manager, dataGridView1, dataGridView2, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14);
                button1.Text = "Обновить";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClassMagic.manager_edit_status == 1)
            {
                ClassMagic.manager_add(dataGridView1, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14);
            }
            if (ClassMagic.manager_edit_status == 3)
            {
                ClassMagic.manager_edit(ClassMagic.id_manager, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, textBox9, textBox10, textBox11, textBox12, textBox13, textBox14);
            }
        }
    }
}
