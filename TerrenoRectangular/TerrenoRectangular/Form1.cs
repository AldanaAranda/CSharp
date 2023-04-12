using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TerrenoRectangular
{
    public partial class fTerreno : Form
    {
        public fTerreno()
        {
            InitializeComponent();
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string direccion = tDireccion.Text;
            double ancho = Convert.ToDouble(tAncho.Text);
            double largo = Convert.ToDouble(tLargo.Text);

            double area = ancho * largo;

            MessageBox.Show($"Terreno ubicado en: {direccion}\n" +
                            $"Area: {area} metros cubicos");
        }
    }
}
