using Microsoft.EntityFrameworkCore;

namespace TEMPLATE.Domain
{
    internal class ClaseContext : DbContext
    {
        internal DbSet<Clase> Clases { get; set; }

        internal ClaseContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=DatabaseDb;Trusted_Connection=True;");
        }
    }
}