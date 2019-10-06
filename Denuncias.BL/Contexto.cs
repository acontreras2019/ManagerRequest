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
        public Contexto() : base("PortalDenunciaSolicitud321")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Usuario>()
                .HasRequired(f => f.Rol)
                .WithMany()
                .HasForeignKey(e => e.RolId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Ciudad>()
                .HasRequired(f => f.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Company>()
                .HasRequired(f => f.Ciudad)
                .WithMany()
                .HasForeignKey(e => e.CiudadId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Asunto>()
                .HasRequired(f => f.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
                .HasRequired(f => f.Usuario)
                .WithMany()
                .HasForeignKey(e => e.UsuarioId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
                .HasRequired(f => f.TipoMedio)
                .WithMany()
                .HasForeignKey(e => e.TipoMedioId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
                .HasRequired(f => f.TipoSolicitante)
                .WithMany()
                .HasForeignKey(e => e.TipoSolicitanteId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
                .HasRequired(f => f.Ciudad)
                .WithMany()
                .HasForeignKey(e => e.CiudadId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
                .HasRequired(f => f.Colonia)
                .WithMany()
                .HasForeignKey(e => e.ColoniaId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Transaccion>()
              .HasRequired(f => f.Asunto)
              .WithMany()
              .HasForeignKey(e => e.AsuntoId)
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
        public DbSet<Estatus> Estatus { get; set; }
        public DbSet<Rol> Rol { get; set; }



    }
}
