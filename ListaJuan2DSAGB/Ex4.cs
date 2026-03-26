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
    public partial class Ex4 : Form
    {
        public Ex4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double gc, gf;
            gc = double.Parse(textBox1.Text);
            gf = (9 * gc + 160) / 5;
            label4.Text = gf.ToString()+"°F";
            textBox1 .Text = gc+"°C";
        }
    }
}
