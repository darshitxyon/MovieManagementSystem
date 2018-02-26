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
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = POORVI\SQLEXPRESS; Initial Catalog = moviemanagement; Integrated Security = True;");

            SqlCommand cmd1 = new SqlCommand();
            cmd1.Connection = con;
            cmd1.CommandType = System.Data.CommandType.StoredProcedure;
            cmd1.CommandText = "searchscreen";
            cmd1.Parameters.AddWithValue("@theatreid", textBox1.Text);
            SqlParameter outputpar = new SqlParameter("@return", SqlDbType.Int);
            outputpar.Direction = ParameterDirection.ReturnValue;
            cmd1.Parameters.Add(outputpar);


           
            con.Open();
            cmd1.ExecuteNonQuery();
            int count = (int)cmd1.Parameters["@return"].Value;
            int cost = count * 200;
            label2.Text = cost.ToString();
            con.Close();
        }
    }
}
