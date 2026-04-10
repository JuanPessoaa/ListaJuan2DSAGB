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
    public partial class Ex9 : Form
    {
        public Ex9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a, b, c, d;
            a = double.Parse(textBox1.Text);
            b = double.Parse(textBox2.Text);
            c = double.Parse(textBox3.Text);
            d = double.Parse(textBox4.Text);

            label8.Text = a.ToString() + " + " + b.ToString() + " = " + (a + b).ToString();
            label9.Text = a.ToString() + " + " + c.ToString() + " = " + (a + c).ToString();
            label10.Text = a.ToString() + " + " + d.ToString() + " = " + (a + d).ToString();
            label11.Text = b.ToString() + " + " + c.ToString() + " = " + (b + c).ToString();
            label12.Text = b.ToString() + " + " + d.ToString() + " = " + (b + d).ToString();
            label13.Text = c.ToString() + " + " + d.ToString() + " = " + (c + d).ToString();
            label19.Text= a.ToString() + " x " + b.ToString() + " = " + (a * b).ToString();
            label18.Text = a.ToString() + " x " + c.ToString() + " = " + (a * c).ToString();
            label17.Text = a.ToString() + " x " + d.ToString() + " = " + (a * d).ToString();
            label16.Text = b.ToString() + " x " + c.ToString() + " = " + (b * c).ToString();
            label15.Text = b.ToString() + " x " + d.ToString() + " = " + (b * d).ToString();
            label14.Text = c.ToString() + " x " + d.ToString() + " = " + (c * d).ToString();
        }

        private void Ex9_Load(object sender, EventArgs e)
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
            textBox4.Clear();
            label8.Text = "";
            label9.Text = "";
            label10.Text = "";
            label11.Text = "";
            label12.Text = "";
            label13.Text = "";
            label14.Text = "";
            label15.Text = "";
            label16.Text = "";
            label17.Text = "";
            label18.Text = "";
            label19.Text = "";
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
