using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VueltoCompra
{
    public partial class fVuelto : Form
    {
        public fVuelto()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string cliente = tCliente.Text;
            double compra = Convert.ToDouble(tCompra.Text);
            double pago = Convert.ToDouble(tPago.Text); 
            double vuelto = pago - compra;

            MessageBox.Show($"Cliente: {cliente} \n" +
                $"Valor del pago: ${pago} \n" +
                $"Valor del vuelto: ${vuelto}");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
