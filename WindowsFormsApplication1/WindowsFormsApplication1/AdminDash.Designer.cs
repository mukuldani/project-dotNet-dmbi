namespace WindowsFormsApplication1
{
    partial class AdminDash
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
            this.btnAddStuDetails = new System.Windows.Forms.Button();
            this.btnViewStuDetails = new System.Windows.Forms.Button();
            this.btnAddCompDetails = new System.Windows.Forms.Button();
            this.btnViewCompDetails = new System.Windows.Forms.Button();
            this.btnGetRank = new System.Windows.Forms.Button();
            this.btnEditProfile = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddStuDetails
            // 
            this.btnAddStuDetails.AutoSize = true;
            this.btnAddStuDetails.Location = new System.Drawing.Point(28, 33);
            this.btnAddStuDetails.Name = "btnAddStuDetails";
            this.btnAddStuDetails.Size = new System.Drawing.Size(118, 35);
            this.btnAddStuDetails.TabIndex = 0;
            this.btnAddStuDetails.Text = "Add Student Details";
            this.btnAddStuDetails.UseVisualStyleBackColor = true;
            this.btnAddStuDetails.Click += new System.EventHandler(this.btnAddStuDetails_Click);
            // 
            // btnViewStuDetails
            // 
            this.btnViewStuDetails.AutoSize = true;
            this.btnViewStuDetails.Location = new System.Drawing.Point(185, 33);
            this.btnViewStuDetails.Name = "btnViewStuDetails";
            this.btnViewStuDetails.Size = new System.Drawing.Size(115, 35);
            this.btnViewStuDetails.TabIndex = 1;
            this.btnViewStuDetails.Text = "View Student Details";
            this.btnViewStuDetails.UseVisualStyleBackColor = true;
            this.btnViewStuDetails.Click += new System.EventHandler(this.btnViewStuDetails_Click);
            // 
            // btnAddCompDetails
            // 
            this.btnAddCompDetails.AutoSize = true;
            this.btnAddCompDetails.Location = new System.Drawing.Point(28, 98);
            this.btnAddCompDetails.Name = "btnAddCompDetails";
            this.btnAddCompDetails.Size = new System.Drawing.Size(118, 38);
            this.btnAddCompDetails.TabIndex = 2;
            this.btnAddCompDetails.Text = "Add Company Details";
            this.btnAddCompDetails.UseVisualStyleBackColor = true;
            this.btnAddCompDetails.Click += new System.EventHandler(this.btnAddCompDetails_Click);
            // 
            // btnViewCompDetails
            // 
            this.btnViewCompDetails.AutoSize = true;
            this.btnViewCompDetails.Location = new System.Drawing.Point(185, 98);
            this.btnViewCompDetails.Name = "btnViewCompDetails";
            this.btnViewCompDetails.Size = new System.Drawing.Size(122, 38);
            this.btnViewCompDetails.TabIndex = 3;
            this.btnViewCompDetails.Text = "View Company Details";
            this.btnViewCompDetails.UseVisualStyleBackColor = true;
            this.btnViewCompDetails.Click += new System.EventHandler(this.btnViewCompDetails_Click);
            // 
            // btnGetRank
            // 
            this.btnGetRank.Location = new System.Drawing.Point(28, 164);
            this.btnGetRank.Name = "btnGetRank";
            this.btnGetRank.Size = new System.Drawing.Size(75, 23);
            this.btnGetRank.TabIndex = 4;
            this.btnGetRank.Text = "Get Rank";
            this.btnGetRank.UseVisualStyleBackColor = true;
            this.btnGetRank.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnEditProfile
            // 
            this.btnEditProfile.Location = new System.Drawing.Point(28, 225);
            this.btnEditProfile.Name = "btnEditProfile";
            this.btnEditProfile.Size = new System.Drawing.Size(75, 23);
            this.btnEditProfile.TabIndex = 6;
            this.btnEditProfile.Text = "Edit Profile";
            this.btnEditProfile.UseVisualStyleBackColor = true;
            this.btnEditProfile.Click += new System.EventHandler(this.btnEditProfile_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(185, 225);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 7;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // AdminDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 290);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnEditProfile);
            this.Controls.Add(this.btnGetRank);
            this.Controls.Add(this.btnViewCompDetails);
            this.Controls.Add(this.btnAddCompDetails);
            this.Controls.Add(this.btnViewStuDetails);
            this.Controls.Add(this.btnAddStuDetails);
            this.Name = "AdminDash";
            this.Text = "Super user and admin page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStuDetails;
        private System.Windows.Forms.Button btnViewStuDetails;
        private System.Windows.Forms.Button btnAddCompDetails;
        private System.Windows.Forms.Button btnViewCompDetails;
        private System.Windows.Forms.Button btnGetRank;
        private System.Windows.Forms.Button btnEditProfile;
        private System.Windows.Forms.Button btnLogout;
    }
}