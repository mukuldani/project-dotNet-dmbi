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
    public partial class ViewStudentDetails : Form
    {
        public ViewStudentDetails()
        {
            InitializeComponent();
        }
        public int sid;
        private void ViewStudentDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.projectDataSet.Student);
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.studentTableAdapter.FillBy(this.projectDataSet.Student);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void btnRank_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                foreach(DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    string id = dr.Cells[0].Value.ToString();
                    sid = Convert.ToInt32(id);
                    EditStudentDetails esd = new EditStudentDetails(sid);
                    esd.Show();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Please Select only row");
            }
        }
    }
}
