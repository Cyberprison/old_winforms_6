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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void оПроектеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void общееЗадание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralTask1 generalTask1 = new GeneralTask1();
            generalTask1.Show();
        }

        private void общееЗадание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralTask2 generalTask2 = new GeneralTask2();
            generalTask2.Show();
        }

        private void общееЗадание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneralTask3 generalTask3 = new GeneralTask3();
            generalTask3.Show();
        }

        private void индивидуальноеЗадание1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualTask1 individualTask1 = new IndividualTask1();
            individualTask1.Show();
        }

        private void индивидуальноеЗадание2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualTask2 individualTask2 = new IndividualTask2();
            individualTask2.Show();
        }

        private void индивидуальноеЗадание3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IndividualTask3 individualTask3 = new IndividualTask3();
            individualTask3.Show();
        }
    }
}
