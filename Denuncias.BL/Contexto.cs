using System;
using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Denuncias.BL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("PortalDenunciaSolicitud")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Ciudad>()
                .HasRequired(f => f.Usuario)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
              .HasRequired(f => f.Ciudad)
              .WithRequiredDependent()
              .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asunto>()
                .HasRequired(f => f.Usuario)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
                .HasRequired(f => f.Usuario)
                .WithRequiredDependent()
                .WillCascadeOnDelete(false);

            Database.SetInitializer(new DatosdeInicio()); // Agrega datos de inicio a la BD

        }

        public DbSet<Asunto> Asunto { get; set; }
        public DbSet<Company> Company { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<TipoSolicitante> TipoSolicitante { get; set; }
        public DbSet<TipoMedio> TipoMedio { get; set; }
        public DbSet<Transaccion> Transaccion { get; set; }
        public DbSet<TipodeDocumento> TipodeDocumento { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Colonia> Colonia { get; set; }
        


    }
}
