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
           //SqlDataReader=new SqlDataReader();
           SqlConnection=new SqlConnection("data source=MAGGY-PC\\SQLEXPRESS;initial catalog=CATALOGO_DB;integrated security=sspi");
           SqlCommand=new SqlCommand();

        }

        public void seterQuery(String query)
        {
           // SqlCommand.CommandType=System.Data.CommandType.Text();
            SqlCommand.CommandText=query;
        }

        public void ejecutarLector()
        {
            try 
	        {	 
                //ABRE LA CONEXION
                SqlConnection.Open();
                //LEE LA NON QUERY
               // SqlDataReader=SqlCommand.ExecuteNonQuery;
		
	        }
	        catch (Exception ex)
	        {

		    throw ex;
	        }
        }

        //CIERRA LA CONEXION CON LA BASE DE DATOS SLSERVER
        public void CerrarConexionDB()
        {
            SqlConnection.Close();
        }
        
           
    }
   
}
