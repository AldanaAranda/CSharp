using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaTiempo
{
    public partial class FTiempo : Form
    {
        public FTiempo()
        {
            InitializeComponent();
        }

        private void bSumar_Click(object sender, EventArgs e)
        {
            int seg1 = Convert.ToInt16(tSeg1.Text);
            int seg2 = Convert.ToInt16(tSeg2.Text);
            int min1 = Convert.ToInt16(tMin1.Text);
            int min2 = Convert.ToInt16(tMin2.Text);
            int hora1 = Convert.ToInt16(tHora1.Text);
            int hora2 = Convert.ToInt16(tHora2.Text);

            int segundos = seg1 + seg2;
            int pasoMin = segundos / 60;
            int segTotal = segundos % 60;
            int minutos = min1 + min2 + pasoMin;
            int pasoHora = minutos / 60;
            int minTotal = minutos % 60;
            int hora = hora1 + hora2 + pasoHora;

            MessageBox.Show($"La suma de los dos tiempos es: {hora}: {minTotal}: {segTotal}");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FTiempo_Load(object sender, EventArgs e)
        {

        }
    }
}
