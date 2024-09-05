using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaActividad
{
    public partial class fmrPrincipal : Form
    {
        public fmrPrincipal()
        {
            InitializeComponent();
            
        }

        private void AbrirDBToolStripMenuItem_Click(object sender, EventArgs e)
        { //Aplication.OpenForms es una coleccion de formularios
            //que estan abiertos en ese momento, en 
            foreach (var item in Application.OpenForms) //el foreach reccorre una coleccion
                                                        //y Aplication es una coleccion
            { //el Objeto es un tipo "Ventana" y el VentanaDB es una "Ventana"
                // la igualacion lo manda al return y detiene la ejecucion
                if (item.GetType() == typeof(VentanaDB))
                {
                    MessageBox.Show("Ya existe una ventana abierta");
                    return; 
                }
            }
            /*Esto es asi, el foreach recorre y encuentra si hay otra ventana
             De ese estilo, si existe, lo lleva al return y lo cierra
            por lo que solamente permite utilizar 1 ventana en ese instante
            ---
            el typeof() me devuelve el tipo de ese elemento */
            
            
            
            VentanaDB ventanaDB = new VentanaDB(); // Se debe instanciar la clase
                                                   // En este caso se instancia la ventana como es
                                                   // En el video muestra FORM1, la ventana de el
                                                   // posee ese nombre. Este es VentanaDB
            ventanaDB.MdiParent = this; // Me abre la ventana dentro de la 
                                        // Ventana principal
            ventanaDB.Show(); //Muestra la ventana
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
