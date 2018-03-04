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
    public partial class DZ2 : Form
    {
        public DZ2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button1.Visible == false)
            {
                button1.Visible = true;
                label1.Text = "Видима";
            }
            else
            {
                button1.Visible = false;
                label1.Text = "Невидима";
            }
        }
    }
}
