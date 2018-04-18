using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class EditProfile : Form
    {
        public int uid;
        public EditProfile(int id)
        {
            InitializeComponent();
            uid = id;
        }
        public int sid;
        public SqlConnection con;
        public SqlCommand cmd;
        public string role;
        private void connDatabase()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MUKUL\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            con.Open();
        }
        protected void getProfileDetails()
        {
            connDatabase();
            string query = "Select * from users where uid =" + uid;
            cmd = new SqlCommand(query, con);
            SqlDataReader sda = cmd.ExecuteReader();
            if (sda.HasRows)
            {
                while (sda.Read())
                {
                    textBoxName.Text = sda["name"].ToString();
                    textBoxEmail.Text = sda["email_id"].ToString();
                    textBoxPhone.Text = sda["phone"].ToString();
                    role = sda["role"].ToString();
                }
            }
            con.Close();
        }
        private void EditProfile_Load(object sender, EventArgs e)
        {
            getProfileDetails();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != null) && (textBoxEmail.Text != null) && (textBoxPassword.Text != null) && (textBoxConfirmPassword.Text != null) && (textBoxPhone.Text != null) )
            {
                if((textBoxPassword.Text == textBoxConfirmPassword.Text))
                {
                    connDatabase();
                    string updateQuery = "Update users set name = '" + textBoxName.Text + "', email_id = '" + textBoxEmail.Text + "', password = '" + textBoxPassword.Text + "',phone = " + Convert.ToInt64(textBoxPhone.Text) + ",role = '" + role + "' where uid = "+uid;
                    cmd = new SqlCommand(updateQuery, con);
                    int row = cmd.ExecuteNonQuery();
                    if(row == 1)
                    {
                        MessageBox.Show("Profile Updated");
                        getProfileDetails();
                    }
                    else
                    {
                        MessageBox.Show("Update Failed");
                    }
                }
                else
                {
                    MessageBox.Show("Please make sure that both the password fields are same");
                }
            }
            else
            {
                MessageBox.Show("Please enter all the fields");
            }
            con.Close();
        }
    }
}
