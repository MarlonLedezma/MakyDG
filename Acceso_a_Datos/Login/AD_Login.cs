using Acceso_a_Datos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acceso_a_Datos.Login
{
    public class AD_Login
    {
        public bool ValidarUsuario(string usuario, string password)
        {
			bool resultado = false;
			try
			{
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "SELECT * FROM Usuario WHERE UserName = @usuario AND PassWord = @password";
                    command.Parameters.AddWithValue("@usuario", usuario);
                    command.Parameters.AddWithValue("@password", password);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        resultado = true;
                    }
                    Conn.CloseConnection();
                }
            }
			catch (Exception)
			{
				throw;
			}
			return resultado;
        }
    }
}
