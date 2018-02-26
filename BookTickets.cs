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
using System.Data.SqlTypes;

namespace MovieManagementSystem
{
    public partial class book_tickets : Form
    {
        public book_tickets()
        {

            InitializeComponent();
            
        }
        SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");

        private void button1_Click(object sender, EventArgs e)
        {
            string city = citybox.Text;
            string theatre = theatrebox.Text;
            string movie = moviebox.Text;
            string show = showbox.Text;
            string ticketid = ticketidbox.Text;

            Seating s = new Seating(city,theatre,movie,show,ticketid);
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
        
        private void book_tickets_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewMovies vm =new ViewMovies();
            vm.Show();
        }

        private void viewtheatre_Click(object sender, EventArgs e)
        {
            theatretable tt = new theatretable();
            tt.Show();
        }
    }
}
