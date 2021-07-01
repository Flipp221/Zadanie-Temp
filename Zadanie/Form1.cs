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

        private void box_KeyPress(object sender, KeyPressEventArgs e)
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

        }
        private void TableFish()
        {
            int norma;
            DateTime time;
            int maxCount = 0;
            int minCount = 0;
            try
            {
                time = Convert.ToDateTime(maskedTextBox1.Text);
            }
            catch
            {
                MessageBox.Show("Введите верный формат времени");
            }
            time = Convert.ToDateTime(maskedTextBox1.Text);
            try
            {
                string ss = text_box4.Text;
                string[] Temp = ss.Split(',', '.', ';', ' ');
                int[] numbers = new int[Temp.Length];
                for (int i = 0; i < Temp.Length; i++)
                {
                    numbers[i] = Int32.Parse(Temp[i]);
                }
                for (int i = 0; i < Temp.Length; i++)
                {
                    if (numbers[i] < 0)
                    {
                        norma = Convert.ToInt32(tbMin.Text);
                    }
                    else
                    {
                        norma = Convert.ToInt32(tbMax.Text);
                    }

                    time = time.AddMinutes(10);
                    dtnTable.Rows.Add();
                    dtnTable[0, i].Value = time;
                    dtnTable[1, i].Value = numbers[i];
                    dtnTable[2, i].Value = norma;
                    dtnTable[3, i].Value = numbers[i] - norma;
                }
            }
            catch
            {
                MessageBox.Show("Подставьте верные значения в строку температура");
                MessageBox.Show("Пример Ввода 0,0,0,0,0");
            }
        }
        private void result_Click(object sender, EventArgs e)
        {
            TableFish();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            Text_Box.Text = "";
            tbMin.Text = "";
            tbMax.Text = "";
            text_box4.Text = "";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
