namespace Курсовая1
{
    partial class Form_manager
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
            this.iDменеджераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.отчествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номертелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датарожденияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.серияпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерпаспортаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.кемвыданDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.принятDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.уволенDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фотоDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.менеджерBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_товаровDataSet = new Курсовая1.Учет_товаровDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.менеджерTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.МенеджерTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаСМенеджерамиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDменеджераDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доступDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доступBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.доступTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ДоступTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDменеджераDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.отчествоDataGridViewTextBoxColumn,
            this.номертелефонаDataGridViewTextBoxColumn,
            this.датарожденияDataGridViewTextBoxColumn,
            this.серияпаспортаDataGridViewTextBoxColumn,
            this.номерпаспортаDataGridViewTextBoxColumn,
            this.кемвыданDataGridViewTextBoxColumn,
            this.принятDataGridViewTextBoxColumn,
            this.уволенDataGridViewTextBoxColumn,
            this.фотоDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.менеджерBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(694, 244);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDменеджераDataGridViewTextBoxColumn
            // 
            this.iDменеджераDataGridViewTextBoxColumn.DataPropertyName = "ID_менеджера";
            this.iDменеджераDataGridViewTextBoxColumn.HeaderText = "ID ";
            this.iDменеджераDataGridViewTextBoxColumn.Name = "iDменеджераDataGridViewTextBoxColumn";
            this.iDменеджераDataGridViewTextBoxColumn.Width = 30;
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // отчествоDataGridViewTextBoxColumn
            // 
            this.отчествоDataGridViewTextBoxColumn.DataPropertyName = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.отчествоDataGridViewTextBoxColumn.Name = "отчествоDataGridViewTextBoxColumn";
            // 
            // номертелефонаDataGridViewTextBoxColumn
            // 
            this.номертелефонаDataGridViewTextBoxColumn.DataPropertyName = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.HeaderText = "Номер_телефона";
            this.номертелефонаDataGridViewTextBoxColumn.Name = "номертелефонаDataGridViewTextBoxColumn";
            this.номертелефонаDataGridViewTextBoxColumn.Visible = false;
            // 
            // датарожденияDataGridViewTextBoxColumn
            // 
            this.датарожденияDataGridViewTextBoxColumn.DataPropertyName = "Дата_рождения";
            this.датарожденияDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.датарожденияDataGridViewTextBoxColumn.Name = "датарожденияDataGridViewTextBoxColumn";
            this.датарожденияDataGridViewTextBoxColumn.Width = 120;
            // 
            // серияпаспортаDataGridViewTextBoxColumn
            // 
            this.серияпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Серия_паспорта";
            this.серияпаспортаDataGridViewTextBoxColumn.HeaderText = "Серия_паспорта";
            this.серияпаспортаDataGridViewTextBoxColumn.Name = "серияпаспортаDataGridViewTextBoxColumn";
            this.серияпаспортаDataGridViewTextBoxColumn.Visible = false;
            // 
            // номерпаспортаDataGridViewTextBoxColumn
            // 
            this.номерпаспортаDataGridViewTextBoxColumn.DataPropertyName = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.HeaderText = "Номер_паспорта";
            this.номерпаспортаDataGridViewTextBoxColumn.Name = "номерпаспортаDataGridViewTextBoxColumn";
            this.номерпаспортаDataGridViewTextBoxColumn.Visible = false;
            // 
            // кемвыданDataGridViewTextBoxColumn
            // 
            this.кемвыданDataGridViewTextBoxColumn.DataPropertyName = "Кем_выдан";
            this.кемвыданDataGridViewTextBoxColumn.HeaderText = "Кем_выдан";
            this.кемвыданDataGridViewTextBoxColumn.Name = "кемвыданDataGridViewTextBoxColumn";
            this.кемвыданDataGridViewTextBoxColumn.Visible = false;
            // 
            // принятDataGridViewTextBoxColumn
            // 
            this.принятDataGridViewTextBoxColumn.DataPropertyName = "Принят";
            this.принятDataGridViewTextBoxColumn.HeaderText = "Принят";
            this.принятDataGridViewTextBoxColumn.Name = "принятDataGridViewTextBoxColumn";
            // 
            // уволенDataGridViewTextBoxColumn
            // 
            this.уволенDataGridViewTextBoxColumn.DataPropertyName = "Уволен";
            this.уволенDataGridViewTextBoxColumn.HeaderText = "Уволен";
            this.уволенDataGridViewTextBoxColumn.Name = "уволенDataGridViewTextBoxColumn";
            // 
            // фотоDataGridViewImageColumn
            // 
            this.фотоDataGridViewImageColumn.DataPropertyName = "Фото";
            this.фотоDataGridViewImageColumn.HeaderText = "Фото";
            this.фотоDataGridViewImageColumn.Name = "фотоDataGridViewImageColumn";
            this.фотоDataGridViewImageColumn.Visible = false;
            // 
            // менеджерBindingSource
            // 
            this.менеджерBindingSource.DataMember = "Менеджер";
            this.менеджерBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // учет_товаровDataSet
            // 
            this.учет_товаровDataSet.DataSetName = "Учет_товаровDataSet";
            this.учет_товаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(578, 283);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Просмотр";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // менеджерTableAdapter
            // 
            this.менеджерTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаСМенеджерамиToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(714, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаСМенеджерамиToolStripMenuItem
            // 
            this.работаСМенеджерамиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьToolStripMenuItem,
            this.редактироватьToolStripMenuItem,
            this.удалитьToolStripMenuItem});
            this.работаСМенеджерамиToolStripMenuItem.Name = "работаСМенеджерамиToolStripMenuItem";
            this.работаСМенеджерамиToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.работаСМенеджерамиToolStripMenuItem.Text = "Работа с менеджерами";
            // 
            // добавитьToolStripMenuItem
            // 
            this.добавитьToolStripMenuItem.Name = "добавитьToolStripMenuItem";
            this.добавитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.добавитьToolStripMenuItem.Text = "Добавить";
            this.добавитьToolStripMenuItem.Click += new System.EventHandler(this.добавитьToolStripMenuItem_Click);
            // 
            // редактироватьToolStripMenuItem
            // 
            this.редактироватьToolStripMenuItem.Name = "редактироватьToolStripMenuItem";
            this.редактироватьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.редактироватьToolStripMenuItem.Text = "Редактировать";
            this.редактироватьToolStripMenuItem.Click += new System.EventHandler(this.редактироватьToolStripMenuItem_Click);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDменеджераDataGridViewTextBoxColumn1,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.доступDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.доступBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 283);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(240, 23);
            this.dataGridView2.TabIndex = 3;
            // 
            // iDменеджераDataGridViewTextBoxColumn1
            // 
            this.iDменеджераDataGridViewTextBoxColumn1.DataPropertyName = "ID_менеджера";
            this.iDменеджераDataGridViewTextBoxColumn1.HeaderText = "ID_менеджера";
            this.iDменеджераDataGridViewTextBoxColumn1.Name = "iDменеджераDataGridViewTextBoxColumn1";
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "Login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // доступDataGridViewTextBoxColumn
            // 
            this.доступDataGridViewTextBoxColumn.DataPropertyName = "Доступ";
            this.доступDataGridViewTextBoxColumn.HeaderText = "Доступ";
            this.доступDataGridViewTextBoxColumn.Name = "доступDataGridViewTextBoxColumn";
            // 
            // доступBindingSource
            // 
            this.доступBindingSource.DataMember = "Доступ";
            this.доступBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // доступTableAdapter
            // 
            this.доступTableAdapter.ClearBeforeFill = true;
            // 
            // Form_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 334);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_manager";
            this.Text = "Просмотр менеджеров";
            this.Load += new System.EventHandler(this.Form_manager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.менеджерBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private Учет_товаровDataSet учет_товаровDataSet;
        private System.Windows.Forms.BindingSource менеджерBindingSource;
        private Учет_товаровDataSetTableAdapters.МенеджерTableAdapter менеджерTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDменеджераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn отчествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номертелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датарожденияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn серияпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерпаспортаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn кемвыданDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn принятDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn уволенDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn фотоDataGridViewImageColumn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаСМенеджерамиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem добавитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem удалитьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource доступBindingSource;
        private Учет_товаровDataSetTableAdapters.ДоступTableAdapter доступTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDменеджераDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доступDataGridViewTextBoxColumn;
    }
}