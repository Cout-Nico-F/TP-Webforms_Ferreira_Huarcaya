using Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Negocios
{
    public class MarcaNegocio
    {
        public List<Marca> ListarMarcas()
        {
            SqlConnection connection = new SqlConnection();
            SqlCommand command = new SqlCommand();
            SqlDataReader Reader;
            List<Marca> AltaArticulos = new List<Marca>();

            connection.ConnectionString = "data source =localhost\\SQLEXPRESS01; initial catalog =CATALOGO_DB; integrated security =sspi";
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = "Select Id,Descripcion From MARCAS";
            command.Connection = connection;

            connection.Open();
            Reader = command.ExecuteReader();

            while (Reader.Read())
            {
                AltaArticulos.Add(new Marca((int)Reader["Id"], (string)Reader["Descripcion"]));
            }

            Reader.Close();
            connection.Close();
            return AltaArticulos;
        }
    }
}
