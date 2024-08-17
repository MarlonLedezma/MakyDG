using Acceso_a_Datos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilidades.Cache;
using Utilidades.Clase;

namespace Acceso_a_Datos.Proyecto
{
    public class AD_Proyecto
    {
        public DataTable ListProyectos() 
        {
            DataTable dt = new DataTable();
            try 
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "SELECT P.IdProyecto, P.Nombre, P.Cliente, P.Direccion, P.Inicio, P.Finalizacion, U.Nombre AS Responsable, P.Estado FROM Proyecto P INNER JOIN Usuario U ON P.Responsable = U.IdUsuario where P.IdEmpresa = @IdEmpresa";
                    command.Parameters.AddWithValue("@IdEmpresa", UsuarioCache.IdEmpresa);
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    Conn.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Error al Obtener los Proyectos: "+ex.Message);
            }
            return dt;
        }
        public DataTable ListarProyectoxId(int IdProyecto) 
        {
            DataTable dt = new DataTable();
            try 
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "SELECT P.IdProyecto, P.Nombre, P.Cliente, P.Direccion, P.Inicio, P.Finalizacion, P.Responsable AS Responsable, P.Estado FROM Proyecto P INNER JOIN Usuario U ON P.Responsable = U.IdUsuario where P.IdEmpresa = @IdEmpresa AND P.IdProyecto = @IdProyecto";
                    command.Parameters.AddWithValue("@IdEmpresa", UsuarioCache.IdEmpresa);
                    command.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                    SqlDataReader reader = command.ExecuteReader();
                    dt.Load(reader);
                    Conn.CloseConnection();
                }
            }
            catch (Exception ex)
            {
                return null;
                throw new Exception("Error al Obtener los Proyectos: "+ex.Message);
            }
            return dt;
        }
        public bool CrearProyecto(clsProyecto clsProyecto) 
        {
            bool resultado = false;
            try 
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "INSERT INTO Proyecto (IdEmpresa, Nombre, Cliente, Direccion, Inicio, Finalizacion, Responsable, Estado) VALUES (@IdEmpresa, @Nombre, @Cliente, @Direccion, @Inicio, @Finalizacion, @Responsable, @Estado)";
                    command.Parameters.AddWithValue("@IdEmpresa", UsuarioCache.IdEmpresa);
                    command.Parameters.AddWithValue("@Nombre", clsProyecto.Nombre);
                    command.Parameters.AddWithValue("@Cliente", clsProyecto.Cliente);
                    command.Parameters.AddWithValue("@Direccion", clsProyecto.Direccion);
                    command.Parameters.AddWithValue("@Inicio", clsProyecto.Inicio);
                    command.Parameters.AddWithValue("@Finalizacion", clsProyecto.Finalizacion);
                    command.Parameters.AddWithValue("@Responsable", clsProyecto.Responsable);
                    command.Parameters.AddWithValue("@Estado", clsProyecto.Estado);
                    command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al crear el proyecto: "+ex.Message);
            }
            return resultado;
        }
        public bool ActualizarProyecto(clsProyecto clsProyecto) 
        {
            bool resultado = false;
            try 
            {
                clsConeccion Conn = new clsConeccion();
                using (var command = new SqlCommand())
                {
                    command.Connection = Conn.OpenConecction();
                    command.CommandText = "UPDATE Proyecto SET Nombre = @Nombre, Cliente = @Cliente, Direccion = @Direccion, Inicio = @Inicio, Finalizacion = @Finalizacion, Responsable = @Responsable, Estado = @Estado WHERE IdProyecto = @IdProyecto";
                    command.Parameters.AddWithValue("@Nombre", clsProyecto.Nombre);
                    command.Parameters.AddWithValue("@Cliente", clsProyecto.Cliente);
                    command.Parameters.AddWithValue("@Direccion", clsProyecto.Direccion);
                    command.Parameters.AddWithValue("@Inicio", clsProyecto.Inicio);
                    command.Parameters.AddWithValue("@Finalizacion", clsProyecto.Finalizacion);
                    command.Parameters.AddWithValue("@Responsable", clsProyecto.Responsable);
                    command.Parameters.AddWithValue("@Estado", clsProyecto.Estado);
                    command.Parameters.AddWithValue("@IdProyecto", clsProyecto.IdProyecto);
                    command.ExecuteNonQuery();
                    Conn.CloseConnection();
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al actualizar el proyecto: "+ex.Message);
            }
            return resultado;
        }
        public bool EliminarProyecto(int IdProyecto)
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
                                commandObservacion.CommandText = "DELETE FROM Observaciones WHERE IdTarea IN (SELECT IdTarea FROM Tarea WHERE IdProyecto = @IdProyecto)";
                                commandObservacion.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                                commandObservacion.ExecuteNonQuery();
                            }

                            // Eliminar las tareas asociadas al proyecto
                            using (var commandTarea = new SqlCommand())
                            {
                                commandTarea.Connection = connection;
                                commandTarea.Transaction = transaction;
                                commandTarea.CommandText = "DELETE FROM Tarea WHERE IdProyecto = @IdProyecto";
                                commandTarea.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                                commandTarea.ExecuteNonQuery();
                            }

                            // Eliminar el proyecto
                            using (var commandProyecto = new SqlCommand())
                            {
                                commandProyecto.Connection = connection;
                                commandProyecto.Transaction = transaction;
                                commandProyecto.CommandText = "DELETE FROM Proyecto WHERE IdProyecto = @IdProyecto";
                                commandProyecto.Parameters.AddWithValue("@IdProyecto", IdProyecto);
                                commandProyecto.ExecuteNonQuery();
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
