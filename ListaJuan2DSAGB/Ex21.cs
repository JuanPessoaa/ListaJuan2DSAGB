using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListaJuan2DSAGB
{
    public partial class Ex21 : Form
    {
        public Ex21()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pn, sn, nc;
            pn = textBox1.Text;
            sn = textBox2.Text;
            nc = pn+" "+sn;
            label4.Text = nc;
        }
    }
}
