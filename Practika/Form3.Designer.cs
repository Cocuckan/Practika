namespace Practika
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.списокПутевокBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database411DataSet = new Practika.Database411DataSet();
            this.список_путевокTableAdapter = new Practika.Database411DataSetTableAdapters.Список_путевокTableAdapter();
            this.database411DataSet2 = new Practika.Database411DataSet2();
            this.списокПутевокBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.список_путевокTableAdapter1 = new Practika.Database411DataSet2TableAdapters.Список_путевокTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDПутевкиDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.названиеDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаНачалаокончанияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количестваМестDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.темаСменыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.списокПутевокBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.database411DataSet21 = new Practika.Database411DataSet2();
            this.списокПутевокBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(882, 12);
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
            this.label1.Location = new System.Drawing.Point(385, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Список путевок";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(364, 450);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 52);
            this.button2.TabIndex = 2;
            this.button2.Text = "Создать заказ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // списокПутевокBindingSource
            // 
            this.списокПутевокBindingSource.DataMember = "Список путевок";
            this.списокПутевокBindingSource.DataSource = this.database411DataSet;
            // 
            // database411DataSet
            // 
            this.database411DataSet.DataSetName = "Database411DataSet";
            this.database411DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // список_путевокTableAdapter
            // 
            this.список_путевокTableAdapter.ClearBeforeFill = true;
            // 
            // database411DataSet2
            // 
            this.database411DataSet2.DataSetName = "Database411DataSet2";
            this.database411DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокПутевокBindingSource1
            // 
            this.списокПутевокBindingSource1.DataMember = "Список путевок";
            this.списокПутевокBindingSource1.DataSource = this.database411DataSet2;
            // 
            // список_путевокTableAdapter1
            // 
            this.список_путевокTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDПутевкиDataGridViewTextBoxColumn,
            this.названиеDataGridViewTextBoxColumn,
            this.датаНачалаокончанияDataGridViewTextBoxColumn,
            this.количестваМестDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.темаСменыDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.списокПутевокBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(49, 169);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(871, 232);
            this.dataGridView1.TabIndex = 3;
            // 
            // iDПутевкиDataGridViewTextBoxColumn
            // 
            this.iDПутевкиDataGridViewTextBoxColumn.DataPropertyName = "ID Путевки";
            this.iDПутевкиDataGridViewTextBoxColumn.HeaderText = "ID Путевки";
            this.iDПутевкиDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDПутевкиDataGridViewTextBoxColumn.Name = "iDПутевкиDataGridViewTextBoxColumn";
            this.iDПутевкиDataGridViewTextBoxColumn.Width = 125;
            // 
            // названиеDataGridViewTextBoxColumn
            // 
            this.названиеDataGridViewTextBoxColumn.DataPropertyName = "Название";
            this.названиеDataGridViewTextBoxColumn.HeaderText = "Название";
            this.названиеDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.названиеDataGridViewTextBoxColumn.Name = "названиеDataGridViewTextBoxColumn";
            this.названиеDataGridViewTextBoxColumn.Width = 200;
            // 
            // датаНачалаокончанияDataGridViewTextBoxColumn
            // 
            this.датаНачалаокончанияDataGridViewTextBoxColumn.DataPropertyName = "Дата начала/окончания";
            this.датаНачалаокончанияDataGridViewTextBoxColumn.HeaderText = "Дата начала/окончания";
            this.датаНачалаокончанияDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.датаНачалаокончанияDataGridViewTextBoxColumn.Name = "датаНачалаокончанияDataGridViewTextBoxColumn";
            this.датаНачалаокончанияDataGridViewTextBoxColumn.Width = 150;
            // 
            // количестваМестDataGridViewTextBoxColumn
            // 
            this.количестваМестDataGridViewTextBoxColumn.DataPropertyName = "Количества мест";
            this.количестваМестDataGridViewTextBoxColumn.HeaderText = "Количества мест";
            this.количестваМестDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.количестваМестDataGridViewTextBoxColumn.Name = "количестваМестDataGridViewTextBoxColumn";
            this.количестваМестDataGridViewTextBoxColumn.Width = 125;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "Цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "Цена";
            this.ценаDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            this.ценаDataGridViewTextBoxColumn.Width = 115;
            // 
            // темаСменыDataGridViewTextBoxColumn
            // 
            this.темаСменыDataGridViewTextBoxColumn.DataPropertyName = "Тема смены";
            this.темаСменыDataGridViewTextBoxColumn.HeaderText = "Тема смены";
            this.темаСменыDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.темаСменыDataGridViewTextBoxColumn.Name = "темаСменыDataGridViewTextBoxColumn";
            this.темаСменыDataGridViewTextBoxColumn.Width = 225;
            // 
            // списокПутевокBindingSource2
            // 
            this.списокПутевокBindingSource2.DataMember = "Список путевок";
            this.списокПутевокBindingSource2.DataSource = this.database411DataSet21;
            // 
            // database411DataSet21
            // 
            this.database411DataSet21.DataSetName = "Database411DataSet2";
            this.database411DataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // списокПутевокBindingSource3
            // 
            this.списокПутевокBindingSource3.DataMember = "Список путевок";
            this.списокПутевокBindingSource3.DataSource = this.database411DataSet2;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 517);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Список путевок";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database411DataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.списокПутевокBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private Database411DataSet database411DataSet;
        private System.Windows.Forms.BindingSource списокПутевокBindingSource;
        private Database411DataSetTableAdapters.Список_путевокTableAdapter список_путевокTableAdapter;
        private Database411DataSet2 database411DataSet2;
        private System.Windows.Forms.BindingSource списокПутевокBindingSource1;
        private Database411DataSet2TableAdapters.Список_путевокTableAdapter список_путевокTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Database411DataSet2 database411DataSet21;
        private System.Windows.Forms.BindingSource списокПутевокBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDПутевкиDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn названиеDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаНачалаокончанияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количестваМестDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn темаСменыDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource списокПутевокBindingSource3;
    }
}