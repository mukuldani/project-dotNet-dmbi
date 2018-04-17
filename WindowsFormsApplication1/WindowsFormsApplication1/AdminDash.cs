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
    public partial class AdminDash : Form
    {
        public AdminDash()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DisplayRankWise dr = new DisplayRankWise();
            dr.Show();
        }

        private void btnAddStuDetails_Click(object sender, EventArgs e)
        {
            StudentDetails sd = new StudentDetails();
            sd.ShowDialog();
        }

        private void btnViewStuDetails_Click(object sender, EventArgs e)
        {
            ViewStudentDetails vs = new ViewStudentDetails();
            vs.Show();
        }

        private void btnAddCompDetails_Click(object sender, EventArgs e)
        {
            AddCompDetails acd = new AddCompDetails();
            acd.ShowDialog();
        }

        private void btnViewCompDetails_Click(object sender, EventArgs e)
        {
            ViewCompDetails vcd = new ViewCompDetails();
            vcd.ShowDialog();
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            EditProfile ep = new EditProfile();
            ep.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
