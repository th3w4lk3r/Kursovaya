namespace Курсовая1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button_enter = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDменеджераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доступDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.доступBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.учет_товаровDataSet = new Курсовая1.Учет_товаровDataSet();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_pass = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.label_pass = new System.Windows.Forms.Label();
            this.доступTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ДоступTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // button_enter
            // 
            this.button_enter.Location = new System.Drawing.Point(44, 86);
            this.button_enter.Name = "button_enter";
            this.button_enter.Size = new System.Drawing.Size(75, 23);
            this.button_enter.TabIndex = 0;
            this.button_enter.Text = "Войти";
            this.button_enter.UseVisualStyleBackColor = true;
            this.button_enter.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDменеджераDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.доступDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.доступBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(47, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(53, 17);
            this.dataGridView1.TabIndex = 1;
            // 
            // iDменеджераDataGridViewTextBoxColumn
            // 
            this.iDменеджераDataGridViewTextBoxColumn.DataPropertyName = "ID_менеджера";
            this.iDменеджераDataGridViewTextBoxColumn.HeaderText = "ID_менеджера";
            this.iDменеджераDataGridViewTextBoxColumn.Name = "iDменеджераDataGridViewTextBoxColumn";
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
            // учет_товаровDataSet
            // 
            this.учет_товаровDataSet.DataSetName = "Учет_товаровDataSet";
            this.учет_товаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textBox_login
            // 
            this.textBox_login.Location = new System.Drawing.Point(98, 31);
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(100, 20);
            this.textBox_login.TabIndex = 2;
            // 
            // textBox_pass
            // 
            this.textBox_pass.Location = new System.Drawing.Point(98, 60);
            this.textBox_pass.Name = "textBox_pass";
            this.textBox_pass.Size = new System.Drawing.Size(100, 20);
            this.textBox_pass.TabIndex = 3;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(44, 34);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(41, 13);
            this.label_login.TabIndex = 4;
            this.label_login.Text = "Логин:";
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(44, 63);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(48, 13);
            this.label_pass.TabIndex = 5;
            this.label_pass.Text = "Пароль:";
            // 
            // доступTableAdapter
            // 
            this.доступTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 129);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.textBox_pass);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_enter);
            this.Name = "Form1";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.доступBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_enter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_pass;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_pass;
        private Учет_товаровDataSet учет_товаровDataSet;
        private System.Windows.Forms.BindingSource доступBindingSource;
        private Учет_товаровDataSetTableAdapters.ДоступTableAdapter доступTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDменеджераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn доступDataGridViewTextBoxColumn;
    }
}

