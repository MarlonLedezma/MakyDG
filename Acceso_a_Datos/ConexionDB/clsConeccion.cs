using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos.ConexionDB
{
    public class clsConeccion
    {
        private SqlConnection Conexion;
        private string connectionString;
        public string usuario;

        public clsConeccion()
        {        
            connectionString = ConfigurationManager.ConnectionStrings["MakyDG"].ConnectionString;
            Conexion = new SqlConnection(connectionString);
        }

        public SqlConnection OpenConecction()
        {
            try
            {
                if (Conexion.State == ConnectionState.Closed)
                {
                    Conexion.ConnectionString = connectionString;
                    Conexion.Open();
                }
                return Conexion;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public SqlConnection CloseConnection()
        {
            try
            {
                if (Conexion.State == ConnectionState.Open)
                    Conexion.Close();
                return Conexion;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
