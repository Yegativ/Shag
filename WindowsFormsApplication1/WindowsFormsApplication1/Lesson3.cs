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
    public partial class Lesson3 : Form
    {
        public Lesson3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            John();
        }
        void John()
        {
            MessageBox.Show("Добрый день/вечер");
            MessageBox.Show("Очень рады вас видеть");
            MessageBox.Show("Желаем провести время");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Steve(textBox1.Text,textBox2.Text);
        }
        void Steve(string name, string purpose)
        {
            MessageBox.Show("Извините Шеф, к вам гость");
            MessageBox.Show("К вам пришел некий" +name);
            MessageBox.Show("Он хочет устроится" +purpose);
            MessageBox.Show("Мне пропустить его?");
        }
        int Zero()
        {
            return 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Convert.ToString(Zero()));
        }
    }
}
