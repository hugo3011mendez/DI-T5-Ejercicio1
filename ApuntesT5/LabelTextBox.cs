using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ApuntesT5
{
    // La diferencia entre ponerlo aquí y ponerlo dentro de la clase LabelTextBox es que para acceder se hará "ApuntesT5.ePosicion" en vez de "ApuntesT5.LabelTextBox.ePosicion"
    public enum ePosicion
    {
        IZQUIERDA, DERECHA
    }


    public partial class LabelTextBox : UserControl
    {
        // Inicializamos todo cuando cargue
        public LabelTextBox()
        {
            InitializeComponent();

            TextLbl = Name;
            TextTxt = "";
            recolocar();
        }

        // Voy a crear un nuevo evento para LabelTextBox
        // Es un evento que se lanza si se detecta un cambio de posición para lbl respecto de txt  
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Posición cambia")]
        public event EventHandler CambiaPosicion;


        // Este evento se lanza si se detecta un cambio de la propiedad separacion
        [Category("La propiedad cambió")]
        [Description("Se lanza cuando la propiedad Separación cambia")]
        public event EventHandler CambiaSeparacion;

        private ePosicion posicion = ePosicion.IZQUIERDA;


        // Category y Description se usan para cuando se implemente el nuevo componente en un Form, que se vea la categoría y la descripción de este en la GUI
        [Category("Appearance")]
        [Description("Indica si la Label se sitúa a la IZQUIERDA o DERECHA del Textbox")]
        public ePosicion Posicion // Creo set y get para la variable posicion
        {
            set
            {
                if (Enum.IsDefined(typeof(ePosicion), value)) // Si el valor de posicion es válido
                {
                    posicion = value;
                    recolocar();

                    if (CambiaPosicion != null) // Compruebo que el nuevo evento no sea null, es decir, que tenga un método asociado
                    {
                        CambiaPosicion(this, EventArgs.Empty); // Añado el evento creado al set de la variable posicion
                    }
                }
                else // Si el valor de posicion no es válido
                {
                    throw new InvalidEnumArgumentException();
                }
            }
            get
            {
                return posicion;
            }
        }



        // Píxeles de separación entre Label y TextBox
        private int separacion = 0;
        [Category("Design")]
        [Description("Píxeles de separación entre Label y Textbox")]
        public int Separacion // Set y Get de los píxeles de separación entre los componentes
        {
            set
            {
                if (value >= 0) // Si el número introducido es mayor o igual que 0
                {
                    separacion = value;
                    recolocar();

                    if (CambiaSeparacion != null) // Compruebo que el nuevo evento no sea null, es decir, que tenga un método asociado
                    {
                        CambiaSeparacion(this, EventArgs.Empty); // Y lanzo el evento cuando se cambia la separación
                    }
                }
                else // Si el número introducido es negativo, se lanza una excepción
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            get
            {
                return separacion;
            }
        }


        // Category, Description, Set y Get para el texto de la etiqueta
        [Category("Appearance")]
        [Description("Texto asociado a la Label del control")]
        public string TextLbl
        {
            set
            {
                lbl.Text = value;
                recolocar();
            }
            get
            {
                return lbl.Text;
            }
        }


        // Category, Description, Set y Get para el texto del TextBox
        [Category("Appearance")]
        [Description("Texto asociado al TextBox del control")]
        public string TextTxt
        {
            set
            {
                txt.Text = value;
            }
            get
            {
                return txt.Text;
            }
        }


        // Función que se encargará de cambiar los Location de los componentes dependiendo de ePosicion
        void recolocar()
        {
            switch (posicion)
            {
                case ePosicion.DERECHA:
                    // Establecemos posición del componente txt
                    txt.Location = new Point(0, 0);

                    // Establecemos ancho del Textbox (la label tiene ancho fijo)
                    txt.Width = this.Width - lbl.Width - Separacion;

                    // Establecemos posición del componente lbl
                    lbl.Location = new Point(txt.Width + Separacion, 0);

                    // Establecemos altura del componente
                    this.Height = Math.Max(txt.Height, lbl.Height);

                    break;

                case ePosicion.IZQUIERDA:
                    // Lo mismo que en el caso que sea DERECHA
                    lbl.Location = new Point(0, 0);

                    txt.Location = new Point(lbl.Width + Separacion, 0);

                    txt.Width = this.Width - lbl.Width - Separacion;

                    this.Height = Math.Max(txt.Height, lbl.Height);

                    break;
            }
        }


        // Cada vez que se cambie el tamaño de este nuevo componente, hago que se recoloque todo para que se muestre mejor en el Form final
        private void LabelTextBox_SizeChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Cambio de tamaño");
        }

        // Si no se tiene acceso, creamos la función "On" de SizeChanged desde la que lanzamos el evento SizeChanged real del nuevo componente
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            recolocar();
        }
    }
}
