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
    public partial class ViewMovies : Form
    {
        public ViewMovies()
        {
            InitializeComponent();
            filldatagrid();
        }

        private void ViewMovies_Load(object sender, EventArgs e)
        {

            //SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            //SqlCommand com = new SqlCommand("select movie_id,movietitle from movie");
            //DataTable data = new DataTable;();
            // SqlDataAdapter sda = new SqlDataAdapter(com);
            // sda.Fill(data);

            // dataGridView1.DataSource = data;
        }

        private void filldatagrid()
        {
            String constring = @"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from movie", con))
                {
                    cmd.CommandType = CommandType.Text;
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            sda.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }
            }
        }
    }
}
