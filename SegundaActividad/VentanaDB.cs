using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace SegundaActividad
{
    public partial class VentanaDB : Form
    {
        public VentanaDB()
        {
            InitializeComponent();
        }

        private void VentanaDB_Load(object sender, EventArgs e)
        {

            ArticuloNegocio ArtNeg = new ArticuloNegocio();
            dgvArticulos.DataSource = ArtNeg.listar();
        }

        private void lblContenidoDB_Click(object sender, EventArgs e)
        {

        }
    }
}
