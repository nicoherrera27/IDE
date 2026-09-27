using Herrera.Domain;
using Microsoft.EntityFrameworkCore;

namespace Herrera.Data
{
    public class PromocionContext : DbContext
    {
        public DbSet<Promocion> Promociones { get; set; }
        public PromocionContext(DbContextOptions<PromocionContext> options) : base(options) { }
        public PromocionContext()
        {
            this.Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Initial Catalog=dbPromocion;Integrated Security=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Promocion>(entity =>
            {
                entity.HasKey(p => p.Id);
                entity.Property(p => p.Id)
                    .ValueGeneratedOnAdd();

                entity.Property(p => p.FechaInicio)
                    .IsRequired();

                entity.Property(p => p.FechaFin)
                    .IsRequired();

                entity.Property(p => p.Descuento)
                    .IsRequired();

                entity.Property(p => p.Estado)
                    .IsRequired()
                    .HasConversion<string>();
                entity.HasData(
                    new {Id=1, Nombre="Navidad", FechaInicio=new DateOnly(2026, 12, 15), FechaFin= new DateOnly(2026, 12, 24), Descuento=30, Estado=EstadoProm.Activa }
                );
            });
        }
    }
}
