using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilidades.Clase
{
    public class clsProyecto
    {
        public int IdEmpresa { get; set; }
        public int IdProyecto { get; set; }
        public string Nombre { get; set; }
        public string Cliente { get; set; }
        public string Direccion { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Finalizacion { get; set; }
        public int Responsable { get; set; }
        public string Estado { get; set; }

    }
}
