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
    public partial class Ex7 : Form
    {
        public Ex7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double hr, vel, combs, dist;
            hr = double.Parse(textBox1.Text);
            vel = double.Parse(textBox2.Text);
            dist = hr * vel;
            combs = dist / 12;
            label8.Text = vel.ToString()+" Km/h";
            label9.Text = hr.ToString() + " horas";
            label10.Text = dist.ToString() + " Km";
            label11.Text = Math.Round(combs, 2).ToString() + " Litros";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label8.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Ex7_Load(object sender, EventArgs e)
        {

        }
    }
}
