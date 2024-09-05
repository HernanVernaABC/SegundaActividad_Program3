using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace negocio
{
    public class AccesoDatos
    {
        private SqlConnection conexion; //Me crea la conexion con la DB
        private SqlCommand comando; // Declara acciones, comandos
        private SqlDataReader lector; // lee los objetos de la DB
        public SqlDataReader Lector
        {
            get { return lector; }
        }


        public AccesoDatos()
        {
            conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_P3_DB; integrated security=true");
            // Le digo a donde me quiero conectar
            comando = new SqlCommand(); // creo la instancia de comando
            comando.Connection = conexion; // le digo que se contecte, donde? Lo que esta guardado en conexion
                                           // que ya esta instanciado arriba
        } 
        public void setearConsulta(string consulta)
        {
            comando.CommandType = System.Data.CommandType.Text; 
            comando.CommandText = consulta; //El nombre de las tablas 
        }
       /* public void LeerTodo()
        {
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "Select Codigo, Nombre, A.Descripcion, Precio, M.Descripcion, C.Descripcion from Articulos A, Marcas M, Categorias C"; 
        }*/
        public void EjecutarLectura()
        {
            comando.Connection = conexion;
            try
            {
                conexion.Open();
                lector = comando.ExecuteReader();

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }


        public void CerrarConexion()
        {
            if (lector != null)
                lector.Close(); 
            conexion.Close(); 
        } 


    }
}
