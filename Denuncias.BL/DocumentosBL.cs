using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
   public  class DocumentosBL
    {
        public DocumentosBL()
        {

        }

        public class Documento
        {
            public int Id { get; set; }
            public string Descripcion { get; set; }
            public string  Usuariocreador { get; set; }
            public string Compania { get; set; }
            public bool Activo { get; set; }
        }




    }
}
