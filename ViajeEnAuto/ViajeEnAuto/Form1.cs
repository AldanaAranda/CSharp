using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViajeEnAuto
{
    public partial class FViaje : Form
    {
        public FViaje()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string lugar = tLugar.Text;
            double distancia = Convert.ToDouble(tDistancia.Text);
            double velocidad = Convert.ToDouble(tVelocidad.Text);

            double tiempo = distancia / velocidad;

            MessageBox.Show($"Lugar a viajar: {lugar} \n" +
                $"El tiempo que durará el viaje es de: {tiempo} hora/as");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
