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
    public partial class SignIn : Form
    {
        public SignIn()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;
        public DataSet ds;

        private void connDatabase()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MUKUL\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            con.Open();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if((textBoxName.Text != null) && (textBoxEmail.Text != null) && (textBoxPassword.Text != null) && (textBoxConfirmPassword.Text != null) && (textBoxPhone.Text != null) && (comboBoxRole.SelectedItem.ToString() != null))
            {
                if(textBoxPassword.Text == textBoxConfirmPassword.Text)
                {
                    connDatabase();
                    string insertQuery = "Insert into users values ('"+textBoxName.Text+"','"+textBoxEmail.Text+"','"+textBoxPassword.Text+"',"+Convert.ToInt64(textBoxPhone.Text)+",'"+comboBoxRole.SelectedItem.ToString()+"')";
                    cmd = new SqlCommand(insertQuery, con);
                    int row = cmd.ExecuteNonQuery();
                    if(row == 1)
                    {
                        MessageBox.Show("User Signed In sucessfully");
                        textBoxName.Text = "";
                        textBoxEmail.Text = "";
                        textBoxPassword.Text = "";
                        textBoxPhone.Text = "";
                        con.Close();
                        Login lg = new Login();
                        this.Close();
                        lg.Show();
                    }
                    else
                    {
                        MessageBox.Show("SQl Injection error");
                        textBoxName.Text = "";
                        textBoxEmail.Text = "";
                        textBoxPassword.Text = "";
                        textBoxPhone.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Password is not same");
                }
            }
            else
            {
                MessageBox.Show("Enter all fields");
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            this.Close();
            lg.ShowDialog();
        }
    }
}
