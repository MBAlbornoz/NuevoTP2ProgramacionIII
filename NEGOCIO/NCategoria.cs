using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class NCategoria
    {
        public List<Categoria> ListarCategorias()
        {
            AccesoBDatos datos = new AccesoBDatos();

            List<Categoria> listaCategorias = new List<Categoria>();
            Categoria aux = new Categoria();
            try
            {
                datos.SqlCommand.CommandType = System.Data.CommandType.Text;
                datos.SqlCommand.CommandText = "Select Id, Descripcion From CATEGORIAS";
                datos.SqlConnection.Open();
                datos.SqlDataReader = datos.SqlCommand.ExecuteReader();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Categoria((int)datos.SqlDataReader["Id"], (string)datos.SqlDataReader["Descripcion"]);
                    listaCategorias.Add(aux);
                }
                return listaCategorias;
            }
            catch (Exception ex)
            {

                throw ex;
            }
           
        }
    }
}
