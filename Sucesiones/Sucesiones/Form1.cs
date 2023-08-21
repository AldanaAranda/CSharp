using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sucesiones
{
    public partial class FSucesiones : Form
    {
        public FSucesiones()
        {
            InitializeComponent();
        }

        private void LRespuesta_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea borrar esta respuesta" , "Respuesta" , 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(respuesta == DialogResult.Yes)
            {
                MessageBox.Show("Se borrara la respuesta");
                LRespuesta.Text = "";
            }
            else
            {
                MessageBox.Show("No se borrara la respuesta");
            }
        }

        private void BTablaMultiplicar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt16(nudTabla.Value);
            string tabla = "";
            int contador = 0;

            while(contador <= 10)
            {
                tabla += ($"{numero} x {contador} = {(numero * contador):00} \n");
                contador += 1;
            }
            
            LRespuesta.Text = ($"Tabla del {numero} \n" +
                $"{tabla}");
            LRespuesta.Visible = true;
        }
        private void BFibonacci_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt16(nudFibonacci.Value);
            int i = 1;
            int j = 1;
            int k = 0;
            string fibo = "";

            for(int contador = 1; contador <= numero; contador++)
            {
                fibo += ($"{i}\n");
                k = i + j;
                i = j;
                j = k;
            }
            LRespuesta.Text = ($"Fibonacci de {numero} \n" +
                $"{fibo}");
            LRespuesta.Visible = true;
        }

        private void bSerie_Click(object sender, EventArgs e)
        {
            int desde = Convert.ToInt16(nudDesde.Value);
            int hasta = Convert.ToInt16(nudHasta.Value);
            int cada = Convert.ToInt16(nudCada.Value);
            string serie = "";

            do
            {
                if(desde < hasta)
                {
                    serie += ($"{desde} \n");
                    desde += cada;
                }
                else
                {
                    MessageBox.Show("Lo siento, el numero desde debe ser menor al numero hasta");
                }
            } while (desde < hasta);

            LRespuesta.Text = ($"{serie}");
            LRespuesta.Visible = true;
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("Desea salir de la aplicacion", "Cerrar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(opcion == DialogResult.Yes)
            {
                MessageBox.Show("Nos vemos");
                Close();
            }
            else
            {
                MessageBox.Show("No se cerrará");
            }
        }
    }
}
