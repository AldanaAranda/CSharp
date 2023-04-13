using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConversionGB
{
    public partial class fConversion : Form
    {
        public fConversion()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            string nombre = tArchivo.Text;
            int mb = Convert.ToInt32(tDimension.Text);

            int gb = mb / 1024;

            MessageBox.Show($"El archivo {nombre} tiene {mb} MB \n" +
                $"El tamaño del mismo en GB es: {gb}");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
