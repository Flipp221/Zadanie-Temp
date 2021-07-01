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
            public string time;
            public int fact;
            public int norm;
            public int otk;

            public User(string _time, int _fact, int _norm, int _otk)
            {
                time = _time;
                fact = _fact;
                norm = _norm;
                otk = _otk;
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {


            dataGridView1.AllowUserToAddRows = false;

            users.Add(new User("12.06.2021 15:23", -4, -3, -1));
            users.Add(new User("12.06.2021 15:33", -4, -3, -1));
            users.Add(new User("12.06.2021 15:43", -5, -3, -2));
            users.Add(new User("12.06.2021 15:53", -5, -3, -2));
            users.Add(new User("12.06.2021 16:03", -4, -3, -1));
            users.Add(new User("12.06.2021 16:13", -4, -3, -1));
            users.Add(new User("12.06.2021 16:23", -4, -3, -1));



            DataTable table = new DataTable();
            table.Columns.Add("Время", typeof(string));
            table.Columns.Add("Факт", typeof(int));
            table.Columns.Add("Норма", typeof(int));
            table.Columns.Add("Отклонение от нормы", typeof(int));

            for (int i = 0; i < users.Count; i++)
            {
                table.Rows.Add(users[i].time, users[i].fact, users[i].norm, users[i].otk);
            }

            dataGridView1.DataSource = table;

        }
    }
}
