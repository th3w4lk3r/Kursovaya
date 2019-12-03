using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_vendor : Form
    {
        public Form_vendor()
        {
            InitializeComponent();
        }

        private void Form_vendor_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Этап_заказа". При необходимости она может быть перемещена или удалена.
            this.этап_заказаTableAdapter.Fill(this.учет_товаровDataSet.Этап_заказа);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Товар". При необходимости она может быть перемещена или удалена.
            this.товарTableAdapter.Fill(this.учет_товаровDataSet.Товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.учет_товаровDataSet.Поставщики);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Поступивший_товар". При необходимости она может быть перемещена или удалена.
            this.поступивший_товарTableAdapter.Fill(this.учет_товаровDataSet.Поступивший_товар);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Поставки". При необходимости она может быть перемещена или удалена.
            this.поставкиTableAdapter.Fill(this.учет_товаровDataSet.Поставки);
            ClassMagic.data_grid_view_settings(dataGridView1);
            ClassMagic.data_grid_view_settings(dataGridView2);
            ClassMagic.data_grid_view_settings(dataGridView3);
            ClassMagic.data_grid_view_settings(dataGridView4);
            ClassMagic.show_delivery(dataGridView1, поступившийтоварBindingSource);
            dataGridView3.Visible = false;
            dataGridView4.Visible = false;
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            ClassMagic.show_delivery(dataGridView1, поступившийтоварBindingSource);
        }

        private void заказатьПоставкуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassMagic.make_delivery(dataGridView1, dataGridView2, dataGridView3, dataGridView4);
            поступивший_товарTableAdapter.Fill(учет_товаровDataSet.Поступивший_товар);
            поставкиTableAdapter.Fill(учет_товаровDataSet.Поставки);
            поставщикиTableAdapter.Fill(учет_товаровDataSet.Поставщики);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ClassMagic.del_id = dataGridView1.CurrentRow.Index;
            ClassMagic.check_status_delivery(dataGridView1);
            if (ClassMagic.check_status_del == true)
            {
                ClassMagic.take_item(ClassMagic.take_item_id = Convert.ToInt32(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value), dataGridView1, dataGridView2, dataGridView4 );
                поставкиTableAdapter.Fill(учет_товаровDataSet.Поставки);
                ClassMagic.check_status_del = false;
            }
            else
            {
                MessageBox.Show("Поставка уже принята");
            }
        }
    }
}
