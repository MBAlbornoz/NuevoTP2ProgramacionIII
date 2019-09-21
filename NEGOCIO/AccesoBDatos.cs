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

        

        public AccesoBDatos()
        {
           //SqlConnection = new SqlConnection("data source=MAGGY-PC\\SQLEXPRESS;initial catalog=CATALOGO_DB;integrated security=sspi");
           SqlConnection = new SqlConnection("data source=.\\SQLEXPRESS;initial catalog=CATALOGO_DB;integrated security=sspi");
           SqlCommand=new SqlCommand();
           SqlCommand.Connection = SqlConnection;

        }

        public void seterQuery(String query)
        {
            SqlCommand.CommandType=System.Data.CommandType.Text;
            SqlCommand.CommandText=query;
        }

        public void ejecutarLector()
        {
            try 
	        {	 
                //ABRE LA CONEXION
                SqlConnection.Open();
                //LEE LA NON QUERY
                SqlDataReader = SqlCommand.ExecuteReader();
		
	        }
	        catch (Exception ex)
	        {

		    throw ex;
	        }
        }
        public void ejecutarAccion()
        {
            try
            {
                SqlConnection.Open();
                SqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                SqlConnection.Close();
            }
        }

        //CIERRA LA CONEXION CON LA BASE DE DATOS SLSERVER
        public void CerrarConexionDB()
        {
            SqlConnection.Close();
        }

        public void agregarParametro(string nombre, object valor)
        {
            SqlCommand.Parameters.AddWithValue(nombre, valor);
        }


    }
   
}
