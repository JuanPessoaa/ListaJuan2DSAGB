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

namespace ListaJuan2DSAGB
{
    public partial class Ex12 : Form
    {
        public Ex12()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2;
            n1 = int.Parse(textBox1.Text);
            n2 = int.Parse(textBox2.Text);
            label5.Text = "(" + n1.ToString() + " + " + n2.ToString() +")^2 = "+ (n1 + n2) * (n1 + n2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Ex12_Load(object sender, EventArgs e)
        {

        }
    }
}
