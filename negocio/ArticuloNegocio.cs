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
        public List<Articulo> listar()
        {
            List<Articulo> articulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio from Articulos");
                datos.EjecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    articulos.Add(aux);
                }

                CategoriaNegocio auxCategoria = new CategoriaNegocio();
                List<Categoria> categorias = auxCategoria.listar();

                NegocioMarca auxMarca = new NegocioMarca();
                List<Marca> marcas = auxMarca.listar();

                foreach (Articulo aux in articulos)
                {
                    foreach(Categoria auxCat in categorias)
                    {
                        if(aux.IdCategoria == auxCat.IdCategoria)
                        {
                            aux.Categoria = auxCat;
                        }
                    }

                    foreach (Marca auxMarc in marcas)
                    {
                        if (aux.IdMarca == auxMarc.idMarca)
                        {
                            aux.Marca = auxMarc;
                        }
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
