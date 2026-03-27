using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaJuan2DSAGB
{
    public partial class Ex8 : Form
    {
        public Ex8()
        {
            InitializeComponent();
        }

        private void Ex8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c;

            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);

            c = a;
            a = b;
            b = c;

            label4.Text = "A = "+ a.ToString();
            label5.Text = "B = " + b.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
