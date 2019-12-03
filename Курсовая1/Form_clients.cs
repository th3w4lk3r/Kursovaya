using System;

using System.Windows.Forms;

namespace Курсовая1
{
    public partial class Form_clients : Form
    {
        public Form_clients()
        {
            InitializeComponent();
        }

        private void Form_clients_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "учет_товаровDataSet.Клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.учет_товаровDataSet.Клиенты);
            ClassMagic.data_grid_view_settings(dataGridView1);
        }
    }
}
