namespace Practika
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.списокЗакаховBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.списокЗакаховBindingSource = new System.Windows.Forms.BindingSource(this.components);
             this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.списокЗакаховBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.списокЗакаховBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.iDЗаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDАгенстваDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDПутевкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.выборDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database411DataSet3 = new Practika.Database411DataSet3();
            this.списокЗакаховBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.список_закаховTableAdapter1 = new Practika.Database411DataSet3TableAdapters.Список_закаховTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource1)).BeginInit();
        
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(885, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(348, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Существующие заказы";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
                      // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDЗаказаDataGridViewTextBoxColumn,
            this.iDАгенстваDataGridViewTextBoxColumn,
            this.iDПутевкиDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn,
            this.выборDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокЗакаховBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(167, 200);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(664, 150);
            this.dataGridView1.TabIndex = 2;
           
            // 
            // iDЗаказаDataGridViewTextBoxColumn
            // 
            this.iDЗаказаDataGridViewTextBoxColumn.DataPropertyName = "ID Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.HeaderText = "ID Заказа";
            this.iDЗаказаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDЗаказаDataGridViewTextBoxColumn.Name = "iDЗаказаDataGridViewTextBoxColumn";
            this.iDЗаказаDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDАгенстваDataGridViewTextBoxColumn
            // 
            this.iDАгенстваDataGridViewTextBoxColumn.DataPropertyName = "ID Агенства";
            this.iDАгенстваDataGridViewTextBoxColumn.HeaderText = "ID Агенства";
            this.iDАгенстваDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDАгенстваDataGridViewTextBoxColumn.Name = "iDАгенстваDataGridViewTextBoxColumn";
            this.iDАгенстваDataGridViewTextBoxColumn.Width = 125;
            // 
            // iDПутевкиDataGridViewTextBoxColumn
            // 
            this.iDПутевкиDataGridViewTextBoxColumn.DataPropertyName = "ID Путевки";
            this.iDПутевкиDataGridViewTextBoxColumn.HeaderText = "ID Путевки";
            this.iDПутевкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПутевкиDataGridViewTextBoxColumn.Name = "iDПутевкиDataGridViewTextBoxColumn";
            this.iDПутевкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            this.количествоDataGridViewTextBoxColumn.Width = 125;
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            this.статусDataGridViewTextBoxColumn.Width = 125;
            // 
            // выборDataGridViewTextBoxColumn
            // 
            this.выборDataGridViewTextBoxColumn.DataPropertyName = "Выбор";
            this.выборDataGridViewTextBoxColumn.HeaderText = "Выбор";
            this.выборDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.выборDataGridViewTextBoxColumn.Name = "выборDataGridViewTextBoxColumn";
            this.выборDataGridViewTextBoxColumn.Width = 125;
            // 
            // database411DataSet3
            // 
            this.database411DataSet3.DataSetName = "Database411DataSet3";
            this.database411DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокЗакаховBindingSource4
            // 
            this.списокЗакаховBindingSource4.DataMember = "Список закахов";
            this.списокЗакаховBindingSource4.DataSource = this.database411DataSet3;
            // 
            // список_закаховTableAdapter1
            // 
            this.список_закаховTableAdapter1.ClearBeforeFill = true;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 577);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "Существующие заказы";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокЗакаховBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
       
        private System.Windows.Forms.BindingSource списокЗакаховBindingSource1;
        private System.Windows.Forms.BindingSource списокЗакаховBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource списокЗакаховBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDЗаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDАгенстваDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПутевкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выборDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource списокЗакаховBindingSource3;
        private Database411DataSet3 database411DataSet3;
        private System.Windows.Forms.BindingSource списокЗакаховBindingSource4;
        private Database411DataSet3TableAdapters.Список_закаховTableAdapter список_закаховTableAdapter1;
    }
}