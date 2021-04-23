namespace Cocing_Maneger
{
    partial class TeacherSalary
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.table4BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.teachersalaryDataSet1 = new Cocing_Maneger.teachersalaryDataSet();
            this.btnadd = new System.Windows.Forms.Button();
            this.btmshow = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.labtotal = new System.Windows.Forms.Label();
            this.teachersalaryDataSet = new Cocing_Maneger.teachersalaryDataSet();
            this.teachersalaryDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table4BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.table4TableAdapter = new Cocing_Maneger.teachersalaryDataSetTableAdapters.Table4TableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersalaryDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersalaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersalaryDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(591, 297);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(432, 34);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(591, 384);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(432, 34);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(489, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(489, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Salary";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.salaryDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.table4BindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(235, 517);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1307, 347);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // salaryDataGridViewTextBoxColumn
            // 
            this.salaryDataGridViewTextBoxColumn.DataPropertyName = "Salary";
            this.salaryDataGridViewTextBoxColumn.HeaderText = "Salary";
            this.salaryDataGridViewTextBoxColumn.Name = "salaryDataGridViewTextBoxColumn";
            // 
            // table4BindingSource1
            // 
            this.table4BindingSource1.DataMember = "Table4";
            this.table4BindingSource1.DataSource = this.teachersalaryDataSet1;
            // 
            // teachersalaryDataSet1
            // 
            this.teachersalaryDataSet1.DataSetName = "teachersalaryDataSet";
            this.teachersalaryDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(591, 453);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(100, 28);
            this.btnadd.TabIndex = 5;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btmshow
            // 
            this.btmshow.Location = new System.Drawing.Point(757, 453);
            this.btmshow.Margin = new System.Windows.Forms.Padding(4);
            this.btmshow.Name = "btmshow";
            this.btmshow.Size = new System.Drawing.Size(100, 28);
            this.btmshow.TabIndex = 6;
            this.btmshow.Text = "Show";
            this.btmshow.UseVisualStyleBackColor = true;
            this.btmshow.Click += new System.EventHandler(this.btmshow_Click);
            // 
            // btnsum
            // 
            this.btnsum.Location = new System.Drawing.Point(924, 453);
            this.btnsum.Margin = new System.Windows.Forms.Padding(4);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(100, 28);
            this.btnsum.TabIndex = 7;
            this.btnsum.Text = "Total Salary";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // labtotal
            // 
            this.labtotal.AutoSize = true;
            this.labtotal.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtotal.Location = new System.Drawing.Point(1180, 454);
            this.labtotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labtotal.Name = "labtotal";
            this.labtotal.Size = new System.Drawing.Size(0, 27);
            this.labtotal.TabIndex = 8;
            // 
            // teachersalaryDataSet
            // 
            this.teachersalaryDataSet.DataSetName = "teachersalaryDataSet";
            this.teachersalaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // teachersalaryDataSetBindingSource
            // 
            this.teachersalaryDataSetBindingSource.DataSource = this.teachersalaryDataSet;
            this.teachersalaryDataSetBindingSource.Position = 0;
            // 
            // table4BindingSource
            // 
            this.table4BindingSource.DataMember = "Table4";
            this.table4BindingSource.DataSource = this.teachersalaryDataSetBindingSource;
            // 
            // table4TableAdapter
            // 
            this.table4TableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1096, 454);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 9;
            this.label3.Text = "Total :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1, 0);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(559, 11);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(365, 68);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sallery Table";
            // 
            // TeacherSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumAquamarine;
            this.ClientSize = new System.Drawing.Size(1800, 897);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labtotal);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btmshow);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TeacherSalary";
            this.Text = "TeacherSalary";
            this.Load += new System.EventHandler(this.TeacherSalary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersalaryDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersalaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teachersalaryDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table4BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btmshow;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Label labtotal;
        private System.Windows.Forms.BindingSource teachersalaryDataSetBindingSource;
        private teachersalaryDataSet teachersalaryDataSet;
        private System.Windows.Forms.BindingSource table4BindingSource;
        private teachersalaryDataSetTableAdapters.Table4TableAdapter table4TableAdapter;
        private teachersalaryDataSet teachersalaryDataSet1;
        private System.Windows.Forms.BindingSource table4BindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
    }
}