using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaComponentes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // El evento click del botón cambia la posición del label y el textbox del nuevo componente, y lanza el evento CambiaPosicion
        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            if (labelTextBox1.Posicion == ApuntesT5.ePosicion.DERECHA)
            {
                labelTextBox1.Posicion = ApuntesT5.ePosicion.IZQUIERDA;

                labelTextBox1_CambiaPosicion(sender, EventArgs.Empty);
            }
            else
            {
                labelTextBox1.Posicion = ApuntesT5.ePosicion.DERECHA;

                labelTextBox1_CambiaPosicion(sender, EventArgs.Empty);
            }
        }


        // Este evento establece el valor del título del Form al valor de la propiedad posicion cuando ésta cambia
        private void labelTextBox1_CambiaPosicion(object sender, EventArgs e)
        {
            Text = labelTextBox1.Posicion.ToString();
        }

        // Este evento establece el valor del título del Form al valor de la propiedad separacion cuando ésta cambia
        private void labelTextBox1_CambiaSeparacion(object sender, EventArgs e)
        {
            Text = labelTextBox1.Separacion.ToString();
        }
    }
}
