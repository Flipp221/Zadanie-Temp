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

        int maxCount = 0;
        int minCount = 0;
        int maxHours;
        int maxMinute;
        int minHours;
        int minMinute;

        public Form1()
        {
            InitializeComponent();
        }

        private void bl1_Click(object sender, EventArgs e)
        {

        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bl2_Click(object sender, EventArgs e)
        {

        }

        private void tbMin_TextChanged(object sender, EventArgs e)
        {

        }


        private void bl3_Click(object sender, EventArgs e)
        {

        }

        private void tbMax_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void bl4_Click(object sender, EventArgs e)
        {

        }

        private void tb4_TextChanged(object sender, EventArgs e)
        {

        }

        private void bl5_Click(object sender, EventArgs e)
        {

        }

        private void tb5_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tb6_TextChanged(object sender, EventArgs e)
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

            try
            {
                time = Convert.ToDateTime(mtb1.Text);
            }
            catch
            {
                MessageBox.Show("Введён неверный формат времени");
            }
            time = Convert.ToDateTime(mtb1.Text);
            try
            {
                string ss = tb4.Text;
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
                    int count = Convert.ToInt32(dtnTable[3, i].Value);
                    if (numbers[i] > 0 && count > 0 && count <= Convert.ToInt32(tbMax.Text))
                    {
                        maxCount += 1;
                    }
                    else
                    {
                        continue;
                    }
                    if (numbers[i] < 0 && count < 0 && count >= Convert.ToInt32(tbMin.Text))
                    {
                        minCount += 1;
                    }
                    else
                    {
                        continue;
                    }

                }
            }
            catch
            {
                MessageBox.Show("Подставь верное значение в строку температура");
            }
        }
        private void result_Click(object sender, EventArgs e)
        {
            TableFish();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            tb1.Text = "";
            tbMin.Text = "";
            tbMax.Text = "";
            tb4.Text = "";
            maxCount = 0;
            minCount = 0;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
