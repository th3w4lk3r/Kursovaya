using System;
using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_vendors : Form
    {
        public Form_vendors()
        {
            InitializeComponent();
        }

        private void Form_vendors_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Поставщики". При необходимости она может быть перемещена или удалена.
            this.поставщикиTableAdapter.Fill(this.учет_товаровDataSet.Поставщики);
            ClassMagic.data_grid_view_settings(dataGridView1);
        }
    }
}
