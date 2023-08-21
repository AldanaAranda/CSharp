using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SueldoEmpleado
{
    public partial class FEmpleado : Form
    {
        public FEmpleado()
        {
            InitializeComponent();
        }

        private void bSalario_Click(object sender, EventArgs e)
        {
            string nombre = tEmpleado.Text;
            int ingreso = Convert.ToInt16(tAnio.Text);
            double tarifa = Convert.ToDouble(tTarifa.Text);
            int horas = Convert.ToInt16(tHoras.Text);
            int dias = Convert.ToInt16(tDias.Text);

            double sueldoBruto = tarifa * horas * dias;
            double retenciones = (sueldoBruto * 20) / 100;
            int antiguedad = 2023 - ingreso;
            double TotalAntiguedad = ((sueldoBruto * 1.5) / 100) * antiguedad;

            sueldoBruto = (sueldoBruto - retenciones) + TotalAntiguedad;

            MessageBox.Show($"Nombre del empleado: {nombre} \n" +
                $"Sueldo: ${sueldoBruto}");

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
