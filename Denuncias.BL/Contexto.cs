using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class Contexto: DbContext

    {
        public Contexto(): base()
        {
                
        }

        public DbSet<Asunto> Asuntos { get; set; }
    }
}
