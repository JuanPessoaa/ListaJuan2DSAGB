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
    public partial class Ex18 : Form
    {
        public Ex18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float salbr, sal1, salliq;

            salbr = float.Parse(textBox1.Text);       
            sal1 = salbr - (salbr * 10 / 100);
            salliq =  sal1 - (sal1 * 5 / 100);
            label4.Text = "R$ "+ salliq.ToString("F2");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label4.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
