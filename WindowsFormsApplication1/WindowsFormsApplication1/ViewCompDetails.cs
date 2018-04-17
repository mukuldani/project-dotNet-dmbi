using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ViewCompDetails : Form
    {
        public ViewCompDetails()
        {
            InitializeComponent();
        }
        public int cid;
        private void ViewCompDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectDataSet1.Comp_Details' table. You can move, or remove it, as needed.
            this.comp_DetailsTableAdapter.Fill(this.projectDataSet1.Comp_Details);
            AdminDash ad = new AdminDash();
            ad.Close();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                foreach (DataGridViewRow dr in dataGridView1.SelectedRows)
                {
                    string id = dr.Cells[0].Value.ToString();
                    cid = Convert.ToInt32(id);
                    EditCompanyDetails esd = new EditCompanyDetails(cid);
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
