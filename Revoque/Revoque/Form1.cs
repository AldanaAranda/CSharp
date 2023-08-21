using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Revoque
{
    public partial class FRevoque : Form
    {
        public FRevoque()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            double ancho = Convert.ToDouble(tAncho.Text);
            double largo = Convert.ToDouble(tLargo.Text);
            double pared = ancho * largo;
            double arena = pared * 0.5;

            MessageBox.Show($"Para una pared de {pared} m2 \n" +
                $"Se necesita {arena} m3 de arena para revocar");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
