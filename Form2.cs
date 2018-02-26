using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieManagementSystem
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Transaction tr = new Transaction();
            tr.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreateMovie cm = new CreateMovie();
            cm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateCinema cc = new CreateCinema();
            cc.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MapTiming mt = new MapTiming();
            mt.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            book_tickets bk = new book_tickets();
            bk.Show();
            this.Hide();
        }
    }
}
