using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace dominio

{
    public class Articulo
    {
        public string Codigo {  get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        public int IdMarca { get; set; }
        public Marca Marca { get; set; }
        public int IdCategoria { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        
    }
}