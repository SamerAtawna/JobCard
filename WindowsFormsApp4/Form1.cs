using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{

    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString))
            using (var command = connection.CreateCommand())
            {
                command.CommandText = "SELECT ColumnName FROM [check]";
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                        textBox2.Text = reader["ColumnName"].ToString();
                }
            }
        }
    }

}
