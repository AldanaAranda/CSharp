using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntercambioDato
{
    public partial class fIntercambio : Form
    {
        public fIntercambio()
        {
            InitializeComponent();
        }

        private void bIntercambiar_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt16(tNum1.Text);
            int b = Convert.ToInt16(tNum2.Text);
            int aux = a;
            a = b;
            b = aux;

            MessageBox.Show($"Primer numero: {a} \n" +
                $"Segundo numero: {b}");

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
