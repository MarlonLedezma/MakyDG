using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clase
{
    public class clsObservacion
    {
        public int IdObservacion { get; set; }
        public int IdTarea { get; set; }
        public int IdProyecto { get; set; }
        public int Responsable { get; set; }
        public string Nombre { get; set; }
        public string Detalle { get; set; }
        public DateTime Fecha { get; set; }
        public string Estado { get; set; }
    }
}
