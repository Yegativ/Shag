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
    public partial class Lesson2 : Form
    {
        int mouseMove = 0;
        public Lesson2()
        {
            InitializeComponent();
        }

        private void tabPage1_MouseMove(object sender, MouseEventArgs e)
        {
            mouseMove++;
            Text = "Ты прошел расстояния: " + mouseMove;
        }
    }
}
