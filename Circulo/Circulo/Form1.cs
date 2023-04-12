using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Circulo
{
    public partial class fCirculo : Form
    {
        public fCirculo()
        {
            InitializeComponent();
        }

        private void bArea_Click(object sender, EventArgs e)
        {
            double centimetros = Convert.ToDouble(tCentimetros.Text);
            double metros = Convert.ToDouble(tMetros.Text);
            double kilometros = Convert.ToDouble(tKilometros.Text);

            double areaCm = 3.14159 * centimetros * centimetros;
            double areaM = 3.14159 * metros * metros;
            double areaKm = 3.14159 * kilometros * kilometros;

            MessageBox.Show($"El area del circulo con radio {centimetros} cm es de {areaCm} cm2 \n" +
                $"El area del circulo con radio {metros} m es de {areaM} m2 \n" +
                $"El area del circulo con radio {kilometros} km es de {areaKm} km2");
        }

        private void bPerimetro_Click(object sender, EventArgs e)
        {
            double cm = Convert.ToDouble(tCentimetros.Text);
            double m = Convert.ToDouble(tMetros.Text);
            double km = Convert.ToDouble(tKilometros.Text);

            double perimetroCm = 2 * 3.14159 * cm;
            double perimetroM = 2 * 3.14159 * m;
            double perimetroKm = 2 * 3.14159 * km;

            MessageBox.Show($"El perimetro del circulo con un radio de {cm} cm es de {perimetroCm} cm2 \n" +
                $"El perimetro del circulo con un radio de {m} m es de {perimetroM} m2 \n" +
                $"El perimetro del circulo con un radio de {km} km es de {perimetroKm} km2");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
