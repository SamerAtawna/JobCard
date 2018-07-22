using System;
using System.Data;

using System.Data.SqlClient;
using MaterialSkin.Controls;

namespace JobCard
{

    public partial class TechStatus : MaterialForm
    {
        public TechStatus()
        {
            InitializeComponent();
        }
     


        private void TechStatus_Load(object sender, EventArgs e)
        {
           GetCnt("Lior");
            liorcnt.Text = GetCnt("Lior").ToString();
            omricnt.Text = GetCnt("Omri").ToString();
            yakovcnt.Text = GetCnt("Yakov").ToString();
            shaharcnt.Text = GetCnt("Shahar").ToString();
            rancnt.Text = GetCnt("Ran").ToString();
            pavelcnt.Text = GetCnt("Pavel").ToString();

        }
        public string conString1 = "Data Source='LCSMKCAFE02, 3180';User ID=ad_salataox ;PASSWORD=1@password;Initial Catalog=master";
        public int GetCnt(string a)
        {
            int counter = 0;
            using (SqlConnection connection = new SqlConnection(conString1))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandType = CommandType.Text;


                command.CommandText = "select COUNT(technician) from JobCardView where technician = '" + a + "' and CONVERT(date, Date, 103) =  CONVERT(date, GETDATE(), 103) ";

                counter = Convert.ToInt32(command.ExecuteScalar());
            }
            return counter;
            

        }
        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }
    }
}
