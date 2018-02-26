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
    public partial class MapTiming : Form
    {
        public MapTiming()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("maptiming", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@theatreid", theatrebox.Text);
            cmd.Parameters.AddWithValue("@scrno", screenbox.Text);
            cmd.Parameters.AddWithValue("@city", citybox.Text);
            cmd.Parameters.AddWithValue("@mid", moviebox.Text);
            cmd.Parameters.AddWithValue("@time", timebox.Text);


            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Values Inserted");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MapTiming_Load(object sender, EventArgs e)
        {
           
        }

        private void ViewCinema_Click(object sender, EventArgs e)
        {
            theatretable tt = new theatretable();
            tt.Show();
            
        }

        private void ViewMovie_Click(object sender, EventArgs e)
        {
            ViewMovies vc = new ViewMovies();
            vc.Show();
            
        }
    }
}
