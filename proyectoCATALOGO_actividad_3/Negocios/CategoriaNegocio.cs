using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocios
{
    public class CategoriaNegocio
    {
        public List<Categoria> ListarCategorias()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader Reader;
            List<Categoria> AltaArticulos = new List<Categoria>();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select Id,Descripcion From CATEGORIAS";
            command.Connection = connection;

            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                AltaArticulos.Add(new Categoria((int)Reader["Id"], (string)Reader["Descripcion"]));
            }

            Reader.Close();
            connection.Close();
            return AltaArticulos;
        }
    }
}
