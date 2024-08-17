using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos.Observacion;
using System.Data;
using Utilidades.Clase;

namespace Logica_de_Negocios.Observacion
{
    public class LN_Observacion
    {
        public DataTable ListarObservaciones(int IdProyecto) 
        {
            try
            {
                AD_Observacion adObservacion = new AD_Observacion();
                return adObservacion.ListarObservaciones(IdProyecto);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public DataTable ListaObservacacionxId(int IdObservacion) 
        {
            try
            {
                AD_Observacion adObservacion = new AD_Observacion();
                return adObservacion.ListaObservacacionxId(IdObservacion);
            }
            catch (Exception)
            {
                return null;
                throw;
            }
        }
        public bool InsertarObservacion(clsObservacion observacion) 
        {
            try
            {
                AD_Observacion adObservacion = new AD_Observacion();
                return adObservacion.InsertarObservacion(observacion);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool ActualizarObservacion(clsObservacion observacion) 
        {
            try
            {
                AD_Observacion adObservacion = new AD_Observacion();
                return adObservacion.ActualizarObservacion(observacion);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        public bool EliminarObservacion(int IdObservacion) 
        {
            try
            {
                AD_Observacion adObservacion = new AD_Observacion();
                return adObservacion.EliminarObservacion(IdObservacion);
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
