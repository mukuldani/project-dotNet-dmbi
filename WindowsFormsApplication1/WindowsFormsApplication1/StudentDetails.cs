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
    public partial class StudentDetails : Form
    {
        public StudentDetails()
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

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {
            AdminDash ad = new AdminDash();
            ad.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if((textBoxName.Text != null) && (textBoxEmail.Text != null) && (textBoxPhone.Text != null) && (richTextBoxAddress.Text != null) && (textBoxHSC.Text != null) && (textBoxSSC.Text != null) && (textBoxGrad.Text != null) && (textBoxSem1.Text != null) && (textBoxSem2.Text != null) && (textBoxSem3.Text != null) && (textBoxSem4.Text != null) && (textBoxLiveKt.Text != null) && (textBoxDeadKt.Text != null))
            {
                connDatabase();
                string insertQuery = "Insert into Student values ('"+ textBoxName.Text+"','"+textBoxEmail.Text+"',"+Convert.ToInt64(textBoxPhone.Text)+",'"+richTextBoxAddress.Text+"',"+Convert.ToInt32(textBoxHSC.Text)+"," + Convert.ToInt32(textBoxSSC.Text) + "," + Convert.ToInt32(textBoxGrad.Text) + "," + Convert.ToDouble(textBoxSem1.Text) + "," + Convert.ToDouble(textBoxSem2.Text) +"," + Convert.ToDouble(textBoxSem3.Text) + "," + Convert.ToDouble(textBoxSem4.Text) +"," + Convert.ToInt32(textBoxLiveKt.Text) + "," + Convert.ToInt32(textBoxDeadKt.Text) + ")";
                cmd = new SqlCommand(insertQuery, con);
                int row = cmd.ExecuteNonQuery();
                if(row == 1)
                {
                    MessageBox.Show("Student data inserted");
                    textBoxName.Text = "";
                    textBoxEmail.Text = "";
                    textBoxPhone.Text = "";
                    richTextBoxAddress.Text = "";
                    textBoxSSC.Text = "";
                    textBoxHSC.Text = "";
                    textBoxSem1.Text = "";
                    textBoxSem2.Text = "";
                    textBoxSem3.Text = "";
                    textBoxSem4.Text = "";
                    textBoxLiveKt.Text = "";
                    textBoxDeadKt.Text = "";
                    con.Close();
                }
                else
                {
                    MessageBox.Show("SQL injection Error");
                }
            }
            else
            {
                MessageBox.Show("Enter all details");
            }
        }

        private void textBoxSSC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            AdminDash ad = new AdminDash();
            ad.ShowDialog();
            this.Close();
        }
    }
}
