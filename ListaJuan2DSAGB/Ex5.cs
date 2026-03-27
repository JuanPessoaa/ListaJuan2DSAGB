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
    public partial class Ex5 : Form
    {
        public Ex5()
        {
            InitializeComponent();
        }

        private void Ex5_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gf, gc;

            gf = double.Parse(textBox1.Text);
            gc = (gf - 32.0) * (5.0 / 9.0);
            label4.Text = gc.ToString() + "°C";
            textBox1.Text = gf + "°F";
        }
    }
}
