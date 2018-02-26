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
using System.Data.SqlTypes;

namespace MovieManagementSystem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String uname = username.Text;
            String pwd = password.Text;

            SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from Login where UserName='"+uname+"' and Password='"+pwd+"'",con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            Form2 f = new Form2();
            if(dt.Rows[0][0].ToString()=="1")
            {
                f.Show();
                this.Hide();
            }
            else
            {
                 MessageBox.Show("Please check your username and password");
            }

            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
