using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class CN_Usuario
    {
        private CD_Usuario Cd_Usuario = new CD_Usuario();

        public List<Usuario> Listar()
        {
            return Cd_Usuario.Listar();
        }
    }
}
