using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clase
{
    public class clsTarea
    {
        public int IdTarea { get; set; }
        public int IdProyecto { get; set; }
        public int Responsable { get; set; }
        public string Nombre { get; set; }
        public DateTime Inicializacion { get; set; }
        public DateTime Finalizacion { get; set; }
        public string Estado { get; set; }

    }
}
