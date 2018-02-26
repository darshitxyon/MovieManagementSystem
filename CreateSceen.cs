using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManagementSystem
{
    public partial class CreateSceen : Form
    {
        public CreateSceen()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("createscreen", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@scr_no",sidbox.Text);
            cmd.Parameters.AddWithValue("@theatreid",cidbox.Text);
            cmd.Parameters.AddWithValue("@capacity",capbox.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Values Inserted");
        }
            
        private void button2_Click(object sender, EventArgs e)
        {
            CreateCinema cc = new CreateCinema();
            cc.Show();
            this.Hide();
        }
    }
}
