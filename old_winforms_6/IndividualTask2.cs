﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace old_winforms_6
{
    public partial class IndividualTask2 : Form
    {
        public IndividualTask2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);

            Random random = new Random();

            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;

            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;

            int[,] mas = new int[n, m];

            int maxValue = -6;
            int flagCountMaxValueInMas = 0;

            for (int i = 0; i + 1 <= n; i++)
            {
                for (int j = 0; j + 1 <= m; j++)
                {
                    dataGridView1.Columns[j].Width = 40;
                    mas[i, j] = random.Next(-5, 5);
                    dataGridView1.Rows[i].Cells[j].Value = mas[i, j];

                    if (mas[i, j] > maxValue)
                    {
                        maxValue = mas[i, j];
                    }
                }
            }

            label5.Text = "...";

            for (int i = 0; i + 1 <= n; i++)
            {
                for (int j = 0; j + 1 <= m; j++)
                {
                    if (mas[i, j] == maxValue)
                    {
                        flagCountMaxValueInMas++;
                    }
                }

                if(flagCountMaxValueInMas >= 2)
                {
                    label5.Text = "True";
                    return;
                }
            }

            label5.Text = "False";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
