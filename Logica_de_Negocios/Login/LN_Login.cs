using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acceso_a_Datos.Login;

namespace Logica_de_Negocios.Login
{
    public class LN_Login
    {
        AD_Login adLogin = new AD_Login();

        public bool ValidarUsuario(string usuario, string contrasena)
        {
            return adLogin.ValidarUsuario(usuario, contrasena);
        }
    }
}
