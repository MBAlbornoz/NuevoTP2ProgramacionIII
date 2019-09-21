using DOMINIO;
using System;
using System.Collections.Generic;

namespace NEGOCIO
{
    public class NArticulo
    {

        //CREAR ALTA ARTICULO
        public void AltaArticulo(Articulo articulo)
        {/*
            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection sqlConnection = new SqlConnection();

            try
            {
                sqlConnection.ConnectionString = ("data source=.\\SQLEXPRESS;initial catalog=CATALOGO_DB;integrated security=sspi");
                sqlCommand.CommandType = System.Data.CommandType.Text;
                sqlCommand.Connection = sqlConnection;
                sqlCommand.CommandText = "INSERT INTO ARTICULOS VALUES(@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@Imagen,@Precio)";
                sqlCommand.Parameters.Clear();
               
                sqlCommand.Parameters.AddWithValue("@Codigo", articulo.Codigo);
                sqlCommand.Parameters.AddWithValue("@Nombre", articulo.Nombre);
                sqlCommand.Parameters.AddWithValue("@Descripcion", articulo.Descripcion);
                sqlCommand.Parameters.AddWithValue("@IdMarca", articulo.Marca.Id);
                sqlCommand.Parameters.AddWithValue("@IdCategoria", articulo.Categoria.Id);
                sqlCommand.Parameters.AddWithValue("@Imagen", articulo.Imagen);
                sqlCommand.Parameters.AddWithValue("@Precio", articulo.Precio);

                sqlCommand.Connection = sqlConnection;
                sqlConnection.Open();
                sqlCommand.ExecuteNonQuery(); */
         ///////////////////////////////////////////
            AccesoBDatos bDatos = new AccesoBDatos();


            try
            {
                string query = "INSERT INTO ARTICULOS VALUES('" + articulo.Codigo + "' ,'" + articulo.Nombre + "' ,'" + articulo.Descripcion + "' ,'" + articulo.Marca.Id + "' ,'" + articulo.Categoria.Id + "' ,'" + articulo.Imagen + "' ,'" + articulo.Precio + "' )";

                bDatos.seterQuery(query);
                bDatos.ejecutarAccion();
                bDatos.CerrarConexionDB();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //BAJA LOGICA DE ARTICULO EN LA BASE DE DATOS
        public void bajaArticulo(Articulo articulo) { }

        //BUSQUEDA DE TODOS LOS ARTICULOS EN LA BASE DE DATOS Y LOS DEVUELVE
        public List<Articulo> ListarArticulos()
        {
            AccesoBDatos datos = new AccesoBDatos();

            List<Articulo> listaArticulos = new List<Articulo>();
            Articulo aux = new Articulo();
            try
            {
                datos.SqlCommand.CommandType = System.Data.CommandType.Text;
                datos.SqlCommand.CommandText = "SELECT A.Id, A.Codigo, A.Nombre,A.Descripcion, A.Imagen, A.Precio, M.Descripcion AS 'Marca', C.Descripcion AS 'Categoria'  FROM ARTICULOS as A INNER JOIN MARCAS AS M ON A.IdMarca=M.Id INNER JOIN CATEGORIAS AS C ON A.IdCategoria=C.Id";
                //datos.SqlCommand.CommandText = "SELECT A.ID AS 'ID_A', A.CODIGO, A.NOMBRE, A.DESCRIPCION, M.ID AS 'ID_MARCA', M.DESCRIPCION AS 'MARCA',C.ID AS 'ID_CAT',C.DESCRIPCION AS'CATEGORIA'FROM ARTICULOS AS A INNER JOIN MARCAS AS M ON A.Id=M.Id INNER JOIN CATEGORIAS AS C ON A.Id=C.Id";


                datos.SqlConnection.Open();
                datos.SqlDataReader = datos.SqlCommand.ExecuteReader();

                while (datos.SqlDataReader.Read())
                {
                    aux = new Articulo();
                    aux.id = (int)datos.SqlDataReader["Id"];
                    aux.Codigo = (string)datos.SqlDataReader["Codigo"];
                    aux.Nombre = (string)datos.SqlDataReader["Nombre"].ToString();
                    aux.Descripcion = datos.SqlDataReader["Descripcion"].ToString();
                    aux.Imagen = datos.SqlDataReader["Imagen"].ToString();
                    
                    aux.Precio = float.Parse(datos.SqlDataReader["Precio"].ToString());
                    
                    //MARCA
                    aux.Marca = new Marca();
                   // aux.Marca.Id = (int)datos.SqlDataReader["ID_MARCA"];
                    aux.Marca.Descripcion = (string)datos.SqlDataReader["Marca"].ToString();
                    //CATEGORIAS
                    aux.Categoria = new Categoria();
                   // aux.Categoria.Id = (int)datos.SqlDataReader["ID_CAT"];
                    aux.Categoria.Descripcion = (string)datos.SqlDataReader["Categoria"].ToString();
                    
                    listaArticulos.Add(aux);
                }

                return listaArticulos;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        //BUSQUEDA ARTICULO
        public void BusquedaArticulo(Articulo articulo)
        {

        }

    }
}
