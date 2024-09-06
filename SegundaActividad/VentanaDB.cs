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
            pbxProducto.Load(Articulos[0].UrlImagen);
            dgvArticulos.DataSource = Articulos;
            dgvArticulos.Columns["IdCategoria"].Visible = false;
            dgvArticulos.Columns["IdMarca"].Visible = false;
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            pnlFondo.Visible = true;
            
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
           
            
            try
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                pbxProducto.Load(seleccionado.UrlImagen);
            }
            catch (Exception)
            {
                pbxProducto.Load("https://plus.unsplash.com/premium_photo-1682310093719-443b6fe140e8?q=80&w=1824&auto=format&fit=crop&ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D");
            }
        }
    }
}
