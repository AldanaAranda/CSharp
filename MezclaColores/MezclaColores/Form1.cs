using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MezclaColores
{
    public partial class FColores : Form
    {
        int contadorA = 0;
        int contadorR = 0;
        int contadorZ = 0;
        public FColores()
        {
            InitializeComponent();
        }

        private void BAmarillo_Click(object sender, EventArgs e)
        {
            if(BackColor == Color.Blue)
            {
                BackColor = Color.Green;
            }
            else if(BackColor == Color.Red)
            {
                BackColor = Color.Orange;
            }
            else if(BackColor == Color.Purple)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Yellow;
            }

            if(bCerrar.Enabled == false)
            {
            bCerrar.Enabled = true;
            bCerrar.Visible = true;

            }

            ++contadorA;
        }

        private void BAzul_Click(object sender, EventArgs e)
        {
            if(BackColor == Color.Yellow)
            {
                BackColor = Color.Green;
            }
            else if(BackColor == Color.Red)
            {
                BackColor = Color.Purple;
            }
            else if(BackColor == Color.Orange)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Blue;
            }

            if (bCerrar.Enabled == false)
            {
                bCerrar.Enabled = true;
                bCerrar.Visible = true;

            }

            ++contadorZ;
        }

        private void BRojo_Click(object sender, EventArgs e)
        {
            if(BackColor == Color.Yellow)
            {
                BackColor = Color.Orange;
            }
            else if(BackColor == Color.Blue)
            {
                BackColor = Color.Purple;
            } 
            else if(BackColor == Color.Green)
            {
                BackColor = Color.Black;
            }
            else
            {
                BackColor = Color.Red;
            }


            if (bCerrar.Enabled == false)
            {
                bCerrar.Enabled = true;
                bCerrar.Visible = true;

            }
            ++contadorR;
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            string primero, segundo, tercero;
            primero = "";
            segundo = "";
            tercero = "";
            /*int first, second, third;
            first = 0;*/

            /*int contador1 = (contadorA > contadorR) ? (contadorA > contadorZ) ? first = contadorA : first = contadorZ : (contadorR > contadorZ) ? first = contadorR : first = contadorZ;
            string intento1 = (contadorA > contadorR) ? (contadorA > contadorZ) ?  primero = "Color Amarillo: " + contadorA + " veces" : primero = "Color Azul: " + contadorZ + " veces" : (contadorR > contadorZ) ? primero = "Color Rojo: " + contadorR + " veces" : primero = "Color Azul: " + contadorZ + " veces";
            string intento2 = (first == contadorA) ? (contadorR > contadorZ) ? segundo = "Color Rojo: " + contadorR + " veces" : segundo = "Color Azul: " + contadorZ + " veces" : (first == contadorR) ? (contadorA > contadorZ) ? segundo = "Color Amarillo: " + contadorA + " veces" : segundo = "Color Azul: " + contadorZ + " veces" : (first == contadorZ) ? (contadorA > contadorR) ? segundo = "Color Amarillo: " + contadorA + " veces" : segundo = "Color Rojo: " + contadorR + " veces" : "Volve a intentarlo";*/



             if (contadorA > contadorR)
             {
                 if(contadorA > contadorZ)
                 {
                     if(contadorR > contadorZ)
                     {
                         segundo = "Color Rojo: " + contadorR + " veces";
                         tercero = "Color Azul" + contadorZ + " veces";
                     }
                    else { 
                         segundo = "Color Azul: " + contadorZ + " veces";
                         tercero = "Color Rojo: " + contadorR + " veces";
                     }

                     primero = "Color Amarillo: " + contadorA + " veces";
                 }
             }
             if(contadorZ > contadorA)
             {
                 if(contadorZ > contadorR)
                 {
                     if(contadorR > contadorA)
                     {
                         segundo = "Color Rojo: " + contadorR + " veces";
                         tercero = "Color Amarillo: " + contadorA + " veces";
                     }
                     else
                     {
                         segundo = "Color Amarillo: " + contadorA + " veces";
                         tercero = "Color Rojo: " + contadorR + " veces";
                     }
                     primero = "Color Azul: " + contadorZ + " veces";
                 }
             }
             if(contadorR > contadorA)
             {
                 if(contadorR > contadorZ)
                 {
                     if(contadorA > contadorZ)
                     {
                         segundo = "Color Amarillo: " + contadorA + " veces";
                         tercero = "Color Azul: " + contadorZ + " veces";
                     }
                     else
                     {
                         segundo = "Color Azul: " + contadorZ + " veces";
                         tercero = "Color Amarillo: " + contadorA + " veces";
                     }
                     primero = "Color Rojo: " + contadorR + " veces";
                 }
             }

            MessageBox.Show($"1°. - {primero} \n" +
                $"2°. - {segundo} \n" +
                $"3°. - {tercero} \n");

            Close();
            
        }
    }
}
