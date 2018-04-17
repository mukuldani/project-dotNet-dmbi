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
    public partial class EditCompanyDetails : Form
    {
        public int cid;
        public EditCompanyDetails(int id)
        {
            InitializeComponent();
            cid = id;
        }

        public int sid;
        public SqlConnection con;
        public SqlCommand cmd;

        private void connDatabase()
        {
            con = new SqlConnection();
            con.ConnectionString = @"Data Source=MUKUL\SQLEXPRESS;Initial Catalog=Project;Integrated Security=True";
            con.Open();
        }

        private void EditCompanyDetails_Load(object sender, EventArgs e)
        {
            connDatabase();
            string query = "Select * from Comp_Details where comp_id =" + cid;
            cmd = new SqlCommand(query, con);
            SqlDataReader sda = cmd.ExecuteReader();
            if (sda.HasRows)
            {
                while (sda.Read())
                {
                    textBoxCompName.Text = sda["comp_name"].ToString();
                    richTextBoxAdd.Text = sda["comp_add"].ToString();
                    textBoxCompEmail.Text = sda["comp_email"].ToString();
                    textBoxCompPhone.Text = sda["comp_phone"].ToString();
                    textBoxHRName.Text = sda["hr_name"].ToString();
                    textBoxHREmail.Text = sda["hr_email"].ToString();
                    textBoxHRPhone.Text = sda["hr_phone"].ToString();
                }
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((textBoxCompName.Text != null) && (richTextBoxAdd.Text != null) && (textBoxCompEmail.Text != null) && (textBoxCompName.Text != null) && (textBoxHRName.Text != null) && (textBoxHREmail.Text != null) && (textBoxHRPhone.Text != null))
            {
                connDatabase();
                string updateQuery = "Update Comp_Details SET comp_name = '"+textBoxCompName.Text+"', comp_add = '"+richTextBoxAdd.Text+"', comp_email = '"+textBoxCompEmail.Text+"', comp_phone ="+Convert.ToInt64(textBoxCompPhone.Text)+", hr_name ='"+textBoxHRName.Text+"', hr_email = '"+textBoxHREmail.Text+"', hr_phone="+Convert.ToInt64(textBoxHRPhone.Text)+ " where comp_id = " + cid;
                cmd = new SqlCommand(updateQuery, con);
                int row = cmd.ExecuteNonQuery();
                if(row == 1)
                {
                    MessageBox.Show("Company Details Updated");
                    ViewCompDetails vcd = new ViewCompDetails();
                    vcd.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Record Not Updated");
                }
            }
            else
            {
                MessageBox.Show("Please Enter all the details");
            }
        }
    }
}
