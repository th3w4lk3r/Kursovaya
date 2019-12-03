namespace Курсовая1
{
    partial class Form_vendors
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
            this.учет_товаровDataSet = new Курсовая1.Учет_товаровDataSet();
            this.поставщикиBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.поставщикиTableAdapter = new Курсовая1.Учет_товаровDataSetTableAdapters.ПоставщикиTableAdapter();
            this.iDпоставщикаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.юридеческийадресDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествопоставокDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDпоставщикаDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.юридеческийадресDataGridViewTextBoxColumn,
            this.количествопоставокDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.поставщикиBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(677, 300);
            this.dataGridView1.TabIndex = 0;
            // 
            // учет_товаровDataSet
            // 
            this.учет_товаровDataSet.DataSetName = "Учет_товаровDataSet";
            this.учет_товаровDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // поставщикиBindingSource
            // 
            this.поставщикиBindingSource.DataMember = "Поставщики";
            this.поставщикиBindingSource.DataSource = this.учет_товаровDataSet;
            // 
            // поставщикиTableAdapter
            // 
            this.поставщикиTableAdapter.ClearBeforeFill = true;
            // 
            // iDпоставщикаDataGridViewTextBoxColumn
            // 
            this.iDпоставщикаDataGridViewTextBoxColumn.DataPropertyName = "ID_поставщика";
            this.iDпоставщикаDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDпоставщикаDataGridViewTextBoxColumn.Name = "iDпоставщикаDataGridViewTextBoxColumn";
            this.iDпоставщикаDataGridViewTextBoxColumn.Width = 30;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 200;
            // 
            // юридеческийадресDataGridViewTextBoxColumn
            // 
            this.юридеческийадресDataGridViewTextBoxColumn.DataPropertyName = "Юридеческий_адрес";
            this.юридеческийадресDataGridViewTextBoxColumn.HeaderText = "Юридеческий адрес";
            this.юридеческийадресDataGridViewTextBoxColumn.Name = "юридеческийадресDataGridViewTextBoxColumn";
            this.юридеческийадресDataGridViewTextBoxColumn.Width = 250;
            // 
            // количествопоставокDataGridViewTextBoxColumn
            // 
            this.количествопоставокDataGridViewTextBoxColumn.DataPropertyName = "Количество_поставок";
            this.количествопоставокDataGridViewTextBoxColumn.HeaderText = "Количество поставок";
            this.количествопоставокDataGridViewTextBoxColumn.Name = "количествопоставокDataGridViewTextBoxColumn";
            this.количествопоставокDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_vendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 370);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form_vendors";
            this.Text = "Поставщики";
            this.Load += new System.EventHandler(this.Form_vendors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.учет_товаровDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.поставщикиBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Учет_товаровDataSet учет_товаровDataSet;
        private System.Windows.Forms.BindingSource поставщикиBindingSource;
        private Учет_товаровDataSetTableAdapters.ПоставщикиTableAdapter поставщикиTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDпоставщикаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn юридеческийадресDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествопоставокDataGridViewTextBoxColumn;
    }
}