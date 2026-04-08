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
            float salbr, sal1, sal2, salliq;

            salbr = float.Parse(textBox1.Text);
            sal1 = salbr - (salbr * 10 / 100);
            label4.Text = $"{int1} / {int2} = {int1 / int2}";
        }
    }
}
