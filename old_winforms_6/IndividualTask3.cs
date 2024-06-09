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
    public partial class IndividualTask3 : Form
    {
        public IndividualTask3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);

            if(m%2 != 0)
            {
                MessageBox.Show("Введите четное количество столбцов");

                return;
            }

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
                    dataGridView2.Rows[i].Cells[j].Value = dataGridView1.Rows[i].Cells[j].Value;
                }
            }

            for (int i = 0; i + 1 <= n; i++)
            {
                var c = dataGridView2.Rows[i].Cells[m / 2].Value;
                dataGridView2.Rows[i].Cells[m / 2].Value = dataGridView2.Rows[i].Cells[m / 2 - 1].Value;
                dataGridView2.Rows[i].Cells[m / 2 - 1].Value = c;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
