using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumaDigitos
{
    public partial class FSuma : Form
    {
        public FSuma()
        {
            InitializeComponent();
        }

        private void bCalcular_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt16(tNumero.Text);

            int cifra1 = num / 10;
            int cifra2 = num % 10;

            MessageBox.Show($"La suma de las cifras del numero es: {cifra1+cifra2}");
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
