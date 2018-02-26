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
//using System.Data.SqlServerCe;

namespace MovieManagementSystem
{
    public partial class theatretable : Form
    {
        //String constring = @"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;"
       // SqlDataAdapter adapter;
        public theatretable()
        {
            InitializeComponent();
            filldatagrid();
        }

        private void theatretable_Load(object sender, EventArgs e)
        {
            
           // dataGridView1.DataSource = getdata();
           // SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            //SqlCommand com = new SqlCommand("select theatreid,name,city,screen_no from theatre natural join screen");
            //DataTable data = new DataTable();
            //SqlDataAdapter sda = new SqlDataAdapter(com);
            //sda.Fill(data);

            //dataGridView1.DataSource = data;
        }

        //private DataTable getdata()
        
        //    DataTable daTa = new DataTable();
          //  String constring = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;
            //using (SqlConnection con = new SqlConnection(constring))
            //{
              //  using (SqlCommand com = new SqlCommand("select theatreid,name,city,screen_no from theatre natural join screen"))
                //{
                  //  con.Open();
                 
                 //   SqlDataReader reader = com.ExecuteReader();
                   // daTa.Load(reader);
                //}
            //}

            //return daTa;
        //}

        private void filldatagrid()
        {
            String constring = @"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;";
            using (SqlConnection con = new SqlConnection(constring))
            {
                using (SqlCommand cmd = new SqlCommand("select * from theatre", con))
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

               /// DataTable daTa = new DataTable();

                //con.Open();
               // SqlCommand com = new SqlCommand("select theatreid,name,city,screen_no from theatre natural join screen",con);
                //SqlDataReader reader = com.ExecuteReader();
                
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
