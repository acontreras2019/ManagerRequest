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
        public Contexto(): base("Asuntos4")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio a la BD

        }

        public DbSet<Asunto> Asunto { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoSolicitante> TipoSolicitante { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }

    }
}
