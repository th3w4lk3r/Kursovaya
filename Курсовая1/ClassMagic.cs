using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Курсовая1
{
    class ClassMagic
    {
        public static string login, password, access;

        public static bool flag_edit = false;
        public static int index_item;
        public static int id_item;
        public static int take_item_id;
        public static int item_stage;

        public static int index_manager;
        public static int id_manager;
        public static int manager_edit_status;

        public static bool check_status_del = false;
        public static int del_id;
        public static int taked_stage;

        public static void show_order(System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.BindingSource заказанныетоварыBindingSource)
        {
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            заказанныетоварыBindingSource.Filter = "ID_заказа = " + id.ToString();
        }

        public static void show_delivery(System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.BindingSource поступившийтоварBindingSource)
        {
            int id;
            int index;

            index = dataGridView1.CurrentRow.Index;

            id = (int)dataGridView1.Rows[index].Cells[0].Value;
            поступившийтоварBindingSource.Filter = "ID_поставки = " + id.ToString();
        }

        public static void data_grid_view_settings(System.Windows.Forms.DataGridView dataGridView)
        {
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
            dataGridView.MultiSelect = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.AllowUserToResizeRows = false;
            dataGridView.AllowUserToResizeColumns = false;
            dataGridView.AllowUserToOrderColumns = false;
        }

        public static void make_delivery(System.Windows.Forms.DataGridView dataGridView1,  System.Windows.Forms.DataGridView dataGridView2, System.Windows.Forms.DataGridView dataGridView3, System.Windows.Forms.DataGridView dataGridView4)
        {
            try
            {
                int nowdelivery = Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value) + 1;
                int max_random_vendor = dataGridView3.RowCount;
                Random rnd = new Random();
                int value = rnd.Next(1, max_random_vendor+1);

                DateTime dt = DateTime.Now;
                string curDate = dt.ToString("yyyy-MM-dd");

                try
                {
                    string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                    SqlConnection Conn = new SqlConnection(strConn);
                    Conn.Open();

                    var cmd = new SqlCommand("INSERT INTO [Поставки] ([ID_поставки],[Дата], [Поставщик], [Этап],[Сумма]) VALUES (@id, @date, @vendor,@stage,@count)", Conn);
                    cmd.Parameters.Add("@id", nowdelivery);
                    cmd.Parameters.Add("@date", curDate);
                    cmd.Parameters.Add("@vendor", value);
                    cmd.Parameters.Add("@stage", "Прибыло");
                    cmd.Parameters.Add("@count", "0");
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();
                }
                catch
                {
                }

                int items_price = 0;
                try
                {
                    int value_max_item = rnd.Next(1, 10);
                    int value_item;
                    int value_item_count;
                    int max_random2 = dataGridView4.RowCount;

                    int item_price = 0;
                    for (int i = 0; i <= value_max_item; i++)
                    {
                        value_item = rnd.Next(1, max_random2);
                        value_item_count = rnd.Next(1, 3);
                        item_price = Convert.ToInt32(dataGridView4.Rows[value_item - 1].Cells[5].Value);
                        string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                        SqlConnection Conn = new SqlConnection(strConn);
                        Conn.Open();

                        var cmd = new SqlCommand("INSERT INTO [Поступивший_товар] ([ID_товара],[ID_поставки], [Колиество], [Цена]) VALUES (@id_item, @id_delivery, @count,@price)", Conn);
                        cmd.Parameters.Add("@id_item", value_item);
                        cmd.Parameters.Add("@id_delivery", nowdelivery);
                        cmd.Parameters.Add("@count", value_item_count);
                        cmd.Parameters.Add("@price", item_price);
                        items_price += item_price; ;
                        cmd.ExecuteNonQuery();
                        Conn.Close();
                        Conn.Dispose();
                    }
                }
                catch
                {
                }

                try
                {
                    string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                    SqlConnection Conn = new SqlConnection(strConn);
                    Conn.Open();

                    SqlCommand cmd = new SqlCommand("Update Поставки" + " Set Сумма = @finall_price where ID_поставки = @ID", Conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@ID";
                    param.Value = nowdelivery;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@finall_price";
                    param.Value = items_price;
                    param.SqlDbType = SqlDbType.Money;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();
                }
                catch
                {
                }

                try
                {
                    string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                    SqlConnection Conn = new SqlConnection(strConn);
                    Conn.Open();

                    SqlCommand cmd = new SqlCommand("Update Поставщики" + " Set Количество_поставок = @count_of_delivery where ID_поставщика = @ID", Conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@ID";
                    param.Value = value;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@count_of_delivery";
                    param.Value = Convert.ToInt32(dataGridView3.Rows[value - 1].Cells[3].Value) + 1;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();
                }
                catch
                {
                }
            }
            catch
            {
                MessageBox.Show("Не получилось");
            }
        }
    
        public static void make_order(System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.DataGridView dataGridView2, System.Windows.Forms.DataGridView dataGridView3, System.Windows.Forms.DataGridView dataGridView4)
        {
            try
            {
                int now_order = Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value) + 1;// dataGridView1.RowCount + 1; //
                int max_random_client = dataGridView3.RowCount;
                Random rnd = new Random();
                int id_client = rnd.Next(1, max_random_client);

                DateTime dt = DateTime.Now;
                string curDate = dt.ToString("yyyy-MM-dd");

                try
                {
                    string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                    SqlConnection Conn = new SqlConnection(strConn);
                    Conn.Open();

                    var cmd = new SqlCommand("INSERT INTO [Заказ] ([ID_заказа],[Дата], [Этап], [ID_менеджера],[ID_клиента], [Адрес_доставки], [Цена]) VALUES (@id, @date, @stage,@idm,@idc, @adress, @price)", Conn);
                    cmd.Parameters.Add("@id", now_order);
                    cmd.Parameters.Add("@date", curDate);
                    cmd.Parameters.Add("@stage", "1");
                    cmd.Parameters.Add("@idm", "2");
                    cmd.Parameters.Add("@idc", id_client);
                    cmd.Parameters.Add("@adress", dataGridView3.Rows[id_client - 1].Cells[5].Value.ToString());
                    cmd.Parameters.Add("@price", "0");
                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();
                }
                catch
                {
                }

                int items_price = 0;
                try
                {
                    int first_choice = rnd.Next(1, 100);

                    int[] mas = new int[dataGridView4.RowCount];
                   

                    if (first_choice > 0 && first_choice < 25)
                    {
                        mas[0] = 1;
                    }
                    if (first_choice > 24 && first_choice < 49)
                    {
                        mas[0] = 2;
                    }
                    if (first_choice > 48 && first_choice < 85)
                    {
                        mas[0] = 3;
                        mas[1] = 4;
                        mas[2] = 6;
                        mas[3] = 7;
                        mas[4] = 8;
                        mas[5] = 9;
                        mas[6] = 10;
                        mas[7] = 11;
                        mas[8] = 12;
                        mas[9] = 13;
                        mas[10] = 14;
                    }
                    if (first_choice > 84 && first_choice < 95)
                    {
                        mas[0] = 10;
                        mas[1] = 12;
                    }
                    if (first_choice > 94 && first_choice < 101)
                    {
                        mas[0] = 5;
                    }

                    int[] typte = new int[dataGridView4.RowCount] ;

                    for (int i = 0; i < typte.Length; i++)
                    {
                        typte[i] = 0;
                    }

                    int u = 0;
                    int cc = 0;
                    for (int h = 0; h < mas.Length; h++)
                    {
                        for (int i = 0; i < dataGridView4.RowCount; i++)
                        {
                            if (Convert.ToInt32(dataGridView4.Rows[i].Cells[1].Value) == mas[h])
                            {
                                typte[u] =Convert.ToInt32(dataGridView4.Rows[i].Cells[0].Value);
                                cc++;
                                u++;
                            }
                        }

                        int var = rnd.Next(1, cc+1)-1;// индекс нужного значения
                        int price = 0;
                        for (int i = 0; i < typte.Length; i++)
                        {
                            if (mas[i] != 0 && typte[i] !=0)
                            {
                                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                                SqlConnection Conn = new SqlConnection(strConn);
                                Conn.Open();

                                price = Convert.ToInt32(dataGridView4.Rows[typte[var]-1].Cells[5].Value);
                                var cmd = new SqlCommand("INSERT INTO [Заказанные_товары] ([ID_товара],[ID_заказа], [Количество], [Сумма]) VALUES (@id_item, @id_order, @count,@price)", Conn);
                                cmd.Parameters.Add("@id_item", typte[var]);
                                cmd.Parameters.Add("@id_order", now_order);
                                cmd.Parameters.Add("@count", "1");
                                cmd.Parameters.Add("@price", price);
                                items_price += price;
                                cmd.ExecuteNonQuery();
                                Conn.Close();
                                Conn.Dispose();
                                break;
                            }
                        }
                        Console.WriteLine();
                        u = 0;
                        cc = 0;
                        for (int i = 0; i < dataGridView4.RowCount; i++)
                        {
                            typte[i] = 0;
                        }
                    }
                }
                catch
                {
                }

                try
                {
                    string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                    SqlConnection Conn = new SqlConnection(strConn);
                    Conn.Open();

                    SqlCommand cmd = new SqlCommand("Update Заказ" + " Set Цена = @finall_price where ID_заказа = @ID", Conn);
                    SqlParameter param = new SqlParameter();
                    param.ParameterName = "@ID";
                    param.Value = now_order;
                    param.SqlDbType = SqlDbType.Int;
                    cmd.Parameters.Add(param);

                    param = new SqlParameter();
                    param.ParameterName = "@finall_price";
                    param.Value = items_price;
                    param.SqlDbType = SqlDbType.Money;
                    cmd.Parameters.Add(param);

                    cmd.ExecuteNonQuery();
                    Conn.Close();
                    Conn.Dispose();
                }
                catch
                {
                }
                
            }
            catch
            {
                MessageBox.Show("Не получилось");
            }

        }
   
        public static void load_item(int index, System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.DataGridView dataGridView2, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.PictureBox pictureBox1)
        {
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[index ].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[index ].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[index ].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[index ].Cells[7].Value.ToString();

            textBox1.Enabled = false;
            if (item_stage != 3)
            {
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
            }
      
            string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
            SqlConnection Conn = new SqlConnection(strConn);
            
            byte[] byteArray = new byte[0]; Conn.Open();

            string s = @"select Фото from Товар where ID_товара="+(index+1).ToString();
            SqlCommand comm = new SqlCommand(s, Conn);

            byteArray = (byte[])comm.ExecuteScalar();
            MemoryStream ms = new MemoryStream(byteArray);
            pictureBox1.Image = Image.FromStream(ms);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            ms.Close();
        }

        public static void load_manager(int index, System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.DataGridView dataGridView2, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.TextBox textBox9, System.Windows.Forms.TextBox textBox10, System.Windows.Forms.TextBox textBox11, System.Windows.Forms.TextBox textBox12, System.Windows.Forms.TextBox textBox13, System.Windows.Forms.TextBox textBox14)
        {
            textBox1.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            textBox5.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            textBox6.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            textBox7.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            textBox8.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            textBox9.Text = dataGridView1.Rows[index].Cells[8].Value.ToString();
            textBox10.Text = dataGridView1.Rows[index].Cells[9].Value.ToString();
            textBox11.Text = dataGridView1.Rows[index].Cells[10].Value.ToString();
            textBox12.Text = dataGridView2.Rows[index].Cells[3].Value.ToString();
            textBox13.Text = dataGridView2.Rows[index].Cells[1].Value.ToString();
            textBox14.Text = dataGridView2.Rows[index].Cells[2].Value.ToString();
            textBox1.Enabled = false;
            if (manager_edit_status != 3)
            {
                
                textBox2.Enabled = false;
                textBox3.Enabled = false;
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                textBox6.Enabled = false;
                textBox7.Enabled = false;
                textBox8.Enabled = false;
                textBox9.Enabled = false;
                textBox10.Enabled = false;
                textBox11.Enabled = false;
                textBox12.Enabled = false;

            }
        }
        
        public static void item_add( System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.DataGridView dataGridView2, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.PictureBox pictureBox1)
        {
            string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
            SqlConnection Conn = new SqlConnection(strConn);
            Conn.Open();

            var cmd = new SqlCommand("INSERT INTO [Товар] ([ID_товара],[Тип_товара], [Производитель], [Модель],[Характеристика], [Цена], [Количество], [Гаранстия_(мес)]) VALUES (@id, @type, @pro,@mod,@xar, @price, @count,@gar)", Conn);

            cmd.Parameters.Add("@id", textBox1.Text);
            cmd.Parameters.Add("@type", textBox2.Text);
            cmd.Parameters.Add("@pro", textBox3.Text);
            cmd.Parameters.Add("@mod", textBox4.Text);
            cmd.Parameters.Add("@xar", textBox5.Text);
            cmd.Parameters.Add("@price", textBox6.Text);
            cmd.Parameters.Add("@count", textBox7.Text);
            cmd.Parameters.Add("@gar", textBox8.Text);
            
            cmd.ExecuteNonQuery();
            Conn.Close();
            Conn.Dispose();
        }

        public static void item_del(int index, System.Windows.Forms.DataGridView dataGridView1)
        {
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                var cmd = new SqlCommand("DELETE FROM Товар WHERE ID_товара = @id", Conn);

                cmd.Parameters.Add("@id", Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));

                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();

            }
            catch
            {
                MessageBox.Show("1");
            }
        }

        public static void item_edit(int id, System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8)
        {
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                SqlCommand cmd = new SqlCommand("Update Товар" + " Set Тип_товара = @type, Производитель = @manufacturer, Модель = @model, Характеристика = @prop, Цена = @price, Количество = @count, [Гаранстия_(мес)] = @garant where ID_товара = @ID", Conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@type";
                param.Value = textBox2.Text;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@manufacturer";
                param.Value = textBox3.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@model";
                param.Value = textBox4.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@prop";
                param.Value = textBox5.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@price";
                param.Value = textBox6.Text;
                param.SqlDbType = SqlDbType.Money;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@count";
                param.Value = textBox7.Text;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@garant";
                param.Value = textBox8.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();

            }
            catch
            {
            }
        }

        public static void take_item(int id, System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.DataGridView dataGridView2, System.Windows.Forms.DataGridView dataGridView4)
        {
            int index_item;

            try
            {
                for (int i = 0;i<dataGridView2.RowCount;i++)
                {
                    if(Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value) == id)
                    {
                        for (int j = 0; i < dataGridView4.RowCount; j++)
                        {
                            if (Convert.ToInt32(dataGridView4.Rows[j].Cells[0].Value) == Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value))
                            {
                                index_item =Convert.ToInt32(dataGridView4.Rows[j].Cells[0].Value);

                                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                                SqlConnection Conn = new SqlConnection(strConn);
                                Conn.Open();

                                SqlCommand cmd = new SqlCommand("Update Товар" + " Set Количество = @count where ID_товара = @ID", Conn);
                                SqlParameter param = new SqlParameter();
                                param.ParameterName = "@ID";
                                param.Value = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                param = new SqlParameter();
                                param.ParameterName = "@count";
                                param.Value = Convert.ToInt32(dataGridView4.Rows[index_item].Cells[6].Value) + Convert.ToInt32(dataGridView2.Rows[i].Cells[2].Value);
                                param.SqlDbType = SqlDbType.Int;
                                cmd.Parameters.Add(param);

                                cmd.ExecuteNonQuery();
                                Conn.Close();
                                Conn.Dispose();

                                break;
                            } 
                        }


                    }
                }

                try
                {
                    string strConn1 = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";

                    SqlConnection Conn1 = new SqlConnection(strConn1);
                    Conn1.Open();

                    SqlCommand cmd1 = new SqlCommand("Update Поставки" + " Set Этап = @stage where ID_поставки = @ID", Conn1);
                    SqlParameter param1 = new SqlParameter();
                    param1.ParameterName = "@ID";
                    param1.Value = ClassMagic.take_item_id;
                    param1.SqlDbType = SqlDbType.Int;
                    cmd1.Parameters.Add(param1);

                    param1 = new SqlParameter();
                    param1.ParameterName = "@stage";
                    param1.Value = "Принято";
                    param1.SqlDbType = SqlDbType.VarChar;
                    cmd1.Parameters.Add(param1);

                    cmd1.ExecuteNonQuery();
                    Conn1.Close();
                    Conn1.Dispose();

                    
                    MessageBox.Show("Поставка принята!");
                }
                catch
                {
                    MessageBox.Show("vse ne pol");
                }
            }
            catch
            {
                MessageBox.Show("ne pol");
            }
        }

        public static void check_status_delivery(System.Windows.Forms.DataGridView dataGridView1)
        {
            if (dataGridView1.Rows[ClassMagic.del_id].Cells[3].Value.ToString() == "Прибыло")
            {
                ClassMagic.check_status_del = true;
            }
        }
    
        public static void manager_add(System.Windows.Forms.DataGridView dataGridView1 , System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.TextBox textBox9, System.Windows.Forms.TextBox textBox10, System.Windows.Forms.TextBox textBox11, System.Windows.Forms.TextBox textBox12, System.Windows.Forms.TextBox textBox13, System.Windows.Forms.TextBox textBox14)
        {
            
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                var cmd = new SqlCommand("INSERT INTO [Менеджер] ([ID_менеджера],[Фамилия], [Имя], [Отчество],[Номер_телефона], [Дата_рождения], [Серия_паспорта], [Номер_паспорта],[Кем_выдан],[Принят]) " +
                    "VALUES (@id, @surname, @name,@namedad,@number_phone, @dateborn, @serialpas, @numberpas, @whovidal, @prinyat)", Conn);
              
                cmd.Parameters.Add("@id", Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount - 1].Cells[0].Value) + 1);    
                cmd.Parameters.Add("@surname", textBox2.Text);
                cmd.Parameters.Add("@name", textBox3.Text);
                cmd.Parameters.Add("@namedad", textBox4.Text);
                cmd.Parameters.Add("@number_phone",textBox5.Text);
                cmd.Parameters.Add("@dateborn", textBox6.Text);
                cmd.Parameters.Add("@serialpas", textBox7.Text);
                cmd.Parameters.Add("@numberpas", textBox8.Text);
                cmd.Parameters.Add("@whovidal", textBox9.Text);
                cmd.Parameters.Add("@prinyat", textBox10.Text);
                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
                
            }
            catch
            {
                MessageBox.Show("1");
            }

            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                var cmd = new SqlCommand("INSERT INTO [Доступ] ([ID_менеджера],[Login], [Password], [Доступ]) " +
                    "VALUES (@id, @login, @pass,@access)", Conn);
                cmd.Parameters.Add("@id", Convert.ToInt32(dataGridView1.Rows[dataGridView1.RowCount-1].Cells[0].Value)+1);
                cmd.Parameters.Add("@login", textBox13.Text);
                cmd.Parameters.Add("@pass", textBox14.Text);
                cmd.Parameters.Add("@access", textBox12.Text);
      
                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
                
            }
            catch
            {
                MessageBox.Show("2");
            }

        }
    
        public static void manager_del(int index, System.Windows.Forms.DataGridView dataGridView1, System.Windows.Forms.DataGridView dataGridView2)
        {
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                var cmd = new SqlCommand("DELETE FROM [Менеджер] WHERE ID_менеджера=@id", Conn);

                cmd.Parameters.Add("@id",Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));
                
                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();

            }
            catch
            {
                MessageBox.Show("1");
            }


            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                var cmd = new SqlCommand("DELETE FROM [Доступ] WHERE ID_менеджера=@id", Conn);

                cmd.Parameters.Add("@id", Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value));

                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
            }
            catch
            {
                MessageBox.Show("2");
            }
        }

        public static void manager_edit(int id,   System.Windows.Forms.TextBox textBox1, System.Windows.Forms.TextBox textBox2, System.Windows.Forms.TextBox textBox3, System.Windows.Forms.TextBox textBox4, System.Windows.Forms.TextBox textBox5, System.Windows.Forms.TextBox textBox6, System.Windows.Forms.TextBox textBox7, System.Windows.Forms.TextBox textBox8, System.Windows.Forms.TextBox textBox9, System.Windows.Forms.TextBox textBox10, System.Windows.Forms.TextBox textBox11, System.Windows.Forms.TextBox textBox12, System.Windows.Forms.TextBox textBox13, System.Windows.Forms.TextBox textBox14)
        {
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                SqlCommand cmd = new SqlCommand("Update Доступ" + " Set Login = @login, Password = @pass, Доступ = @access where ID_менеджера = @ID", Conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@login";
                param.Value = textBox13.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@pass";
                param.Value = textBox14.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@access";
                param.Value = textBox12.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
               
            }
            catch
            {
            }
            
            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                
                SqlCommand cmd = new SqlCommand("Update Менеджер" + " Set Фамилия = @surname, Имя = @name,Отчество = @dadname, Номер_телефона = @numphone, Дата_рождения = @dateborn, Серия_паспорта = @serialpas, Номер_паспорта = @numberpas, Кем_выдан = @whovidal, Принят = @prinyat where ID_менеджера = @ID", Conn);//, Уволен = @uvolen
                SqlParameter param = new SqlParameter(); 
                param.ParameterName = "@ID";
                param.Value = Convert.ToInt32(id);
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@surname";
                param.Value = textBox2.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@name";
                param.Value = textBox3.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@dadname";
                param.Value = textBox4.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@numphone";
                param.Value = textBox5.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@dateborn";
                param.Value =Convert.ToDateTime(textBox6.Text);
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@serialpas";
                param.Value = textBox7.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@numberpas";
                param.Value = textBox8.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@whovidal";
                param.Value = textBox9.Text;
                param.SqlDbType = SqlDbType.VarChar;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@prinyat";
                param.Value = Convert.ToDateTime(textBox10.Text);
                param.SqlDbType = SqlDbType.Date;
                cmd.Parameters.Add(param);

                //param = new SqlParameter();
                //param.ParameterName = "@uvolen";
                //param.Value = Convert.ToDateTime(textBox10.Text);
                //param.SqlDbType = SqlDbType.Date;
                //cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                Conn.Close();
                
            }
            catch
            {
            }
            
        }

        public static void view_stage(int stage, System.Windows.Forms.ComboBox comboBox1)
        { 
            switch(stage)
            {
                case 1:
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("К оплате");
                    comboBox1.Items.Add("Отменен");
                    comboBox1.Enabled = true;
                    taked_stage = 1;
                    break; //новый
                case 2:
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = true;
                    taked_stage = 2;
                    break; //к оплате
                case 3:
                    comboBox1.Items.Clear();
                    comboBox1.Items.Add("Готов");
                    comboBox1.Enabled = true;
                    taked_stage = 3;
                    break; //оплачен
                case 4:
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = false;
                    taked_stage = 4;
                    break; //готов
                case 5:
                    comboBox1.Items.Clear();
                    comboBox1.Enabled = false;
                    taked_stage = 5;
                    break; //отменен
            }



        }

        public static void change_status(int index, int id)
        {
            int choice_stage=1;
            switch (taked_stage)
            {
                case 1:
                    switch(index)
                    {
                        case 0:
                            choice_stage = 3; //оплачен
                            break;
                        case 1:
                            choice_stage = 5; //отменен
                            break;
                    }
                    break; //новый
               
                case 3:
                    switch (index)
                    {
                        case 0:
                            choice_stage = 4; //готов
                            break;
                    }
                    break; //оплачен
            }

            try
            {
                string strConn = @"Data Source=DESKTOP-GB3UGEB\SQLEXPRESS;Initial Catalog=Учет_товаров;Integrated Security=True";
                SqlConnection Conn = new SqlConnection(strConn);
                Conn.Open();

                SqlCommand cmd = new SqlCommand("Update Заказ" + " Set Этап = @stage where ID_заказа = @ID", Conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@ID";
                param.Value = id;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                param = new SqlParameter();
                param.ParameterName = "@stage";
                param.Value = choice_stage;
                param.SqlDbType = SqlDbType.Int;
                cmd.Parameters.Add(param);

                cmd.ExecuteNonQuery();
                Conn.Close();
                Conn.Dispose();
            }
            catch
            {
            }
            
        }

    }
}
