using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class SeguridadBL
    {
        public bool Autorizar(string usuario, string contraseña)
        {
            if (usuario == "admin" && contraseña == "123")
            {
                return  true;
            }
            else
            {
                if (usuario == "user" && contraseña == "456")
                {
                    return true;
                }
            }
            return false;
        }
    }
}
