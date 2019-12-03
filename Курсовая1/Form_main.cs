using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Тип_товара". При необходимости она может быть перемещена или удалена.
            this.тип_товараTableAdapter.Fill(this.учет_товаровDataSet.Тип_товара);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Этап_заказа". При необходимости она может быть перемещена или удалена.
            this.этап_заказаTableAdapter.Fill(this.учет_товаровDataSet.Этап_заказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.учет_товаровDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.учет_товаровDataSet.Клиенты);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Заказанные_товары". При необходимости она может быть перемещена или удалена.
            this.заказанные_товарыTableAdapter.Fill(this.учет_товаровDataSet.Заказанные_товары);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.учет_товаровDataSet.Заказ);
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
            заказBindingSource.Position = заказBindingSource.Find("ID_заказа", 1);
            ClassMagic.show_order(dataGridView1, заказанныетоварыBindingSource);
            ClassMagic.data_grid_view_settings(dataGridView1);
            ClassMagic.data_grid_view_settings(dataGridView2);
            ClassMagic.data_grid_view_settings(dataGridView3);

        }

        private void товарыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_item form = new Form_item();
            form.Show();
        }

        private void поставкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_vendor form = new Form_vendor();
            form.Show();
        }

        private void поставщикиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_vendors form = new Form_vendors();
            form.Show();
        }

        private void менеджерыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_manager form = new Form_manager();
            form.Show();
        }

        private void клиентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_clients form = new Form_clients();
            form.Show();
        }

        private void обновитьТаблицуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            заказTableAdapter.Fill(учет_товаровDataSet.Заказ);
            заказанные_товарыTableAdapter.Fill(учет_товаровDataSet.Заказанные_товары);
        }

        private void обновитьЗаказыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagic.make_order(dataGridView1, dataGridView2, dataGridView3, dataGridView4);
            заказTableAdapter.Fill(учет_товаровDataSet.Заказ);
            заказанные_товарыTableAdapter.Fill(учет_товаровDataSet.Заказанные_товары);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ClassMagic.show_order(dataGridView1, заказанныетоварыBindingSource);
            ClassMagic.view_stage((int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[2].Value, comboBox1);

            //int j = 0;
            //for(int i =0;i<dataGridView2.RowCount;i++)
            //{
            //    j += Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
            //}
            //label2.Text = j.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassMagic.change_status(comboBox1.SelectedIndex, (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value);
        }
    }
}
