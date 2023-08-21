using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Triangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(tLadoA.Text);
            double b = Convert.ToDouble(tLadoB.Text);
            double c = Convert.ToDouble(tLadoC.Text);


        }
    }
}
