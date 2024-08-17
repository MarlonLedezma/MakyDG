using Acceso_a_Datos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Clase;

namespace Acceso_a_Datos.Observacion
{
    public class AD_Observacion
    {
        public DataTable ListarObservaciones(int IdProyecto) 
        {                   
            try
            {
                DataTable dt = new DataTable();
                clsConeccion Conn = new clsConeccion();
                using (var Command = new SqlCommand()) 
                {
                    Command.Connection = Conn.OpenConecction();
                    Command.CommandText = "SELECT O.IdObservacion, O.IdTarea, O.Nombre, O.Detalle, U.Nombre AS Creador, O.Fecha, O.Estado FROM Observaciones O INNER JOIN Usuario U ON O.Creador = U.IdUsuario where O.IdProyecto = @IdProyecto";
                    Command.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                    SqlDataReader reader = Command.ExecuteReader();
                    dt.Load(reader);
                    Conn.CloseConnection();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Error al Listar las Observaciones");
            }
        }
        public DataTable ListaObservacacionxId(int IdObservacion) 
        {
            try
            {
                DataTable dt = new DataTable();
                clsConeccion Conn = new clsConeccion();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = Conn.OpenConecction();
                    Command.CommandText = "SELECT O.IdObservacion, O.IdTarea, O.Nombre, O.Detalle, U.Nombre AS Creador, O.Fecha, O.Estado FROM Observaciones O INNER JOIN Usuario U ON O.Creador = U.IdUsuario where O.IdObservacion = @IdObservacion";
                    Command.Parameters.AddWithValue("@IdObservacion", IdObservacion);
                    SqlDataReader reader = Command.ExecuteReader();
                    dt.Load(reader);
                    Conn.CloseConnection();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Error al Listar las Observaciones");
            }
        }
        public bool InsertarObservacion(clsObservacion observacion) 
        {
            try
            {
                clsConeccion Conn = new clsConeccion();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = Conn.OpenConecction();
                    Command.CommandText = "INSERT INTO Observaciones (IdProyecto, IdTarea, Nombre, Detalle, Creador, Fecha, Estado) VALUES (@IdProyecto, @IdTarea, @Nombre, @Detalle, @Creador, @Fecha, @Estado)";
                    Command.Parameters.AddWithValue("@IdProyecto", observacion.IdProyecto);
                    Command.Parameters.AddWithValue("@IdTarea", observacion.IdTarea);
                    Command.Parameters.AddWithValue("@Nombre", observacion.Nombre);
                    Command.Parameters.AddWithValue("@Detalle", observacion.Detalle);
                    Command.Parameters.AddWithValue("@Creador", observacion.Responsable);
                    Command.Parameters.AddWithValue("@Fecha", observacion.Fecha);
                    Command.Parameters.AddWithValue("@Estado", observacion.Estado);
                    Command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al Insertar la Observacion");
            }
        }
        public bool ActualizarObservacion(clsObservacion observacion) 
        {
            try
            {
                clsConeccion Conn = new clsConeccion();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = Conn.OpenConecction();
                    Command.CommandText = "UPDATE Observaciones SET Nombre = @Nombre, Detalle = @Detalle, Estado = @Estado WHERE IdObservacion = @IdObservacion";
                    Command.Parameters.AddWithValue("@IdObservacion", observacion.IdObservacion);
                    Command.Parameters.AddWithValue("@Nombre", observacion.Nombre);
                    Command.Parameters.AddWithValue("@Detalle", observacion.Detalle);
                    Command.Parameters.AddWithValue("@Estado", observacion.Estado);
                    Command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al Actualizar la Observacion");
            }
        }
        public bool EliminarObservacion(int IdObservacion) 
        {
            try
            {
                clsConeccion Conn = new clsConeccion();
                using (var Command = new SqlCommand())
                {
                    Command.Connection = Conn.OpenConecction();
                    Command.CommandText = "DELETE FROM Observaciones WHERE IdObservacion = @IdObservacion";
                    Command.Parameters.AddWithValue("@IdObservacion", IdObservacion);
                    Command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al Eliminar la Observacion");
            }
        }
    }
}
