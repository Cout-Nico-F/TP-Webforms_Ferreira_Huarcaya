using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using System.Data.SqlClient;

namespace Negocios
{
    public class ArticulosNegocio
    {
        public List<Articulo> ListarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();

            ConexionMSSQL conexion = new ConexionMSSQL();

            conexion.Conectar();
            string consulta = "select a.codigo, a.nombre, a.descripcion, a.imagenUrl, a.precio, m.descripcion as Marca , c.descripcion as Categoria, a.id As IDArticulo, c.id As IDCategoria, m.id As IDMarca from articulos a left join categorias c on a.idcategoria = c.id inner join marcas m on a.idmarca = m.id";

            conexion.SetConsulta(consulta);

            SqlDataReader lectura =  conexion.Leer();


            while (lectura.Read())
            {
                Articulo aux = new Articulo();
                aux.Marca = new Marca();
                aux.Categoria = new Categoria();

                aux.Codigo = lectura.GetString(0);
                aux.Nombre = lectura.GetString(1);
                aux.Descripcion = lectura.GetString(2);
                aux.Precio = lectura.GetDecimal(4);
                try
                {
                    aux.ImagenUrl = lectura.GetString(3);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    aux.ImagenUrl = " No contiene una Direccion URL";
                }
                try
                {
                    aux.Marca.Descripcion = (string)lectura.GetString(5);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                }
                try
                {
                    aux.Marca.Id = lectura.GetInt32(9);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                }
                try
                {
                    aux.Categoria.Descripcion = (string)lectura.GetString(6);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                    aux.Categoria.Descripcion = " ";
                }
                try
                {
                    aux.Categoria.Id = lectura.GetInt32(8);
                }
                catch (System.Data.SqlTypes.SqlNullValueException)
                {
                }

                aux.Id = lectura.GetInt32(7);

                listaArticulos.Add(aux);
            }
            conexion.Desconectar();
            return listaArticulos;
        }

        public void AgregarArticulo(Articulo nuevo)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "insert into ARTICULOS(Codigo,Nombre,Descripcion,Precio,IdMarca,IdCategoria,ImagenUrl) values ('" + nuevo.Codigo + "','" + nuevo.Nombre + "','" + nuevo.Descripcion + "','" + nuevo.Precio + "','" + nuevo.Marca.Id + "','" + nuevo.Categoria.Id + "','" + nuevo.ImagenUrl + "')";

            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
        }

        public void ModificarArticulo(Articulo nuevo)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            try
            {
                connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
                command.CommandType = System.Data.CommandType.Text;
                command.CommandText = "update ARTICULOS Set Codigo=@codigo,Nombre=@nombre,Descripcion=@descripcion,Precio=@precio,idMarca=@idMarca,idCategoria=@idCategoria Where Id=@id";

                command.Parameters.AddWithValue("@codigo", nuevo.Codigo);
                command.Parameters.AddWithValue("@nombre", nuevo.Nombre);
                command.Parameters.AddWithValue("@descripcion", nuevo.Descripcion);
                command.Parameters.AddWithValue("@precio", nuevo.Precio);
                command.Parameters.AddWithValue("@id", nuevo.Id);
                command.Parameters.AddWithValue("@idMarca", nuevo.Marca.Id);
                command.Parameters.AddWithValue("@idCategoria", nuevo.Categoria.Id);

                command.Connection = connection;
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void BajaArticulo(int idArticulo)
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "delete from articulos where articulos.id = " + idArticulo;
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
        }
    }
}
