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
        private List<Articulo> Articulos;
        public VentanaDB()
        {
            InitializeComponent();
        }

        private void VentanaDB_Load(object sender, EventArgs e)
        {
            pnlFondo.Visible = false;
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ArticuloNegocio ArtNeg = new ArticuloNegocio();

            Articulos = ArtNeg.listar();

            dgvArticulos.DataSource = Articulos;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = true;
        }
    }
}
