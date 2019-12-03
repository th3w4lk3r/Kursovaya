using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_item : Form
    {
        public Form_item()
        {
            InitializeComponent();
        }

        private void Form_item_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.учет_товаровDataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.учет_товаровDataSet.Товар);
            ClassMagic.data_grid_view_settings(dataGridView1);
        }

        private void button_view_item_Click(object sender, EventArgs e)
        {
            ClassMagic.item_stage = 2;
            int index;

            index = dataGridView1.CurrentRow.Index;
            ClassMagic.index_item = index;
           
            Form_view_item form = new Form_view_item();
            form.Show();
        }

        private void добавитьТоварToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagic.item_stage = 1;
            Form_view_item form = new Form_view_item();
            form.Show();
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagic.id_item = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;

            ClassMagic.index_item = dataGridView1.CurrentRow.Index;
            ClassMagic.item_stage = 3;
            Form_view_item form = new Form_view_item();
            form.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;

            index = dataGridView1.CurrentRow.Index;
            ClassMagic.item_del(index, dataGridView1);
            товарTableAdapter.Fill(учет_товаровDataSet.Товар);
        }
    }
}
