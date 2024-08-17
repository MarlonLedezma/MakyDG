using Acceso_a_Datos.ConexionDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos.Proyecto;
using Utilidades.Clase;

namespace Logica_de_Negocios.Proyecto
{
    public class LN_Proyecto
    {
        public DataTable ListProyectos() 
        {
            try 
            {
                AD_Proyecto adProyecto = new AD_Proyecto();
                return adProyecto.ListProyectos();
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public DataTable ListarProyectoxId(int IdProyecto) 
        {
            try 
            {
                AD_Proyecto adProyecto = new AD_Proyecto();
                return adProyecto.ListarProyectoxId(IdProyecto);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public bool CrearProyecto(clsProyecto clsProyecto)
        {
            try
            {
                AD_Proyecto adProyecto = new AD_Proyecto();
                return adProyecto.CrearProyecto(clsProyecto);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al crear el proyecto: " + ex.Message);
            }
        }
        public bool ActualizarProyecto(clsProyecto clsProyecto)
        {
            try
            {
                AD_Proyecto adProyecto = new AD_Proyecto();
                return adProyecto.ActualizarProyecto(clsProyecto);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al actualizar el proyecto: " + ex.Message);
            }
        }
        public bool EliminarProyecto(int IdProyecto)
        {
            try
            {
                AD_Proyecto adProyecto = new AD_Proyecto();
                return adProyecto.EliminarProyecto(IdProyecto);
            }
            catch (Exception ex)
            {
                return false;
                throw new Exception("Error al eliminar el proyecto: " + ex.Message);
            }
        }
    }
}
