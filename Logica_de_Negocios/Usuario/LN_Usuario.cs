using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos.Usuario;
using System.Data;

namespace Logica_de_Negocios.Usuario
{
    public class LN_Usuario
    {
        public DataTable ListarUsuarioxEmpresa() 
        {
            try
            {
                AD_Usuario adUsuario = new AD_Usuario();
                return adUsuario.ListarUsuarioxEmpresa();
            }
            catch (Exception ex)
            {
                throw new Exception("Error al listar los usuarios: " + ex.Message);
            }
        }
    }
}
