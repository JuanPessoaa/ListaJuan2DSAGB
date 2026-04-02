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
    public partial class Ex15 : Form
    {
        public Ex15()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float NumA, NumB;
            NumA = float.Parse(textBox1.Text);
            NumB = float.Parse(textBox2.Text);
            label4.Text = NumB.ToString() +" e "+ NumA.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
