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
    public partial class AddCompDetails : Form
    {
        public AddCompDetails()
        {
            InitializeComponent();
        }

        public SqlConnection con;
        public SqlCommand cmd;

        private void connDatabase()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MUKUL\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            con.Open();
        }


        private void AddCompDetails_Load(object sender, EventArgs e)
        {
            AdminDash ad = new AdminDash();
            ad.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if ((textBoxCompName.Text != null) && (richTextBoxAdd.Text != null) && (textBoxCompEmail.Text != null) && (textBoxCompName.Text != null) && (textBoxHRName.Text != null) && (textBoxHREmail.Text != null) && (textBoxHRPhone.Text != null))
            {
                connDatabase();
                string insertQuery = "Insert into Comp_Details values ('" + textBoxCompName.Text + "','" + richTextBoxAdd.Text + "','" + textBoxCompEmail.Text + "'," + Convert.ToInt64(textBoxCompPhone.Text) + ",'" + textBoxHRName.Text + "','" + textBoxHREmail.Text + "'," + Convert.ToInt64(textBoxHRPhone.Text) + ")";
                cmd = new SqlCommand(insertQuery, con);
                int row = cmd.ExecuteNonQuery();
                if (row == 1)
                {
                    MessageBox.Show("Company data inserted");
                    textBoxCompName.Text = "";
                    textBoxCompEmail.Text = "";
                    textBoxCompPhone.Text = "";
                    textBoxHRName.Text = "";
                    textBoxHREmail.Text = "";
                    textBoxHRPhone.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("SQL Injection error. Please check the entered fields");
                }
            }
            else
            {
                MessageBox.Show("Enter details in all fields");
            }
        }
    }
}
