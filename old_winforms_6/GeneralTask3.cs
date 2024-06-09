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
    public partial class GeneralTask3 : Form
    {
        public GeneralTask3()
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

            dataGridView2.RowCount = n;
            dataGridView2.ColumnCount = m;

            dataGridView2.ColumnHeadersVisible = false;
            dataGridView2.RowHeadersVisible = false;

            for (int i = 0; i + 1 <= n; i++)
            {
                for (int j = 0; j + 1 <= m; j++)
                {
                    dataGridView1.Columns[j].Width = 40;
                    dataGridView1.Rows[i].Cells[j].Value = random.Next(-100, 100);
                    
                    dataGridView2.Columns[j].Width = 40;
                    dataGridView2.Rows[i].Cells[j].Value = Math.Pow(Convert.ToInt32(dataGridView1.Rows[i].Cells[j].Value), 2);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
