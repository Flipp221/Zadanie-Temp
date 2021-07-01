using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Zadanie
{
    public partial class Form1 : Form
    {

        public struct User
        {
            public int day;
            public int sum;

            public User(int _day, int _sum)
            {
                day = _day;
                sum = _sum;
            }
        }
        List<User> users = new List<User>();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void box_label3_Click(object sender, EventArgs e)
        {

        }

        private void text_box3_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_label4_Click(object sender, EventArgs e)
        {

        }

        private void text_box4_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_label5_Click(object sender, EventArgs e)
        {

        }

        private void text_box5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void text_box6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
