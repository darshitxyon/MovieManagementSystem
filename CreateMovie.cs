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

namespace MovieManagementSystem
{
    public partial class CreateMovie : Form
    {
        public CreateMovie()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("createmovie", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@mid", midbox.Text);
            cmd.Parameters.AddWithValue("@title", titlebox.Text);
            cmd.Parameters.AddWithValue("@rating", ratingbox.Text);
            cmd.Parameters.AddWithValue("@production", productionbox.Text);
            cmd.Parameters.AddWithValue("@director", directorbox.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Values Inserted");
        }
    }
}
