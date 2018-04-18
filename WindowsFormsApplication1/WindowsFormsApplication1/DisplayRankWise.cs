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
    public partial class DisplayRankWise : Form
    {
        public DisplayRankWise()
        {
            InitializeComponent();
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
        
        int rowCount;
        private void DisplayRankWise_Load(object sender, EventArgs e)
        {
            getRank();
        }
        public void getRank()
        {
            connDatabase();
            string query = "Select * from Student";
            cmd = new SqlCommand(query, con);
            SqlDataReader sda = cmd.ExecuteReader();
            if(sda.HasRows)
            {
                while(sda.Read())
                {
                    rowCount++;
                }
            }
            string[] name = new string[rowCount];
            int[] id = new int[rowCount];
            int[] mgrad = new int[rowCount];
            while (sda.Read())
            {
                for (int i = 0; i < rowCount; i++)
                {
                    id[i] = Convert.ToInt32(sda["stuId"]);
                    name[i] = sda["sname"].ToString();
                    mgrad[i] = Convert.ToInt32(sda["marks_grad"]);
                }
            }
            int []tempArr = new int[rowCount];
            int temp;
            for(int i=0; i<rowCount; i++)
            {
                for(int j=0; j<(rowCount-1); j++)
                {
                    if(mgrad[j] > mgrad[j+1])
                    {
                        temp = mgrad[j + 1];
                        mgrad[j + 1] = mgrad[j];
                        mgrad[j] = temp;
                        //tempArr[i] = id[j];

                    }
                }           
            }
            for(int i=0;i <rowCount;i++)
            {
                Console.WriteLine(mgrad[i]);
            }
        }
    }
}
