using Herrera.Domain;
using Microsoft.EntityFrameworkCore;

namespace Herrera.Data
{
    public class PromocionRepository
    {
        
        public async Task<IEnumerable<Promocion>> GetAllAsync()
        {
            using (var context = new PromocionContext())
            {
                return await context.Promociones.ToListAsync();
            }
        }

        public async Task<IEnumerable<Promocion>> GetByEstadoAsync(EstadoProm estado)
        {
            using (var context = new PromocionContext())
            {
                return await context.Promociones.Where(p => p.Estado == estado).ToListAsync();
            }
        }

        public async Task AddAsync(Promocion promo)
        {
            using (var context = new PromocionContext())
            {
                context.Promociones.Add(promo);
                await context.SaveChangesAsync();       
            }
        }

        public async Task<bool> DeleteAsync(int id)
        {
            using (var context = new PromocionContext())
            {
                var promo = await context.Promociones.FindAsync(id);
                if (promo == null) { 
                    return false;
                }
                promo.SetEstado(EstadoProm.Expirada);
                await context.SaveChangesAsync();
                return true;
                
            }
        }
    }
}
