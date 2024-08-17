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
                        while (reader.Read())
                        {
                            Utilidades.Cache.UsuarioCache.IdUsuario = reader.GetInt32(0);
                            Utilidades.Cache.UsuarioCache.IdEmpresa = reader.GetInt32(1);
                            Utilidades.Cache.UsuarioCache.Nombre = reader.GetString(2);
                            Utilidades.Cache.UsuarioCache.Apellido = reader.GetString(3);
                            Utilidades.Cache.UsuarioCache.Rol = reader.GetString(4);
                            Utilidades.Cache.UsuarioCache.Usuario = reader.GetString(5);
                            Utilidades.Cache.UsuarioCache.Contrasena = reader.GetString(6);
                            resultado = true;
                        }
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
