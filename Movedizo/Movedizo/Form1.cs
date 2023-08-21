using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Movedizo
{
    public partial class FMovedizo : Form
    {
        public FMovedizo()
        {
            InitializeComponent();
        }

        private void FMovedizo_Click(object sender, EventArgs e)
        {

            switch (lTitulo.Text)
            {
                case "VERDE": case "GRIS":
                    BackColor = Color.Red;
                    lTitulo.Text = "ROJO";
                    lTitulo.Location = new Point(lTitulo.Location.X + 10, lTitulo.Location.Y + 10);
                    Size = new Size(300-15, 250+10);
                    break;
                case "ROJO":
                    BackColor = Color.Blue;
                    lTitulo.Text = "AZUL";
                    lTitulo.Location = new Point(lTitulo.Location.X - 15, lTitulo.Location.Y);
                    Size = new Size(285 + 20, 260 + 5);
                    break;
                case "AZUL":
                    BackColor = Color.Green;
                    lTitulo.Text = "VERDE";
                    lTitulo.Location = new Point(lTitulo.Location.X - 15, lTitulo.Location.Y - 15);
                    Size = new Size(305 - 5, 265 - 15);
                    break;
            }
        }
    }
}
