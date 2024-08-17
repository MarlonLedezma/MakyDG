using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos.Tarea;
using Utilidades.Clase;

namespace Logica_de_Negocios.Tarea
{
    public class LN_Tarea
    {
        public DataTable ListarTareas(int IdProyecto)
        {
            try
            {
                AD_Tarea adTarea = new AD_Tarea();
                return adTarea.ListarTareas(IdProyecto);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public DataTable ListarTareaxId(int IdTarea)
        {
            try
            {
                AD_Tarea adTarea = new AD_Tarea();
                return adTarea.ListarTareaxId(IdTarea);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public bool CrearTarea(clsTarea clsTarea)
        {
            try
            {
                AD_Tarea adTarea = new AD_Tarea();
                return adTarea.CrearTarea(clsTarea);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al crear la tarea: " + ex.Message);
            }
        }
        public bool ActualizarTarea(clsTarea clsTarea)
        {
            try
            {
                AD_Tarea adTarea = new AD_Tarea();
                return adTarea.ActualizarTarea(clsTarea);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al actualizar la tarea: " + ex.Message);
            }
        }
        public bool EliminarTarea(int IdTarea)
        {
            try
            {
                AD_Tarea adTarea = new AD_Tarea();
                return adTarea.EliminarTarea(IdTarea);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al eliminar la tarea: " + ex.Message);
            }
        }
    }
}
