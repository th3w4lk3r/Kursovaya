namespace Курсовая1
{
    partial class Form_item
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
            this.iDтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типтовараDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.типтовараBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_товаровDataSet = new Курсовая1.Учет_товаровDataSet();
            this.производительDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.модельDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.характеристикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.гаранстиямесDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.товарBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.товарTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ТоварTableAdapter();
            this.button_view_item = new System.Windows.Forms.Button();
            this.тип_товараTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.Тип_товараTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСТоварамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьТоварToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.изменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.типтовараBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDтовараDataGridViewTextBoxColumn,
            this.типтовараDataGridViewTextBoxColumn,
            this.производительDataGridViewTextBoxColumn,
            this.модельDataGridViewTextBoxColumn,
            this.характеристикаDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.гаранстиямесDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.товарBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(692, 238);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDтовараDataGridViewTextBoxColumn
            // 
            this.iDтовараDataGridViewTextBoxColumn.DataPropertyName = "ID_товара";
            this.iDтовараDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDтовараDataGridViewTextBoxColumn.Name = "iDтовараDataGridViewTextBoxColumn";
            this.iDтовараDataGridViewTextBoxColumn.Width = 30;
            // 
            // типтовараDataGridViewTextBoxColumn
            // 
            this.типтовараDataGridViewTextBoxColumn.DataPropertyName = "Тип_товара";
            this.типтовараDataGridViewTextBoxColumn.DataSource = this.типтовараBindingSource;
            this.типтовараDataGridViewTextBoxColumn.DisplayMember = "Название";
            this.типтовараDataGridViewTextBoxColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.типтовараDataGridViewTextBoxColumn.HeaderText = "Тип товара";
            this.типтовараDataGridViewTextBoxColumn.Name = "типтовараDataGridViewTextBoxColumn";
            this.типтовараDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.типтовараDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.типтовараDataGridViewTextBoxColumn.ValueMember = "ID";
            // 
            // типтовараBindingSource
            // 
            this.типтовараBindingSource.DataMember = "Тип_товара";
            this.типтовараBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // учет_товаровDataSet
            // 
            this.учет_товаровDataSet.DataSetName = "Учет_товаровDataSet";
            this.учет_товаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
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
            this.гаранстиямесDataGridViewTextBoxColumn.Visible = false;
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            this.фотоDataGridViewImageColumn.Visible = false;
            // 
            // товарBindingSource
            // 
            this.товарBindingSource.DataMember = "Товар";
            this.товарBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // товарTableAdapter
            // 
            this.товарTableAdapter.ClearBeforeFill = true;
            // 
            // button_view_item
            // 
            this.button_view_item.Location = new System.Drawing.Point(562, 271);
            this.button_view_item.Name = "button_view_item";
            this.button_view_item.Size = new System.Drawing.Size(143, 23);
            this.button_view_item.TabIndex = 2;
            this.button_view_item.Text = "Просмотреть";
            this.button_view_item.UseVisualStyleBackColor = true;
            this.button_view_item.Click += new System.EventHandler(this.button_view_item_Click);
            // 
            // тип_товараTableAdapter
            // 
            this.тип_товараTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСТоварамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(717, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСТоварамиToolStripMenuItem
            // 
            this.работаСТоварамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьТоварToolStripMenuItem,
            this.изменитьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.работаСТоварамиToolStripMenuItem.Name = "работаСТоварамиToolStripMenuItem";
            this.работаСТоварамиToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.работаСТоварамиToolStripMenuItem.Text = "Работа с товарами";
            // 
            // добавитьТоварToolStripMenuItem
            // 
            this.добавитьТоварToolStripMenuItem.Name = "добавитьТоварToolStripMenuItem";
            this.добавитьТоварToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.добавитьТоварToolStripMenuItem.Text = "Добавить";
            this.добавитьТоварToolStripMenuItem.Click += new System.EventHandler(this.добавитьТоварToolStripMenuItem_Click);
            // 
            // изменитьToolStripMenuItem
            // 
            this.изменитьToolStripMenuItem.Name = "изменитьToolStripMenuItem";
            this.изменитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.изменитьToolStripMenuItem.Text = "Изменить";
            this.изменитьToolStripMenuItem.Click += new System.EventHandler(this.изменитьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // Form_item
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 334);
            this.Controls.Add(this.button_view_item);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_item";
            this.Text = "Товары";
            this.Load += new System.EventHandler(this.Form_item_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.типтовараBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.товарBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Учет_товаровDataSet учет_товаровDataSet;
        private System.Windows.Forms.BindingSource товарBindingSource;
        private Учет_товаровDataSetTableAdapters.ТоварTableAdapter товарTableAdapter;
        private System.Windows.Forms.Button button_view_item;
        private System.Windows.Forms.BindingSource типтовараBindingSource;
        private Учет_товаровDataSetTableAdapters.Тип_товараTableAdapter тип_товараTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn типтовараDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn производительDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn модельDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn характеристикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn гаранстиямесDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСТоварамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьТоварToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem изменитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
    }
}