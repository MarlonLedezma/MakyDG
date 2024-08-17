using Acceso_a_Datos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Clase;

namespace Acceso_a_Datos.Tarea
{
    public class AD_Tarea
    {
        public DataTable ListarTareas(int IdProyecto)
        {
            DataTable dt = new DataTable();
            try 
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "SELECT T.IdTarea, T.IdProyecto, T.Inicializacion, T.Finalizacion, U.Nombre AS Responsable, T.Estado, T.Nombre FROM Tarea T INNER JOIN Usuario U ON T.Responsable = U.IdUsuario WHERE T.IdProyecto = @IdProyecto";
                    command.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    Conn.CloseConnection();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Error al Listar las Tareas: "+ex.Message);
            }
        }  
        public DataTable ListarTareaxId(int IdTarea)
        {
            DataTable dt = new DataTable();
            try 
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "SELECT T.IdTarea, T.IdProyecto, T.Inicializacion, T.Finalizacion, T.Responsable AS Responsable, T.Estado, T.Nombre FROM Tarea T INNER JOIN Usuario U ON T.Responsable = U.IdUsuario WHERE T.IdTarea = @IdTarea";
                    command.Parameters.AddWithValue("@IdTarea", IdTarea);
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    Conn.CloseConnection();
                    return dt;
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Error al Listar las Tareas: "+ex.Message);
            }
        }
        public bool CrearTarea(clsTarea clsTarea)
        {
            try
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "INSERT INTO Tarea (IdProyecto, Inicializacion, Finalizacion, Responsable, Estado, Nombre) VALUES (@IdProyecto, @Inicializacion, @Finalizacion, @Responsable, @Estado, @Nombre)";
                    command.Parameters.AddWithValue("@IdProyecto", clsTarea.IdProyecto);
                    command.Parameters.AddWithValue("@Inicializacion", clsTarea.Inicializacion);
                    command.Parameters.AddWithValue("@Finalizacion", clsTarea.Finalizacion);
                    command.Parameters.AddWithValue("@Responsable", clsTarea.Responsable);
                    command.Parameters.AddWithValue("@Estado", clsTarea.Estado);
                    command.Parameters.AddWithValue("@Nombre", clsTarea.Nombre.ToString().TrimEnd());
                    command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al Crear la Tarea: "+ex.Message);
            }
        }
        public bool ActualizarTarea(clsTarea clsTarea)
        {
            try
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "UPDATE Tarea SET Inicializacion = @Inicializacion, Finalizacion = @Finalizacion, Responsable = @Responsable, Estado = @Estado, Nombre = @Nombre WHERE IdTarea = @IdTarea";
                    command.Parameters.AddWithValue("@IdTarea", clsTarea.IdTarea);
                    command.Parameters.AddWithValue("@Inicializacion", clsTarea.Inicializacion);
                    command.Parameters.AddWithValue("@Finalizacion", clsTarea.Finalizacion);
                    command.Parameters.AddWithValue("@Responsable", clsTarea.Responsable);
                    command.Parameters.AddWithValue("@Estado", clsTarea.Estado);
                    command.Parameters.AddWithValue("@Nombre", clsTarea.Nombre.ToString().TrimEnd());
                    command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al Actualizar la Tarea: "+ex.Message);
            }
        }
        public bool EliminarTarea(int IdTarea)
        {
            bool resultado = false;
            clsConeccion Conn = new clsConeccion();

            try
            {
                using (var connection = Conn.OpenConecction())
                {
                    // Iniciar la transacción
                    using (var transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            // Eliminar las observaciones asociadas al proyecto
                            using (var commandObservacion = new SqlCommand())
                            {
                                commandObservacion.Connection = connection;
                                commandObservacion.Transaction = transaction;
                                commandObservacion.CommandText = "DELETE FROM Observaciones WHERE IdTarea = @IdTarea";
                                commandObservacion.Parameters.AddWithValue("@IdTarea", IdTarea);
                                commandObservacion.ExecuteNonQuery();
                            }

                            // Eliminar las tareas asociadas al proyecto
                            using (var commandTarea = new SqlCommand())
                            {
                                commandTarea.Connection = connection;
                                commandTarea.Transaction = transaction;
                                commandTarea.CommandText = "DELETE FROM Tarea WHERE IdTarea = @IdTarea";
                                commandTarea.Parameters.AddWithValue("@IdTarea", IdTarea);
                                commandTarea.ExecuteNonQuery();
                            }

                            // Confirmar la transacción
                            transaction.Commit();
                            resultado = true;
                        }
                        catch (Exception ex)
                        {
                            // Si hay algún error, se deshacen todos los cambios
                            transaction.Rollback();
                            throw new Exception("Error al eliminar el proyecto: " + ex.Message);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al establecer la conexión: " + ex.Message);
            }

            return resultado;
        }
    }
}
