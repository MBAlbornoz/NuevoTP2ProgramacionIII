using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class AccesoBDatos
    {
        public SqlDataReader SqlDataReader { get; set; }
        public SqlConnection SqlConnection { get; set; }
        public SqlCommand SqlCommand { get; set; }


        //CIERRA LA CONEXION CON LA BASE DE DATOS SLSERVER
        public void CerrarConexionDB()
        {
            SqlConnection.Close();
        }
    }
}
