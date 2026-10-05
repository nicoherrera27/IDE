using Herrera.Dominio;
using Microsoft.EntityFrameworkCore;
namespace Herrera.Data
{
    public class AlquilerContext : DbContext
    {
        public DbSet<Alquiler> Alquileres { get; set; }

        public AlquilerContext(DbContextOptions<AlquilerContext> options) : base(options)
        {
        }
        public AlquilerContext()
        {
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=dbAlquiler;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Alquiler>(entity =>
            {
                entity.HasKey(a => a.Id);
                entity.Property(a => a.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(a => a.Inquilino)
                    .IsRequired();

                entity.Property(a => a.MontoAlquiler)
                    .IsRequired();

                entity.Property(a => a.FechaInicio)
                    .IsRequired();

                entity.Property(a => a.FechaFin)
                    .IsRequired();

                entity.Property(a => a.Estado)
                    .IsRequired()
                    .HasConversion<string>();
                entity.HasData(
                    new Alquiler(1, "Juan Perez", 1000, new DateTime(2023, 1, 1), new DateTime(2023, 12, 31), EstadoAlquiler.Activo)
                    );
            });
        }
    }
}
