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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            float raio, area, pi;
            raio = float.Parse(textBox1.Text);
            area = (raio * raio); 

           
        }
    }
}
//1.Faça um algoritmo para calcular a área de uma circunferência, considerando a fórmula ÁREA = π * RAIO2. 
//Utilize as variáveis AREA e RAIO, a constante π (pi = 3,14159) e os operadores aritméticos de multiplicação.
