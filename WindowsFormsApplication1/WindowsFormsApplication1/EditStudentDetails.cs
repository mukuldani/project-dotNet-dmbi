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
    public partial class EditStudentDetails : Form
    {
        public EditStudentDetails(int id)
        {
            InitializeComponent();
            sid = id;
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
        private void EditStudentDetails_Load(object sender, EventArgs e)
        {
            connDatabase();
            string query = "Select * from Student where stuId ="+sid;
            cmd = new SqlCommand(query, con);
            SqlDataReader sda = cmd.ExecuteReader();
            if(sda.HasRows)
            {
                while(sda.Read())
                {
                    textBoxName.Text = sda["sname"].ToString();
                    textBoxEmail.Text = sda["email"].ToString();
                    textBoxPhone.Text = sda["phone"].ToString();
                    richTextBoxAddress.Text = sda["address"].ToString();
                    textBoxHSC.Text = sda["marks_hsc"].ToString();
                    textBoxSSC.Text = sda["marks_ssc"].ToString();
                    textBoxGrad.Text = sda["marks_grad"].ToString();
                    textBoxSem1.Text = sda["marks_sem1"].ToString();
                    textBoxSem2.Text = sda["marks_sem2"].ToString();
                    textBoxSem3.Text = sda["marks_sem3"].ToString();
                    textBoxSem4.Text = sda["marks_sem4"].ToString();
                    textBoxLiveKt.Text = sda["live_kt"].ToString();
                    textBoxDeadKt.Text = sda["dead_kt"].ToString();
                }
            }
            con.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if ((textBoxName.Text != null) && (textBoxEmail.Text != null) && (textBoxPhone.Text != null) && (richTextBoxAddress.Text != null) && (textBoxHSC.Text != null) && (textBoxSSC.Text != null) && (textBoxGrad.Text != null) && (textBoxSem1.Text != null) && (textBoxSem2.Text != null) && (textBoxSem3.Text != null) && (textBoxSem4.Text != null) && (textBoxLiveKt.Text != null) && (textBoxDeadKt.Text != null))
            {
                connDatabase();
                string updateQuery = "Update Student set sname ='" + textBoxName.Text + "',email = '" + textBoxEmail.Text + "', phone = " + Convert.ToInt64(textBoxPhone.Text) + ", address = '" + richTextBoxAddress.Text + "', marks_hsc = " + Convert.ToInt32(textBoxHSC.Text) + ", marks_ssc = " + Convert.ToInt32(textBoxSSC.Text) + ", marks_grad = " + Convert.ToInt32(textBoxGrad.Text) + ", marks_sem1 = " + Convert.ToDouble(textBoxSem1.Text) + ", marks_sem2 = " + Convert.ToDouble(textBoxSem2.Text) + ", marks_sem3 = " + Convert.ToDouble(textBoxSem1.Text) + ", marks_sem4 = " + Convert.ToDouble(textBoxSem4.Text) + ",live_kt =" + Convert.ToInt32(textBoxLiveKt.Text) + ", dead_kt = " + Convert.ToInt32(textBoxDeadKt.Text) + " where stuId = " + sid;
                cmd = new SqlCommand(updateQuery, con);
                int row = cmd.ExecuteNonQuery();
                if(row == 1)
                {
                    MessageBox.Show("Record Updated");
                    ViewStudentDetails vsd = new ViewStudentDetails();
                    vsd.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Record Not Updated");
                }
            }
            else
            {
                MessageBox.Show("Please enter all the fields");
            }
        }
    }
}
