namespace WindowsFormsApplication1
{
    partial class AddCompDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxCompName = new System.Windows.Forms.TextBox();
            this.richTextBoxAdd = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxCompEmail = new System.Windows.Forms.TextBox();
            this.textBoxHRName = new System.Windows.Forms.TextBox();
            this.textBoxHREmail = new System.Windows.Forms.TextBox();
            this.textBoxHRPhone = new System.Windows.Forms.TextBox();
            this.textBoxCompPhone = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Company Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // textBoxCompName
            // 
            this.textBoxCompName.Location = new System.Drawing.Point(113, 39);
            this.textBoxCompName.Name = "textBoxCompName";
            this.textBoxCompName.Size = new System.Drawing.Size(261, 20);
            this.textBoxCompName.TabIndex = 2;
            this.textBoxCompName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBoxAdd
            // 
            this.richTextBoxAdd.Location = new System.Drawing.Point(113, 77);
            this.richTextBoxAdd.Name = "richTextBoxAdd";
            this.richTextBoxAdd.Size = new System.Drawing.Size(261, 61);
            this.richTextBoxAdd.TabIndex = 3;
            this.richTextBoxAdd.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "HR Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "HR\'s Email ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "HR\'s Phone Number";
            // 
            // textBoxCompEmail
            // 
            this.textBoxCompEmail.Location = new System.Drawing.Point(113, 169);
            this.textBoxCompEmail.Name = "textBoxCompEmail";
            this.textBoxCompEmail.Size = new System.Drawing.Size(150, 20);
            this.textBoxCompEmail.TabIndex = 8;
            // 
            // textBoxHRName
            // 
            this.textBoxHRName.Location = new System.Drawing.Point(113, 218);
            this.textBoxHRName.Name = "textBoxHRName";
            this.textBoxHRName.Size = new System.Drawing.Size(182, 20);
            this.textBoxHRName.TabIndex = 9;
            // 
            // textBoxHREmail
            // 
            this.textBoxHREmail.Location = new System.Drawing.Point(113, 271);
            this.textBoxHREmail.Name = "textBoxHREmail";
            this.textBoxHREmail.Size = new System.Drawing.Size(158, 20);
            this.textBoxHREmail.TabIndex = 10;
            this.textBoxHREmail.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBoxHRPhone
            // 
            this.textBoxHRPhone.Location = new System.Drawing.Point(419, 270);
            this.textBoxHRPhone.Name = "textBoxHRPhone";
            this.textBoxHRPhone.Size = new System.Drawing.Size(133, 20);
            this.textBoxHRPhone.TabIndex = 11;
            // 
            // textBoxCompPhone
            // 
            this.textBoxCompPhone.Location = new System.Drawing.Point(410, 169);
            this.textBoxCompPhone.Name = "textBoxCompPhone";
            this.textBoxCompPhone.Size = new System.Drawing.Size(142, 20);
            this.textBoxCompPhone.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Phone Number";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(166, 339);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 14;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(275, 339);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(75, 23);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Submit";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // AddCompDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 391);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxCompPhone);
            this.Controls.Add(this.textBoxHRPhone);
            this.Controls.Add(this.textBoxHREmail);
            this.Controls.Add(this.textBoxHRName);
            this.Controls.Add(this.textBoxCompEmail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxAdd);
            this.Controls.Add(this.textBoxCompName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddCompDetails";
            this.Text = "AddCompDetails";
            this.Load += new System.EventHandler(this.AddCompDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxCompName;
        private System.Windows.Forms.RichTextBox richTextBoxAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCompEmail;
        private System.Windows.Forms.TextBox textBoxHRName;
        private System.Windows.Forms.TextBox textBoxHREmail;
        private System.Windows.Forms.TextBox textBoxHRPhone;
        private System.Windows.Forms.TextBox textBoxCompPhone;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnInsert;
    }
}