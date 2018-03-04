using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Yegativ\n\n Компания:AutistbI", "О программе");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lesson2 lesson2 = new Lesson2();
            lesson2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lesson3 lesson3 = new Lesson3();
            lesson3.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DZ2 dz2 = new DZ2();
            dz2.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DZ3 dz3 = new DZ3();
            dz3.Show();
        }
    }
}
