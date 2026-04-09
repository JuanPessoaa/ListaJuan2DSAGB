using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ListaJuan2DSAGB
{
    public partial class Ex20 : Form
    {
        public Ex20()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            100Application.Exit();
        }

        private void Ex20_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int mat, ano;
            char sem;
            mat = int.Parse(textBox1.Text);
            ano = mat / 10000; //separa os 2 numeros que compoe o ano na matricula
            sem = mat.ToString()[2];//extrai somente o número do semestre
            label5.Text = $"20{ano}";
            label6.Text = $"{sem}º Semestre";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label5.Text = "";
            label6.Text = "";
        }
    }
}
