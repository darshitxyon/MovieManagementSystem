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
    public partial class Seating : Form
    {
        public Seating()
        {
            InitializeComponent();
        }
        public string city, theatre, show1,show2, movie,ticketid;
        SqlConnection con;
        public Seating(string ct,string th,string mov,string st,string tick)
        {
            city = ct;
            theatre = th;
            movie = mov;
            // show = Convert.ToDateTime(s).TimeOfDay;
            show1 = st;
            show2 = st;
            ticketid = tick;
            MessageBox.Show(city + theatre + movie+show2);

            InitializeComponent();
        }

        private void Seating_Load(object sender, EventArgs e)
        {

        }

        private void checkBox88_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox195_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox267_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            book_tickets bk = new book_tickets();
            bk.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "";
            string ticket = "";
            int count = 0;
            //Random random = new Random();
           // int ticketid = random.Next(0, 10000);
            //Receipt r = new Receipt();

            con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
           
            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.CommandText = "screensearch1";
            cmd1.Parameters.AddWithValue("@tid", ticketid);
            cmd1.Parameters.AddWithValue("@movie_id", movie);
            cmd1.Parameters.AddWithValue("@time", show1);
            SqlParameter outputpar = new SqlParameter("@return",SqlDbType.Int);
            outputpar.Direction = ParameterDirection.ReturnValue;
            
            cmd1.Parameters.Add(outputpar);
            con.Open();
            cmd1.ExecuteNonQuery();
            int scrno = (int)cmd1.Parameters["@return"].Value;
            con.Close();

            con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");

            foreach (Control c in this.Controls)
            {
                if(c is CheckBox)
                {
                    CheckBox b = (CheckBox)c;
                    if(b.Checked)
                    {
                        s = b.Name;
                        count++;
                        SqlCommand cmd = new SqlCommand("createticket", con);
                        cmd.CommandType = System.Data.CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@tid", ticketid);
                        cmd.Parameters.AddWithValue("@cpt", 200);
                        cmd.Parameters.AddWithValue("@scrno",scrno );
                        cmd.Parameters.AddWithValue("@seat", s);
                        cmd.Parameters.AddWithValue("@time", 10);
                        //cmd.Parameters.AddWithValue("@time", Convert.ToInt32(show2));
                        cmd.Parameters.AddWithValue("@theatreid", theatre);


                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        ticket = "TicketId:" + ticketid + "\nTheatreId:" + theatre + "\nScreenNo:" + scrno + "\nseats:" + s + "\nTime:" + show2;
                        MessageBox.Show(ticket);
                        

                    }
                }
            }

          //  r.Show();
            //this.Hide();


        }

    }
}
