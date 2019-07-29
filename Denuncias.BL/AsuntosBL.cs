using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class AsuntosBL
    {
        public AsuntosBL()
        {


        }

        public class Asunto
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public string Operador { get; set; } //Quien resuelve el asunto
            public bool activo { get; set; }
            public string multiple { get; set; }

        }
    }
}
