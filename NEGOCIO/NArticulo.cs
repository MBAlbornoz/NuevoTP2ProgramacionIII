using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOMINIO;
using System.Data.SqlClient;

namespace NEGOCIO
{
    public class NArticulo { 

        //CREAR ALTA ARTICULO
    public void AltaArticulo(Articulo articulo)
    {
        articulo = new Articulo();

    }

    //BAJA LOGICA DE ARTICULO EN LA BASE DE DATOS
    public void bajaArticulo(Articulo articulo) { }

        //BUSQUEDA DE TODOS LOS ARTICULOS EN LA BASE DE DATOS Y LOS DEVUELVE
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            try
            {
                
            }
            
            catch (Exception ex)
            {
                throw ex;
            }
            return listaArticulos;
        }

    //BUSQUEDA ARTICULO
    public void BusquedaArticulo(Articulo articulo)
    {

    }

}
}
