using GranDT.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GRANDT
{
    public static class DataGlobals
    {
        public static Usuario UsuarioLogueado { get; private set; }
        public static int IdUsuarioLogueado { get; private set; }

        public static void SetUsuario(Usuario u)
        {
            UsuarioLogueado = u;
            IdUsuarioLogueado = (int)u.IdUsuario;
        }

        public static bool EstaLogueado()
        {
            return UsuarioLogueado != null;
        }

        public static void CerrarSesion()
        {
            UsuarioLogueado = null;
            IdUsuarioLogueado = 0;
        }
    }

}
