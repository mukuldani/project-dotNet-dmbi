namespace WindowsFormsApplication1
{
    partial class ViewStudentDetails
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
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectDataSet = new WindowsFormsApplication1.ProjectDataSet();
            this.studentTableAdapter = new WindowsFormsApplication1.ProjectDataSetTableAdapters.StudentTableAdapter();
            this.stuIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.snameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markshscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markssscDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marksgradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markssem1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markssem2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markssem3DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.markssem4DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livektDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deadktDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stuIdDataGridViewTextBoxColumn,
            this.snameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.markshscDataGridViewTextBoxColumn,
            this.markssscDataGridViewTextBoxColumn,
            this.marksgradDataGridViewTextBoxColumn,
            this.markssem1DataGridViewTextBoxColumn,
            this.markssem2DataGridViewTextBoxColumn,
            this.markssem3DataGridViewTextBoxColumn,
            this.markssem4DataGridViewTextBoxColumn,
            this.livektDataGridViewTextBoxColumn,
            this.deadktDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(883, 255);
            this.dataGridView1.TabIndex = 0;
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataMember = "Student";
            this.studentBindingSource.DataSource = this.projectDataSet;
            // 
            // projectDataSet
            // 
            this.projectDataSet.DataSetName = "ProjectDataSet";
            this.projectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentTableAdapter
            // 
            this.studentTableAdapter.ClearBeforeFill = true;
            // 
            // stuIdDataGridViewTextBoxColumn
            // 
            this.stuIdDataGridViewTextBoxColumn.DataPropertyName = "stuId";
            this.stuIdDataGridViewTextBoxColumn.HeaderText = "Student ID";
            this.stuIdDataGridViewTextBoxColumn.Name = "stuIdDataGridViewTextBoxColumn";
            this.stuIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.stuIdDataGridViewTextBoxColumn.Width = 60;
            // 
            // snameDataGridViewTextBoxColumn
            // 
            this.snameDataGridViewTextBoxColumn.DataPropertyName = "sname";
            this.snameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.snameDataGridViewTextBoxColumn.Name = "snameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email ID";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.Width = 80;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // markshscDataGridViewTextBoxColumn
            // 
            this.markshscDataGridViewTextBoxColumn.DataPropertyName = "marks_hsc";
            this.markshscDataGridViewTextBoxColumn.HeaderText = "HSC";
            this.markshscDataGridViewTextBoxColumn.Name = "markshscDataGridViewTextBoxColumn";
            this.markshscDataGridViewTextBoxColumn.Width = 40;
            // 
            // markssscDataGridViewTextBoxColumn
            // 
            this.markssscDataGridViewTextBoxColumn.DataPropertyName = "marks_ssc";
            this.markssscDataGridViewTextBoxColumn.HeaderText = "SSC";
            this.markssscDataGridViewTextBoxColumn.Name = "markssscDataGridViewTextBoxColumn";
            this.markssscDataGridViewTextBoxColumn.Width = 40;
            // 
            // marksgradDataGridViewTextBoxColumn
            // 
            this.marksgradDataGridViewTextBoxColumn.DataPropertyName = "marks_grad";
            this.marksgradDataGridViewTextBoxColumn.HeaderText = "Grad.";
            this.marksgradDataGridViewTextBoxColumn.Name = "marksgradDataGridViewTextBoxColumn";
            this.marksgradDataGridViewTextBoxColumn.Width = 40;
            // 
            // markssem1DataGridViewTextBoxColumn
            // 
            this.markssem1DataGridViewTextBoxColumn.DataPropertyName = "marks_sem1";
            this.markssem1DataGridViewTextBoxColumn.HeaderText = "Sem 1";
            this.markssem1DataGridViewTextBoxColumn.Name = "markssem1DataGridViewTextBoxColumn";
            this.markssem1DataGridViewTextBoxColumn.Width = 45;
            // 
            // markssem2DataGridViewTextBoxColumn
            // 
            this.markssem2DataGridViewTextBoxColumn.DataPropertyName = "marks_sem2";
            this.markssem2DataGridViewTextBoxColumn.HeaderText = "Sem 2";
            this.markssem2DataGridViewTextBoxColumn.Name = "markssem2DataGridViewTextBoxColumn";
            this.markssem2DataGridViewTextBoxColumn.Width = 45;
            // 
            // markssem3DataGridViewTextBoxColumn
            // 
            this.markssem3DataGridViewTextBoxColumn.DataPropertyName = "marks_sem3";
            this.markssem3DataGridViewTextBoxColumn.HeaderText = "Sem 3";
            this.markssem3DataGridViewTextBoxColumn.Name = "markssem3DataGridViewTextBoxColumn";
            this.markssem3DataGridViewTextBoxColumn.Width = 45;
            // 
            // markssem4DataGridViewTextBoxColumn
            // 
            this.markssem4DataGridViewTextBoxColumn.DataPropertyName = "marks_sem4";
            this.markssem4DataGridViewTextBoxColumn.HeaderText = "Sem 4";
            this.markssem4DataGridViewTextBoxColumn.Name = "markssem4DataGridViewTextBoxColumn";
            this.markssem4DataGridViewTextBoxColumn.Width = 45;
            // 
            // livektDataGridViewTextBoxColumn
            // 
            this.livektDataGridViewTextBoxColumn.DataPropertyName = "live_kt";
            this.livektDataGridViewTextBoxColumn.HeaderText = "Live KT";
            this.livektDataGridViewTextBoxColumn.Name = "livektDataGridViewTextBoxColumn";
            this.livektDataGridViewTextBoxColumn.Width = 45;
            // 
            // deadktDataGridViewTextBoxColumn
            // 
            this.deadktDataGridViewTextBoxColumn.DataPropertyName = "dead_kt";
            this.deadktDataGridViewTextBoxColumn.HeaderText = "Dead KT";
            this.deadktDataGridViewTextBoxColumn.Name = "deadktDataGridViewTextBoxColumn";
            this.deadktDataGridViewTextBoxColumn.Width = 45;
            // 
            // ViewStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 353);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewStudentDetails";
            this.Text = "ViewStudentDetails";
            this.Load += new System.EventHandler(this.ViewStudentDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDataSet projectDataSet;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private ProjectDataSetTableAdapters.StudentTableAdapter studentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn stuIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn snameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markshscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markssscDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn marksgradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markssem1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markssem2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markssem3DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn markssem4DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn livektDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadktDataGridViewTextBoxColumn;
    }
}