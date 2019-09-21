using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;

namespace NEGOCIO
{
    public class NMarca
    {
        public List<Marca>ListarMarcas()
        {
            AccesoBDatos datos = new AccesoBDatos();

            List<Marca> listaMarcas = new List<Marca>();
            Marca aux = new Marca();
            try
            {
                datos.SqlCommand.CommandType = System.Data.CommandType.Text;
                datos.SqlCommand.CommandText = "Select Id, Descripcion From MARCAS";
                datos.SqlConnection.Open();
                datos.SqlDataReader = datos.SqlCommand.ExecuteReader();

                while(datos.SqlDataReader.Read())
                {
                    aux = new Marca((int)datos.SqlDataReader["Id"], (string)datos.SqlDataReader["Descripcion"]);
                    listaMarcas.Add(aux);
                }
                return listaMarcas;
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
        }
    }
}
