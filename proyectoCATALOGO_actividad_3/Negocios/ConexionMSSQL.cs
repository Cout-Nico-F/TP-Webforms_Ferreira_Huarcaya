using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocios
{
    class ConexionMSSQL
    {
        public SqlDataReader dataReader { get; set; }
        public SqlConnection connection { get; set; }
        public SqlCommand command { get; set; }

        public void Conectar  ()
        {
            connection = new SqlConnection("data source = localhost\\SQLEXPRESS01; initial catalog = CATALOGO_DB; integrated security = sspi");
            command = new SqlCommand();
            command.Connection = connection;
            connection.Open();
        }

        public void Desconectar()
        {
            connection.Close();
        }

        public void SetConsulta(string consulta)
        {
            command.CommandText = consulta;
        }

        public SqlDataReader Leer()
        {
            dataReader = command.ExecuteReader();
            dataReader.Read();
            return dataReader;
        }

        public SqlDataReader Consulta_Rapida(string consulta)
        {
            Conectar();
            SetConsulta(consulta);
            SqlDataReader lectura = Leer();
            Desconectar();
            return lectura;
        }
    }
}
