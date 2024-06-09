using System;
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
    public partial class GeneralTask2 : Form
    {
        public GeneralTask2()
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

            for (int i = 0; i + 1 <= n; i++)
            {
                for (int j = 0; j + 1 <= m; j++)
                {
                    dataGridView1.Columns[j].Width = 40;
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(-100, 100);
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

