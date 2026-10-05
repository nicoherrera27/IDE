using Microsoft.EntityFrameworkCore;

namespace TEMPLATE.Domain
{
    public class ClaseService
    {
        public async Task<Clase> GetAsync(int id)
        {
            using var context = new ClaseContext();
            return await context.Clases.FindAsync(id);
        }

        public async Task<IEnumerable<Clase>> GetAllAsync()
        {
            using var context = new ClaseContext();
            return await context.Clases.ToListAsync();
        }

        public async Task<Clase> AddAsync(Clase clase)
        {
            if (ClaseValidation.isValid(clase))
            {
                using var context = new ClaseContext();
                clase.Estado = "Activo";
                context.Clases.Add(clase);
                await context.SaveChangesAsync();
            }
            return clase;
        }

        public async Task<IEnumerable<Clase>> GetByEstadoAsync(string estado)
        {
            using var context = new ClaseContext();
            return await context.Clases.Where(a => a.Estado == estado).ToListAsync();
        }

        public async Task<bool> FinalizarAsync(int id)
        {
            using var context = new ClaseContext();
            var clase = await context.Clases.FindAsync(id);
            if (clase == null)
            {
                return false;
            }
            else if (clase.Estado == "Finalizado") 
            {
                throw new Exception("El alquiler ya se encuentra finalizado.");
            }
            clase.Estado = "Finalizado";
            await context.SaveChangesAsync();
            return true;
        }
    }
}