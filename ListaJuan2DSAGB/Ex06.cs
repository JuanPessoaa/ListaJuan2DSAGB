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
    public partial class Ex06 : Form
    {
        public Ex06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float vol, pi = 3.14159F, raio, alt;
            raio = float.Parse(textBox1.Text);
            alt = float.Parse(textBox2.Text);
            vol = pi * (raio * raio) * alt;
            label5.Text = Math.Round(vol, 2).ToString();
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

        private void Ex6_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}