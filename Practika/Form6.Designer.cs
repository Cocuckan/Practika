namespace Practika
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.database411DataSet1 = new Practika.Database411DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаСменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокПутевокBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.database411DataSet2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database411DataSet2 = new Practika.Database411DataSet2();
            this.списокПутевокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database411DataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database411DataSet1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.список_путевокTableAdapter = new Practika.Database411DataSetTableAdapters.Список_путевокTableAdapter();
            this.список_путевокTableAdapter1 = new Practika.Database411DataSet2TableAdapters.Список_путевокTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet1BindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(102, 477);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(291, 52);
            this.button2.TabIndex = 1;
            this.button2.Text = "Добавить/Удалить путевку";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.Location = new System.Drawing.Point(586, 477);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(291, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "Редактировать путевку";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(406, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Список путевок";
            // 
            // database411DataSet1
            // 
            this.database411DataSet1.DataSetName = "Database411DataSet";
            this.database411DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.темаСменыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокПутевокBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(40, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(912, 202);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID Путевки";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Путевки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Название";
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата начала/окончания";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата начала/окончания";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Количества мест";
            this.dataGridViewTextBoxColumn4.HeaderText = "Количества мест";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Цена";
            this.dataGridViewTextBoxColumn5.HeaderText = "Цена";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 115;
            // 
            // темаСменыDataGridViewTextBoxColumn
            // 
            this.темаСменыDataGridViewTextBoxColumn.DataPropertyName = "Тема смены";
            this.темаСменыDataGridViewTextBoxColumn.HeaderText = "Тема смены";
            this.темаСменыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.темаСменыDataGridViewTextBoxColumn.Name = "темаСменыDataGridViewTextBoxColumn";
            this.темаСменыDataGridViewTextBoxColumn.Width = 225;
            // 
            // списокПутевокBindingSource1
            // 
            this.списокПутевокBindingSource1.DataMember = "Список путевок";
            this.списокПутевокBindingSource1.DataSource = this.database411DataSet2BindingSource;
            // 
            // database411DataSet2BindingSource
            // 
            this.database411DataSet2BindingSource.DataSource = this.database411DataSet2;
            this.database411DataSet2BindingSource.Position = 0;
            // 
            // database411DataSet2
            // 
            this.database411DataSet2.DataSetName = "Database411DataSet2";
            this.database411DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокПутевокBindingSource
            // 
            this.списокПутевокBindingSource.DataMember = "Список путевок";
            this.списокПутевокBindingSource.DataSource = this.database411DataSet1;
            // 
            // database411DataSet1BindingSource
            // 
            this.database411DataSet1BindingSource.DataSource = this.database411DataSet1;
            this.database411DataSet1BindingSource.Position = 0;
            // 
            // database411DataSet1BindingSource1
            // 
            this.database411DataSet1BindingSource1.DataSource = this.database411DataSet1;
            this.database411DataSet1BindingSource1.Position = 0;
            // 
            // список_путевокTableAdapter
            // 
            this.список_путевокTableAdapter.ClearBeforeFill = true;
            // 
            // список_путевокTableAdapter1
            // 
            this.список_путевокTableAdapter1.ClearBeforeFill = true;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 602);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "Учет путевок";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet1BindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПутевкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количестваМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типДеятельностиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn выборDataGridViewTextBoxColumn;
        private Database411DataSet database411DataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource database411DataSet1BindingSource;
        private System.Windows.Forms.BindingSource database411DataSet1BindingSource1;
        private System.Windows.Forms.BindingSource списокПутевокBindingSource;
        private Database411DataSetTableAdapters.Список_путевокTableAdapter список_путевокTableAdapter;
        private System.Windows.Forms.BindingSource database411DataSet2BindingSource;
        private Database411DataSet2 database411DataSet2;
        private System.Windows.Forms.BindingSource списокПутевокBindingSource1;
        private Database411DataSet2TableAdapters.Список_путевокTableAdapter список_путевокTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаСменыDataGridViewTextBoxColumn;
        public System.Windows.Forms.Button button2;
    }
}