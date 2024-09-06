using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using dominio;


namespace negocio
{
    public class ArticuloNegocio
    {
        private string articuloAnterior = "";
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("SELECT A.Id, A.Precio, A.IdCategoria, A.IdMarca, A.Codigo, A.Nombre, A.Descripcion, I.ImagenUrl ,C.Descripcion AS DesCategoria, M.Descripcion AS DesMarca FROM ARTICULOS A JOIN CATEGORIAS C ON A.IdCategoria = C.Id JOIN MARCAS M ON A.IdMarca = M.Id JOIN IMAGENES I ON A.Id = I.IdArticulo");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    if(articuloAnterior != (string)datos.Lector["Codigo"])
                    { 
                        Articulo aux = new Articulo();
                        aux.Codigo = (string)datos.Lector["Codigo"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        aux.Precio = (decimal)datos.Lector["Precio"];
                        aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                        aux.IdMarca = (int)datos.Lector["IdMarca"];
                        aux.Categoria = new Categoria();
                        aux.Categoria.Descripcion = (string)datos.Lector["DesCategoria"];
                        aux.Marca = new Marca();
                        aux.Marca.Descripcion = (string)datos.Lector["DesMarca"];
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                        articulos.Add(aux);
                        articuloAnterior = aux.Codigo;
                    }
                }


                return articulos;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public int cargarArticulo()
        {
            return 0;
        }

    }
}
