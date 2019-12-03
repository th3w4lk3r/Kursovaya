namespace Курсовая1
{
    partial class Form_vendor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDпоставкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.поставщикиBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.учет_товаровDataSet = new Курсовая1.Учет_товаровDataSet();
            this.этапDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.суммаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставкиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.товарBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDпоставкиDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колиествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поступившийтоварBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.iDпоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.юридеческийадресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествопоставокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.iDтовараDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гаранстиямесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставкиTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ПоставкиTableAdapter();
            this.поступивший_товарTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.Поступивший_товарTableAdapter();
            this.поставщикиTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ПоставщикиTableAdapter();
            this.товарTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ТоварTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСПоставкамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заказатьПоставкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.этапзаказаBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.этап_заказаTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.Этап_заказаTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступившийтоварBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.этапзаказаBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDпоставкиDataGridViewTextBoxColumn,
            this.датаDataGridViewTextBoxColumn,
            this.поставщикDataGridViewTextBoxColumn,
            this.этапDataGridViewTextBoxColumn,
            this.суммаDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставкиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(534, 167);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.dataGridView1_Click);
            // 
            // iDпоставкиDataGridViewTextBoxColumn
            // 
            this.iDпоставкиDataGridViewTextBoxColumn.DataPropertyName = "ID_поставки";
            this.iDпоставкиDataGridViewTextBoxColumn.HeaderText = "№";
            this.iDпоставкиDataGridViewTextBoxColumn.Name = "iDпоставкиDataGridViewTextBoxColumn";
            this.iDпоставкиDataGridViewTextBoxColumn.Width = 30;
            // 
            // датаDataGridViewTextBoxColumn
            // 
            this.датаDataGridViewTextBoxColumn.DataPropertyName = "Дата";
            this.датаDataGridViewTextBoxColumn.HeaderText = "Дата";
            this.датаDataGridViewTextBoxColumn.Name = "датаDataGridViewTextBoxColumn";
            // 
            // поставщикDataGridViewTextBoxColumn
            // 
            this.поставщикDataGridViewTextBoxColumn.DataPropertyName = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.DataSource = this.поставщикиBindingSource1;
            this.поставщикDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.поставщикDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.поставщикDataGridViewTextBoxColumn.HeaderText = "Поставщик";
            this.поставщикDataGridViewTextBoxColumn.Name = "поставщикDataGridViewTextBoxColumn";
            this.поставщикDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.поставщикDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.поставщикDataGridViewTextBoxColumn.ValueMember = "ID_поставщика";
            this.поставщикDataGridViewTextBoxColumn.Width = 140;
            // 
            // поставщикиBindingSource1
            // 
            this.поставщикиBindingSource1.DataMember = "Поставщики";
            this.поставщикиBindingSource1.DataSource = this.учет_товаровDataSet;
            // 
            // учет_товаровDataSet
            // 
            this.учет_товаровDataSet.DataSetName = "Учет_товаровDataSet";
            this.учет_товаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // этапDataGridViewTextBoxColumn
            // 
            this.этапDataGridViewTextBoxColumn.DataPropertyName = "Этап";
            this.этапDataGridViewTextBoxColumn.HeaderText = "Этап";
            this.этапDataGridViewTextBoxColumn.Name = "этапDataGridViewTextBoxColumn";
            this.этапDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // суммаDataGridViewTextBoxColumn
            // 
            this.суммаDataGridViewTextBoxColumn.DataPropertyName = "Сумма";
            this.суммаDataGridViewTextBoxColumn.HeaderText = "Сумма";
            this.суммаDataGridViewTextBoxColumn.Name = "суммаDataGridViewTextBoxColumn";
            // 
            // поставкиBindingSource
            // 
            this.поставкиBindingSource.DataMember = "Поставки";
            this.поставкиBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDтовараDataGridViewTextBoxColumn,
            this.iDпоставкиDataGridViewTextBoxColumn1,
            this.колиествоDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.поступившийтоварBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 200);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(399, 195);
            this.dataGridView2.TabIndex = 1;
            // 
            // iDтовараDataGridViewTextBoxColumn
            // 
            this.iDтовараDataGridViewTextBoxColumn.DataPropertyName = "ID_товара";
            this.iDтовараDataGridViewTextBoxColumn.DataSource = this.товарBindingSource1;
            this.iDтовараDataGridViewTextBoxColumn.DisplayMember = "Модель";
            this.iDтовараDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.iDтовараDataGridViewTextBoxColumn.HeaderText = "Наименование";
            this.iDтовараDataGridViewTextBoxColumn.Name = "iDтовараDataGridViewTextBoxColumn";
            this.iDтовараDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iDтовараDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.iDтовараDataGridViewTextBoxColumn.ValueMember = "ID_товара";
            this.iDтовараDataGridViewTextBoxColumn.Width = 150;
            // 
            // товарBindingSource1
            // 
            this.товарBindingSource1.DataMember = "Товар";
            this.товарBindingSource1.DataSource = this.учет_товаровDataSet;
            // 
            // iDпоставкиDataGridViewTextBoxColumn1
            // 
            this.iDпоставкиDataGridViewTextBoxColumn1.DataPropertyName = "ID_поставки";
            this.iDпоставкиDataGridViewTextBoxColumn1.HeaderText = "ID_поставки";
            this.iDпоставкиDataGridViewTextBoxColumn1.Name = "iDпоставкиDataGridViewTextBoxColumn1";
            this.iDпоставкиDataGridViewTextBoxColumn1.Visible = false;
            // 
            // колиествоDataGridViewTextBoxColumn
            // 
            this.колиествоDataGridViewTextBoxColumn.DataPropertyName = "Колиество";
            this.колиествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.колиествоDataGridViewTextBoxColumn.Name = "колиествоDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // поступившийтоварBindingSource
            // 
            this.поступившийтоварBindingSource.DataMember = "Поступивший_товар";
            this.поступившийтоварBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDпоставщикаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.юридеческийадресDataGridViewTextBoxColumn,
            this.количествопоставокDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.поставщикиBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(433, 257);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(113, 32);
            this.dataGridView3.TabIndex = 2;
            // 
            // iDпоставщикаDataGridViewTextBoxColumn
            // 
            this.iDпоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn.HeaderText = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn.Name = "iDпоставщикаDataGridViewTextBoxColumn";
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            // 
            // юридеческийадресDataGridViewTextBoxColumn
            // 
            this.юридеческийадресDataGridViewTextBoxColumn.DataPropertyName = "Юридеческий_адрес";
            this.юридеческийадресDataGridViewTextBoxColumn.HeaderText = "Юридеческий_адрес";
            this.юридеческийадресDataGridViewTextBoxColumn.Name = "юридеческийадресDataGridViewTextBoxColumn";
            // 
            // количествопоставокDataGridViewTextBoxColumn
            // 
            this.количествопоставокDataGridViewTextBoxColumn.DataPropertyName = "Количество_поставок";
            this.количествопоставокDataGridViewTextBoxColumn.HeaderText = "Количество_поставок";
            this.количествопоставокDataGridViewTextBoxColumn.Name = "количествопоставокDataGridViewTextBoxColumn";
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoGenerateColumns = false;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDтовараDataGridViewTextBoxColumn1,
            this.типтовараDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.характеристикаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn1,
            this.количествоDataGridViewTextBoxColumn,
            this.гаранстиямесDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn});
            this.dataGridView4.DataSource = this.товарBindingSource;
            this.dataGridView4.Location = new System.Drawing.Point(433, 295);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(113, 25);
            this.dataGridView4.TabIndex = 3;
            // 
            // iDтовараDataGridViewTextBoxColumn1
            // 
            this.iDтовараDataGridViewTextBoxColumn1.DataPropertyName = "ID_товара";
            this.iDтовараDataGridViewTextBoxColumn1.HeaderText = "ID_товара";
            this.iDтовараDataGridViewTextBoxColumn1.Name = "iDтовараDataGridViewTextBoxColumn1";
            // 
            // типтовараDataGridViewTextBoxColumn
            // 
            this.типтовараDataGridViewTextBoxColumn.DataPropertyName = "Тип_товара";
            this.типтовараDataGridViewTextBoxColumn.HeaderText = "Тип_товара";
            this.типтовараDataGridViewTextBoxColumn.Name = "типтовараDataGridViewTextBoxColumn";
            // 
            // производительDataGridViewTextBoxColumn
            // 
            this.производительDataGridViewTextBoxColumn.DataPropertyName = "Производитель";
            this.производительDataGridViewTextBoxColumn.HeaderText = "Производитель";
            this.производительDataGridViewTextBoxColumn.Name = "производительDataGridViewTextBoxColumn";
            // 
            // модельDataGridViewTextBoxColumn
            // 
            this.модельDataGridViewTextBoxColumn.DataPropertyName = "Модель";
            this.модельDataGridViewTextBoxColumn.HeaderText = "Модель";
            this.модельDataGridViewTextBoxColumn.Name = "модельDataGridViewTextBoxColumn";
            // 
            // характеристикаDataGridViewTextBoxColumn
            // 
            this.характеристикаDataGridViewTextBoxColumn.DataPropertyName = "Характеристика";
            this.характеристикаDataGridViewTextBoxColumn.HeaderText = "Характеристика";
            this.характеристикаDataGridViewTextBoxColumn.Name = "характеристикаDataGridViewTextBoxColumn";
            // 
            // ценаDataGridViewTextBoxColumn1
            // 
            this.ценаDataGridViewTextBoxColumn1.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn1.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn1.Name = "ценаDataGridViewTextBoxColumn1";
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // гаранстиямесDataGridViewTextBoxColumn
            // 
            this.гаранстиямесDataGridViewTextBoxColumn.DataPropertyName = "Гаранстия_(мес)";
            this.гаранстиямесDataGridViewTextBoxColumn.HeaderText = "Гаранстия_(мес)";
            this.гаранстиямесDataGridViewTextBoxColumn.Name = "гаранстиямесDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // поставкиTableAdapter
            // 
            this.поставкиTableAdapter.ClearBeforeFill = true;
            // 
            // поступивший_товарTableAdapter
            // 
            this.поступивший_товарTableAdapter.ClearBeforeFill = true;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСПоставкамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСПоставкамиToolStripMenuItem
            // 
            this.работаСПоставкамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.заказатьПоставкуToolStripMenuItem});
            this.работаСПоставкамиToolStripMenuItem.Name = "работаСПоставкамиToolStripMenuItem";
            this.работаСПоставкамиToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.работаСПоставкамиToolStripMenuItem.Text = "Работа с поставками";
            // 
            // заказатьПоставкуToolStripMenuItem
            // 
            this.заказатьПоставкуToolStripMenuItem.Name = "заказатьПоставкуToolStripMenuItem";
            this.заказатьПоставкуToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.заказатьПоставкуToolStripMenuItem.Text = "Заказать поставку";
            this.заказатьПоставкуToolStripMenuItem.Click += new System.EventHandler(this.заказатьПоставкуToolStripMenuItem_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // этапзаказаBindingSource
            // 
            this.этапзаказаBindingSource.DataMember = "Этап_заказа";
            this.этапзаказаBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // этап_заказаTableAdapter
            // 
            this.этап_заказаTableAdapter.ClearBeforeFill = true;
            // 
            // Form_vendor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 421);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_vendor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню поставок";
            this.Load += new System.EventHandler(this.Form_vendor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставкиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поступившийтоварBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.этапзаказаBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private Учет_товаровDataSet учет_товаровDataSet;
        private System.Windows.Forms.BindingSource поставкиBindingSource;
        private Учет_товаровDataSetTableAdapters.ПоставкиTableAdapter поставкиTableAdapter;
        private System.Windows.Forms.BindingSource поступившийтоварBindingSource;
        private Учет_товаровDataSetTableAdapters.Поступивший_товарTableAdapter поступивший_товарTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Учет_товаровDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn юридеческийадресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествопоставокDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private Учет_товаровDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDтовараDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn типтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характеристикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гаранстиямесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСПоставкамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem заказатьПоставкуToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewComboBoxColumn iDтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource товарBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставкиDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn колиествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource этапзаказаBindingSource;
        private Учет_товаровDataSetTableAdapters.Этап_заказаTableAdapter этап_заказаTableAdapter;
        private System.Windows.Forms.BindingSource поставщикиBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn поставщикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этапDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn суммаDataGridViewTextBoxColumn;
    }
}