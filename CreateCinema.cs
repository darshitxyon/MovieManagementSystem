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
using System.Configuration;

namespace MovieManagementSystem
{
    public partial class CreateCinema : Form
    {
        public CreateCinema()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }

        private void CreateCinema_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateSceen cs = new CreateSceen();
            cs.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand("createcinema", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@tid", tidbox.Text);
            cmd.Parameters.AddWithValue("@name", namebox.Text);
            cmd.Parameters.AddWithValue("@city", citybox.Text);
            cmd.Parameters.AddWithValue("@numofscr", numscrbox.Text);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Values inserted");

        }
    }
}
