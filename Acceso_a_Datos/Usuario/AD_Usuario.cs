using Acceso_a_Datos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Cache;

namespace Acceso_a_Datos.Usuario
{
    public class AD_Usuario
    {
        public DataTable ListarUsuarioxEmpresa() 
        {
            DataTable dt = new DataTable();
            try
            {
                clsConeccion coneccion = new clsConeccion();
                using (var Command = new SqlCommand()) 
                {
                    Command.Connection = coneccion.OpenConecction();
                    Command.CommandText = "Select * from Usuario where IdEmpresa = @IdEmpresa";
                    Command.Parameters.AddWithValue("@IdEmpresa", UsuarioCache.IdEmpresa);
                    Command.CommandType = CommandType.Text;
                    SqlDataReader reader = Command.ExecuteReader();
                    dt.Load(reader);
                    coneccion.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                dt = null;
                throw new Exception("Error al listar los usuarios: " + ex.Message);
            }
            return dt;
        }
    }
}
