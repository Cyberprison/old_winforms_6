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
    public partial class GeneralTask1 : Form
    {
        public GeneralTask1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);

            textBox3.Clear();

            for (int i = 0; i + 1 <= n; i++)
            {
                for (int j = 0; j + 1 <= m; j++)
                {
                    textBox3.Text += $"{i * j} \t";
                }
                textBox3.Text += " \r\n";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
