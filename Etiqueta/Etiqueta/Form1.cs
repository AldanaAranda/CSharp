using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Etiqueta
{
    public partial class FEtiqueta : Form
    {
        public FEtiqueta()
        {
            InitializeComponent();
        }

        private void TTexto_TextChanged(object sender, EventArgs e)
        {
            LEtiqueta.Text = TTexto.Text.ToUpper();
        }

        private void nudLetra_ValueChanged(object sender, EventArgs e)
        {
            if(nudLetra.Value == 2)
            {
                LEtiqueta.Font = new Font("Yu Gothic UI", LEtiqueta.Font.Size);
                LLetra.Text = "Yu Gothic UI";
            }
            else if(nudLetra.Value == 3)
            {
                LEtiqueta.Font = new Font("Informal Roman", LEtiqueta.Font.Size);
                LLetra.Text = "Informal Roman";
            }
            else if(nudLetra.Value == 4)
            {
                LEtiqueta.Font = new Font("Harrington", LEtiqueta.Font.Size);
                LLetra.Text = "Harrington";
            }
            else
            {
                LEtiqueta.Font = new Font("Algerian", LEtiqueta.Font.Size);
                LLetra.Text = "Algerian";
            }
        }

        private void BColor_Click(object sender, EventArgs e)
        {

            if (LEtiqueta.ForeColor == Color.Black)
            {
                LEtiqueta.ForeColor = Color.Blue;
            }
            else if (LEtiqueta.ForeColor == Color.Blue)
            {
                LEtiqueta.ForeColor = Color.Red;
            }
            else if (LEtiqueta.ForeColor == Color.Red)
            {
                LEtiqueta.ForeColor = Color.Green;
            }
            else
            {
                LEtiqueta.ForeColor = Color.Black;
            }
        }

        private void BTamanioMenos_Click(object sender, EventArgs e)
        {
            BTamanioMas.Enabled = true;
            if (LEtiqueta.Font.Size > 10)
            {
                LEtiqueta.Font = new Font(LEtiqueta.Font.FontFamily, LEtiqueta.Font.Size - 2);
            }
            else
            {
                BTamanioMenos.Enabled = false;
                MessageBox.Show("Ha llegado al límite inferior");
            }
        }

        private void BTamanioMas_Click(object sender, EventArgs e)
        {
            BTamanioMenos.Enabled = true;
            if(LEtiqueta.Font.Size < 20)
            {
                LEtiqueta.Font = new Font(LEtiqueta.Font.FontFamily, LEtiqueta.Font.Size + 2);
            }
            else
            {
                BTamanioMas.Enabled = false;
                MessageBox.Show("Ha llegado al límite superior");
            }
        }
    }
}
