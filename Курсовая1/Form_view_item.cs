using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_view_item : Form
    {
        public Form_view_item()
        {
            InitializeComponent();
        }

        private void Form_view_item_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.учет_товаровDataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.учет_товаровDataSet.Товар);
            ClassMagic.data_grid_view_settings(dataGridView1);
            ClassMagic.data_grid_view_settings(dataGridView2);
            dataGridView1.Visible = false;
            dataGridView2.Visible = false;
            if(ClassMagic.item_stage == 1)
            {
                textBox1.Enabled = false;
            }
            if (ClassMagic.item_stage == 2)
            {
                ClassMagic.load_item(ClassMagic.index_item, dataGridView1, dataGridView2, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, pictureBox1);
                button1.Visible = false;
            }
            if(ClassMagic.item_stage == 3)
            {
                ClassMagic.load_item(ClassMagic.index_item, dataGridView1, dataGridView2, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, pictureBox1);
                button1.Text = "Обновить";
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ClassMagic.item_stage == 1)
            {
                ClassMagic.item_add(dataGridView1, dataGridView2, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8, pictureBox1);
                товарTableAdapter.Fill(учет_товаровDataSet.Товар);
            }
            if (ClassMagic.item_stage == 3)
            {
                ClassMagic.item_edit(ClassMagic.id_item, textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7, textBox8);
            }
        }
    }
}
