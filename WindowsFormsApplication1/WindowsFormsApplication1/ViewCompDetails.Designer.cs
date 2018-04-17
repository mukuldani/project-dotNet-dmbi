namespace WindowsFormsApplication1
{
    partial class ViewCompDetails
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
            this.projectDataSet1 = new WindowsFormsApplication1.ProjectDataSet1();
            this.compDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comp_DetailsTableAdapter = new WindowsFormsApplication1.ProjectDataSet1TableAdapters.Comp_DetailsTableAdapter();
            this.compidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compemailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.compphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hremailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hrphoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDetailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.compidDataGridViewTextBoxColumn,
            this.compnameDataGridViewTextBoxColumn,
            this.compaddDataGridViewTextBoxColumn,
            this.compemailDataGridViewTextBoxColumn,
            this.compphoneDataGridViewTextBoxColumn,
            this.hrnameDataGridViewTextBoxColumn,
            this.hremailDataGridViewTextBoxColumn,
            this.hrphoneDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.compDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 55);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(775, 268);
            this.dataGridView1.TabIndex = 0;
            // 
            // projectDataSet1
            // 
            this.projectDataSet1.DataSetName = "ProjectDataSet1";
            this.projectDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // compDetailsBindingSource
            // 
            this.compDetailsBindingSource.DataMember = "Comp_Details";
            this.compDetailsBindingSource.DataSource = this.projectDataSet1;
            // 
            // comp_DetailsTableAdapter
            // 
            this.comp_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // compidDataGridViewTextBoxColumn
            // 
            this.compidDataGridViewTextBoxColumn.DataPropertyName = "comp_id";
            this.compidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.compidDataGridViewTextBoxColumn.Name = "compidDataGridViewTextBoxColumn";
            this.compidDataGridViewTextBoxColumn.ReadOnly = true;
            this.compidDataGridViewTextBoxColumn.Width = 30;
            // 
            // compnameDataGridViewTextBoxColumn
            // 
            this.compnameDataGridViewTextBoxColumn.DataPropertyName = "comp_name";
            this.compnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.compnameDataGridViewTextBoxColumn.Name = "compnameDataGridViewTextBoxColumn";
            // 
            // compaddDataGridViewTextBoxColumn
            // 
            this.compaddDataGridViewTextBoxColumn.DataPropertyName = "comp_add";
            this.compaddDataGridViewTextBoxColumn.HeaderText = "Address";
            this.compaddDataGridViewTextBoxColumn.Name = "compaddDataGridViewTextBoxColumn";
            // 
            // compemailDataGridViewTextBoxColumn
            // 
            this.compemailDataGridViewTextBoxColumn.DataPropertyName = "comp_email";
            this.compemailDataGridViewTextBoxColumn.HeaderText = "Company\'s Email ID";
            this.compemailDataGridViewTextBoxColumn.Name = "compemailDataGridViewTextBoxColumn";
            // 
            // compphoneDataGridViewTextBoxColumn
            // 
            this.compphoneDataGridViewTextBoxColumn.DataPropertyName = "comp_phone";
            this.compphoneDataGridViewTextBoxColumn.HeaderText = "Company\'s Phone";
            this.compphoneDataGridViewTextBoxColumn.Name = "compphoneDataGridViewTextBoxColumn";
            // 
            // hrnameDataGridViewTextBoxColumn
            // 
            this.hrnameDataGridViewTextBoxColumn.DataPropertyName = "hr_name";
            this.hrnameDataGridViewTextBoxColumn.HeaderText = "HR Name";
            this.hrnameDataGridViewTextBoxColumn.Name = "hrnameDataGridViewTextBoxColumn";
            // 
            // hremailDataGridViewTextBoxColumn
            // 
            this.hremailDataGridViewTextBoxColumn.DataPropertyName = "hr_email";
            this.hremailDataGridViewTextBoxColumn.HeaderText = "HR Email ID";
            this.hremailDataGridViewTextBoxColumn.Name = "hremailDataGridViewTextBoxColumn";
            // 
            // hrphoneDataGridViewTextBoxColumn
            // 
            this.hrphoneDataGridViewTextBoxColumn.DataPropertyName = "hr_phone";
            this.hrphoneDataGridViewTextBoxColumn.HeaderText = "HR Phone";
            this.hrphoneDataGridViewTextBoxColumn.Name = "hrphoneDataGridViewTextBoxColumn";
            // 
            // ViewCompDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 335);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ViewCompDetails";
            this.Text = "ViewCompDetails";
            this.Load += new System.EventHandler(this.ViewCompDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.compDetailsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ProjectDataSet1 projectDataSet1;
        private System.Windows.Forms.BindingSource compDetailsBindingSource;
        private ProjectDataSet1TableAdapters.Comp_DetailsTableAdapter comp_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn compidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compemailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn compphoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hremailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hrphoneDataGridViewTextBoxColumn;
    }
}