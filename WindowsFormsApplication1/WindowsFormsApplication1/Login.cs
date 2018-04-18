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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        public DataSet ds;
        public int uid;
        public string user_name;
        public string user_role;
        private void connDatabase()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MUKUL\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            con.Open();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            if (textBoxUsername.Text == "")
            {
                MessageBox.Show("Enter a user name");
            }
            if(textBoxPassword.Text == "")
            {
                MessageBox.Show("Enter password");
            }

            if((textBoxUsername.Text != null) && (textBoxPassword.Text != null))
            {
                connDatabase();
                string query = "Select uid, name, email_id, phone, role from users where email_id = '" + textBoxUsername.Text + "'and password = '" + textBoxPassword.Text +"'";
                cmd = new SqlCommand(query, con);
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    if (sdr.Read())
                    {
                        uid = sdr.GetInt32(0);
                        user_name = sdr["name"].ToString();
                        user_role = sdr["role"].ToString();
                    }
                    MessageBox.Show("Login Sucessfull. Welcome " + user_name);
                    con.Close();
                    AdminDash ad = new AdminDash(uid);
                    ad.Show();
                }
                else
                {
                    MessageBox.Show("Login unsucessfull. Please check the user name and password");
                    textBoxUsername.Text = "";
                    textBoxPassword.Text = "";
                }  
            }
            else
            {
                MessageBox.Show("Enter User name and password");
                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            SignIn si = new SignIn();      
            si.Show();
            this.Close();
        }
    }
}
