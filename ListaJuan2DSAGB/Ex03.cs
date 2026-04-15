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
    public partial class Ex03 : Form
    {
        public Ex03()
        {
            InitializeComponent();
        }

        private void Ex3_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float hora = float.Parse(textBox1.Text);
            float valorhora = float.Parse(textBox2.Text);
            float percdesconto = float.Parse(textBox3.Text);

            float salbruto = hora * valorhora;
            float desconto = ((percdesconto / 100) * salbruto);
            float salliquido = salbruto - desconto;

            label5.Text = "R$ "+salbruto.ToString("F2");
            label7.Text = "R$ " + desconto.ToString("F2");
            label9.Text = "R$ " + salliquido.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
            label7.Text = "";
            label9.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
