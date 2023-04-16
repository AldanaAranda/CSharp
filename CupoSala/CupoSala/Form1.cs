using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CupoSala
{
    public partial class FSala : Form
    {
        public FSala()
        {
            InitializeComponent();
        }

        private void bPorcentaje_Click(object sender, EventArgs e)
        {
            int cupo = Convert.ToInt16(tCupo.Text);
            int actual = Convert.ToInt16(tCantidad.Text);

            double porcentaje = (actual * 100) / cupo;

            MessageBox.Show($"La sala está: {porcentaje}% ocupada");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bIngreso_Click(object sender, EventArgs e)
        {
            int persona = Convert.ToInt16(tCantidad.Text);
            persona = ++persona;
            MessageBox.Show($"La sala ahora tiene {persona} persona/as");
        }

        private void bSalida_Click(object sender, EventArgs e)
        {
            int persona = Convert.ToInt16(tCantidad.Text);
            int decremento = persona--;
            MessageBox.Show($"La sala ahora tiene {persona} persona/as");
        }
    }
}
