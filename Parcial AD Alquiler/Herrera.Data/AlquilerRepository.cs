using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herrera.Dominio;
using Microsoft.EntityFrameworkCore;
namespace Herrera.Data
{
    public class AlquilerRepository
    {
        public async Task<IEnumerable<Alquiler>> GetAllAsync()
        {
            using (var context = new AlquilerContext())
            {
                return await context.Alquileres.ToListAsync();
            }
        }
        public async Task<IEnumerable<Alquiler>> GetByEstadoAsync(EstadoAlquiler estado)
        {
            using (var context = new AlquilerContext())
            {
                return await context.Alquileres.Where(a=>a.Estado == estado).ToListAsync();
            }
        }

        public async Task AddAsync(Alquiler alq)
        {
            using (var context = new AlquilerContext())
            {
                context.Alquileres.Add(alq);
                await context.SaveChangesAsync();
            }
        }

        public async Task<bool> DeleteAsync(int id) { 
            using (var context = new AlquilerContext())
            {
                var exists = await context.Alquileres.FindAsync(id);
                if (exists == null)
                {
                    return false;
                }
                exists.SetEstado(EstadoAlquiler.Finalizado);
                await context.SaveChangesAsync();
                return true;


            }
        }
    }
}
