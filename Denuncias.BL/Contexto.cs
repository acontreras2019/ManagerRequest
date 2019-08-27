using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Denuncias.BL
{
    public class Contexto: DbContext
    {
        public Contexto(): base("Asuntos")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio());// 
        }

        public DbSet<Asunto> Asuntos { get; set; }
        public DbSet<CreadoresAsunto> CreadoresAsunto { get; set; }
    }
}
