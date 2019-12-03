using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_manager : Form
    {
        public Form_manager()
        {
            InitializeComponent();
        }

        private void Form_manager_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Доступ". При необходимости она может быть перемещена или удалена.
            this.доступTableAdapter.Fill(this.учет_товаровDataSet.Доступ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Менеджер". При необходимости она может быть перемещена или удалена.
            this.менеджерTableAdapter.Fill(this.учет_товаровDataSet.Менеджер);
            ClassMagic.data_grid_view_settings(dataGridView1);
            dataGridView2.Visible = false;
            ClassMagic.data_grid_view_settings(dataGridView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassMagic.manager_edit_status = 2;
            int index;

            index = dataGridView1.CurrentRow.Index;
            ClassMagic.index_manager = index;

            Form_manager_view form = new Form_manager_view();
            form.Show();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagic.manager_edit_status = 1;
            Form_manager_view form = new Form_manager_view();
            form.Show();
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index;

            index = dataGridView1.CurrentRow.Index;
            ClassMagic.manager_del(index, dataGridView1, dataGridView2);
            менеджерTableAdapter.Fill(учет_товаровDataSet.Менеджер);
        }

        private void редактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagic.id_manager = (int)dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value;
            
            ClassMagic.index_manager = dataGridView1.CurrentRow.Index;
            ClassMagic.manager_edit_status = 3;
            Form_manager_view form = new Form_manager_view();
            form.Show();
        }
    }
}
