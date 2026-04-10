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
    public partial class Ex10 : Form
    {
        public Ex10()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float larg, comp, alt;
            comp = float.Parse(textBox1.Text);
            larg = float.Parse(textBox2.Text);
            alt = float.Parse(textBox3.Text);
            label6.Text = comp.ToString() +" * "+ larg.ToString() + " * " + alt.ToString() + " = " + (alt * comp * larg).ToString();
        }

        private void Ex10_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label6.Text = "";
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
